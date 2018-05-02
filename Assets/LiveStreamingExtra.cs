using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(MediaPlayerCtrl))]
[RequireComponent(typeof(YoutubeLivestreamSystem))]

public class LiveStreamingExtra : MonoBehaviour {
    private YoutubeLivestreamSystem youtubeLiveStream;
    private MediaPlayerCtrl player;

    public Text debugText;

    private void Start()
    {
        youtubeLiveStream = GetComponent<YoutubeLivestreamSystem>();
        player = GetComponent<MediaPlayerCtrl>();
    }

    public void Reload()
    {
        player.Stop();
        player.UnLoad();
        player.m_strFileName = null;
        youtubeLiveStream.PlayYoutubeVideo(youtubeLiveStream.videoId);
    }

    private void Update()
    {
        debugText.text = player.GetCurrentState().ToString();
    }
}
