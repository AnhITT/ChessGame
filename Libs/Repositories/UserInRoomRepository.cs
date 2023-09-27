using Libs.Data;
using Libs.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs.Repositories
{
    public interface IUserInRoomRepository : IRepository<UserInRoom>
    {
        public void insertUserInRoom(UserInRoom UserInRoom);
        public List<UserInRoom> getUserInRoomList(Guid roomId);
       
    }

    public class UserInRoomRepository : RepositoryBase<UserInRoom>, IUserInRoomRepository
    {
        public UserInRoomRepository(ApplicationDbContext dBContext) : base(dBContext) { }


        public void insertUserInRoom(UserInRoom userInRoom)
        {
            _dbContext.UserInRoom.Add(userInRoom);
        }
        public List<UserInRoom> getUserInRoomList(Guid roomid)
        {
            return _dbContext.UserInRoom.Where(s => s.RoomId == roomid).ToList();
        }

       
    }
}
