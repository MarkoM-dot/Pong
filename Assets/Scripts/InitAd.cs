using UnityEngine;
using GoogleMobileAds.Api;

public class InitAd : MonoBehaviour
{
    private InterstitialAd InterstitialAd;

    string InterstitialAdId = "ca-app-pub-3940256099942544/1033173712";

    private void Start()
    {
        ShowInterstitial();
    }

    private void RequestInterstitial()
    {
        this.InterstitialAd = new InterstitialAd(InterstitialAdId);
        // create an empty request
        AdRequest request = new AdRequest.Builder().Build();
        // load the interstitial with the request
        this.InterstitialAd.LoadAd(request);
    }

    private void ShowInterstitial()
    {
        RequestInterstitial();
        if (this.InterstitialAd.IsLoaded())
        {
            this.InterstitialAd.Show();
        }
    }
    public void DestroyInterstitialAd()
    {
        if (InterstitialAd != null)
        {
            InterstitialAd.Destroy();
        }
    }
}
