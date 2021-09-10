using UnityEngine;
using GoogleMobileAds.Api;
public class RightBanner : MonoBehaviour
{
    private BannerView bannerView;
    string adUnitId = "ca-app-pub-3940256099942544/6300978111";

    private void Start()
    {
        RequestBanner();
    }

    private void RequestBanner()
    {

        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.BottomRight);

        AdRequest request = new AdRequest.Builder().Build();

        bannerView.LoadAd(request);
    }

    public void DestroyBannerAd()
    {
        if (bannerView != null)
        {
            bannerView.Destroy();
        }
    }
}
