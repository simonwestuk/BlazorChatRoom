using System;

namespace BlazorChatRoom.Models
{
    public class CurrentUser
    {
        public UserModel User { get; set; } = new UserModel();

        public CurrentUser()
        {
            User.Online = true;
            User.UserId = Guid.NewGuid();
        }
    }
}

 