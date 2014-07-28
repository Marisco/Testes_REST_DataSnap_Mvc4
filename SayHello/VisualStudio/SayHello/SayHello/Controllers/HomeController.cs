using Embarcadero.Datasnap.WindowsPhone7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SayHello.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        string _SayHello = "";

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SayHello(Usuario usuario)
        {
            var Proxy = conectarInstanciarProxy();
            Proxy.SayHello(usuario.nome.ToString(), (String sResult) =>
                {
                    _SayHello = sResult;

                }, null);

            //// 2ª forma de chamar a Proxy.SayHello é instaciar o delegate passando um método de result e criar
            // DSProxy.TServerMethods1.SayHelloCallback delegateSayhello = new DSProxy.TServerMethods1.SayHelloCallback(SayHelloResult);
            // Proxy.SayHello(usuario.nome.ToString(), delegateSayhello, ExceptionCallback);
           return Json(new { message = _SayHello });

        }
        //// Método result da 2ª  forma 
        // public void SayHelloResult(String sResult)
        // {
        //     _SayHello = sResult;
        // }

        private Embarcadero.Datasnap.WindowsPhone7.DSProxy.TServerMethods1 conectarInstanciarProxy()
        {
            DSRESTConnection connection = new DSRESTConnection();
            connection.setHost("localhost");
            connection.setPort(8080);
            connection.setProtocol("http");
            DSProxy.TServerMethods1 Proxy = new DSProxy.TServerMethods1(connection, ExceptionCallback);
            return Proxy;
        }

        public void ExceptionCallback(Exception e)
        {
            //todo
        }
    }
}