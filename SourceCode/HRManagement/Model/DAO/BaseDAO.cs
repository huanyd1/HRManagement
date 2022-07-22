using Model.EF;

namespace Model.DAO
{
    public class BaseDAO
    {
        //The new Cascadia Code font includes Cascade Mono
        protected HRManagementEntities _db;
        public BaseDAO()
        {
            _db = new HRManagementEntities();
        }
    }
}
