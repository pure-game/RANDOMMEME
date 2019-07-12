using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DownMemesList : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < MemLists.strings_down.Count; i++)
        {
            var Panel = Instantiate(Resources.Load("Prefabs/MemePanel"), transform);
            Transform child = transform.GetChild(i);
            Transform text = child.GetChild(0);
            Transform button = child.GetChild(1);

            child.GetComponent<DeleteMeme>().content = MemLists.strings_down[i];
            child.GetComponent<DeleteMeme>().type = "down";

            text.GetComponent<Text>().text  = MemLists.strings_down[i];
        }
    }
}
