using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteMeme : MonoBehaviour
{
    public string content;
    public string type;

    public void OnDelete()
    {
        Destroy(gameObject);

        if (type == "up")
            MemLists.strings_up.Remove(content);
        else
            MemLists.strings_down.Remove(content);

        SaveAndLoad.Save();
    }
}
