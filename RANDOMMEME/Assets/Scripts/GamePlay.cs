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
    public List<string> strings_up;
    public List<string> strings_down;

    // Start is called before the first frame update
    void Start()
    {
        strings_up = new List<string>();
        strings_down = new List<string>();

        memeImage = GameObject.Find("MainImage").GetComponent<Image>();

        AddDownMemes();
        AddUpMemes();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClick()
    {

        memeImage.sprite = Resources.Load<Sprite>("meme_" + Random.Range(1, 50));
        upMeme.text = strings_up[Random.Range(0, 78)];
        downMeme.text = strings_down[Random.Range(0, 53)];
    }

    public void AddUpMemes()
    {
        strings_up.Add("Дело было вечером");
        strings_up.Add("Нельзя просто так взять и");
        strings_up.Add("Пока твою мать имели за гаражами");
        strings_up.Add("Почему нельзя просто взять и");
        strings_up.Add("У тебя очень узкое очко, как");
        strings_up.Add("Никогда не думал о том, что");
        strings_up.Add("Странное чувство, ведь мне нравится насколько");
        strings_up.Add("Когда твоя зарплата меньше, чем");
        strings_up.Add("На словах ты Лев Толстой, а на деле");
        strings_up.Add("То, что вы увидете, называется");
        strings_up.Add("Решил закадрить девочек, но");
        strings_up.Add("Болельшики сборной России не подозревали, что");
        strings_up.Add("Узбагойзя, ведь");
        strings_up.Add("Несмотря на плохую погоду,");
        strings_up.Add("Чуваки, хорош шутить.");
        strings_up.Add("Странно это все, но");
        strings_up.Add("Ты наверное не поймешь, но");
        strings_up.Add("Люди конечно тупые, но");
        strings_up.Add("Мем был настолько смешной, что");
        strings_up.Add("Мем был настолько тупой, что");
        strings_up.Add("Макака долго прыгала, когда узнала, что");
        strings_up.Add("Голову Ватсона посетила странная мысль о том, что");
        strings_up.Add("Ты не поверишь, но");
        strings_up.Add("Медведь сел в машину и");
        strings_up.Add("Твой пьяный батя не запалил, что");
        strings_up.Add("Путин увидел, что");
        strings_up.Add("Вчера вечером все заметили,");
        strings_up.Add("Неделю назад в школе опять стреляли, ведь");
        strings_up.Add("Увы, но");
        strings_up.Add("Медведев украл два миллиарда, а");
        strings_up.Add("Ты сгенерил самый смешной мем в мире, не смотря на то, что");
        strings_up.Add("Мем посвящается самым крутым, а");
        strings_up.Add("ХАХАХАХАХАХАХАХААХ");
        strings_up.Add("А что если я скажу тебе, что");
        strings_up.Add("Твоя мама такая толстая, что");
        strings_up.Add("Нетрудно усмотреть, что");
        strings_up.Add("Твоя мама такая толстая, что");
        strings_up.Add("Жесть мясо, а");
        strings_up.Add("Мы живем в великой стране, ведь");
        strings_up.Add("Никто и не подозревал, что");
        strings_up.Add("Мы живем в очень сложное время, а");
        strings_up.Add("Только попробуй сказать мне, что");
        strings_up.Add("Я начал пить, когда узнал, что");
        strings_up.Add("Не читай этот мем, ведь");
        strings_up.Add("Ты можешь не понять, но");
        strings_up.Add("Можно долго говорить, но");
        strings_up.Add("Как заработать 1000 рублей?");
        strings_up.Add("Ты можешь не понять, но");
        strings_up.Add("Пиндосы такие тупые, что");
        strings_up.Add("Блондинка (купила) себе новый айфон, а");
        strings_up.Add("Она не насосала, а");
        strings_up.Add("Долго ты не протянешь, ведь");
        strings_up.Add("Трудно приходится без денег, а");
        strings_up.Add("Все помнят, что");
        strings_up.Add("Когда готовишься к гомо№?**бле, а");
        strings_up.Add("Хммм...");
        strings_up.Add("Иммануил Кант когда-то сказал, что");
        strings_up.Add("Один мудрец однажды сказал, что");
        strings_up.Add("Ванга предсказывала, что");
        strings_up.Add("Поднимем бокал за героев, а");
        strings_up.Add("Твои друзья чиллят на вписоне, а");
        strings_up.Add("Твоя телка очень тупая, а");
        strings_up.Add("Ясен-красен, а");
        strings_up.Add("Тебя с потрохами съедят, когда узнают, что");
        strings_up.Add("Ты короткоствол, а");
        strings_up.Add("Я позвонил Генадию тощему, так-как");
        strings_up.Add("Свидетелей слэма повязали, а");
        strings_up.Add("Было холодно и");
        strings_up.Add("Я купил порше, а");
        strings_up.Add("Я ослеп, когда узнал, что");
        strings_up.Add("Твоя жопа прилипла к стулу, когда");
        strings_up.Add("Мне понадобился вазелин, так-как");
        strings_up.Add("Кек и лол и валидол,");
        strings_up.Add("Ох уж эта постирония,");
        strings_up.Add("Мемы бывают хорошими и плохими, а");
        strings_up.Add("Уроки учат только лохи, а");
        strings_up.Add("Однажды Сократ сказал, что");
        strings_up.Add("Я проснулся в подливе по уши, ведь мне приснилось, что");
        strings_up.Add("У меня перекрутилось яичко, ведь я узнал, что");
        strings_up.Add("Слепой прозрел, когда узнал, что");
    }

    public void AddDownMemes()
    {
        strings_down.Add("у твоего соседа раздрочено очко");
        strings_down.Add("как тебе такое, Илон Маск?");
        strings_down.Add("мы купили бутылку балтики 9");
        strings_down.Add("у твоего отца маленькая писька");
        strings_down.Add("у Антохи огромная писька");
        strings_down.Add("привет от Блика!!!");
        strings_down.Add("ты тупой олень");
        strings_down.Add("ты полное чмо");
        strings_down.Add("у тебя тупое лицо");
        strings_down.Add("все твои родственники умерли от спида");
        strings_down.Add("все мы люди");
        strings_down.Add("ты болеешь раком очка");
        strings_down.Add("у тебя рак!");
        strings_down.Add("ты все же пошел на%?#Й");
        strings_down.Add("все твои друзья тупые овощи");
        strings_down.Add("у меня не встал");
        strings_down.Add("ты тупо лучший в мире");
        strings_down.Add("колобок повесился.");
        strings_down.Add("ты сгорел");
        strings_down.Add("пакет насика нашли у тебя во внутреннем кармане");
        strings_down.Add("все уже все поняли");
        strings_down.Add("Милонов совершил каминг-аут");
        strings_down.Add("Обама опять нагадил в лифте");
        strings_down.Add("ты жрешь дошик");
        strings_down.Add("АХАХАХАХАХАХАХХА");
        strings_down.Add("смешно до усрачки, не правда?");
        strings_down.Add("14 см это приговор");
        strings_down.Add("твоя мамка жирная корова");
        strings_down.Add("она раздавила камаз");
        strings_down.Add("Путин лучший в мире президент!");
        strings_down.Add("твоя девушка обмазалась калом");
        strings_down.Add("в соседней комнате умер дед");
        strings_down.Add("КТО ПРОЧИТАЛ, ТОТ СДОХНЕТ");
        strings_down.Add("у тебя сифилис");
        strings_down.Add("кусок говна");
        strings_down.Add("е%;№ать ты лох");
        strings_down.Add("THIS IS SPARTA!");
        strings_down.Add("драные тапки");
        strings_down.Add("Я ПИДОРАС!");
        strings_down.Add("это приложение полное гавно");
        strings_down.Add("макарошки стынут:((");
        strings_down.Add("мне придавили писькин-пиписькин");
        strings_down.Add("кек и лол и валидол!");
        strings_down.Add("ты разбил батину девятку");
        strings_down.Add("мы все в полной ЖоПе");
        strings_down.Add("ты весь день провел в дурке");
        strings_down.Add("пацаны е%№;ут ладохи");
        strings_down.Add("Иван жидко обосрался и умер");
        strings_down.Add("у твоего парня из очка вытекла сперма");
        strings_down.Add("ты пукнув, обмяк");
        strings_down.Add("я случайно переспал с матерью");
        strings_down.Add("тебя отпиздили детдомовцы");
        strings_down.Add("я увидел фото где тебя жарит негр");
        strings_down.Add("тебя опять выебал отчим");
        strings_down.Add("пацаны е%№;ут ладохи");
    }


}
