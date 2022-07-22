using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class BaseDAO
    {
        protected HRManagementEntities _db;
        public BaseDAO()
        {
            _db = new HRManagementEntities();
        }
    }
}
