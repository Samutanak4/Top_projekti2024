using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Työkalupakkisovellus
{
    public class VarausTiedotTab
    {
        private IMongoCollection<BsonDocument> _activeBookingsCollection;
        private IMongoCollection<BsonDocument> _toolsCollection;


        public VarausTiedotTab()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("TyokaluDB");
            _activeBookingsCollection = database.GetCollection<BsonDocument>("ActiveBookings");
            _toolsCollection = database.GetCollection<BsonDocument>("Tools");
        }

        public void SendBookingInfo(string studentName, string teacherName, DateTime dateTime, string additionalInfo, IEnumerable<string> checkedTools)
        {           
            var document = new BsonDocument
            {
                { "studentName", studentName },
                { "teacherName", teacherName },
                { "dateTime", dateTime },
                { "additionalInfo", additionalInfo },
                { "checkedTools", new BsonArray(checkedTools) }
            };          
            _activeBookingsCollection.InsertOne(document);
        }

        public BsonDocument GetBookingDetails(string studentName)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("studentName", studentName);
            return _activeBookingsCollection.Find(filter).FirstOrDefault();
        }

        public List<string> GetBookingName()
        {
            var bookings = _activeBookingsCollection.Find(new BsonDocument()).ToList();
            return bookings.Select(b => b["studentName"].AsString).ToList();
        }

        public void RemoveBooking(string bookingId)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(bookingId));
            _activeBookingsCollection.DeleteOne(filter);
        }

        public List<string> GetBorrowedToolsForBooking(string bookingId)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(bookingId));
            var projection = Builders<BsonDocument>.Projection.Include("borrowedTools");
            var document = _activeBookingsCollection.Find(filter).Project(projection).FirstOrDefault();

            if (document != null && document.Contains("borrowedTools"))
            {
                var tools = document["borrowedTools"].AsBsonArray.Select(b => b.AsString).ToList();
                return tools;
            }

            return new List<string>();
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
    }
}
