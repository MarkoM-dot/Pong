using UnityEngine;
public class MusicController : MonoBehaviour
{
    public static bool musicExists;

    public AudioSource[] musicTracks;

    public int currentTrack;

    private void Start()
    {
        
        if (!musicExists)
        {
            musicExists = true;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void CheckTrack(int newTrack)
    {
        if (currentTrack != newTrack)
        {
            musicTracks[currentTrack].Stop();
            currentTrack = newTrack;
            musicTracks[currentTrack].Play();
        }
    }
}
