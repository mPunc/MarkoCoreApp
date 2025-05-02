using Models.Interfaces;

namespace Models.Base
{
    public class Class1 : IDeleteLater
    {
        public void ClassTest() {
            Console.WriteLine("Class1 here!");
        }

        public void RandomCrapPrinter()
        {
            Console.WriteLine("Random crap!");
        }
    }
}
