using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
        private int storageCapacity;
        public ShoeStore(string name, int storageCapacity)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            Shoes = new List<Shoe>();
        }
        public string Name { get; set; }
        public int StorageCapacity { get {return storageCapacity; } set {storageCapacity=value; } }
        public List<Shoe> Shoes{ get; private set; }
        public int Count { get { return Shoes.Count; }}

        public string AddShoe(Shoe shoe)
        {
            if(Shoes.Count() == StorageCapacity)
            {
                return "No more space in the storage room.";
            }
            else
            {
                Shoes.Add(shoe);
                return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
            }
        }     
        public int RemoveShoes(string material)
        {
            return Shoes.RemoveAll(x=>x.Material==material);
     
        }
        public List<Shoe> GetShoesByType(string type)
        {
            List<Shoe>newShoes= new List<Shoe>();
            foreach (var shoe in Shoes)
            {
                if(shoe.Type.ToLower()==type.ToLower())
                {
                    newShoes.Add(shoe);
                }
            }
            return newShoes;
        }
        public Shoe GetShoeBySize(double size)
        {
            Shoe shoe = Shoes.First(x => x.Size == size);
            return shoe;
        }

        public string StockList(double size, string type)
        {
            StringBuilder sb= new StringBuilder();
            sb.AppendLine($"Stock list for size {size} - {type} shoes:");
            bool haveShoes= false;
            foreach (var shoe in Shoes)
            {
                if(shoe.Size== size&&shoe.Type==type) 
                { 
                   sb.AppendLine(shoe.ToString());
                    haveShoes=true;
                }
            }
            if (haveShoes)
            {
                return sb.ToString().TrimEnd();
            }
            return "No matches found!";
        }
    }
}
