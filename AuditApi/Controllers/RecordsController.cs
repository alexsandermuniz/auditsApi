using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditApi.Entities;
using BookStoreApi.Business;
using Microsoft.AspNetCore.Mvc;

namespace AuditApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        RecordsBusiness _RecordsBusiness = new RecordsBusiness();
        // GET api/records
        [HttpGet]
        public ActionResult<List<Record>> Get()
        {
            return _RecordsBusiness.getRecords();
        }

        // GET api/records/5
        [HttpGet("{id}")]
        public ActionResult<Record> Get(int id)
        {
            return _RecordsBusiness.getRecord(id);
        }

        // POST api/record
        [HttpPost]
        public ActionResult<long> Post([FromBody] Record record)
        {
            return _RecordsBusiness.addRecord(record);
        }
    }
}
