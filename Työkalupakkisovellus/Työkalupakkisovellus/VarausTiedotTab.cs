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

        public VarausTiedotTab()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("TyokaluDB");
            _activeBookingsCollection = database.GetCollection<BsonDocument>("ActiveBookings");
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
    }
}
