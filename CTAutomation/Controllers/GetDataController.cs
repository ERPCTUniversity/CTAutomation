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
        public bool GetOnOffData(string roomno)
        {
            using (CTAutomationEntities1 entities = new CTAutomationEntities1())
            {
                var data = entities.Automations.Where(i => i.RoomNo.Equals(roomno)).FirstOrDefault();
                if (data != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
