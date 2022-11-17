namespace ping_pong_api;

public class PingOrPong
{
    public string msg { get; set; }

    public PingOrPong(string isPingOrPong)
    {
        switch (isPingOrPong.ToLower().Trim())
        {
            case "pong": msg = "Ping"; break;
            case "ping": msg = "Pong"; break;
            default: msg = "-1"; break;
        }
    }
}