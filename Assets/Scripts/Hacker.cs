using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Hacker : MonoBehaviour
{
    // GAME CONFIG
    private readonly string[] _level1Passwords =

    {
        "home", "toe", "bear", "acid", "peep", "drop", "man", "warm", "jog", "trap", "tire", "pray", "land", "poke",
        "book", "old", "jump", "coal", "hate", "boat", "bell", "play", "hall", "shoe", "hill", "harm", "hat", "hole",
        "turn",
        "war", "low", "rod", "wary", "toy", "wide", "yarn", "ten", "dead", "tie", "tub", "worm", "jar", "oil", "boy",
        "cave", "cows", "pan", "cap", "add", "pipe", "icy", "toes", "wrap", "grin", "use", "mean", "tax", "cute",
        "dare", "lush",
        "pull", "can", "busy", "talk", "keen", "oval", "root", "tug", "suck", "blue", "bake", "lake", "ball", "kick",
        "ugly", "stay", "ice", "tent", "edge", "doll", "end", "cats", "ants", "rat", "air", "wiry", "big", "past",
        "list", "road",
        "join", "rare", "plan", "bolt", "time", "back", "tour", "clap", "swim", "many", "eyes", "sin", "song", "wish",
        "soap", "stem", "tray", "box", "seat", "pet", "crib", "male", "earn", "bone", "home", "toe", "bear", "acid",
        "peep",
        "drop", "man", "warm", "jog", "trap", "tire", "pray", "land", "poke", "book", "old", "jump", "coal", "hate",
        "boat",
        "bell", "play", "hall", "shoe", "hill", "harm", "hat", "hole", "turn", "war", "low", "rod", "wary", "toy",
        "wide",
        "yarn", "ten", "dead", "tie", "tub", "worm", "jar", "oil", "boy", "cave", "cows", "pan", "cap", "add", "pipe",
        "icy", "toes", "wrap", "grin", "use", "mean", "tax", "cute", "dare", "lush", "pull", "can", "busy", "talk",
        "keen",
        "oval", "root", "tug", "suck", "blue", "bake", "lake", "ball", "kick", "ugly", "stay", "ice", "tent", "edge",
        "doll", "end", "cats", "ants", "rat", "air", "wiry", "big", "past", "list", "road", "join"
    };

    private readonly string[] _level2Passwords =
    {
        "house", "grass", "babies", "ghost", "peace", "zephyr", "female", "cheap", "rustic", "steel", "truck", "refuse",
        "spring", "useful", "mushy", "scary", "appear", "acidic", "nutty", "retire", "simple", "awake", "dolls",
        "yummy", "elite", "kindly", "ritzy", "aware", "alarm", "shaggy", "switch", "bloody", "elbow", "stingy", "strip",
        "squeak", "blush", "arrive", "minor", "honey", "great", "claim", "steep", "hollow", "rough", "lunch", "arrest",
        "scent", "polish", "weigh", "kneel", "scared", "hammer", "liquid", "curvy", "friend", "joyous", "tight",
        "hushed", "choke", "scorch", "mourn", "scene", "three", "ready", "better", "value", "lavish", "jazzy", "legal",
        "pencil", "grade", "feeble", "riddle", "nerve", "quiet", "berry", "sheet", "stick", "roomy", "slimy", "little",
        "nappy", "button", "throat", "stuff", "shave", "hurry", "furry", "remove", "collar", "cable", "right", "jeans",
        "ocean", "shake", "flesh", "untidy", "sudden", "order", "swing", "juicy", "shrug", "scarce", "elated", "whole",
        "burly", "tempt", "lumber", "charge", "fresh", "belong", "horses", "steam", "madly", "flock", "knock", "glove",
        "verse", "abaft", "letter", "blood", "faulty", "cobweb", "check", "porter", "mitten", "attack", "quack",
        "jumpy", "reason", "plucky", "north", "donkey", "insect", "future", "dinner", "cloudy", "shoes", "unpack",
        "injure", "reduce", "spade", "tasty", "report", "absurd", "juggle", "homely", "torpid", "phone", "quiver",
        "fixed", "hover", "spooky", "permit", "attach", "plate", "daily", "number", "twist", "repeat", "accept",
        "damage", "sassy", "marble", "sticky", "spare", "punish", "spoil", "range", "rapid", "excuse", "fuzzy", "tacit",
        "match", "bless", "wealth", "window", "scare"
    };

    private readonly string[] _level3Passwords =
    {
        "enchanted", "religion", "unwieldy", "decisive", "disastrous", "afterthought", "endurable", "youthful",
        "healthy", "complex", "truculent", "thoughtless", "tedious", "peaceful", "synonymous", "suggest", "staking",
        "momentous", "science", "efficient", "payment", "gorgeous", "befitting", "cynical", "quizzical", "writing",
        "overconfident", "behavior", "produce", "miniature", "dangerous", "carriage", "apathetic", "obsolete",
        "overrated", "delightful", "division", "shocking", "squealing", "thoughtful", "languid", "plastic",
        "disapprove", "aftermath", "perfect", "elegant", "neighborly", "wretched", "actually", "supreme", "adjustment",
        "mammoth", "quicksand", "tendency", "minister", "unhealthy", "rejoice", "deranged", "unarmed", "separate",
        "average", "enthusiastic", "volatile", "womanly", "delirious", "shallow", "thinkable", "precious",
        "comfortable", "wide-eyed", "guarded", "wandering", "unnatural", "aquatic", "outgoing", "knowledge", "license",
        "evasive", "guttural", "station", "capable", "guarantee", "cherries", "unbiased", "history", "disillusioned",
        "festive", "aggressive", "multiply", "cluttered", "insidious", "distribution", "warlike", "loutish",
        "teeny-tiny", "kindhearted", "hilarious", "observe", "wholesale", "jobless", "attract", "develop", "account",
        "cemetery", "destroy", "needless", "equable", "increase", "obsequious", "adorable", "understood", "vengeful",
        "boundless", "discreet", "handsome", "powerful", "chicken", "believe", "unaccountable", "receipt", "influence",
        "dynamic", "obscene", "splendid", "hissing", "railway", "conscious", "courageous", "perform", "naughty",
        "servant", "homeless", "halting", "flippant", "knowledgeable", "prevent", "venomous", "erratic", "enormous",
        "anxious", "country", "pancake", "surround", "present", "permissible", "black-and-white", "ordinary", "imagine",
        "wriggle", "lamentable", "careful", "pollution", "rightful", "elderly", "longing", "haircut", "abiding",
        "announce", "include", "accurate", "certain", "graceful", "puncture", "provide", "draconian", "abundant",
        "voiceless", "bedroom", "pointless", "bashful", "reflect", "righteous", "seashore", "coherent", "expensive",
        "exercise", "abnormal", "stomach", "combative", "satisfy", "accessible", "useless", "enchanting", "ossified",
        "second-hand", "cabbage", "instruct", "selective", "digestion", "breathe", "fluttering", "secretive",
        "electric", "demonic", "amusement", "energetic", "responsible", "pleasant", "utopian"
    };

    // GAME STATE
    private string _level;
    private Screen _currentScreen = Screen.MainMenu;
    private string _password = "";
    [SerializeField] private Text _text;

    private enum Screen
    {
        MainMenu,
        Password,
        WinScreen
    }

    private static class Nodes
    {
        public const string School = "03xd3e";
        public const string Police = "7d13me";
        public const string Nasa = "x21d9e";
    }

    //----------------------------------------------METHODS------------------------------------
    void Start()
    {
        this.ShowMainMenu();
    }

    private void ShowMainMenu()
    {
        _currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        this.Header();
        Terminal.WriteLine("==========================\n Nodes available [IM3R7E] \n==========================");
        Terminal.WriteLine("[Node_id: " + Nodes.School + " l1] Terminal-3093X");
        Terminal.WriteLine("[Node_id: " + Nodes.Police + " l2] Terminal-67X6G");
        Terminal.WriteLine("[Node_id: " + Nodes.Nasa + " l3] Terminal-GT438");
        Terminal.WriteLine("> enter cmd: ");
    }

    private void Header()
    {
        _text.fontSize = 28;
        Terminal.WriteLine("jason@archx64:~# sudo nmfr -list -all");
        Terminal.WriteLine("NodeFlow Mapper loaded (t: 1.3s)");
        Terminal.WriteLine("Commands: \\help \\version \\nodes \\exit");
    }

    private void OnUserInput(string message)
    {
        if (message == "\\nodes")
            this.ShowMainMenu();
        else if (message == "\\help")
            this.Help();
        else if (message == "\\version")
            this.Info();
        else if (message == "\\exit")
        {
            Terminal.WriteLine("Application exited(0)");
            Terminal.WriteLine("WEB_BUILD: close tab");
            Terminal.WriteLine("jason@archx64:~#");
	    Application.Quit();
        }
        else
            switch (_currentScreen)
            {
                case Screen.MainMenu:
                    this.GameMenu(message);
                    break;
                case Screen.Password:
                    this.CheckPassword(message);
                    break;
            }
    }

    private void GameMenu(string input)
    {
        bool validLevel = (input == Nodes.School || input == Nodes.Police || input == Nodes.Nasa);
        _text.fontSize = 28;
        if (validLevel)
            StartGame(input);
        else
            Terminal.WriteLine("(.text+0x20): undefined reference to `cmd_input'" +
                               "\nException raised: INVALID_INPUT");
    }

    private void StartGame(string input)
    {
        _currentScreen = Screen.Password;
        this.SetNode(input);
    }

    private void SetNode(string input)
    {
        Terminal.ClearScreen();
        this.Header();
        switch (input)
        {
            case Nodes.School:
                _level = Nodes.School;
                _password = _level1Passwords[UnityEngine.Random.Range(0, _level1Passwords.Length)];
                Terminal.WriteLine("Selected Node: " + Nodes.School);
                Terminal.WriteLine("Node_info: Terminal-3093X");
                break;
            case Nodes.Police:
                _level = Nodes.Police;
                _password = _level2Passwords[UnityEngine.Random.Range(0, _level2Passwords.Length)];
                Terminal.WriteLine("Selected Node: " + Nodes.Police);
                Terminal.WriteLine("Node_info: Terminal-67X6G");
                break;
            case Nodes.Nasa:
                _level = Nodes.Nasa;
                _password = _level3Passwords[UnityEngine.Random.Range(0, _level3Passwords.Length)];
                Terminal.WriteLine("Selected Node: " + Nodes.Nasa);
                Terminal.WriteLine("Node_info: Terminal-GT438");
                break;
        }

        print(_password);
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("Decrypt the password: " + _password.Anagram());
    }

    private void CheckPassword(string password)
    {
        Terminal.ClearScreen();
        this.Header();
        Terminal.WriteLine("-------------------------------------");
        Terminal.WriteLine("Please enter the password: ");
        if (password == _password)
            this.DisplayWinScreen();
        else
            this.StartGame(_level);
    }

    private void DisplayWinScreen()
    {
        _currentScreen = Screen.WinScreen;
        Terminal.ClearScreen();
        this.ShowLevelReward();
    }

    private void ShowLevelReward()
    {
        Terminal.WriteLine("Have some titties!");
        this.ShowTitties();
    }

    private void ShowTitties()
    {
        _text.fontSize = 50;
        Terminal.WriteLine("(. Y . )");
    }

    private void Help()
    {
        Terminal.ClearScreen();
        this.Header();
        Terminal.WriteLine("==========================\n HELP \n==========================");
        Terminal.WriteLine("Enter a node id to select a node. \n\\nodes to show nodes again" +
                           "\n\\version to get program info \n\\exit to quit \n> enter cmd: ");
    }

    private void Info()
    {
        Terminal.ClearScreen();
        this.Header();
        Terminal.WriteLine("==========================\n VERSION \n==========================");
        Terminal.WriteLine("NodeFlow Mapper v1.0.3 \nbuild_info: 1.8.0_231-b11 \nReleased 2020 \n" +
                           "> enter cmd: ");
    }
}