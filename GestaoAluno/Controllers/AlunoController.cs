using GestaoAluno.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestaoAluno.Controllers
{
    public class AlunoController : Controller
    {
        private AlunoBLL _alunoBLL;
        // GET: Aluno

        public AlunoController()
        {
            _alunoBLL = new AlunoBLL();
        }
        public ActionResult Index()
        {
            var x = _alunoBLL.Teste();

            return View();
        }
    }
}