using System;

namespace bazaarcs.api.Model
{
    public class ActionLog
    {
        public string Id { get; set; }
        public string  ActionLogId { get; set; }
        public string AspNetUserId { get; set; }
        public UserAction UserAction { get; set; }
        public DateTime ActionTime { get; set; }
    }

    public enum UserAction
    {
        Login,
        LogOut,
        Search,
        ItemView,
        HomePage,
        ListProducts
    }
}
