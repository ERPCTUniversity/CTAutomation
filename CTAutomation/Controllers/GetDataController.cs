using CTAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CTAutomation.Controllers
{
    public class GetDataController : ApiController
    {
        //Get the data
        public object GetOnOffData(string deviceId)
        {
            using (CTAutomationEntities1 entities = new CTAutomationEntities1())
            {
                var data = entities.Automations.Where(i => i.DeviceId.ToString().Equals(deviceId)).ToList();
                if (data != null)
                {
                    return data;
                }
                else
                {
                    return false;
                }
            }
        }
        //Post data
        [HttpGet]
        public object PostData(string roomno, string value) 
        {
            using (CTAutomationEntities1 entities = new CTAutomationEntities1())
            {
                var data = entities.Automations.Where(i => i.RoomNo.Equals(roomno)).FirstOrDefault();
                if(data != null)
                {
                    data.Value = bool.Parse(value);
                    entities.SaveChanges();
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NoContent);
                }

                return Request.CreateResponse(HttpStatusCode.Created);
            }
        }
    }
}
