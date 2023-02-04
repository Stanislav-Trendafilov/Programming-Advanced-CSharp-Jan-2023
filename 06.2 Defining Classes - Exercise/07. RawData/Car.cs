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
        private Cargo cargo;
        private Tire[] tires;

        public Car()
        {
            engine = new Engine();
            cargo = new Cargo();
            tires = new Tire[4];
        } 
        public Car(string model, int engineSpeed,int enginePower, int cargoWeight,string cargoType, double tire1Pressure,
             int tire1Age,double tire2Pressure,int tire2Age, double tire3Pressure,int tire3Age, double tire4Pressure ,int tire4Age):this() 
        {
            Model = model;
            engine.Speed = engineSpeed;
            engine.Power = enginePower;
            cargo.Weight=cargoWeight;
            cargo.Type = cargoType;
            tires=new Tire[4];
            {
                tires[0]= new Tire()
                    { Pressure = tire1Pressure, Years = tire1Age };
                tires[1] = new Tire()
                    { Pressure = tire2Pressure, Years = tire2Age };
                tires[2] = new Tire()
                    { Pressure = tire3Pressure, Years = tire3Age };
                tires[3] = new Tire()
                    { Pressure = tire4Pressure, Years = tire4Age };
            };
        }

        public string Model { get { return model; } set { model=value; } }
        public Engine Engine { get { return engine; } set { engine = value; } }
        public Cargo Cargo { get { return cargo; } set { cargo = value; } }
        public Tire[] Tires { get { return tires; } set { tires = value; } }



    }
}
