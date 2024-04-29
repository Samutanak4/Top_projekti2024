using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Työkalupakkisovellus
{
    internal class TyokalulistaTab
    {
        private IMongoCollection<BsonDocument> _toolsCollection;

        public TyokalulistaTab(string connectionString, string tyokaluDB, string tools)
        {
            //var client = new MongoClient(connectionString);
            //var database = client.GetDatabase(tyokaluDB);
            //_toolsCollection = database.GetCollection<BsonDocument>(tools);
        }
        public decimal GetToolReplacementCost(string toolName)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("displayName", toolName);
            var projection = Builders<BsonDocument>.Projection.Include("replacementCostEur");
            var toolDocument = _toolsCollection.Find(filter).Project(projection).FirstOrDefault();

            if (toolDocument != null && toolDocument.Contains("replacementCostEur"))
            {
                return toolDocument["replacementCostEur"].AsDecimal;
            }

            return 0;  
        }

        public List<string> GetTools()
        {
            return _toolsCollection.Find(new BsonDocument()).ToList()
                .Select(doc => doc["displayName"].AsString + " - €" + doc["replacementCostEur"].AsDecimal.ToString("F2"))
               .ToList();
        }

        public void AddTool(string toolName, decimal replacementCostEur)
        {
            var document = new BsonDocument
        {
            { "displayName", toolName },
            { "replacementCostEur", replacementCostEur }
        };
            _toolsCollection.InsertOne(document);
        }

        public void RemoveTool(string name)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("displayName", name);
            _toolsCollection.DeleteOne(filter);
        }
    }
}
