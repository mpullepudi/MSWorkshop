namespace Backend;

public class ChatSession
{
    public record struct message(string name, string body);
    public static List<message> Session = new List<message>();
}