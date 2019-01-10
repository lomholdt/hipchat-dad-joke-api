namespace DadJokes
{
  public class HipChatResponse
  {
    public string Color { get; set; }

    public string Message { get; set; }

    public bool Notify { get; set; }

    public string MessageFormat { get; set; } = "text";
  }
}
