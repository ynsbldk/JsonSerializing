using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonSoft
{

    public class Program
    {


        static void Main(string[] args)
        {
            List<Product> prd = new List<Product>
            {
                 new Product
                 {
                      Id=1,
                      Cash=25.40,
                      IsOk=true,
                      Name="Urun1"
                 },
                 new Product
                 {
                       Id=2,
                       Cash=12.40,
                       IsOk=false,
                       Name="Urun2"
                 }
            };

            string output = JsonConvert.SerializeObject(prd);


            Console.WriteLine(output);

            Console.WriteLine("-----------------------------");         


            Console.ReadLine();



        }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class Product
    {
        public int Id { get; set; }

        [JsonProperty]
        public string Name { get; set; }
        public double Cash { get; set; }
        public bool IsOk { get; set; }
    }
}
