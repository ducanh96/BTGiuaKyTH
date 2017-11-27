using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebClient.Models;

namespace WebClient.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (var cliet = new HttpClient())
            {
                
                cliet.BaseAddress = new Uri("http://localhost:49928/");
               
                cliet.DefaultRequestHeaders.Accept.Clear();
                cliet.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = cliet.GetAsync("dsnsx");
                response.Wait();
                var result = response.Result;
                if(result.IsSuccessStatusCode)
                {
                   var KQ = result.Content.ReadAsAsync<List<NSX>>();
                    KQ.Wait();
                    List<NSX> nsx = KQ.Result;
                    return View(nsx);
                }
               
            }
            return View();
               
        }
        public static async Task<List<NSX>> GetProductAsync(string path)
        {
            using (var client = new HttpClient())
            {


                List<NSX> product = null;
                HttpResponseMessage response = await client.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    product = await response.Content.ReadAsAsync<List<NSX>>();
                }
                return product;
            }
        }
          



    }
}