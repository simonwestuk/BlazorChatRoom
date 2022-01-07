using System.Collections.Generic;

namespace BlazorChatRoom.Models
{
    public class ChatRoomsModel
    {
        public List<RoomModel> ChatRooms { get; set; } = new List<RoomModel>();
    }
}
