namespace UserManagement
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(UserManager.Login("nika1998", "123")); //false
            User user1 = new User();
            user1.Username = "nika1998";
            user1.Password = "123";
            Console.WriteLine(UserManager.Register(user1)); //0
            Console.WriteLine(UserManager.Register(user1)); //-2
            User user2 = new User() { Username = "Nino9796", Password = "9796" };
            Console.WriteLine(UserManager.Register(user2)); //0
            Console.WriteLine(UserManager.Login("nika1998", "123")); //true
            Console.WriteLine(UserManager.Login("nika1998", "111")); //false
            Console.WriteLine(UserManager.UnRegister("nikusha1998")); //false
            Console.WriteLine(UserManager.UnRegister("nika1998")); //true
            Console.WriteLine(UserManager.Login("nika1998", "123")); //false
        }
    }

    class User
    {
        public User(string username, string password) 
        {
            ValidateUsername(username);
            ValidatePassword(password);
            Username = username;
            Password = password;
        }

        public string Username { get; }
        public string Password { get; private set; }

        public void ChangePassword(string currentPassword, string newPassword)
        {
            if (currentPassword == newPassword)
                throw new ArgumentException("New password cannot be the same as the current password.");
            if (Password != currentPassword)
                throw new ArgumentException("Current password is incorrect.");

            ValidatePassword(newPassword);
            Password = newPassword;
        }

        private static void ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username cannot be null or empty.");
            if (username.Length < 8)
                throw new ArgumentException("Username must be at least 8 characters long.");
        }

        private static void ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password cannot be null or empty.");
            if (password.Length < 4)
                throw new ArgumentException("Password must be at least 4 characters long.");
        }
    }

    static class UserManager
    {
        private static User?[] _users = new User?[10];

        public static int Register(User? user)
        {
            if (user == null)
                return -1;

            if (UserExists(user.Username))
                return -2;

            int emptyIndex = GetEmptySlotIndex();
            // Modify Systems so if there is no empty slot, it should add a new slot dynamically.
            // For now, we return -3 to indicate no available slots.
            if (emptyIndex == -1)
                Resize();
                emptyIndex = GetEmptySlotIndex();                // before there was 'return -3'

            _users[emptyIndex] = user;
            return 0;
        }

        private static void Resize()
        {
            User?[] newArray = new User?[_users.Length + 1];

            for (int i = 0; i < _users.Length; i++)
            {
                newArray[i] = _users[i];
            }

            _users = newArray;
        }

        public static bool Login(string username, string password) 
            => GetUser(username)?.Password == password;

        public static bool UnRegister(string username)
        {
            int index = GetUserIndex(username);
            if (index == -1)
                return false;
            _users[index] = null;
            return true;
        }

        private static int GetUserIndex(string username)
        {
            for (int i = 0; i < _users.Length; i++)
            {
                if (_users[i]?.Username == username)
                    return i;
            }
            return -1;
        }

        private static User? GetUser(string username)
        {
            int index = GetUserIndex(username);
            return index != -1 
                ? _users[index] 
                : null;
        }

        private static bool UserExists(string username) 
            => GetUserIndex(username) != -1;

        private static int GetEmptySlotIndex()
        {
            for (int i = 0; i < _users.Length; i++)
            {
                if (_users[i] == null)
                    return i;
            }
            return -1;
        }
}
