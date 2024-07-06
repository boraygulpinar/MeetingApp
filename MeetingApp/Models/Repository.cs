namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new List<UserInfo>();

        static Repository()
        {
            _users.Add(new UserInfo() { Name = "Ali", Email = "abc@gmail.com", Phone = "123", WillAttend = true });
            _users.Add(new UserInfo() { Name = "Kemal", Email = "abcd@gmail.com", Phone = "1234", WillAttend = true });
            _users.Add(new UserInfo() { Name = "Veli", Email = "abcde@gmail.com", Phone = "12345", WillAttend = true });
        }

        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }
        public static void CreateUser(UserInfo user)
        {
            _users.Add(user);
        }
    }
}
