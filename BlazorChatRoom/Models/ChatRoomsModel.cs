using System;
using System.Collections.Generic;

namespace BlazorChatRoom.Models
{
    public class ChatRoomsModel
    {
        public Dictionary<Guid, RoomModel> ChatRooms { get; set; } = new Dictionary<Guid, RoomModel>();
    }
}
