using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PoddProjekt
{
    public class Medlem
    {
        [BsonId]
        public string Id { get; set; }


        [BsonElement("namn")]
        public string Namn { get; set; }


        [BsonElement("epost")]
        public string Epost { get; set; }


        


        [BsonElement("totalpoang")]
        public int TotalPoang { get; set; }

        public Medlem() { }

        public Medlem(string id, string namn, string epost, int totalPoang)
        {
            Id = id;
            Namn = namn;
            Epost = epost;
            TotalPoang = totalPoang;
        }
    }
}
