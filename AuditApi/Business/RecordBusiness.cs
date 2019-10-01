using AuditApi.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BookStoreApi.Business
{
    
    public class RecordsBusiness
    {
        private static long contMockId = 100;
        public static List<Record> recordsMock = new List<Record>();
        public long addRecord(Record record)
        {
            record.id = contMockId;
            recordsMock.Add(record);
            return contMockId++;
        }
        public Record getRecord(long recordId)
        {
            return recordsMock.Where(x => x.id == recordId).FirstOrDefault();
        }
        public List<Record> getRecords()
        {
            return recordsMock;
        }
    }

}


