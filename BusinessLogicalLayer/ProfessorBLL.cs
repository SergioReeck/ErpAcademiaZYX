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
    public class ProfessorBLL : BaseValidator<Professor>, IProfessor
    {
        private ProfessorDAL professorDAL = new ProfessorDAL();

        public override Response Validate(Professor item)
        {
            return base.Validate(item);
        }
        public DataResponse<Professor> GetAll()
        {
            return professorDAL.GetAll();
        }

        public Response Insert(Professor professor)
        {
            Response response = this.Validate(professor);
            if (!response.Success)
            {
                return response;
            }
            return professorDAL.Insert(professor);
        }

        public Response Update(Professor professor)
        {
            Response response = this.Validate(professor);
            if (!response.Success)
            {
                return response;
            }
            return professorDAL.Update(professor);
        }

        public DataResponse<Professor> PesquisarProfessor(Professor professor)
        {
            ProfessorDAL professorDAL = new ProfessorDAL();
            return professorDAL.PesquisarProfessor(professor);
        }
    }
}

