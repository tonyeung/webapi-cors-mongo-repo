using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mongo_Repo_DTO_Test.Controllers
{
    public class ValuesController : ApiController
    {
        // POST api/values
        public void poco(POCO poco)
        {
            Console.WriteLine(poco.Name);
        }

        // POST api/values
        public void derived(EntityDerived derived)
        {
            Console.WriteLine(derived.Name);
        }
    }

    public class POCO
    {
        public int id { get; set; }
        public string Name { get; set; }
    }

    [Serializable]
    public class EntityDerived : Entity
    {
        public string Name { get; set; }
    }
}