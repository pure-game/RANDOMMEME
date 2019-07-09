using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{

    Image memeImage;
    public TextMeshProUGUI upMeme;
    public TextMeshProUGUI downMeme;

    // Start is called before the first frame update
    void Start()
    {
        memeImage = GameObject.Find("MainImage").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClick()
    {
        memeImage.sprite = Resources.Load<Sprite>("meme_" + Random.Range(1, 50));
        upMeme.text = MainMenu.strings_up[Random.Range(0, MainMenu.strings_up.Count)];
        downMeme.text = MainMenu.strings_down[Random.Range(0, MainMenu.strings_down.Count)];
    }

}
