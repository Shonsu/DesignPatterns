namespace Proxy;

public class YoutTubeService : IYoutTubeService
{
    public byte[] GetVideo(int videoId)
    {
        System.Console.WriteLine($"Youtube service downloading video with id: {videoId}");
        return new byte[videoId];
    }
}
