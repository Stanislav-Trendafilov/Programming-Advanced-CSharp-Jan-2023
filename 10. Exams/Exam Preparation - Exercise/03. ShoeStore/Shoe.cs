using System.Drawing;

namespace ShoeStore
{
    public class Shoe
    {
		//        You are given a class Shoe,  create the following properties:
		//•	Brand – string
		//•	Type – string
		//•	Size – double
		//•	Material – string
		//The class constructor should receive brand, type, size and material.
		//Override ToString() method: "Size {Size}, {Material} {Brand} {Type} shoe."

		private string brand;
		private string type;
        private string material;
        private double size;

        public Shoe(string brand, string type, double size, string material)
        {
            this.brand = brand;
            this.type = type;
            this.material = material;
            this.size = size;
        }

        public string Type {get { return type; } set { type = value; }}
		public string Brand {get { return brand; }set { brand = value; }}
        public double Size{ get { return size; } set { size = value; } }
        public string Material { get { return material; } set { material = value; } }

        public override string ToString()
        {
            return $"Size {Size}, {Material} {Brand} {Type} shoe.";
        }

    }
}
