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

        public TyokalulistaTab(string connectionString, string databaseName, string collectionName)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            _toolsCollection = database.GetCollection<BsonDocument>(collectionName);
        }

        public List<string> GetAllTools()
        {
            return _toolsCollection.Find(new BsonDocument())
                                   .ToList()
                                   .Select(doc => doc["displayName"].AsString)
                                   .ToList();
        }

        public void AddTool(string toolName, decimal replacementCost)
        {
            var document = new BsonDocument
        {
            { "displayName", toolName },
            { "replacementCostEur", replacementCost }
        };
            _toolsCollection.InsertOne(document);
        }

        public void RemoveTool(string toolName)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("displayName", toolName);
            _toolsCollection.DeleteOne(filter);
        }

        public decimal GetToolReplacementCost(string toolName)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("displayName", toolName);
            var tool = _toolsCollection.Find(filter).FirstOrDefault();
            return tool != null ? tool["replacementCostEur"].AsDecimal : 0;
        }
    }
}
