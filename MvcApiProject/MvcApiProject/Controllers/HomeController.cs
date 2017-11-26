using MvcApiProject.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApiProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString);
            List<Users> lista = new List<Users>();
            Users users;
            //var model = new Noticias();

            try
            {
                conn.Open();

                string comando = "select * from tb_user";
                NpgsqlCommand cmd = new NpgsqlCommand(comando, conn);
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter(cmd);
                DataSet dsResult = new DataSet();
                adp.Fill(dsResult);

                conn.Close();

                //lista = new List<string>();

                foreach (DataRow r in dsResult.Tables[0].Rows)
                {
                    users = new Users();
                    users.codigo = int.Parse(r["codigo"].ToString());
                    users.nome = r["nome"].ToString();
                    lista.Add(users);
                }
            }
            catch { }

            ViewBag.List = lista;

            return View();
        }
    }
}
