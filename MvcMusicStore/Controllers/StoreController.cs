using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "Hello from Store.index()";
        }
        
        //GET /store/browse?genre=disco
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);

            return message;
        }

        //GET /store/details/5
        public string Details(int id)
        {

            return $"hello from store.Details(ID = {id}) ";
        }
    }
}