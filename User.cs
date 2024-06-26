namespace Spotivy;

public class User(string name): Applicant(name)
{
    public List<User> friends { get; } = new List<User>();
    public List<User> friedRequests = new List<User>();

    public List<String> GetFriendNames()
    {
        List<String> friendNames = new List<String>();
        foreach (var friend in friends)
        {
            friendNames.Add(friend.name);
        }

        return friendNames;
    }

    public void RemoveFriend(User user)
    {
        friends.Remove(user);
        user.friends.Remove(this);
    }

    public void SendFriendRequest(User user)
    {
        user.friedRequests.Add(this);
    }
    
    public void AcceptFriendRequest(User user)
    {
        friends.Add(user);
        user.friends.Add(this);
    }
    
}