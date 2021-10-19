using System;

namespace AppModels
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int DepartId { get; set; }
    }
}
