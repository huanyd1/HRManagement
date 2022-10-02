using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class SpecializeDAO : BaseDAO
    {
        public List<Specialize> GetAll()
        {
            List<Specialize> list = _db.Specializes.ToList();

            return list;
        }

        public Specialize GetSingleByID(int id)
        {
            Specialize specialize = _db.Specializes.Where(x => x.IDSpecialize == id).FirstOrDefault();

            return specialize;
        }
    }
}
