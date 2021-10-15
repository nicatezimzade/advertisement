using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement
{
           
    public class Program
    {
        static void Main(string[] args)
        {
           
            Advertisement ad1 = new Advertisement("game", 500, "Nicat");
            Advertisement ad2 = new Advertisement("food", 1000, "Eli");
            Advertisement ad3 = new Advertisement("car", 1500, "Veli");
            
            Advertisement[] Ads = { ad1, ad2, ad3 };

            double result = ad1.Cost + ad2.Cost + ad3.Cost;
            Console.WriteLine(result);

            try
            {
                Array.Sort(Ads);
            }
            catch (Exception)
            {
                Console.WriteLine($"Array sort oluna bilmir");
            }
            foreach (Advertisement item in Ads)
            {
                Console.WriteLine(item);
            }
        }

    }




    enum Category
    {
        Television,
        Mobile,
        SocialMedia
    }


}
