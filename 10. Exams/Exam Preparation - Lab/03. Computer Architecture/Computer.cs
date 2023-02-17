using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ComputerArchitecture
{
    public class Computer
    {
        private int capacity;
        private string model;
        public Computer(string model, int capacity)
        {
            Capacity = capacity;
            Model = model;
            this.Multiprocessor = new List<CPU>();
        }
        public string Model { get { return model; } set { model = value; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }    
        public List<CPU> Multiprocessor { get; set; }
        public int Count { get { return Multiprocessor.Count; }}
        public void Add(CPU cpu)
        {
            if (Count < capacity)
            {
                Multiprocessor.Add(cpu);
            }
        }
        public bool Remove(string brand)
        {
            if(Multiprocessor.Any(x=>x.Brand==brand))
            {
                  var removed=Multiprocessor.First(x=>x.Brand==brand);
                  Multiprocessor.Remove(removed);
                  return true;
            }
            return false;
        }
        
        public CPU MostPowerful()
        {
            return Multiprocessor.MaxBy(x => x.Frequency);
        }
        public CPU GetCPU (string brand)
        {
           if (Multiprocessor.Any(x => x.Brand == brand))
           {
               return Multiprocessor.First(x => x.Brand == brand);
           }
           return null;
        }
        public string Report()
        {
            StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.AppendLine($"CPUs in the Computer {model}:");
            foreach (var cpu in Multiprocessor)
            {
                stringBuilder.AppendLine(cpu.ToString());
            }
            return stringBuilder.ToString().Trim();
        }
       
    }
}
