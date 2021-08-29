using DataAccessLayer;
using Entities;
using Entities.Interfaces;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class AlunoBLL : BaseValidator<Aluno>, IAluno
    {
        private AlunoDAL alunoDAL = new AlunoDAL();

        public override Response Validate(Aluno item)
        {
            return base.Validate(item);
        }
        public DataResponse<Aluno> GetAll()
        {
            return alunoDAL.GetAll();
        }

        public Response Insert(Aluno aluno)
        {
            Response response = this.Validate(aluno);
            if (!response.Success)
            {
                return response;
            }
            return alunoDAL.Insert(aluno);
        }

        public Response Update(Aluno aluno)
        {
            Response response = this.Validate(aluno);
            if (!response.Success)
            {
                return response;
            }
            return alunoDAL.Update(aluno);
        }

        public DataResponse<Aluno> PesquisarAluno(Aluno aluno)
        {
            AlunoDAL alunoDAL = new AlunoDAL();
            return alunoDAL.PesquisarAluno(aluno);
        }
    }
}

