using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;
        public Car()
        {
            Model = string.Empty;
            Engine = new Engine();
            Weight = -1;
            Color = null;
        }

        public Car(string model, Engine engine) : this()
        {
            Model = model;
            Engine = engine;
        }

        public Car(string model, Engine engine, int weight) : this()
        {
            Model = model;
            Engine = engine;
            Weight = weight;
        }

        public Car(string model, Engine engine, string color) : this()
        {
            Model = model;
            Engine = engine;
            Color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }
        public string Model { get { return model; } set { model=value; } }
        public Engine Engine { get { return engine; } set { engine = value; } }
        public int Weight { get { return weight; } set { weight = value; } }
        public string Color { get { return color; } set { color = value; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (weight != -1 && color != null)
            {
                sb.AppendLine($"{model}:");
                sb.AppendLine(Engine.ToString());
                sb.AppendLine($"  Weight: {weight}");
                sb.Append($"  Color: {color}");
            }
            else if (weight == -1 && color != null)
            {
                sb.AppendLine($"{model}:");
                sb.AppendLine(Engine.ToString());
                sb.AppendLine($"  Weight: n/a");
                sb.Append($"  Color: {color}");
            }
            else if (weight != -1 && color == null)
            {
                sb.AppendLine($"{model}:");
                sb.AppendLine(Engine.ToString());
                sb.AppendLine($"  Weight: {weight}");
                sb.Append($"  Color: n/a");
            }  
            else
            {
                sb.AppendLine($"{model}:");
                sb.AppendLine(Engine.ToString());
                sb.AppendLine($"  Weight: n/a");
                sb.Append($"  Color: n/a");
            }
            return sb.ToString();
        }
    }
}
