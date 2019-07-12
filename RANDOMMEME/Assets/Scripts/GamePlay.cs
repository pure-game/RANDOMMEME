using GoogleMobileAds.Api;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{

    Image memeImage;
    public TextMeshProUGUI upMeme;
    public TextMeshProUGUI downMeme;
    public int adsBuy = 0;
    private InterstitialAd interstitial;


    // Start is called before the first frame update
    void Start()
    {
        memeImage = GameObject.Find("MainImage").GetComponent<Image>();
        if (PlayerPrefs.GetInt("isAdsOff", 0) == 0)
        {
            RequestInterstitial();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClick()
    {
        memeImage.sprite = Resources.Load<Sprite>("meme_" + UnityEngine.Random.Range(1, 56));
        upMeme.text = MemLists.strings_up[UnityEngine.Random.Range(0, MemLists.strings_up.Count)];
        downMeme.text = MemLists.strings_down[UnityEngine.Random.Range(0, MemLists.strings_down.Count)];       
        if (interstitial != null && this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
    }

    private void RequestInterstitial()
    {
        string adUnitId = "ca-app-pub-7272958162561065/9217082760";

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);

        this.interstitial.OnAdClosed += HandleOnAdClosed;

        void HandleOnAdClosed(object sender, EventArgs args)
        {
            RequestInterstitial();
        }
    }

}
