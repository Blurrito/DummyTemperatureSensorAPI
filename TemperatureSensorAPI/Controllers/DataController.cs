using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemperatureSensorAPI.Controllers
{
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpGet("data/{EntryId}")]
        public async Task<ActionResult<TemperatureData>> GetData(int EntryId)
        {
            List<TemperatureData> Data = new List<TemperatureData>()
            {
                new TemperatureData()
                {
                    DataEntryId = 0,
                    SensorId = 0,
                    TemperatureC = 14.6m
                },
                new TemperatureData()
                {
                    DataEntryId = 1,
                    SensorId = 1,
                    TemperatureC = 27.4m
                }
            };
            if (EntryId >= Data.Count)
                return NotFound();
            return Data[EntryId];
        }
    }

    public struct TemperatureData
    {
        public int DataEntryId { get; set; }
        public int SensorId { get; set; }
        public decimal TemperatureC { get; set; }
    }
}
