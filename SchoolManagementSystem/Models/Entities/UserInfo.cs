﻿namespace SchoolManagementSystem.Models.Entities
{
    public class UserInfo
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string AccessLevel { get; set; }
    }
}
