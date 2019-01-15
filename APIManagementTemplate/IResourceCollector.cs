using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIManagementTemplate
{
    public interface IResourceCollector
    {
        string Login(string tenantName);
        Task<JObject> GetResource(string resourceId, string suffix = "", string apiversion = "2018-06-01-preview");
    }
}
