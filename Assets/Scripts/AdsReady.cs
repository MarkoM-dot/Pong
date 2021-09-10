using UnityEngine;
using GoogleMobileAds.Api;

public class AdsReady : MonoBehaviour
{
    private void Start()
    {
        MobileAds.Initialize(InitializationStatus => { });
    }
}
