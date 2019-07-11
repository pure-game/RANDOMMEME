using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpMemesList : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < MemLists.strings_up.Count; i++)
        {
            var Panel = Instantiate(Resources.Load("Prefabs/MemePanel"), transform);
            Transform child = transform.GetChild(i);
            Transform text = child.GetChild(0);
            Transform button = child.GetChild(1);

            child.GetComponent<DeleteMeme>().id = i;
            child.GetComponent<DeleteMeme>().type = "up";

            text.GetComponent<Text>().text  = MemLists.strings_up[i];
        }
    }
}
