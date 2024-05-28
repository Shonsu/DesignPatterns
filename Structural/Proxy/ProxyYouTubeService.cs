namespace Proxy;

public class ProxyYouTubeService : IYoutTubeService
{
    private Dictionary<int, byte[]> _cache = [];
    private YoutTubeService _youtTubeService;

    public ProxyYouTubeService(YoutTubeService youtTubeService)
    {
        _youtTubeService = youtTubeService;
    }

    public byte[] GetVideo(int videoId)
    {
        System.Console.WriteLine($"PROXY Youtube service getting video with id: {videoId}");
        byte[] _cachedVideo;
        if (_cache.TryGetValue(videoId, out _cachedVideo))
        {
            System.Console.WriteLine($"Getting video with id: {videoId} from cache");
            return _cachedVideo;
        }

        byte[] video = _youtTubeService.GetVideo(videoId);
        _cache.Add(videoId, video);

        return video;
    }
}
