﻿using GestaoAluno.DAL;
using GestaoAluno.MOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAluno.BLL
{
    public class AlunoBLL
    {
        private AlunoDAL _alunoDAL;

        public AlunoBLL()
        {
            _alunoDAL = new AlunoDAL();
        }
        public List<AlunoMOD> RetornaAlunos()
        {
            return _alunoDAL.RetornaAlunos();
        }
    }
}
