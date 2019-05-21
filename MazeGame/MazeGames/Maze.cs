using System.Collections.Generic;

namespace MazeGame
{
    public class MapSite
    {
        public List<Room> rooms = new List<Room>();
        public  void AddRooms(List<Room> roomsToAdd)
        {
            rooms.AddRange(roomsToAdd);
        }
    }
}