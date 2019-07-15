using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class SettingsScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PurchaseManager.OnPurchaseConsumable += PurchaseManager_OnPurchaseConsumable;
    }

    private void PurchaseManager_OnPurchaseConsumable(PurchaseEventArgs args)
    {
        if(args.purchasedProduct.definition.id == "offads")
        {
            MainMenu.isAdsOff = 1;
            PlayerPrefs.SetInt("isAdsOff", MainMenu.isAdsOff);
            PlayerPrefs.Save();
        }
    }

    // Update is called once per frame
    void Update()
    {


    }

  /*  public void Purch()
    {
        MainMenu.isAdsOff = 1;
        PlayerPrefs.SetInt("isAdsOff", MainMenu.isAdsOff);
        PlayerPrefs.Save();
        print(MainMenu.isAdsOff);
    }*/

    public void MoreGames()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.kamikaze.close2");
    }
}
