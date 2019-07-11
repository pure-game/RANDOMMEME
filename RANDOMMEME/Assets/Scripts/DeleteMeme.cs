using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteMeme : MonoBehaviour
{
    public int id;
    public string type;

    public void OnDelete()
    {
        Destroy(gameObject);

        if (type == "up")
            MemLists.strings_up.RemoveAt(id);
        else
            MemLists.strings_down.RemoveAt(id);

        SaveAndLoad.Save();
    }
}
