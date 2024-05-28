using Proxy;

var youtTubeService = new YoutTubeService();

youtTubeService.GetVideo(10);
youtTubeService.GetVideo(10);

var proxyYoutTubeService = new ProxyYouTubeService(youtTubeService);

proxyYoutTubeService.GetVideo(10);
proxyYoutTubeService.GetVideo(10);