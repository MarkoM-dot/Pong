using UnityEngine;

public class MusicSwitcher : MonoBehaviour
{
    private MusicController theMC;
    public int newTrack;
    private void Start()
    {
        theMC = FindObjectOfType<MusicController>();
        theMC.CheckTrack(newTrack);
    }
}
