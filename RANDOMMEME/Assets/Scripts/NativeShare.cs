using System.Collections;
using UnityEngine;

public class NativeShare : MonoBehaviour
{

    public string ScreenshotName = "screenshot.png"; // "имя" скриншота
    public string url = "sdfdsf"; //url приложения (например на маркете)

    /// <summary>
    /// Метод для кнопки. 
    /// </summary>
    /// <param name="text">Текст которым делимся</param>
    public void ShareScreenshotWithText(string text)
    {
        ScreenCapture.CaptureScreenshot(ScreenshotName);
        StartCoroutine(DelayedShare(text, url));
    }

    /// <summary>
    /// Небольшая пауза для скриншота и вызов метода "Поделиться"
    /// </summary>
    /// <param name="text">Текст которым делимся</param>
    /// <param name="urlApp">Ссылка на приложение</param>
    /// <returns></returns>
    private IEnumerator DelayedShare(string text, string urlApp)
    {
        yield return new WaitForSeconds(0.25f);
        string screenShotPath = Application.persistentDataPath + "/" + ScreenshotName;
        Share(text, screenShotPath, urlApp);
    }

    //"Делимся"
    private void Share(string shareText, string imagePath, string url, string subject = "")
    {
        AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");
        AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");

        intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));
        AndroidJavaClass uriClass = new AndroidJavaClass("android.net.Uri");
        AndroidJavaObject uriObject = uriClass.CallStatic<AndroidJavaObject>("parse", "file://" + imagePath);
        intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_STREAM"), uriObject);
        intentObject.Call<AndroidJavaObject>("setType", "image/png");

        intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), shareText + "\n" + url);

        AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");

        AndroidJavaObject jChooser = intentClass.CallStatic<AndroidJavaObject>("createChooser", intentObject, subject);
        currentActivity.Call("startActivity", jChooser);
    }

    public void OnShareClicked()
    {

        // Get the required Intent and UnityPlayer classes.
        AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");
        AndroidJavaClass unityPlayerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");

        // Construct the intent.
        AndroidJavaObject intent = new AndroidJavaObject("android.content.Intent");
        intent.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));
        intent.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), "Here's the text I want to share.");
        intent.Call<AndroidJavaObject>("setType", "text/plain");

        // Display the chooser.
        AndroidJavaObject currentActivity = unityPlayerClass.GetStatic<AndroidJavaObject>("currentActivity");
        AndroidJavaObject chooser = intentClass.CallStatic<AndroidJavaObject>("createChooser", intent, "Share");
        currentActivity.Call("startActivity", chooser);

    }

}