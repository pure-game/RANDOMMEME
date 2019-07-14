using System;
using System.Collections;
using UnityEngine;
using VoxelBusters.NativePlugins;

public class NativeShare : MonoBehaviour
{

    [SerializeField] RectTransform screen;
    [SerializeField] RectTransform imageRect;

    Camera camera;
    Rect image;

    private void Start()
    {
        camera = GetComponent<Camera>();
    }

    public void ShareScreenShotUsingShareSheet()
    {
        // Create share sheet
        ShareSheet _shareSheet = new ShareSheet();
        _shareSheet.Text = "Check this GENIUS game on GooglePlay: https://play.google.com/store/apps/details?id=com.PickleHero.RandomMeme";

        // Set this list if you want to exclude any service/application type. Else, ignore.
        // _shareSheet.ExcludedShareOptions = m_excludedOptions;

        // Attaching screenshot here
        image = imageRect.rect;
        Debug.Log(imageRect.position);
        image.position = camera.WorldToScreenPoint(imageRect.position);
        Debug.Log(image.position);
        Debug.Log(image.size);
        image.width *= camera.pixelWidth / screen.rect.width;
        image.height *= camera.pixelHeight/ screen.rect.height;
        Debug.Log(image.size);
        _shareSheet.AttachScreenShot(image);

        // Show composer
        NPBinding.UI.SetPopoverPointAtLastTouchPosition();
        NPBinding.Sharing.ShowView(_shareSheet, FinishedSharing);
    }

    private void FinishedSharing(eShareResult _result)
    {
        throw new NotImplementedException();
    }

}