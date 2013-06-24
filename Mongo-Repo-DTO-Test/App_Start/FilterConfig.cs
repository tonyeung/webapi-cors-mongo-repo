using System.Web;
using System.Web.Mvc;

namespace Mongo_Repo_DTO_Test
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}