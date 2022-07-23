using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class PositionDAO : BaseDAO
    {
        public List<Position> GetAll()
        {
            List<Position> list = _db.Positions.ToList();

            return list;
        }

        public Position GetSingleByID(string id)
        {
            Position position = _db.Positions.Where(x => x.IDPosition == id).FirstOrDefault();

            return position;
        }

        public bool Add(Position position)
        {
            try
            {
                _db.Positions.Add(position);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool Edit(Position position)
        {
            try
            {
                Position currentPosition = GetSingleByID(position.IDPosition);

                currentPosition.PositionName = position.PositionName;
                currentPosition.Status = position.Status;
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool Delete(string id)
        {
            try
            {
                Position currentPosition = GetSingleByID(id);

                _db.Positions.Remove(currentPosition);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                Model.NotificationCommon.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool IsExitPosition(string name)
        {
            var result = _db.Positions.Where(x => x.PositionName == name).Any();

            return result;
        }
    }
}
