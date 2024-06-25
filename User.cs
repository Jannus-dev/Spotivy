namespace Spotivy;

public class User(string name): Applicant(name)
{
    public List<User> friends = new List<User>();
    public List<User> friedRequests = new List<User>();
    
    public void AddFriend(User user)
    {

    }
    
    public void RemoveFriend(User user)
    {

    }

    public void SendFriendRequest(User user)
    {

    }
    
    public void AcceptFriendRequest(User user)
    {

    }
    
}