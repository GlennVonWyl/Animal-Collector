namespace Animal_Collector.Models
{
    public class UserService
    {
        private List<User> _users = new List<User>();
        private User _currentUser;

        public bool Register(User newUser)
        {
            if (_users.Any(u => u.Email == newUser.Email))
            {
                return false;
            }

            _users.Add(newUser);
            _currentUser = newUser;
            return true;
        }

        public bool Login(string email, string password)
        {
            var user = _users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                _currentUser = user;
                return true;
            }
            return false;
        }

        public User GetCurrentUser()
        {
            return _currentUser;
        }

        public class User
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }
    }
}
