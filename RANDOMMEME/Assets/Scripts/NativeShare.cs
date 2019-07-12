using System;
using System.Collections;
using UnityEngine;
using VoxelBusters.NativePlugins;

public class NativeShare : MonoBehaviour
{

    public void ShareScreenShotUsingShareSheet()
    {
        // Create share sheet
        ShareSheet _shareSheet = new ShareSheet();
        _shareSheet.Text = "https://play.google.com/store/apps/details?id=com.PickleHero.RandomMeme";

        // Set this list if you want to exclude any service/application type. Else, ignore.
        // _shareSheet.ExcludedShareOptions = m_excludedOptions;

        // Attaching screenshot here
        _shareSheet.AttachScreenShot();

        // Show composer
        NPBinding.UI.SetPopoverPointAtLastTouchPosition();
        NPBinding.Sharing.ShowView(_shareSheet, FinishedSharing);
    }

    private void FinishedSharing(eShareResult _result)
    {
        throw new NotImplementedException();
    }

}