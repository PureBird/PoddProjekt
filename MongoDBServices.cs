using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace PoddProjekt
{
    public class MongoDBServices
    {
        public readonly IMongoCollection<Medlem> medlemKollektion;
        public MongoDBServices()
        {
            var klient = new MongoClient("mongodb+srv://OruMongoDBAdmin:hej@orumongodb.8yb9y4t.mongodb.net/?appName=OruMongoDB");
            var databas = klient.GetDatabase("OruMongoDB");
            medlemKollektion = databas.GetCollection<Medlem>("Medlemmar");
        }

        public bool MedlemFinns(string ID)
        {

            var filter = Builders<Medlem>.Filter.Eq(m => m.Id, ID);

            return medlemKollektion.Find(filter).Any();

        }


        public List<Medlem> HamtaAllaMedlemmar()
        {
            var filter = FilterDefinition<Medlem>.Empty;
            List<Medlem> medlemLista = medlemKollektion.Find(filter).ToList();
            return medlemLista;
        }

        public void LaggTillMedlem(Medlem m)
        {
            if (!MedlemFinns(m.Id))
            {
                medlemKollektion.InsertOne(m);
            }
        }

    }
}
