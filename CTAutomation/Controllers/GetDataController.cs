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
    }
}
