using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public static List<string> strings_up;
    public static List<string> strings_down;
    public static bool Started = true;

    // Start is called before the first frame update
    void Start()
    {
        if (Started)
        {
            strings_up = new List<string>();
            strings_down = new List<string>();
            AddDownMemes();
            AddUpMemes();
            Save();
            Started = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddUpMemes()
    {
        strings_up.Add("During comfort evening");
        strings_up.Add("You can't just try and... ");
        strings_up.Add("While ur mom was getting f@¢|<§ behind car boxes");
        strings_up.Add("Why can'r I just try and... ");
        strings_up.Add("U have such a narrow asscrack");
        strings_up.Add("Never thought that");
        strings_up.Add("Strange feeling that I");
        strings_up.Add("When ur income is lower than");
        strings_up.Add("While u sound like Lev Tolstoi");
        strings_up.Add("What u'll see is called");
        strings_up.Add("Wanted to get some chicks but");
        strings_up.Add("Keep culm man, 'cause");
        strings_up.Add("Despite the horrible weather");
        strings_up.Add("Guys, stop making fun of me.");
        strings_up.Add("That's weird but");
        strings_up.Add("Mb u won't get it, but");
        strings_up.Add("Yeah people are dumb but");
        strings_up.Add("The meme was so funny that");
        strings_up.Add("The meme was so dumb that");
        strings_up.Add("The monkey's jumped for so long that");
        strings_up.Add("Watson got a strange thought that");
        strings_up.Add("U won't believe but");
        strings_up.Add("A bear jumped into the car and");
        strings_up.Add("Ur drunk dad didn't notice that");
        strings_up.Add("Putin saw that");
        strings_up.Add("Yesterday in the evening all noticed");
        strings_up.Add("Last week there was shooting in the school again 'cause");
        strings_up.Add("Sad but");
        strings_up.Add("Medvedev stole 2 billions and");
        strings_up.Add("U generated the funniest meme in the world despite the fact that");
        strings_up.Add("This meme is devoted to the coolest guys and");
        strings_up.Add("Ahahahhahahahaha");
        strings_up.Add("What if i say to u that");
        strings_up.Add("Ur mom is so fat that");
        strings_up.Add("It's not hard to notice that");
        strings_up.Add("Wow, brutal, but");
        strings_up.Add("We live in a great country 'cause");
        strings_up.Add("Nobodu has ever suspended that");
        strings_up.Add("We're living hard days but");
        strings_up.Add("Just try saying me that");
        strings_up.Add("I started drinking when I realised that");
        strings_up.Add("Don't read this meme cause");
        strings_up.Add("U may not get it but");
        strings_up.Add("The discussion may last forever but");
        strings_up.Add("How to earn a 1000$?");
        strings_up.Add("Mexicans are so dumb that");
        strings_up.Add("A blonde (bought) a new IPhone but");
        strings_up.Add("She wasn't sucking but");
        strings_up.Add("U won't last long cause");
        strings_up.Add("It's hard to live without cash but");
        strings_up.Add("Everyone remembers that");
        strings_up.Add("When u're getting ready for homosexual sexxx but");
        strings_up.Add("Hmm...");
        strings_up.Add("Immanuel Kant once said that");
        strings_up.Add("Once a master daid that");
        strings_up.Add("Vanga forsaw that");
        strings_up.Add("Let's raise our glasses for heroes and");
        strings_up.Add("Ur friends are chillin' on the party but u");
        strings_up.Add("Ur girl is so dumb but");
        strings_up.Add("U'll be eaten to a bone when");
        strings_up.Add("U're a smallpeniser and");
        strings_up.Add("The witnesses of slam were ripped but");
        strings_up.Add("It was cold and");
        strings_up.Add("I bought a Porshe while");
        strings_up.Add("I got blind when I got that");
        strings_up.Add("Ur butt got stuck to a chair");
        strings_up.Add("I needed lube because");
        strings_up.Add("Lol kek crack");
        strings_up.Add("That postirony is like");
        strings_up.Add("Memes can good or bad but");
        strings_up.Add("Only losers study lessons");
        strings_up.Add("Socrates once said that");
        strings_up.Add("I woke up in a dumpster because");
        strings_up.Add("I got one of my balls twisted because I was told that");
        strings_up.Add("A blind man got his vision back when");
        strings_up.Add("When u've watched too much anime");
        strings_up.Add("Let's make America");
        strings_up.Add("When u're already 25 and ur mom keeps telling u");
    }

    public void AddDownMemes()
    {
        strings_down.Add("Ur neighbor got his asscrack blown up");
        strings_down.Add("How do u like this, Elon Musk? ");
        strings_down.Add("We bought a bottle of Baltika");
        strings_down.Add("Ur dad has a small penis");
        strings_down.Add("Tony has a huge dick");
        strings_down.Add("Here's Jonny!");
        strings_down.Add("U're a dumbass");
        strings_down.Add("U're worthless");
        strings_down.Add("U have a dumb face");
        strings_down.Add("All ur relatives died cause of AIDS");
        strings_down.Add("We're all people");
        strings_down.Add("U have ass cancer");
        strings_down.Add("U have cancer lol");
        strings_down.Add("F@#& u anyway");
        strings_down.Add("All ur friends are animals");
        strings_down.Add("I couldn't get an erection");
        strings_down.Add("U're the best!");
        strings_down.Add("Humpty Dumpty linched himself");
        strings_down.Add("U've burnt down");
        strings_down.Add("There was some weed discovered in ur coat");
        strings_down.Add("All understood everything");
        strings_down.Add("Putin made a coming-out");
        strings_down.Add("Trump crapped his pants again");
        strings_down.Add("U eat shiiiiet");
        strings_down.Add("LOOOOOOOOOOL");
        strings_down.Add("Funny as f@#& isn't it?");
        strings_down.Add("14 cm is a sentence");
        strings_down.Add("Ur mom is a fat cow");
        strings_down.Add("She crushed a truck");
        strings_down.Add("Putin is the best president!");
        strings_down.Add("Ur girl smared herself with s@&t");
        strings_down.Add("In the next room an old man died");
        strings_down.Add("WHOEVER READ THIS WILL DIE!");
        strings_down.Add("U have cancer");
        strings_down.Add("Piece of shieeeet");
        strings_down.Add("Take the L loooseeeerrr");
        strings_down.Add("THIS IS SPARTA!");
        strings_down.Add("I'm faggot!");
        strings_down.Add("This app is a complete bullshit");
        strings_down.Add("The burger is cooling down:((");
        strings_down.Add("I hurt my tinypenis");
        strings_down.Add("Lol kek crack!!");
        strings_down.Add("U crashed ur dad's juke");
        strings_down.Add("We're all f@₽&#d!");
        strings_down.Add("U spent the whole day in psycho clinic");
        strings_down.Add("True guys fuck their hands!");
        strings_down.Add("Jack dumped himself and died");
        strings_down.Add("There is cum dripping from ass");
        strings_down.Add("U farted and went limp");
        strings_down.Add("I accidently spent night with ur mom");
        strings_down.Add("U got beaten by homeless children");
        strings_down.Add("I saw a pic where u're getting fucked by a big n#&&a");
        strings_down.Add("U got f&#@₽d by step-dad again");
        strings_down.Add("U'll get ur asscrack blocked");
    }

    public static void Save()
    {
        //Convert to Json
        string jsonDataUp = JsonUtility.ToJson(strings_up);
        //Save Json string
        PlayerPrefs.SetString("MySettings", jsonDataUp);
        PlayerPrefs.Save();

        //Convert to Json
        string jsonDataDown = JsonUtility.ToJson(strings_down);
        //Save Json string
        PlayerPrefs.SetString("MySettings", jsonDataDown);
        PlayerPrefs.Save();

        print(strings_up.Count);
    }


}
