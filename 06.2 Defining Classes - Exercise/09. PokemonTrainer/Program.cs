

using DefiningClasses;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            string command = string.Empty;
            List<Trainer> trainers = new List<Trainer>();
            while ((command = Console.ReadLine()) != "Tournament")
            {
                string[] args = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
                string trainerName = args[0];
                string pokemonName = args[1];
                string pokemonElement = args[2];
                int pokemonHealth = int.Parse(args[3]);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                if (trainers.Any(x => x.Name == trainerName))
                {
                    var train = trainers.First(x => x.Name == trainerName);
                    train.Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                    continue;
                }
                Trainer currTrainer = new(trainerName);
                currTrainer.Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                trainers.Add(currTrainer);
            }
            while ((command = Console.ReadLine()) != "End")
            {
               foreach (var trainer in trainers)
               {
                   if(trainer.Pokemons.Any(x=>x.Element==command))
                   {
                       trainer.Badges += 1;
                   }
                   else
                   {
                       foreach (var pokemon in trainer.Pokemons)
                       {
                           pokemon.Health -= 10;
                           
                       }
                       trainer.Pokemons.RemoveAll(x => x.Health <= 0);
                   }
               }               
            }
            foreach (var trainer in trainers.OrderByDescending(x=>x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}
