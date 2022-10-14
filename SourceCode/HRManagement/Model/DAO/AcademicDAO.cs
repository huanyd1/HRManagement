using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class AcademicDAO : BaseDAO
    {
        public List<AcademicLevel> GetAll()
        {
            List<AcademicLevel> list = _db.AcademicLevels.ToList();

            return list;
        }

        public AcademicLevel GetSingleByID(int id)
        {
            AcademicLevel academic = _db.AcademicLevels.Where(x => x.IDAcademic == id).FirstOrDefault();

            return academic;
        }

        public int GetIDAcademicByName(string name)
        {
            int idAcademic = _db.AcademicLevels.Where(t => t.AcademicName == name).Select(t => t.IDAcademic).FirstOrDefault();

            return idAcademic;
        }
    }
}
