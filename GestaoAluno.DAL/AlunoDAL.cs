using GestaoAluno.MOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAluno.DAL
{
    public class AlunoDAL
    {
        public List<AlunoMOD> RetornaAlunos()
        {
            using (var connection = ConnectionFactory.banco())
            {
                #region QUERY
                const string query = @"
                                SELECT
                                    *
                                FROM
                                    Alunos";
                #endregion

                return
            }

        }
    }
}
