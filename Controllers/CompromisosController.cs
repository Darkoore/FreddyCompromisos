using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Compromisos.Models;

namespace Compromisos.Controllers
{
    public class CompromisosController : Controller
    {
        // GET: Compromisos

        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(IdFuncionario lc)
        {
            if (ModelState.IsValid)
            {

                string mainconn = ConfigurationManager.ConnectionStrings["LOCAL_BD"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "select FUNC_ID, FUNC_UTRABAJO from [dbo].[FUNCIONARIO] where FUNC_ID=@FUNC_ID and FUNC_UTRABAJO=@FUNC_UTRABAJO";
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                sqlcomm.Parameters.AddWithValue("FUNC_ID", lc.FUNC_ID);
                sqlcomm.Parameters.AddWithValue("FUNC_UTRABAJO", lc.FUNC_UTRABAJO);

                SqlDataReader sdr = sqlcomm.ExecuteReader();
                if (sdr.Read())
                {
                    Session["FUNC_ID"] = lc.FUNC_ID.ToString();
                    return RedirectToAction("Inicio");
                }
                else
                {
                    ViewData["Message"] = "Fallo el inicio de sesion !";
                }
                sqlconn.Close();
            }
            return View();
        }

        public ActionResult Inicio()
        {
            return View();

        }

        public ActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(Participantes smodel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ConexionBD sdb = new ConexionBD();
                    if (sdb.AñadirPart(smodel))
                    {
                        ViewBag.Message = "Student Details Added Successfully";
                        ModelState.Clear();
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Actividad()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Actividad(Participantes smodel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ConexionBD sdb = new ConexionBD();
                    if (sdb.AñadirPart(smodel))
                    {
                        ViewBag.Message = "Student Details Added Successfully";
                        ModelState.Clear();
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }



    }
}