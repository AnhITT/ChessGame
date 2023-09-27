using Libs.Entity;
using Libs.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs.Service
{
    public class RoomService
    {
        private ApplicationDbContext applicationDbContext;
        private IRoomRepository roomRepository;
        private UserInRoomRepository userInRoomRepository;

        public RoomService(ApplicationDbContext applicationDbContext) 
        {
            this.applicationDbContext = applicationDbContext;
            this.roomRepository = new RoomRepository(applicationDbContext);
        }
        public void Save()
        {
            applicationDbContext.SaveChanges();
        }
        public void InsertRoom(Room room)
        {
            roomRepository.InsertRoom(room);
            Save();
        }
        public List<Room> GetRoomList()
        {
            return roomRepository.GetRoomList();
        }
        public List<UserInRoom> getUserInRoomList(Guid roomId)
        {
            return userInRoomRepository.getUserInRoomList(roomId);
        }
        public Room getRoomById(Guid roomId)
        {
            return roomRepository.GetById(roomId);
        }
    }
}
