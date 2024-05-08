namespace HelpersMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sai Pavani");

            Console.WriteLine("What are the products list ? ");
            string productslist = Console.ReadLine();

            Console.WriteLine("We supply Glass and Glass Fixings! ");
            string GlassandGlassFixings  =  Console.ReadLine();

            Console.WriteLine("We supply Hardware Items : ");
            string HardwareItems = Console.ReadLine();

            char[] productlistarray = productslist.ToCharArray();
            Array.Reverse(productlistarray);

            char[] GlassandGlassFixingsarray = GlassandGlassFixings.ToCharArray();
            Array.Reverse(GlassandGlassFixingsarray);

            char[] HardwareItemsarray = HardwareItems.ToCharArray();
            Array.Reverse(HardwareItemsarray);

            string result = " ";

            foreach (char item in productlistarray) ;
            { 
                  result +=  productslist;
            }
            result += " ";

            foreach (char item in GlassandGlassFixingsarray) ;
            {
                result +=  GlassandGlassFixings;
            }

            result += " ";

            foreach (char item in HardwareItemsarray) ;
            {
                result += HardwareItems;
            }

            Console.WriteLine("Results: " + result);

            Console.ReadLine();
        }
    }
}
