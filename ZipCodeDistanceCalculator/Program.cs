using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ZipCodeDistanceCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Setup();
        }

        private static async void Setup()
        {
            var client =
                new MongoClient(
                    System.Configuration.ConfigurationManager.ConnectionStrings["mongoConnection"].ConnectionString);

            var database = client.GetDatabase(ConfigurationManager.AppSettings["mongoDb"]);

            var source = database.GetCollection<IpZip>(ConfigurationManager.AppSettings["source"]);
            var zips = database.GetCollection<TheZipCode>(ConfigurationManager.AppSettings["search"]);

            var results = source.Find(_ => true).ToList();

            results.ForEach(r =>
            {
                var f = Builders<TheZipCode>.Filter.Eq("ZipCode", r.zip);
                var zip = zips.Find(f);
            });

//            using (var results = await source.FindAsync(_ => true))
//            {
//                while (await results.MoveNextAsync())
//                {
//                    var c = results.Current;
//                    foreach (var t in c)
//                    {
//                        var f = Builders<TheZipCode>.Filter.Eq("ZipCode", t.zip);
//                        var zip = zips.Find(f);
//                    }
//                }
//            }
        }
    }
}
