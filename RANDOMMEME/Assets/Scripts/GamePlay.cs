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
    public const string bannerID = "ca-app-pub-7272958162561065/4152458345";
    public const string adID = "ca-app-pub-7272958162561065/4152458345";

    // Start is called before the first frame update
    void Start()
    {
        memeImage = GameObject.Find("MainImage").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClick()
    {
       /* if(adsBuy == 0)
        {
            BannerView bannerView = new BannerView(bannerID, AdSize.Banner, AdPosition.Bottom);
            AdRequest adRequest = new AdRequest.Builder().AddTestDevice(AdRequest.TestDeviceSimulator).AddTestDevice("320D89DA65836B55").Build();
            bannerView.LoadAd(adRequest);

            InterstitialAd interstitialAd = new InterstitialAd(adID);
            AdRequest ad = new AdRequest.Builder().AddTestDevice(AdRequest.TestDeviceSimulator).AddTestDevice("320D89DA65836B55").Build();
            interstitialAd.LoadAd(ad);
            if (interstitialAd.IsLoaded()) interstitialAd.Show();
        }*/

        memeImage.sprite = Resources.Load<Sprite>("meme_" + Random.Range(1, 50));
        upMeme.text = MainMenu.strings_up[Random.Range(0, MainMenu.strings_up.Count)];
        downMeme.text = MainMenu.strings_down[Random.Range(0, MainMenu.strings_down.Count)];
    }

}
