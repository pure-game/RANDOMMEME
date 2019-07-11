using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewDownMem : MonoBehaviour
{

    public InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickButton()
    {
        string newText = inputField.GetComponent<InputField>().text;
        MemLists.strings_down.Add(newText);
        print(MemLists.strings_down.Count);
        SaveAndLoad.Save();
    }
}
