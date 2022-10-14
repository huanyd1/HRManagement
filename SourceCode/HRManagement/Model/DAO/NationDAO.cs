using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class NationDAO : BaseDAO
    {
        public List<Nation> GetAll()
        {
            List<Nation> list = _db.Nations.ToList();

            return list;
        }

        public Nation GetSingleByID(int id)
        {
            Nation nation = _db.Nations.Where(x => x.IDNation == id).FirstOrDefault();

            return nation;
        }

        public int GetIDNationByName(string name)
        {
            int idNation = _db.Nations.Where(t => t.NationName == name).Select(t => t.IDNation).FirstOrDefault();

            return idNation;
        }
    }
}
