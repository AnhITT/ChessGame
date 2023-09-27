using Libs.Data;
using Libs.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs.Repositories
{
    public interface IRoomRepository : IRepository<Room>
    {
        public void InsertRoom(Room room);
        public List<Room> GetRoomList();
        public Room GetById(object id);
    }
    public class RoomRepository : RepositoryBase<Room>, IRoomRepository
    {
        public RoomRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public void InsertRoom(Room room)
        {
            _dbContext.Room.Add(room); 
        }
        public List<Room> GetRoomList()
        {
            return _dbContext.Room.ToList();
        }
        public Room GetById(object id)
        {
            Room room = _dbContext.Room.Find(id);
            if (room != null)
                return room;
            throw new NotImplementedException();
        }
    }
}
