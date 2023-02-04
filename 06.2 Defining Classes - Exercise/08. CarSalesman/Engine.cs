using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Engine
    {	
        private string model;
        private int power;
        private int displacement;
        private string efficiency;
        public Engine()
        {
            Model = string.Empty;
            Power = 0;
            Displacement = -1;
            Efficiency = null;
        }

        public Engine(string model, int power) : this()
        {
            Model = model;
            Power = power;
        }

        public Engine(string model, int power, int displacement) : this()
        {
            Model = model;
            Power = power;
            Displacement = displacement;
        }

        public Engine(string model, int power, string efficiency) : this()
        {
            Model = model;
            Power = power;
            Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public string Model { get { return model; } set { model = value; } }
        public int Power { get { return power; } set { power = value; }}
        public int Displacement { get { return displacement; } set { displacement = value; } }
        public string Efficiency { get { return efficiency; } set { efficiency = value; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (displacement != -1 && efficiency != null)
            {
                sb.AppendLine($"  {model}:");
                sb.AppendLine($"    Power: {power}");
                sb.AppendLine($"    Displacement: {displacement}");
                sb.Append($"    Efficiency: {efficiency}");
            }
            else if (displacement != -1 && efficiency == null)
            {
                sb.AppendLine($"  {model}:");
                sb.AppendLine($"    Power: {power}");
                sb.AppendLine($"    Displacement: {displacement}");
                sb.Append($"    Efficiency: n/a");
            }
            else if (displacement == -1 && efficiency != null)
            {
                sb.AppendLine($"  {model}:");
                sb.AppendLine($"    Power: {power}");
                sb.AppendLine($"    Displacement: n/a");
                sb.Append($"    Efficiency: {efficiency}");
            }
            else
            {
                sb.AppendLine($"  {model}:");
                sb.AppendLine($"    Power: {power}");
                sb.AppendLine($"    Displacement: n/a");
                sb.Append($"    Efficiency: n/a");
            }
            return sb.ToString();
        }

    }
        
}
