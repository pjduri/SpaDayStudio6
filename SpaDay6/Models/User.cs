namespace SpaDay6;

public class User
{

    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public User(){  }

    public User(string username, string email, string password)
    {
        Username = username;
        Email = email;
        Password = password;
    }
    // public string Username { get; set; }
    // public string Email { get; set; }
    // public string Password { get; set; }

    // // Bonus Mission
    // public DateTime SignUpTime { get; }

    // public User()
    // {
    //     SignUpTime = DateTime.Now;
    // }

    // public User(string u, string e, string p)
    // {
    //     Username = u;
    //     Email = e;
    //     Password = p;
    //     SignUpTime = DateTime.Now;
    // }
}
