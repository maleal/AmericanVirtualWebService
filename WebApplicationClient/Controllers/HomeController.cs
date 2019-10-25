using DataBusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AVServiceReference.UserDTO dto = new AVServiceReference.UserDTO();
            AVServiceReference.UserDTOResp resp = new AVServiceReference.UserDTOResp();
            AVServiceReference.UserDTOReq req = new AVServiceReference.UserDTOReq()
            {
                Users = new AVServiceReference.ListaUsers(),
            };

            using (AVServiceReference.Service1Client service1 = new AVServiceReference.Service1Client())
            {
                req.Operacion = Constantes.User.CONSULTAR_CON_NAME;
                //
                dto.UserName = TempData["mario_leal_fuentes"] as string;
                req.Users.Add(dto);
                resp = service1.UserConsultar(req);
            }

            //Si obtuvimos respuesta
            if (resp.Users != null && resp.Users.Count() > 0)
            {
                dto = resp.Users[0];
            }


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}