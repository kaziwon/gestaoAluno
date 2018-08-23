using GestaoAluno.BLL;
using GestaoAluno.MOD;
using GestaoAluno.Models;
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


        [HttpPost]
        public bool CadastrarAluno(AlunoModel model)
        {
            if (ModelState.IsValid)
            {
                var aluno = new AlunoMOD()
                {
                    Nome = model.Nome,
                    RM = model.RM
                };

                return _alunoBLL.CadastrarAluno(aluno);
            }

            return false;
        }

        
        [HttpGet]
        public ActionResult Index()
        {
            var alunos = _alunoBLL.RetornaAlunos();

            return View(alunos);
        }
    }
}