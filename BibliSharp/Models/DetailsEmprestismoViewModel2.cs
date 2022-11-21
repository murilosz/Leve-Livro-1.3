using BibliSharp.DbModels;

namespace BibliSharp.Models
{
    public class DetailsEmprestismoViewModel2
    {
        public string Aluno { get; set; }
        public string AlunoTurma { get; set; }
        public string AlunoPeriodo{ get; set; }
        public string Livro { get; set; }
        public Emprestismo Emprestismo { get; set; }
    }
}
