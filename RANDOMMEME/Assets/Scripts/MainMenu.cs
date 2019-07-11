using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class MainMenu : MonoBehaviour
{

    public static int FirstLaunch = 0;
    public static int isAdsOff = 0;

    private BannerView bannerView;
    private string FIRST_LAUNCH = "First_Launch";

    public string appId = "ca-app-pub-7272958162561065~5553259565";

    // Start is called before the first frame update
    void Start()
    {
        if (FirstLaunch == 0)
        {
            MemLists.strings_up = new List<string>();
            MemLists.strings_down = new List<string>();
            SaveAndLoad.Load();
            Debug.Log("Loaded");

            isAdsOff = 0;
            PlayerPrefs.SetInt("isAdsOff", isAdsOff);
            PlayerPrefs.Save();
            print(isAdsOff);
            FirstLaunch = 1;
        }
        
        if (PlayerPrefs.GetInt(FIRST_LAUNCH, 0) == 0)
        {
            MemLists.AddDownMemes();
            MemLists.AddUpMemes();
            SaveAndLoad.Save();
            PlayerPrefs.SetInt(FIRST_LAUNCH, 1);
        }

        if (PlayerPrefs.GetInt("isAdsOff", 0) == 0)
        {
            MobileAds.Initialize(appId);
            this.RequestBanner();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RequestBanner()
    {
        string adUnitId = "ca-app-pub-7272958162561065/4152458345";

        // Create a 320x50 banner at the top of the screen.
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
        AdRequest request = new AdRequest.Builder().Build();
        bannerView.LoadAd(request);
    }

    void OnDisabled()
    {
        Debug.Log("Disabled");
        SaveAndLoad.Save();
    }

}
