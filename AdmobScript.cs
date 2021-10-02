using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using GoogleMobileAds.Api;
public class AdmobScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text adStatus;
    string App_ID="ca-app-pub-7944689346847311~6813945589";
    string Banner_Ad_ID="ca-app-pub-7944689346847311/1561618908";
    string Interstitial_Ad_ID="ca-app-pub-7944689346847311/9056965549";
    private BannerView bannerView;
    private InterstitialAd interstitialView;
    void Start()
    {
        MobileAds.Initialize(App_ID);
        this.RequestBanner();
        this.RequestInterstitial();
    }

    // Update is called once per frame
     public void RequestBanner()
    {
    	this.bannerView = new BannerView(Banner_Ad_ID, AdSize.Banner, AdPosition.Top);



    	 // Called when an ad request has successfully loaded.
        this.bannerView.OnAdLoaded += this.HandleOnAdLoaded;
        // Called when an ad request failed to load.
        this.bannerView.OnAdFailedToLoad += this.HandleOnAdFailedToLoad;
        // Called when an ad is clicked.
        this.bannerView.OnAdOpening += this.HandleOnAdOpened;
        // Called when the user returned from the app after an ad click.
        this.bannerView.OnAdClosed += this.HandleOnAdClosed;
        // Called when the ad click caused the user to leave the application.
        this.bannerView.OnAdLeavingApplication += this.HandleOnAdLeavingApplication;
    }

    public void ShowBannerAD(){
    	 // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(request);
    }



    public void RequestInterstitial()
    {
    	this.interstitialView = new InterstitialAd(Interstitial_Ad_ID);

    	    // Called when an ad request has successfully loaded.
    	this.interstitialView.OnAdLoaded += HandleOnAdLoaded;
    	// Called when an ad request failed to load.
    	this.interstitialView.OnAdFailedToLoad += HandleOnAdFailedToLoad;
    	// Called when an ad is shown.
    	this.interstitialView.OnAdOpening += HandleOnAdOpened;
    	// Called when the ad is closed.
    	this.interstitialView.OnAdClosed += HandleOnAdClosed;
    	// Called when the ad click caused the user to leave the application.
    	this.interstitialView.OnAdLeavingApplication += HandleOnAdLeavingApplication;



    	AdRequest request = new AdRequest.Builder().Build();
    	this.interstitialView.LoadAd(request);
    }

    public void ShowInterstitialAd(){
    	 if (this.interstitialView.IsLoaded()) {
    	 	this.interstitialView.Show();
    	 }
    }


    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        adStatus.text="Ad Loaded";
         if (this.interstitialView.IsLoaded()) {
         	this.interstitialView.Show();
         }
    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        adStatus.text="Ad failed to load";
    }

    public void HandleOnAdOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdOpened event received");
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdClosed event received");
    }

    public void HandleOnAdLeavingApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLeavingApplication event received");
    }

}
