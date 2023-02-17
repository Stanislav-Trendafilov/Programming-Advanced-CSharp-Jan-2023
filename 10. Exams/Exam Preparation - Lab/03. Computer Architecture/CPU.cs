using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerArchitecture
{
    public class CPU
    {
        private int cores;
        private string brand;
        private double frequency;

        public CPU(string brand, int cores, double frequency)
        {
            this.brand = brand;
            this.cores = cores;
            this.frequency = frequency;

        }
        public double Frequency { get { return frequency; } set { frequency = value; } }
        public string Brand { get { return brand; } set { brand = value; } }
        public int Cores { get { return cores; } set { cores = value; } }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"{this.brand} CPU:");
            sb.AppendLine($"Cores: {this.cores}");
            sb.AppendLine($"Frequency: {this.frequency:F1} GHz");
            return sb.ToString().Trim();
        }
    }
}
