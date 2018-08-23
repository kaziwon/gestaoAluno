using Dapper;
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

                var alunos = connection.Query<AlunoMOD>(query) as List<AlunoMOD>;
                
                return alunos;
            }

        }

        public bool CadastraAluno(AlunoMOD aluno)
        {
            using (var connection = ConnectionFactory.banco())
            {
                #region Cadastrar
                const string query = @"
                                INSERT INTO 
	                                Alunos 
                                VALUES
	                                (@Nome, @RM)";
                #endregion

                var linhasCadastradas = connection.Execute(query, aluno) == 1;
                return linhasCadastradas;
            }
        }
    }
}
