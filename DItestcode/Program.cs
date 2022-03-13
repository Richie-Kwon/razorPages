using System;

namespace DItestcode
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoesStore shoesStore = new ShoesStore();
            Shoes myNShoes = shoesStore.OrderShoes(new NShoes());
            Console.WriteLine($"Name:{myNShoes.Name} and Size:{myNShoes.Size}");
        }
    }

    public class Shoes
    {
        public string Name { get; set; }
        public int Size { get; set; }
    }

    public interface IShoesFactory
    {
        public Shoes MakeShoes();
    }

    public class NShoes : IShoesFactory
    {
        public Shoes MakeShoes()
        {
            return new Shoes()
            {
                Name = "Russian", Size = 250
            };
        }
    }

    public class AShoes : IShoesFactory
    {
        public Shoes MakeShoes()
        {
            return new Shoes()
            {
                Name = "Ukraine", Size = 270
            };
        }
    }

    public class ShoesStore
    {
        public Shoes OrderShoes(IShoesFactory sharesFactory)
        {
            return sharesFactory.MakeShoes();
        }
    }
}