using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextController : MonoBehaviour {

    public Text text;
    public GameObject gameOver;
    Text gameOverText;
    public GameObject win;
    Text winText;

    private enum States {
        menu, livingroom, livingroom_01, livingroom_02, livingroom_03, livingroom_04a, livingroom_04b, livingroom_05,
        livingroom_06a, livingroom_06b, livingroom_07a, livingroom_07b, livingroom_07c, livingroom_08, livingroom_09,
        livingroom_10a, livingroom_10b, livingroom_10c, attic, attic_01, attic_02a, attic_02b, attic_03a, attic_03b, attic_04a,
        attic_04b, attic_05a, attic_05b, attic_05c, attic_06a, attic_06b, kitchen_a, kitchen_b, kitchen_01a, kitchen_01b,
        kitchen_01c, kitchen_01d, kitchen_02a, kitchen_02b, kitchen_02c, kitchen_02d, neighborhood_a, neighborhood_b,
        neighborhood_c, neighbor, neighborleft, neighborright, neighborfront, neighborfront_01a, neighborfront_01b,
        neighborfront_01c, neighborfront_02a, neighborfront_02b, neighborfront_03a, neighborfront_03b, neighborfront_04a,
        neighborfront_04b, neighborfront_05a, neighborfront_05b, neighborfront_05c, neighborhouse_a, neighborhouse_b, neighborhouse_c,
        neighborhouse_d, neighborupstairs, neighborupstairs_a, neighborupstairs_b, neighborupstairs_c, neighborupstairs_01, neighborupstairs_02,
        neighborgarage, neighborgarage_a, neighborgarage_b, neighborgarage_c, city_a, city_b, subway, subway_a, subway_b, subway_c, subway_01a,
        subway_01b, highway_a, highway_b, highway_01, highway_01a, highway_01b, sewer_a, sewer_b, gasstation, downtown_a, downtown_b, downtown_c,
        downtown_d, evacuationzone_a, evacuationzone_b, evacuationzone_c, evacuationzone_d, helicopterpad, sky, win, gameover, thankyou
    };
    private States myState;
    private bool Flashlight;
    private bool Backpack;
    private bool Knife;
    private bool Direction; // True = Left, False = Right
    private bool Code;
    private bool Medicine;
    private bool Medkit;
    private bool Boots;
    private bool Gun;
    private bool[] boolArray = new bool[7] {false, false, false, false, false, false, false};
    private bool Secret = false;


    // Use this for initialization
    void Start() {

        gameOver = GameObject.Find("GameOver");
        gameOverText = gameOver.GetComponent<Text>();
        gameOverText.enabled = false;
        win = GameObject.Find("Win");
        winText = win.GetComponent<Text>();
        winText.enabled = false;

        myState = States.livingroom;
        Flashlight = boolArray[1];
        Backpack = boolArray[2];
        Knife = boolArray[3];
        Direction = false;
        Code = boolArray[4];
        Medicine = boolArray[5];
        Medkit = boolArray[5];
        Boots = boolArray[6];
        Gun = boolArray[0];
    }

    // Update is called once per frame
    void Update() {

        print(myState);
        #region Menus
        if (myState == States.menu) { gameOverText.enabled = false; winText.enabled = false; SceneManager.LoadScene(1); } else if (myState == States.gameover) { Gameover(); } else if (myState == States.win) { Win(); } else if (myState == States.thankyou) { Thankyou(); }
        #endregion
        #region LivingRoom
        else if (myState == States.livingroom) { Livingroom(); } else if (myState == States.livingroom_01) { Livingroom_01(); } else if (myState == States.livingroom_02) { Livingroom_02(); } else if (myState == States.livingroom_03) { Livingroom_03(); } else if (myState == States.livingroom_04a) { Livingroom_04a(); } else if (myState == States.livingroom_04b) { Livingroom_04b(); } else if (myState == States.livingroom_05) { Livingroom_05(); } else if (myState == States.livingroom_06a) { Livingroom_06a(); } else if (myState == States.livingroom_06b) { Livingroom_06b(); } else if (myState == States.livingroom_07a) { Livingroom_07a(); } else if (myState == States.livingroom_07b) { Livingroom_07b(); } else if (myState == States.livingroom_07c) { Livingroom_07c(); } else if (myState == States.livingroom_08) { Livingroom_08(); } else if (myState == States.livingroom_09) { Livingroom_09(); } else if (myState == States.livingroom_10a) { Livingroom_10a(); } else if (myState == States.livingroom_10b) { Livingroom_10b(); } else if (myState == States.livingroom_10c) { Livingroom_10c(); }
        #endregion
        #region Attic
        else if (myState == States.attic) { Attic(); } else if (myState == States.attic_01) { Attic_01(); } else if (myState == States.attic_02a) { Attic_02a(); } else if (myState == States.attic_02b) { Attic_02b(); } else if (myState == States.attic_03a) { Attic_03a(); } else if (myState == States.attic_03b) { Attic_03b(); } else if (myState == States.attic_04a) { Attic_04a(); } else if (myState == States.attic_04b) { Attic_04b(); } else if (myState == States.attic_05a) { Attic_05a(); } else if (myState == States.attic_05b) { Attic_05b(); } else if (myState == States.attic_05c) { Attic_05c(); } else if (myState == States.attic_06a) { Attic_06a(); } else if (myState == States.attic_06b) { Attic_06b(); }
        #endregion
        #region Kitchen
        else if (myState == States.kitchen_a) { Kitchen_a(); } else if (myState == States.kitchen_b) { Kitchen_b(); } else if (myState == States.kitchen_01a) { Kitchen_01a(); } else if (myState == States.kitchen_01b) { Kitchen_01b(); } else if (myState == States.kitchen_01c) { Kitchen_01c(); } else if (myState == States.kitchen_01d) { Kitchen_01d(); } else if (myState == States.kitchen_02a) { Kitchen_02a(); } else if (myState == States.kitchen_02b) { Kitchen_02b(); } else if (myState == States.kitchen_02c) { Kitchen_02c(); } else if (myState == States.kitchen_02d) { Kitchen_02d(); }
        #endregion
        #region Neighborhood
        else if (myState == States.neighborhood_a) { Neighborhood_a(); } else if (myState == States.neighborhood_b) { Neighborhood_b(); } else if (myState == States.neighborhood_c) { Neighborhood_c(); } else if (myState == States.neighbor) { Neighbor(); } else if (myState == States.neighborleft) { Neighborleft(); } else if (myState == States.neighborright) { Neighborright(); } else if (myState == States.neighborfront_01a) { Neighborfront_01a(); } else if (myState == States.neighborfront_01b) { Neighborfront_01b(); } else if (myState == States.neighborfront_01c) { Neighborfront_01c(); } else if (myState == States.neighborfront_02a) { Neighborfront_02a(); } else if (myState == States.neighborfront_02b) { Neighborfront_02b(); } else if (myState == States.neighborfront_03a) { Neighborfront_03a(); } else if (myState == States.neighborfront_03b) { Neighborfront_03b(); } else if (myState == States.neighborfront_04a) { Neighborfront_04a(); } else if (myState == States.neighborfront_04b) { Neighborfront_04b(); } else if (myState == States.neighborfront_05a) { Neighborfront_05a(); } else if (myState == States.neighborfront_05b) { Neighborfront_05b(); } else if (myState == States.neighborfront_05c) { Neighborfront_05c(); } else if (myState == States.neighborhouse_a) { Neighborhouse_a(); } else if (myState == States.neighborhouse_b) { Neighborhouse_b(); } else if (myState == States.neighborhouse_c) { Neighborhouse_c(); } else if (myState == States.neighborhouse_d) { Neighborhouse_d(); } else if (myState == States.neighborupstairs) { Neighborupstairs(); } else if (myState == States.neighborupstairs_a) { Neighborupstairs_a(); } else if (myState == States.neighborupstairs_b) { Neighborupstairs_b(); } else if (myState == States.neighborupstairs_c) { Neighborupstairs_c(); } else if (myState == States.neighborupstairs_01) { Neighborupstairs_01(); } else if (myState == States.neighborupstairs_02) { Neighborupstairs_02(); } else if (myState == States.neighborgarage) { Neighborgarage(); } else if (myState == States.neighborgarage_a) { Neighborgarage_a(); } else if (myState == States.neighborgarage_b) { Neighborgarage_b(); } else if (myState == States.neighborgarage_c) { Neighborgarage_c(); }
        #endregion
        #region City
        else if (myState == States.city_a) { City_a(); } else if (myState == States.city_b) { City_b(); } else if (myState == States.subway) { Subway(); } else if (myState == States.subway_a) { Subway_a(); } else if (myState == States.subway_b) { Subway_b(); } else if (myState == States.subway_c) { Subway_c(); } else if (myState == States.subway_01a) { Subway_01a(); } else if (myState == States.subway_01b) { Subway_01b(); } else if (myState == States.downtown_a) { Downtown_a(); } else if (myState == States.downtown_b) { Downtown_b(); } else if (myState == States.downtown_c) { Downtown_c(); } else if (myState == States.downtown_d) { Downtown_d(); } else if (myState == States.evacuationzone_a) { Evacuationzone_a(); } else if (myState == States.evacuationzone_b) { Evacuationzone_b(); } else if (myState == States.evacuationzone_c) { Evacuationzone_c(); } else if (myState == States.evacuationzone_d) { Evacuationzone_d(); }
        #endregion
        #region Highway
        else if (myState == States.highway_a) { Highway_a(); } else if (myState == States.highway_b) { Highway_b(); } else if (myState == States.highway_01) { Highway_01(); } else if (myState == States.highway_01a) { Highway_01a(); } else if (myState == States.highway_01b) { Highway_01b(); } else if (myState == States.sewer_a) { Sewer_a(); } else if (myState == States.sewer_b) { Sewer_b(); } else if (myState == States.gasstation) { Gasstation(); } else if (myState == States.helicopterpad) { Helicopterpad(); } else if (myState == States.sky) { Sky(); }
        #endregion
    }

    // Functions

    #region Menus
    void Gameover() {
        gameOverText.enabled = true;
        text.text = ("\n\n\n\n\n\n Try Again?\n\n\n" +
                    "Press [Y] for Yes or [N] for No.");
        if (Input.GetKeyDown(KeyCode.Y)) { SceneManager.LoadScene(2); } else if (Input.GetKeyDown(KeyCode.N)) { myState = States.thankyou; }
    }

    void Win() {
        winText.enabled = true;
        text.text = ("\n\n\n\n\n YOU SURVIVED! \n\n Play Again? \n\n" +
                    "Press [Y] for Yes or [N] for No.");
        if (Input.GetKeyDown(KeyCode.Y)) { SceneManager.LoadScene(2); } else if (Input.GetKeyDown(KeyCode.N)) { myState = States.thankyou; }
    }

    void Thankyou() {
        gameOverText.enabled = false;
        winText.enabled = false;
        text.text = ("\n A BIG SPECIAL THANK YOU FOR PLAYING!!\n\n" +
                    "WE HOPE YOU ENJOYED THE GAME!!\n\n" +
                    "STAY TUNED FOR THE NEXT EPISODE OF THE ZOMBIE TEXT ADVENTURE GAME!!... \n\n\n" +
                    "For more of our games please visit https://www.imagitechstudios.com \n\n\n" +
                    "Press ANY KEY to exit...");

        if (Input.anyKeyDown) {
            // Quit Application in Unity Editor
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #endif

            // Quit application
            Application.Quit();
        }

    }

    #endregion
    #region LivingRoom
    void Livingroom() {
        text.text = ("The morning started off just like any other… well almost.\n\n " +
                    "You awoke on your couch in the middle of your dimly lit living room. The curtains " +
                    "were still drawn from last night's video game binge session, a sliver of light peeking " +
                    "through their cracks. The only notable items in the room are a half-eaten pizza, a 2-liter " +
                    "of root beer, an XBOX controller, and a TV remote lying on the coffee table in front of " +
                    "you. What do you want to do?\n\n" +
                    "Press [P] for Pizza, [R] for Root beer, [X] for Xbox controller, or [T] for TV remote.");
        if (Input.GetKeyDown(KeyCode.P)) { myState = States.livingroom_01; } else if (Input.GetKeyDown(KeyCode.R)) { myState = States.livingroom_02; } else if (Input.GetKeyDown(KeyCode.X)) { myState = States.livingroom_03; } else if (Input.GetKeyDown(KeyCode.T)) { myState = States.livingroom_08; }
    }

    void Livingroom_01() {
        text.text = ("That old pizza sure looks tasty. You eat the leftover pizza. Your stomach rumbles and you let " +
                    "out a big fart!!...\n\nThe only notable items left in the room are a 2-liter of root beer, " +
                    "an XBOX controller, and a TV remote lying on the coffee table in front of you. What do you " +
                    "want to do?\n\n" +
                    "Press [R] for Root beer, [X] for Xbox controller, or [T] for TV remote.");
        if (Input.GetKeyDown(KeyCode.R)) { myState = States.livingroom_04a; } else if (Input.GetKeyDown(KeyCode.X)) { myState = States.livingroom_05; } else if (Input.GetKeyDown(KeyCode.T)) { myState = States.livingroom_08; }
    }

    void Livingroom_02() {
        text.text = ("That root beer sure looks refreshing. You drink the root beer. Your stomach rumbles " +
                    "and you let out a big burp!!...\n\nThe only notable items left in the room are a half-eaten " +
                    "pizza, an XBOX controller, and a TV remote lying on the coffee table in front of you. " +
                    "What do you want to do?\n\n" +
                    "Press [P] for Pizza, [X] for Xbox controller, or [T] for TV remote.");
        if (Input.GetKeyDown(KeyCode.P)) { myState = States.livingroom_04b; } else if (Input.GetKeyDown(KeyCode.X)) { myState = States.livingroom_06a; } else if (Input.GetKeyDown(KeyCode.T)) { myState = States.livingroom_08; }
    }

    void Livingroom_03() {
        text.text = ("You didn't get enough game time last night so you pick up the XBOX controller " +
                    "and play for a bit. You soon get bored and put the XBOX controller back down.\n\nThe only " +
                    "notable items left in the room are a half-eaten pizza, a 2-liter of root beer, " +
                    "and a TV remote lying on the coffee table in front of you. What do you want to do?\n\n" +
                    "Press [P] for Pizza, [R] for Root beer, or [T] for TV remote.");
        if (Input.GetKeyDown(KeyCode.P)) { myState = States.livingroom_05; } else if (Input.GetKeyDown(KeyCode.R)) { myState = States.livingroom_06b; } else if (Input.GetKeyDown(KeyCode.T)) { myState = States.livingroom_08; }
    }

    void Livingroom_04a() {
        text.text = ("That root beer sure looks refreshing. You drink the root beer. Your stomach rumbles " +
                    "and you let out a big burp!!...\n\nThe only notable items left in the room are an XBOX " +
                    "controller and a TV remote lying on the coffee table in front of you. What do you want to do?\n\n" +
                    "Press [X] for Xbox controller, or [T] for TV remote.");
        if (Input.GetKeyDown(KeyCode.X)) { myState = States.livingroom_07c; } else if (Input.GetKeyDown(KeyCode.T)) { myState = States.livingroom_08; }
    }

    void Livingroom_04b() {
        text.text = ("That old pizza sure looks tasty. You eat the leftover pizza. Your stomach rumbles and you let " +
                    "out a big fart!!...\n\nThe only notable items left in the room are an XBOX " +
                    "controller and a TV remote lying on the coffee table in front of you. What do you want to do?\n\n" +
                    "Press [X] for Xbox controller, or [T] for TV remote.");
        if (Input.GetKeyDown(KeyCode.X)) { myState = States.livingroom_07c; } else if (Input.GetKeyDown(KeyCode.T)) { myState = States.livingroom_08; }
    }

    void Livingroom_05() {
        text.text = ("That old pizza sure looks tasty. You eat the leftover pizza. Your stomach rumbles and you let " +
                    "out a big fart!!...\n\nThe only notable items in the room are a 2-liter of root beer and a TV " +
                    "remote lying on the coffee table in front of you. What do you want to do?\n\n" +
                    "Press [R] for Root beer or [T] for TV remote.");
        if (Input.GetKeyDown(KeyCode.R)) { myState = States.livingroom_07b; } else if (Input.GetKeyDown(KeyCode.T)) { myState = States.livingroom_08; }
    }

    void Livingroom_06a() {
        text.text = ("You didn't get enough game time last night so you pick up the XBOX controller and play for a bit. " +
                    "You soon get bored and put the XBOX controller back down.\n\nThe only notable items in the room are " +
                    "a half-eaten pizza and a TV remote lying on the coffee table in front of you. What do you want to do?\n\n" +
                    "Press [P] for Pizza or [T] for TV remote.");
        if (Input.GetKeyDown(KeyCode.P)) { myState = States.livingroom_07a; } else if (Input.GetKeyDown(KeyCode.T)) { myState = States.livingroom_08; }
    }

    void Livingroom_06b() {
        text.text = ("That root beer sure looks refreshing. You drink the root beer. Your stomach rumbles and you let out a " +
                    "big burp!!...\n\nThe only notable items left in the room are a half-eaten pizza and a TV remote lying " +
                    "on the coffee table in front of you. What do you want to do?\n\n" +
                    "Press [P] for Pizza or [T] for TV remote.");
        if (Input.GetKeyDown(KeyCode.P)) { myState = States.livingroom_07a; } else if (Input.GetKeyDown(KeyCode.T)) { myState = States.livingroom_08; }
    }

    void Livingroom_07a() {
        text.text = ("That old, stale pizza sure looks tasty. You eat the leftover pizza. Your stomach rumbles and you let " +
                    "out a big fart!!...\n\nThe only notable item left in the room is a TV remote lying on the coffee " +
                    "table in front of you. What do you want to do?\n\n" +
                    "Press [T] for TV remote.");
        if (Input.GetKeyDown(KeyCode.T)) { myState = States.livingroom_08; }
    }

    void Livingroom_07b() {
        text.text = ("That root beer sure looks refreshing. You drink the root beer. Your stomach rumbles " +
                    "and you let out a big burp!!...\n\nThe only notable item left in the room is a TV " +
                    "remote lying on the coffee table in front of you. What do you want to do?\n\n" +
                    "Press [T] for TV remote.");
        if (Input.GetKeyDown(KeyCode.T)) { myState = States.livingroom_08; }
    }

    void Livingroom_07c() {
        text.text = ("You didn't get enough game time last night. You pick up the XBOX controller " +
                    "and play for a bit. You get bored and put the XBOX controller down.\n\nThe only " +
                    "notable item left in the room is a TV remote lying on the coffee table in front of " +
                    "you. What do you want to do?\n\n" +
                    "Press [T] for TV remote.");
        if (Input.GetKeyDown(KeyCode.T)) { myState = States.livingroom_08; }
    }

    void Livingroom_08() {
        text.text = ("You pick up the TV remote and change the channel to watch anime. As you're watching an " +
                    "emergency news broadcast interupts your show. 'This is an emergency announcement!... " +
                    "Zombies have taken over the city... I repeat... Zombies... Yes, zombies... have taken " +
                    "over the city... All citizens are advised to... and stay calm... gather your loved ones... " +
                    "and head to the evacuation zone in downtown... Soldiers... assist you to safety. Get out " +
                    "while you still can!!'\n\n" +
                    "Press SPACE to continue.");
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.livingroom_09; }
    }

    void Livingroom_09() {
        text.text = ("Suddenly the power goes out and the television shuts off. You jump to your feet, everything in the " +
                    "house eerily quiet around you. Zombie apocalypse you think?! You better get to safety before its too " +
                    "late!! But first maybe you should check for supplies.\n\nYou can go upstairs to the attic, into the " +
                    "kitchen, or leave the house. What will you do?\n\n" +
                    "Press [A] to check the Attic, [K] to check the Kitchen, or [L] to Leave the house.");
        if (Input.GetKeyDown(KeyCode.A)) { myState = States.attic; } else if (Input.GetKeyDown(KeyCode.K)) { myState = States.kitchen_a; } else if (Input.GetKeyDown(KeyCode.L)) { myState = States.neighborhood_a; }
    }

    void Livingroom_10a() { // After Attic
        text.text = ("You went back to the living room. You can go into the kitchen or leave the house. What will you do?\n\n" +
                    "Press [K] to check the Kitchen, or [L] to Leave the house.");
        if (Input.GetKeyDown(KeyCode.K)) { myState = States.kitchen_b; } else if (Input.GetKeyDown(KeyCode.L)) { myState = States.neighborhood_a; }
    }

    void Livingroom_10b() { // After Kitchen
        text.text = ("You went back to the living room. You can go upstairs to the attic or leave the house. What will you do?\n\n" +
                    "Press [A] to check the Attic, or [L] to Leave the house.");
        if (Input.GetKeyDown(KeyCode.A)) { myState = States.attic_01; } else if (Input.GetKeyDown(KeyCode.L)) { myState = States.neighborhood_a; }
    }

    void Livingroom_10c() { // After Attic and Kitchen 
        text.text = ("You went back to the living room. What will you do?\n\n" +
                    "Press [L] to Leave the house.");
        if (Input.GetKeyDown(KeyCode.A)) { myState = States.attic; } else if (Input.GetKeyDown(KeyCode.L)) { myState = States.neighborhood_a; }
    }
    #endregion
    #region Attic
    void Attic() { //Before Kitchen
        text.text = ("You decide to go upstairs to the attic to look for supplies. You find the hideaway stairs to the attic " +
                    "already pulled down and get a bad feeling. Will you continue on?\n\n" +
                    "Press [C] to Continue up to the attic or [B] to go Back.");
        if (Input.GetKeyDown(KeyCode.C)) { myState = States.attic_02a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.livingroom_10a; }
    }

    void Attic_01() { // After Kitchen
        text.text = ("You decide to go upstairs to the attic to look for supplies. You find the hideaway stairs to the attic " +
                    "already pulled down and get a bad feeling. Will you continue on?\n\n" +
                    "Press [C] to Continue up to the attic or [B] to go Back.");
        if (Input.GetKeyDown(KeyCode.C)) { myState = States.attic_02b; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.livingroom_10c; }
    }

    void Attic_02a() { // Before Kitchen
        text.text = ("You continue up to the attic to look for supplies. The attic is dark and dusty causing you to cough. " +
                    "Without warning the attic creaks from the back corner! You stand perfectly still without breathing and " +
                    "listen. Nothing? Maybe just your imagination? You can walk forward, inspect the floor around you, or go " +
                    "back.\n\n" +
                    "Press [W] to Walk forward, [I] to Inspect the floor, or [B] to go Back.");
        if (Input.GetKeyDown(KeyCode.W)) { boolArray[1] = true; myState = States.attic_03a; } else if (Input.GetKeyDown(KeyCode.I)) { boolArray[1] = true; myState = States.attic_04a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.livingroom_10a; }
    }

    void Attic_02b() { // After Kitchen
        text.text = ("You continue up to the attic to look for supplies. The attic is dark and dusty causing you to cough. " +
                    "Without warning the attic creaks from the back corner! You stand perfectly still without breathing and " +
                    "listen. Nothing? Maybe just your imagination? You can walk forward, inspect the floor around you, or go " +
                    "back.\n\n" +
                    "Press [W] to Walk forward, [I] to Inspect the floor, or [B] to go Back.");
        if (Input.GetKeyDown(KeyCode.W)) { boolArray[1] = true; myState = States.attic_03b; } else if (Input.GetKeyDown(KeyCode.I)) { boolArray[1] = true; myState = States.attic_04b; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.livingroom_10c; }
    }

    void Attic_03a() { // Before Kitchen
        text.text = ("You walk forward into the dark and kick something with your foot. You slowly bend down and feel around until " +
                    "your hand finds a round object. You pick it up. It's a flashlight! You can turn on the flashlight, feel around " +
                    "in the dark some more, or go back downstairs. What will you do?\n\n" +
                    "Press [T] to Turn on flashlight, [F] to feel around in the dark, or [B] to go Back downstairs.");
        if (Input.GetKeyDown(KeyCode.T)) { myState = States.attic_05a; } else if (Input.GetKeyDown(KeyCode.F)) { boolArray[2] = true; myState = States.attic_06a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.livingroom_10a; }
    }

    void Attic_03b() { // After Kitchen
        text.text = ("You walk forward into the dark and kick something with your foot. You slowly bend down and feel around until " +
                    "your hand finds a round object. You pick it up. It's a flashlight! You can turn on the flashlight, feel around " +
                    "in the dark some more, or go back downstairs. What will you do?\n\n" +
                    "Press [T] to Turn on flashlight, [F] to feel around in the dark, or [B] to go Back downstairs.");
        if (Input.GetKeyDown(KeyCode.T)) { myState = States.attic_05b; } else if (Input.GetKeyDown(KeyCode.F)) { boolArray[2] = true; myState = States.attic_06b; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.livingroom_10c; }
    }

    void Attic_04a() { // Before Kitchen
        text.text = ("You reach down and inspect the floor until eventually your hand finds a round object. You pick it up. It's a " +
                    "flashlight! You can turn on the flashlight, feel around in the dark some more, or go back downstairs. What will " +
                    "you do?\n\n" +
                    "Press [T] to Turn on flashlight, [F] to feel around in the dark, or [B] to go Back downstairs.");
        if (Input.GetKeyDown(KeyCode.T)) { myState = States.attic_05a; } else if (Input.GetKeyDown(KeyCode.F)) { boolArray[2] = true; myState = States.attic_06a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.livingroom_10a; }
    }

    void Attic_04b() { // After Kitchen
        text.text = ("You reach down and inspect the floor until eventually your hand finds a round object. You pick it up. It's a " +
                    "flashlight! You can turn on the flashlight, feel around in the dark some more, or go back downstairs. What will " +
                    "you do?\n\n" +
                    "Press [T] to Turn on flashlight, [F] to feel around in the dark, or [B] to go Back downstairs.");
        if (Input.GetKeyDown(KeyCode.T)) {
            if (boolArray[3] == true) { myState = States.attic_05c; } else { myState = States.attic_05b; }
        } else if (Input.GetKeyDown(KeyCode.F)) { boolArray[2] = true; myState = States.attic_06b; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.livingroom_10a; }
    }

    void Attic_05a() { // Before Kitchen
        text.text = ("You turn on the flashlight and right in front of you is a zombie! You try to back up and trip over a loose " +
                    "floorboard dropping the flashlight on the floor. The zombie falls on top of you biting and scratching for your brains. You struggle, trying to throw the " +
                    "zombie off of you, but eventually he gets a good bite in and you scream before everything goes black...\n\n" +
                    "Press [SPACE] to continue...");
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.gameover; }
    }

    void Attic_05b() { // After Kitchen without Knife
        text.text = ("You turn on the flashlight and right in front of you is a zombie! You try to back up and trip over a loose " +
                    "floorboard dropping the flashlight on the floor. The zombie falls on top of you biting and scratching for your brains. You struggle, trying to throw the " +
                    "zombie off of you, but eventually he gets a good bite in and you scream before everything goes black.\n\n" +
                    "Press SPACE to continue...");
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.gameover; }
    }

    void Attic_05c() { // After Kitchen with Knife
        text.text = ("You turn on the flashlight and right in front of you is a zombie! You try to back up and trip over a loose " +
                    "floorboard, dropping the knife and flashlight on the floor. The zombie falls on top of you biting and scratching " +
                    "for your brains. You struggle, trying to throw the zombie off of you. You reach around on the floor while holding " +
                    "the zombie at bay and feel the knife so you pick it up. You attack over and over with the knife and the zombie " +
                    "eventually stops moving. You push the zombie off and climb to your feet. You pick up the flashlight and run out of the attic.\n\n" +
                    "Press SPACE to continue.");
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.livingroom_10c; }
    }

    void Attic_06a() { // Before Kitchen
        text.text = ("You walk slowly, feeling around in the dark some more, until you find a coat hangar with a backpack on it! You throw " +
                    "the backpack on your back. You can turn on the flashlight or go back downstairs. What will you do?\n\n" +
                    "Press [T] to Turn on the flashlight or [B] to go Back downstairs.");
        if (Input.GetKeyDown(KeyCode.T)) { myState = States.attic_05a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.livingroom_10a; }
    }

    void Attic_06b() { // After Kitchen
        text.text = ("You walk slowly, feeling around in the dark some more, until you find a coat hangar with a backpack on it! You throw " +
                    "the backpack on your back. You can turn on the flashlight or go back downstairs. What will you do?\n\n" +
                    "Press [T] to Turn on the flashlight or [B] to go Back downstairs.");
        if (Input.GetKeyDown(KeyCode.T)) {
            if (boolArray[3] == true) { myState = States.attic_05c; } else { myState = States.attic_05b; }
        } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.livingroom_10c; }
    }
    #endregion
    #region Kitchen
    void Kitchen_a() { // Before Attic
        text.text = ("You decide to go into the kitchen to look for supplies. In the kitchen you find blood smeared on the " +
                    "outside of the kitchen window. You look out, but don't see anything. You look at the back door. Still " +
                    "locked. Around the kitchen nothing really stands out. You can inspect the drawers, open the refrigerator, " +
                    "leave out the back door, or go back to the living room. What will you do?\n\n" +
                    "Press [I] to Inspect the drawers, [O] to Open the refrigerator, [L] to Leave out the back door, or [B] to go Back.");
        if (Input.GetKeyDown(KeyCode.I)) { boolArray[3] = true; myState = States.kitchen_01a; } else if (Input.GetKeyDown(KeyCode.O)) { myState = States.kitchen_02a; } else if (Input.GetKeyDown(KeyCode.L)) { myState = States.neighborhood_a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.livingroom_10b; }
    }

    void Kitchen_b() { // After Attic
        text.text = ("You decide to go into the kitchen to look for supplies. In the kitchen you find blood smeared on the " +
                    "outside of the kitchen window. You look out, but don't see anything. you look at the back door. Still " +
                    "locked. Around the kitchen nothing really stands out. You can inspect the drawers, open the refrigerator, " +
                    "leave out the back door, or go back to the living room. What will you do?\n\n" +
                    "Press [I] to Inspect the drawers, [O] to Open the refrigerator, [L] to Leave out the back door, or [B] to go Back.");
        if (Input.GetKeyDown(KeyCode.I)) { boolArray[3] = true; myState = States.kitchen_01c; } else if (Input.GetKeyDown(KeyCode.O)) { myState = States.kitchen_02c; } else if (Input.GetKeyDown(KeyCode.L)) { myState = States.neighborhood_a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.livingroom_10c; }
    }

    void Kitchen_01a() { // Inspect Drawers Before Refrigerator And Before Attic
        text.text = ("You decide to rummage through the drawers and find a knife! You equip yourself for danger and move on. " +
                    "You can open the refrigerator, leave out the back door, or go back to the living room. What will you do?\n\n" +
                    "Press [O] to Open the refrigerator, [L] to Leave out the back door, or [B] to go Back to the living room.");
        if (Input.GetKeyDown(KeyCode.O)) { myState = States.kitchen_02b; } else if (Input.GetKeyDown(KeyCode.L)) { myState = States.neighborhood_a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.livingroom_10b; }
    }

    void Kitchen_01b() { // Inspect Drawers After Refrigerator But Before Attic
        text.text = ("You decide to rummage through the drawers and find a knife! You equip yourself for danger and move on. " +
                    "You can leave out the back door or go back to the living room. What will you do?\n\n" +
                    "Press [L] to Leave out the back door or [B] to go Back to the living room.");
        if (Input.GetKeyDown(KeyCode.L)) { myState = States.neighborhood_a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.livingroom_10b; }
    }

    void Kitchen_01c() { // Inspect Drawers Before Refrigerator But After Attic
        text.text = ("You decide to rummage through the drawers and find a knife! You equip yourself for danger and move on. " +
                    "You can open the refrigerator, leave out the back door, or go back to the living room. What will you do?\n\n" +
                    "Press [O] to Open the refrigerator, [L] to Leave out the back door, or [B] to go Back to the living room.");
        if (Input.GetKeyDown(KeyCode.O)) { myState = States.kitchen_02d; } else if (Input.GetKeyDown(KeyCode.L)) { myState = States.neighborhood_a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.livingroom_10c; }
    }

    void Kitchen_01d() { // Inspect Drawers After Refrigerator And After Attic
        text.text = ("You decide to rummage through the drawers and find a knife! You equip yourself for danger and move on. " +
                    "You can open the refrigerator, leave out the back door, or go back to the living room. What will you do?\n\n" +
                    "Press [L] to Leave out the back door or [B] to go Back to the living room.");
        if (Input.GetKeyDown(KeyCode.L)) { myState = States.neighborhood_a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.livingroom_10c; }
    }

    void Kitchen_02a() { // Open Refrigerator Before Drawers And Before Attic
        text.text = ("You open the fridge to get some supplies. It is mostly empty except for some old leftovers. You close the fridge " +
                    "and move on. You can inspect the drawers, leave out the back door, or go back to the living room. What will you do?\n\n" +
                    "Press [I] to Inspect the drawers, [L] to Leave out the back door, or [B] to go back to the living room.");
        if (Input.GetKeyDown(KeyCode.I)) { boolArray[3] = true; myState = States.kitchen_01b; } else if (Input.GetKeyDown(KeyCode.L)) { myState = States.neighborhood_a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.livingroom_10b; }
    }

    void Kitchen_02b() { // Open Refrigerator After Drawers But Before Attic
        text.text = ("You open the fridge to get some supplies. It is mostly empty except for some old leftovers. You close the fridge " +
                    "and move on. You can leave out the back door, or go back to the living room. What will you do?\n\n" +
                    "Press [L] to Leave out the back door or [B] to go back to the living room.");
        if (Input.GetKeyDown(KeyCode.L)) { myState = States.neighborhood_a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.livingroom_10b; }
    }

    void Kitchen_02c() { // Open Refrigerator Before Drawers But After Attic
        text.text = ("You open the fridge to get some supplies. It is mostly empty except for some old leftovers. You close the fridge " +
                    "and move on. You can leave out the back door, or go back to the living room. What will you do?\n\n" +
                    "Press [L] to Leave out the back door or [B] to go back to the living room.");
        if (Input.GetKeyDown(KeyCode.I)) { boolArray[3] = true; myState = States.kitchen_01d; } else if (Input.GetKeyDown(KeyCode.L)) { myState = States.neighborhood_a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.livingroom_10c; }
    }

    void Kitchen_02d() { // Open Refrigerator After Drawers And After Attic
        text.text = ("You open the fridge to get some supplies. It is mostly empty except for some old leftovers. You close the fridge " +
                    "and move on. You can leave out the back door, or go back to the living room. What will you do?\n\n" +
                    "Press [L] to Leave out the back door or [B] to go back to the living room.");
        if (Input.GetKeyDown(KeyCode.L)) { myState = States.neighborhood_a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.livingroom_10c; }
    }
    #endregion
    #region Neighborhood
    void Neighborhood_a() {
        text.text = ("You decide to leave the house. When you walk out into the neighborhood you can see plumes of smoke blanketing " +
                    "the city off in the distance. Down the street a couple zombies are feasting on something while black crows caw " +
                    "overhead. You walk up to your car in the drive way and pull out your keys, but hesitate. You can inspect the " +
                    "neighbor's house, go into the city, take the highway out of town, or go back inside your house. What will you do?\n\n" +
                    "Press [N] for Neighbor's house, [C] to go into the City, [H] to take the Highway out of town, or [B] to go Back inside your house.");
        if (Input.GetKeyDown(KeyCode.N)) { myState = States.neighbor; } else if (Input.GetKeyDown(KeyCode.C)) { myState = States.city_a; } else if (Input.GetKeyDown(KeyCode.H)) { myState = States.highway_a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.neighborhood_c; }
    }

    void Neighborhood_b() {
        text.text = ("You walk back to your car. Down the street a couple zombies are feasting on something while black crows caw " +
                    "overhead. You can go into the city, take the highway out of town, or go back inside your house. What will you do?\n\n" +
                    "Press [C] to go into the City, [H] to take the Highway out of town, or [B] to go Back inside your house.");
        if (Input.GetKeyDown(KeyCode.C)) { myState = States.city_a; } else if (Input.GetKeyDown(KeyCode.H)) { myState = States.highway_a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.neighborhood_c; }
    }

    void Neighborhood_c() {
        text.text = ("You walk back to the house. When you open the door a zombie leaps forward attacking you!! He scrapes your arm as " +
                    "you try to get away, causing you to stumble. He grabs you from behind and bites down on your shoulder. You scream and " +
                    "everything goes black...\n\n" +
                    "Press [SPACE] to continue...");
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.gameover; }
    }

    void Neighbor() {
        text.text = ("You decide to check the neighbor's house for supplies before leaving, but which neighbor's house should you check? " +
                    "You can pick the nieghbor to the left of your house, or the neighbor to the right of your house. What do you want to " +
                    "do?\n\n" +
                    "Press [L] for the left neighbor's house and [R] for the right neighbor's house.");
        if (Input.GetKeyDown(KeyCode.L)) { Direction = true; myState = States.neighborleft; } else if (Input.GetKeyDown(KeyCode.R)) { Direction = false; myState = States.neighborright; }

    }

    void Neighborleft() {
        text.text = ("You choose the neighbor's house on the left. You cautiously walk up the sidewalk towards the front door, eyes looking " +
                    "back over your shoulders. A stray breeze starts to blow and the leaves in the trees above you start to rustle. You approach " +
                    "the front door and stand on the welcome mat. To the left, the curtains are drawn in the window. You can try to get in " +
                    "through the window, ring the doorbell, turn the doorknob, or go back to your car. What will you do?\n\n" +
                    "Press [W] to try the Window, [R] to Ring the doorbell, [T] to Turn the doorknob, or [B] to go Back to your car.");
        if (Input.GetKeyDown(KeyCode.W)) { myState = States.neighborfront_01a; } else if (Input.GetKeyDown(KeyCode.R)) { myState = States.neighborfront_01b; } else if (Input.GetKeyDown(KeyCode.T)) { myState = States.neighborfront_01c; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.neighborhood_b; }
    }

    void Neighborright() {
        text.text = ("You choose the neighbor's house on the right. You cautiously walk up the sidewalk towards the front door, eyes looking " +
                    "back over your shoulders. A stray breeze starts to blow and the leaves in the trees above you start to rustle. You approach " +
                    "the front door and stand on the welcome mat. To the right, the curtains are drawn in the window. You can try to get in " +
                    "through the window, ring the doorbell, turn the doorknob, or go back to your car. What will you do?\n\n" +
                    "Press [W] to try the Window, [R] to Ring the doorbell, [T] to Turn the doorknob, or [B] to go Back to your car.");
        if (Input.GetKeyDown(KeyCode.W)) { myState = States.neighborfront_01a; } else if (Input.GetKeyDown(KeyCode.R)) { myState = States.neighborfront_01b; } else if (Input.GetKeyDown(KeyCode.T)) { myState = States.neighborfront_01c; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.neighborhood_b; }
    }

    void Neighborfront_01a() { // Try the window first
        text.text = ("You try to get in the window. The window is locked and won't open. You try to see in but the curtains make it almost impossible to " +
                    "see anything. You can ring the doorbell, turn the doorknob, or go back to your car. What will you do?\n\n" +
                    "Press [R] to Ring the doorbell, [T] to Turn the doorknob, or [B] to go Back to your car.");
        if (Input.GetKeyDown(KeyCode.R)) { myState = States.neighborfront_02a; } else if (Input.GetKeyDown(KeyCode.T)) { myState = States.neighborfront_02b; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.neighborhood_b; }
    }

    void Neighborfront_01b() { // Ring the doorbell first
        text.text = ("You ring the doorbell. You hear the bell chime and then nothing... Silence... I guess no one is home. You can try to get in through the " +
                    "window, turn the doorknob, or go back to your car. What will you do?\n\n" +
                    "Press [W] to try the Window, [T] to Turn the doorknob, or [B] to go Back to your car.");
        if (Input.GetKeyDown(KeyCode.W)) { myState = States.neighborfront_03a; } else if (Input.GetKeyDown(KeyCode.T)) { myState = States.neighborfront_03b; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.neighborhood_b; }
    }

    void Neighborfront_01c() { // // Turn the doorknob first
        text.text = ("You turn the doorknob. The door is locked and won't budge. You can try to get in through the window, ring the doorbell, or go back to your " +
                    "car. What will you do?\n\n" +
                    "Press [W] to try the Window, [R] to Ring the doorbell, or [B] to go Back to your car.");
        if (Input.GetKeyDown(KeyCode.W)) { myState = States.neighborfront_04a; } else if (Input.GetKeyDown(KeyCode.R)) { myState = States.neighborfront_04b; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.neighborhood_b; }
    }

    void Neighborfront_02a() { // Ring doorbell after trying window
        text.text = ("You ring the doorbell. You hear the bell chime and then nothing... Silence... I guess no one is home. You can turn the doorknob, or go back " +
                    "to your car. What will you do?\n\n" +
                    "Press [T] to Turn the doorknob, or [B] to go Back to your car.");
        if (Input.GetKeyDown(KeyCode.T)) { myState = States.neighborfront_05a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.neighborhood_b; }
    }

    void Neighborfront_02b() { // Turn doorknob after trying window
        text.text = ("You turn the doorknob. The door is locked and won't budge. You can ring the doorbell or go back to your car. What will you do?\n\n" +
                    "Press [R] to Ring the doorbell or [B] to go Back to your car.");
        if (Input.GetKeyDown(KeyCode.R)) { myState = States.neighborfront_05b; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.neighborhood_b; }
    }

    void Neighborfront_03a() { // Try window after doorbell
        text.text = ("You try to get in the window. The window is locked and won't open. You can turn the doorknob or go back to your car. What will you do?\n\n" +
                    "Press [T] to Turn the doorknob or [B] to go Back to your car.");
        if (Input.GetKeyDown(KeyCode.T)) { myState = States.neighborfront_05a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.neighborhood_b; }
    }

    void Neighborfront_03b() { // Turn doorknob after doorbell
        text.text = ("You turn the doorknob. The door is locked and won't budge. You can try to get in through the window or go back to your car. What will you do?\n\n" +
                    "Press [W] to try the Window or [B] to go Back to your car.");
        if (Input.GetKeyDown(KeyCode.W)) { myState = States.neighborfront_05c; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.neighborhood_b; }
    }

    void Neighborfront_04a() { // Try window after doorknob
        text.text = ("You try to get in the window. The window is locked and won't open. You can ring the doorbell or go back to your car. What will you do?\n\n" +
                    "Press [R] to Ring the doorbell or [B] to go Back to your car.");
        if (Input.GetKeyDown(KeyCode.R)) { myState = States.neighborfront_05b; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.neighborhood_b; }
    }

    void Neighborfront_04b() { // Try doorbell after doorknob
        text.text = ("You ring the doorbell. You hear the bell chime and then nothing... Silence... I guess no one is home. You can try to get in through the window or " +
                    "go back to your car. What will you do?\n\n" +
                    "Press [W] to try the Window or [B] to go Back to your car.");
        if (Input.GetKeyDown(KeyCode.W)) { myState = States.neighborfront_05c; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.neighborhood_b; }
    }

    void Neighborfront_05a() { // Turn doorknob last
        text.text = ("You turn the doorknob. The door is locked and won't budge. You can check under the welcome mat or go back to your car. What will you do?\n\n" +
                    "Press [C] to Check under the welcome mat or [B] to go Back to your car.");
        if (Input.GetKeyDown(KeyCode.C)) { myState = States.neighborhouse_a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.neighborhood_b; }
    }

    void Neighborfront_05b() { // Ring doorbell last
        text.text = ("You ring the doorbell. You hear the bell chime and then nothing... Silence... I guess no one is home. You can check under the welcome mat or go back " +
                    "to your car. What will you do?\n\n" +
                    "Press [C] to Check under the welcome mat or [B] to go Back to your car.");
        if (Input.GetKeyDown(KeyCode.C)) { myState = States.neighborhouse_a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.neighborhood_b; }
    }

    void Neighborfront_05c() { // Try window last
        text.text = ("You try to get in the window. The window is locked and won't open. You can check under the welcome mat or go back to your car. What will you do?\n\n" +
                    "Press [C] to Check under the welcome mat or [B] to go Back to your car.");
        if (Input.GetKeyDown(KeyCode.C)) { myState = States.neighborhouse_a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.neighborhood_b; }
    }

    void Neighborhouse_a() { // Check under welcome mat
        text.text = ("You check under the welcome mat and find a spare key! What luck! You use the key to unlock the front door and step inside. You find the house in shambles. " +
                    "To your left are some stairs and to the right is a door to the garage. You can search upstairs, search the garage, or go back to your car. What will you " +
                    "do?\n\n" +
                    "Press [U] to search Upstairs, [G] to search to the Garage, or [B] to go Back to your car.");
        if (Input.GetKeyDown(KeyCode.U)) { myState = States.neighborupstairs; } else if (Input.GetKeyDown(KeyCode.G)) { myState = States.neighborgarage; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.neighborhouse_b; }
    }

    void Neighborhouse_b() { // Go back to your car
        text.text = ("You turn to leave the house and the front door slams in front of you locking you in. You try the doorknob, but something is jamming it. On the floor in " +
                    "front of you is a note. You can search upstairs, search the garage, or read the note. What will you do?\n\n" +
                    "Press [U] to search Upstairs, [L] to search the Living room, [G] to search the Garage, or [R] to Read the note.");
        if (Input.GetKeyDown(KeyCode.U)) { myState = States.neighborupstairs; } else if (Input.GetKeyDown(KeyCode.G)) { myState = States.neighborgarage; } else if (Input.GetKeyDown(KeyCode.R)) { boolArray[4] = true; myState = States.neighborhouse_c; }
    }

    void Neighborhouse_c() { // Pickup and read note
        text.text = ("You pickup the note and read it. On the note are the words 'Sewer Access' and a code '56132'. You tuck the note in your pocket, unsure of how it will help. " +
                    "You turn around and face the dark, empty house. You can search upstairs or search the garage. What will you do?\n\n" +
                    "Press [U] to search Upstairs or [G] to search the garage.");
        if (Input.GetKeyDown(KeyCode.U)) { myState = States.neighborupstairs; } else if (Input.GetKeyDown(KeyCode.G)) { myState = States.neighborgarage; }
    }

    void Neighborhouse_d() { // Go back to main house from upstairs
        text.text = ("You walk back downstairs. You can still search the garage. What will you do?\n\n" +
            "Press [G] to search the Garage.");
        if (Input.GetKeyDown(KeyCode.G)) { myState = States.neighborgarage; }
    }

    void Neighborupstairs() { // pain medicine / medkit
        text.text = ("You decide to see what's upstairs. You walk up the stairs, each stair creaking under your feet. At the top of the stairs is a hallway with two bedroom doors " +
                    "and a bathroom door. You can open the left bedroom door, open the bathroom door, open the right bedroom door, or go downstairs. What will you do?\n\n" +
                    "Press [L] for the Left bedroom door, [B] for the Bathroom door, [R] for the Right bedroom door, or [D] to go Downstairs.");
        if (Input.GetKeyDown(KeyCode.L)) { myState = States.neighborupstairs_a; } else if (Input.GetKeyDown(KeyCode.B)) { myState = States.neighborupstairs_b; } else if (Input.GetKeyDown(KeyCode.R)) { myState = States.neighborupstairs_c; } else if (Input.GetKeyDown(KeyCode.D)) { myState = States.neighborhouse_b; }
    }

    void Neighborupstairs_a() { // Left bedroom door
        if (boolArray[3] == true) {
            text.text = ("You choose to open the left bedroom door. As soon as you walk in you wish you hadn't. A group of zombies in the room are alerted to your presence " +
            "and lunge forward to attack. You pull out your knife and strike the first zombie, dropping it to the floor and tripping the other zombies. You quickly " +
            "turn and run out the doorway, slamming the door behind you, and barely escaping with your life. You can only go downstairs. What will you do?\n\n" +
            "Press [D] to go Downstairs.");
            if (Input.GetKeyDown(KeyCode.D)) { myState = States.neighborhouse_d; }
        } else {
            text.text = ("You choose to open the left bedroom door. As soon as you walk in you wish you hadn't. A group of zombies in the room are alerted to your presence " +
            "and lunge forward to attack. You turn to run out the doorway, but it is too late. A zombie grabs you from behind and pulls you down onto the ground. The other zombies " +
            "fall on top of you and begin biting and scratching. You scream and everything goes black...\n\n" +
            "Press [SPACE] to continue...");
            if (Input.GetKeyDown(KeyCode.Space)) { myState = States.gameover; }
        }
    }

    void Neighborupstairs_b() { // Middle bathroom door
        text.text = ("You choose to open the bathroom door. In the bathroom you don't see anything particularly useful. You can check the medicine cabinet, check under the sink, or " +
                    "go downstairs. What will you do?\n\n" +
                    "Press [M] to check the Medicine cabinet, [S] to check under the Sink, or [D] to go Downstairs.");
        if (Input.GetKeyDown(KeyCode.M)) { myState = States.neighborupstairs_01; } else if (Input.GetKeyDown(KeyCode.S)) { myState = States.neighborupstairs_02; } else if (Input.GetKeyDown(KeyCode.D)) { myState = States.neighborhouse_d; }
    }

    void Neighborupstairs_c() { // Right bedroom door
        if (boolArray[3] == true) {
            text.text = ("You choose to open the right bedroom door. As soon as you walk in you wish you hadn't. A group of zombies in the room are alerted to your presence " +
            "and lunge forward to attack. You pull out your knife and strike the first zombie, dropping it to the floor and tripping the other zombies. You quickly " +
            "turn and run out the doorway, slamming the door behind you, and barely escaping with your life. You can only go downstairs. What will you do?\n\n" +
            "Press [D] to go Downstairs.");
            if (Input.GetKeyDown(KeyCode.D)) { myState = States.neighborhouse_d; }
        } else {
            text.text = ("You choose to open the right bedroom door. As soon as you walk in you wish you hadn't. A group of zombies in the room are alerted to your presence " +
            "and lunge forward to attack. You turn to run out the doorway, but it is too late. A zombie grabs you from behind and pulls you down onto the ground. The other zombies " +
            "fall on top of you and begin biting and scratching. You scream and everything goes black...\n\n" +
            "Press [SPACE] to continue...");
            if (Input.GetKeyDown(KeyCode.Space)) { myState = States.gameover; }
        }
    }

    void Neighborupstairs_01() { // Medicine cabinet
        if (Direction == true) {
            text.text = ("You decide to check the medicine cabinet. You open the mirrored door and find a bootle of pain medicine. You grab it and slip it into your backpack. You " +
                        "can only go downstairs. What will you do?\n\n" +
                        "Press [D] to go Downstairs.");
            if (Input.GetKeyDown(KeyCode.D)) { boolArray[5] = true; myState = States.neighborhouse_d; }
        } else {
            text.text = ("You decide to check the medicine cabinet. You open the mirrored door and find a medkit. You grab it and slip it into your backpack. You can only go " +
                        "downstairs. What will you do?\n\n" +
                        "Press [D] to go Downstairs.");
            if (Input.GetKeyDown(KeyCode.D)) { boolArray[5] = true; myState = States.neighborhouse_d; }
        }
    }

    void Neighborupstairs_02() { // Sink
        text.text = ("You decide to check under the sink. You open the cabinet and a rat squeaks and runs past you. You don't see anything useful. You can check the medicine cabinet " +
                    "or go downstairs. What will you do?\n\n" +
                    "Press [M] to check the Medicine cabinet or [D] to go Downstairs.");
        if (Input.GetKeyDown(KeyCode.M)) { myState = States.neighborupstairs_01; } else if (Input.GetKeyDown(KeyCode.D)) { myState = States.neighborhouse_d; }
    }

    void Neighborgarage() {

        if (boolArray[1] == true) {
            text.text = ("You decide to see what's in the garage. You open the door to the garage and walk through. In the garage it is very dark. You can hear the sounds of leaking " +
                        "pipes and some sort of scratching noise. You can turn on your flashlight, search around in the dark, or open the garage door. What will you do?\n\n" +
                        "Press [F] to turn on the Flashlight, [S] to search in the dark, or [O] to Open the garage door.");
            if (Input.GetKeyDown(KeyCode.F)) { boolArray[6] = true; myState = States.neighborgarage_a; } else if (Input.GetKeyDown(KeyCode.S)) { myState = States.neighborgarage_b; } else if (Input.GetKeyDown(KeyCode.O)) { myState = States.neighborgarage_c; }
        } else {
            text.text = ("You decide to see what's in the garage. You open the door to the garage and walk through. In the garage it is very dark. You can hear the sounds of leaking " +
                        "pipes and some sort of scratching noise. You can search around in the dark or open the garage door. What will you do?\n\n" +
                        "Press [S] to search in the dark or [O] to Open the garage door.");
            if (Input.GetKeyDown(KeyCode.S)) { myState = States.neighborgarage_b; } else if (Input.GetKeyDown(KeyCode.O)) { myState = States.neighborgarage_c; }
        }
    }

    void Neighborgarage_a() { // Turn on the flashlight
        text.text = ("You take out your flashlight and turn it on. You start searching the back wall of the garage and come across a dark figure in the corner. It turns around and " +
                    "starts running at you. You throw the flashlight at its head and the zombie falls to the ground like a sack of potatoes. You quickly run over to the garage door and lift " +
                    "it up with your hands illuminating the garage with sunlight. You turn back around and the zombie is motionless on the floor. You cautiosly walk back to pick up your " +
                    "flashlight. Next to your flashlight on the ground is a pair of boots. You look down at your sandals and realize how underprepared you are for the zombie apocalypse. You grab " +
                    "the boots and your flashlight and leave the garage before the zombie wakes up.\n\n" +
                    "Press [SPACE] to continue...");
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.neighborhood_b; }
    }

    void Neighborgarage_b() { // Search in the dark
        text.text = ("You start searching the back wall of the garage in the dark. You come across a dark figure in the corner. It turns around and starts running at you. You grab " +
                    "some shelving next to you and throw it down on top of the zombie, pinning it to the ground. You quickly run over to the garage door and lift it up with your " +
                    "hands illuminating the garage with sunlight. You turn back around and the zombie is pinned and motionless on the floor. You turn and leave the garage before " +
                    "the zombie wakes up.\n\n" +
                    "Press [SPACE] to continue...");
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.neighborhood_b; }
    }

    void Neighborgarage_c() { // Open the garage door
        text.text = ("You walk over to the garage door and lift it up with your hands illuminating the garage with sunlight. You turn back around and see a zombie in the corner " +
                    "start running towards you. You grab some shelving next to you and throw it down on top of the zombie, pinning it to the ground. You turn and leave the garage " +
                    "before the zombie wakes up.\n\n" +
                    "Press [SPACE] to continue...");
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.neighborhood_b; }
    }

    #endregion
    #region City
    void City_a() {
        text.text = ("You get in your car, start the engine, and pull out of your driveway. You head in the direction of the city, oldies playing on " +
                    "the radio. The closer you get the darker and thicker the smoke gets. When you arrive the city is battered and torn like the aftermath " +
                    "of a hurricane. You pull down the main street towards downtown and immediately find a large group of zombies surrounding a crashed " +
                    "car. You try to swerve to avoid the wreckage and veer off into the railing on the left. Dazed and disoriented you unbuckle and can " +
                    "see the subway entrance out the driver door, and signs for downtown out the passenger door. You can search the glove box, go out the " +
                    "driver door, or go out the passenger door. What will you do?\n\n" +
                    "Press [S] to search the glovebox, [D] for the Driver door, and [P] for the passenger door.");
        if (Input.GetKeyDown(KeyCode.S)) { boolArray[0] = true; myState = States.city_b; } else if (Input.GetKeyDown(KeyCode.D)) { myState = States.subway; } else if (Input.GetKeyDown(KeyCode.P)) { myState = States.downtown_a; }
    }

    void City_b() { // Search the Glovebox
        text.text = ("You reach to open the glove box. Inside you find a gun, but before you can grab it the passenger window breaks and zombie hands reach for " +
                    "your brains. You reach for the gun and just barely escape a zombie's grip. You turn off the safety, cock the gun, aim for the zombies, " +
                    "and fire off a couple shots. The zombies falter backwards and topple over on the street, a couple of them dying off for good. You can see " +
                    "the subway entrance out of the driver door, and signes for downtown out the passenger door. What will you do?\n\n" +
                    "Press [D] to exit the Driver door or [P] to exit the passenger door.");
        if (Input.GetKeyDown(KeyCode.D)) { myState = States.subway; } else if (Input.GetKeyDown(KeyCode.P)) { myState = States.downtown_a; }
    }

    void Subway() {
        text.text = ("You exit the driver door and head towards the subway entrance. The large group of zombies in the street start chasing after you. " +
                    "You head down the stairs and into the subway terminal. the subway reeks of rotting flesh and death. The lights flicker and you can " +
                    "make out many zombies surrounding you. You can fight the zombie horde, try to escape up the stairs, or jump across the subway tracks. " +
                    "What will you do?\n\n" +
                    "Press [F] to Fight the zombies, [E] to Escape up the stairs, or [J] to Jump across the tracks.");
        if (Input.GetKeyDown(KeyCode.F)) { myState = States.subway_a; } else if (Input.GetKeyDown(KeyCode.E)) { myState = States.subway_b; } else if (Input.GetKeyDown(KeyCode.J)) { myState = States.subway_c; }
    }

    void Subway_a() { // Fight the zombies
        if (boolArray[0] == true && boolArray[1] == true) {
            text.text = ("You take out your gun and flashlight and go into a defensive shooting stance. You quickly let off a couple shots into the zombies closest " +
                        "to you, buying yourself a little more time. You can try to escape up the stairs or jump across the subway tracks. What will you do?\n\n" +
                        "Press [E] to Escape up the stairs or [J] to Jump across the tracks.");
            if (Input.GetKeyDown(KeyCode.E)) { myState = States.subway_b; } else if (Input.GetKeyDown(KeyCode.J)) { myState = States.subway_c; }
        } else if (boolArray[0] == false && boolArray[3] == true && boolArray[1] == true) {
            text.text = ("You take out your knife and flashlight and go into a defensive fighting stance. You quickly leap forward and strike at the couple zombies " +
                        "that are closest to you, buying yourself a little more time. You can try to escape up the stairs or jump across the subway tracks. What will " +
                        "you do?\n\n" +
                        "Press [E] to Escape up the stairs or [J] to Jump across the tracks.");
            if (Input.GetKeyDown(KeyCode.E)) { myState = States.subway_b; } else if (Input.GetKeyDown(KeyCode.J)) { myState = States.subway_c; }
        } else {
            text.text = ("You turn to face the zombies and get yourself into a fighting stance. You slowly scan the zombies closest to you, looking for a way out " +
                        "of this mess and realize that you might not make it out alive. The zombies leap forward to attack. You kick the first, punch the second, but " +
                        "then you feel one bite down on your shoulder. You scream in agony until everything eventually goes black...\n\n" +
                        "Press [SPACE] to continue...");
            if (Input.GetKeyDown(KeyCode.Space)) { myState = States.gameover; }
        }
    }

    void Subway_b() { // Try to escape up the stairs
        text.text = ("You turn and try to escape up the stairs. Before you reach the top another group of zombies starts running down the stairs trapping you in the subway. " +
                    "You see an opening between the zombies and attempt to run through, however a zombie grabs for you, scratching your neck. You get by and start running for " +
                    "your life, strong body aches and a fever coming on. The sickness is eventually too much for you to handle and you stumble to the floor, the zombies closing " +
                    "in behind you. You try to stand, but it's too late, the zombies grab at you and start biting into you. You scream in agony until everything goes black...\n\n " +
                    "Press [SPACE] to continue...");
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.gameover; }
    }

    void Subway_c() { // Jump across the subway tracks
        text.text = ("You turn and run towards the tracks, picking up as much speed as you can. You jump and easily clear the landing then make your way down a hallway with an " +
                    "'EXIT' sign above it. When you reach the end of the hallway you find a ladder that leads up to a sewer grate, and a door to a supply room. You can climb the " +
                    "ladder, open the supply room door, or turn around and head back. What will you do?\n\n" +
                    "Press [L] to climb the Ladder, [S] to open the Supply room, or [T] to Turn around and go back.");
        if (Input.GetKeyDown(KeyCode.L)) { myState = States.downtown_b; } else if (Input.GetKeyDown(KeyCode.S)) { myState = States.subway_01a; } else if (Input.GetKeyDown(KeyCode.T)) { myState = States.subway_01b; }
    }

    void Subway_01a() { // Open the supply room
        text.text = ("You try to open the supply room door, but it feels like something is holding the door shut from the other side. You try to kick it but it won't budge. Zombies " +
                    "start piling into the hallway behind you, trapping you in. You can only climb the ladder. What will you do?\n\n" +
                    "Press [L] to climb the Ladder.");
        if (Input.GetKeyDown(KeyCode.L)) { myState = States.downtown_b; }
    }

    void Subway_01b() { // Turn around and go back
        text.text = ("You turn around to go back, but before you can get out of the hallway the zombies come pouring in trapping you in. You can only climb the ladder. What will you " +
                    "do?\n\n" +
                    "Press [L] to climb the Ladder.");
        if (Input.GetKeyDown(KeyCode.L)) { myState = States.downtown_b; }
    }

    void Downtown_a() {
        text.text = ("You exit the passenger door and head down the main street towards downtown, the group of zombies in close pursuit. When you reach the downtown area you find a " +
                    "group of soldiers fighting with an outbreak of zombies. In front of you is the evacuation zone and behind you is the road out of town. You can hide until the " +
                    "fighting stops, fight with the soldiers, or leave town. What will you do?\n\n" +
                    "Press [H] to Hide until the fighting stops, [F] to Fight with the soldiers, or [L] to Leave town.");
        if (Input.GetKeyDown(KeyCode.H)) { myState = States.downtown_c; } else if (Input.GetKeyDown(KeyCode.F)) { myState = States.downtown_d; } else if (Input.GetKeyDown(KeyCode.L)) { myState = States.highway_b; }
    }

    void Downtown_b() {
        text.text = ("You climb up the ladder, narrowly escaping death. When you reach the sewer grate at the top you push it open slowly and peek around. Out on the street are " +
                    "soldiers fighting with an outbreak of zombies. You pull yourself up the rest of the way onto the street. In front of you is the evacuation zone and behind you " +
                    "is the road out of town. You can hide until the fighting stops, fight with the soldiers, or leave town. What will you do?\n\n" +
                    "Press [H] to Hide until the fighting stops, [F] to Fight with the soldiers, or [L] to Leave town.");
        if (Input.GetKeyDown(KeyCode.H)) { myState = States.downtown_c; } else if (Input.GetKeyDown(KeyCode.F)) { myState = States.downtown_d; } else if (Input.GetKeyDown(KeyCode.L)) { myState = States.highway_b; }
    }

    void Downtown_c() { // Hide until the fighting stops
        text.text = ("You duck down behind a totaled car and hope that no one saw you. You peek out to check and everyone is still busy trying to keep the zombies at bay. You sit " +
                    "back down and sigh. What a day! While you are busy with your thoughts a zombie notices you and starts creeping in your direction. When you look up it is on top " +
                    "of you and about to attack. Before it can grab you a loud shot rings out and the zombie slumps to the floor. A soldier comes running over and asks if you are " +
                    "okay. You stand to your feet and thank the soldier for saving your life. He then yells to make your way to the evacuation zone ahead while they cover you. You " +
                    "can head to the evacuation zone or leave town. What will you do?\n\n" +
                    "Press [E] to go to the Evacuation zone or [L] to Leave town.");
        if (Input.GetKeyDown(KeyCode.E)) { myState = States.evacuationzone_a; } else if (Input.GetKeyDown(KeyCode.L)) { myState = States.highway_b; }
    }

    void Downtown_d() { // Fight with the soldiers
        text.text = ("You look around and find an assault rifle on the street. You pick it up, check the clip, and then cock it. You start firing like crazy at the zombies, bullets " +
                    "tearing them apart. Your clip runs out and the gun just clicks in your hand. Close by a zombie notices you so you duck behind a car. When you look up it is on " +
                    "top of you and about to attack. Before it can grab you a loud shot rings out and the zombie slumps to the floor. A soldier comes running over and asks if you are " +
                    "okay. You stand to your feet and thank the soldier for saving your life. He then yells to make your way to the evacuation zone ahead while they cover you. You " +
                    "can head to the evacuation zone or leave town. What will you do?\n\n" +
                    "Press [E] to go to the Evacuation zone or [L] to Leave town.");
        if (Input.GetKeyDown(KeyCode.E)) { myState = States.evacuationzone_a; } else if (Input.GetKeyDown(KeyCode.L)) { myState = States.highway_b; }
    }

    void Evacuationzone_a() {
        text.text = ("You decide to do what the soldier says and head behind him towards the evacuation zone. When you get there soldiers in hazmat suits are processing the civilians " +
                    "upon arrival before entering the evacuation camp. You walk up to the first soldier and are given instructions to remove your clothing for inspection. You reluctantly " +
                    "comply and the hazmat team checks you over for bites and scratches. They then take a vial of your blood and a cotton swab of your mouth for testing, and send you on " +
                    "your way. Once in the evacuation camp you head towards the emergency transportation terminal to get on the first ride out of here!...\n\n" +
                    "Press [SPACE] to continue.");
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.evacuationzone_b; }
    }

    void Evacuationzone_b() {
        text.text = ("When you get to the emergency transportation terminal you find a large group of civilians being held back from entering the terminal by a battalion of soldiers. One " +
                    "of the soldiers is speaking into a megaphone and addressing the crowd. 'The emergency transportation terminal has been temporarily shut down and emergency extraction " +
                    "operations have been stopped. All civilians are to remain in the evacuation camp until further notice. Due to the zombie outbreak the city is being quarantined. Please " +
                    "remain calm and await further instructions.'\n\n" +
                    "Press [SPACE] to continue...");
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.evacuationzone_c; }
    }

    void Evacuationzone_c() {
        text.text = ("You quickly realize that your situation is looking bleak. You are stuck in the middle of downtown and being held against your will by soldiers quaranting the city. You " +
                    "probably should have left town while you still had the chance. Just then loud sirens start to sound and immediately all the soldiers go into a frenzy. You overhear a " +
                    "soldier yelling something about purging the outbreak, but he couldn't possibly mean before the civilians are evacuated...\n\n" +
                    "Press [SPACE] to continue...");
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.evacuationzone_d; }
    }

    void Evacuationzone_d() {
        text.text = ("Up in the sky a lone fighter jet screams over the city. The pilot, sitting comfortably in his cockpit, picks up his radio and says, 'This is Eagle 1-2, I have the target " +
                    "in site. I need confirmation for delivery, over.' Over the radio comes a deep voice stating, 'Eagle 1-2 this is Eagle Actual. You have go for delivery. I repeat you " +
                    "have go for delivery, over.' Then the pilot grabs the control stick, flips up a button cover, and presses a button. He then says, 'Confirmed Eagle Actual. Payload sent.'\n\n" +
                    "From down in the evacuation camp you can hear the fighter jet overhead. Shortly after it comes into view a missle is released that is aimed right for the city center!! You " +
                    "immediately start to panic and look around for shelter. You run into a bunker entrance right as a large explosion shakes the Earth around you. Everything goes white. Is this " +
                    "the end?...\n\n" +
                    "Press [SPACE] to continue...");
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.gameover; }
    }

    #endregion
    #region Highway
    void Highway_a() { // Drive out of town
        text.text = ("You get in your car, start the engine, and pull out of your driveway. You head in the direction of the highway, oldies playing on the radio. When you get to the " +
                    "highway you speed up and roll the windows down, wind blowing in your face. After a while of driving, the car starts to shake and sputter. Suddenly the engine dies and " +
                    "the car rolls to a stop down the street from an abandoned gas station. You get out of the car and slam the door. What horrible luck. You can walk to the gas station, " +
                    "walk back to town, or wait on the side of the road. What will you do?\n\n" +
                    "Press [G] to walk to the Gas station, [T] to walk back to Town, or [W] to Wait on the side of the road.");
        if (Input.GetKeyDown(KeyCode.G)) { myState = States.gasstation; } else if (Input.GetKeyDown(KeyCode.T)) { myState = States.highway_01; } else if (Input.GetKeyDown(KeyCode.W)) { myState = States.sewer_a; }
    }

    void Highway_b() { // Walk out of town
        text.text = ("When all of the soldiers are busy you duck behind a totaled car and then start heading up the street towards the highway. After a mile you hit the highway and start " +
                    "hiking to the next closest city. A couple miles down the road you find an abandoned gas station. You can walk to the gas station, walk back to town, or wait on the side " +
                    "of the road. What will you do?\n\n" +
                    "Press [G] to walk to the Gas station, [T] to walk back to Town, or [W] to Wait on the side of the road.");
        if (Input.GetKeyDown(KeyCode.G)) { myState = States.gasstation; } else if (Input.GetKeyDown(KeyCode.T)) { myState = States.highway_01; } else if (Input.GetKeyDown(KeyCode.W)) { myState = States.sewer_a; }
    }

    void Highway_01() { // Walk back to town
        text.text = ("You turn around and start hiking back into town. The sun starts to set and the temperature drops. A loud rustling noise from the bushes nearby break the silence and you " +
                    "immediately go on guard. A large group of zombies come pouring out of the bushes surrounding you on the road. You quickly look around, scanning your immediate environment " +
                    "and start to formulate a plan. You can fight the group of zombies or you can try to run away. What will you do?\n\n" +
                    "Press [F] to Fight the zombies or [R] to try to Run away.");
        if (Input.GetKeyDown(KeyCode.F)) { myState = States.highway_01a; } else if (Input.GetKeyDown(KeyCode.R)) { myState = States.highway_01b; }
    }

    void Highway_01a() { // Fight
        text.text = ("You decide there isn't any escape and that you must fight your way to safety. The zombies rush at you, leaving you little time to react. You manuever yourself around the " +
                    "first couple zombies, careful not to get scratched, and then kick one down from behind, causing the others to stumble. The next couple zombies start to approach you once " +
                    "again try to manuever around them. This time, however, you are not so fortunate to get by unscathed. A zombie scratches you down your back while trying to grab you, and you " +
                    "fall to the ground in pain. You feel a fever spreading throughout your body and try to get back up, but stumble. Soon, everything goes black...\n\n" +
                    "Press [SPACE] to continue.");
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.gameover; }
    }

    void Highway_01b() { // Run
        text.text = ("You decide you must escape and make your way to safety. The zombies rush at you, leaving you little time to react. You manuever yourself around the first couple zombies, " +
                    "careful not to get scratched, and then kick one down from behind, causing the others to stumble. The next couple zombies start to approach you once again try to manuever " +
                    "around them. This time, however, you are not so fortunate to get by unscathed. A zombie scratches you down your back while trying to grab you, and you fall to the ground " +
                    "in pain. You feel a fever spreading throughout your body and try to get back up, but stumble. Soon, everything goes black...\n\n" +
                    "Press [SPACE] to continue.");
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.gameover; }
    }

    void Sewer_a() { // Wait on the side of the road
        foreach (bool b in boolArray) {
            if (b) {
                Secret = true;
                break;
            } else {
                Secret = false;
            }
        }
        Debug.Log(Secret ? "true" : "false");

        // Check player inventory for all required items to proceed to secret ending
        if (Secret) {
                text.text = ("You decide the gas station is too sketchy, and walking back into town would be a waste of time, so you sit down on the side of the road. Up and down the highway in both " +
                        "directions the road is empty, except for the occasional tumbleweed. Just then you hear the sound of a helicopter growing in the distance. A few moments later a black " +
                        "helicopter comes into sight flying low overhead. The helicopter slows and touches down on the other side of a hill, just out of sight. At the bottom of the hill is a " +
                        "sewer access tunnel surrounded by chain-linked fence with barbed wire on top. You walk up to the sewer access door and find a keypad with a red light. You pull out the " +
                        "note you found in your neighbor's house and find the sewer access code. You enter the code, 5-6-1-3-2... The red light turns green and you hear the door unlock. You slowly " +
                        "step inside the sewer tunnel. You pull out your flashlight and gun and cautiously walk towards the end of the tunnel...\n\n" +
                        "Press [SPACE] to continue...");
                if (Input.GetKeyDown(KeyCode.Space)) { myState = States.sewer_b; }
        } else {
            text.text = ("You decide the gas station is too sketchy, and walking back into town would be a waste of time, so you sit down on the side of the road. Up and down the highway in both " +
                        "directions the road is empty, except for the occasional tumbleweed. Just then you hear the sound of a helicopter growing in the distance. A few moments later a black " +
                        "helicopter comes into sight flying low overhead. The helicopter slows and touches down on the other side of a hill, just out of sight. At the bottom of the hill is a " +
                        "sewer access tunnel surrounded by a chain-linked fence. You walk up to the sewer access door and find a keypad with a red light. You try to punch in some numbers, but nothing " +
                        "happens. You walk back up to the road and look around. You can walk to the gas station or walk back into town. What will you do?\n\n" +
                        "Press [G] to walk to the Gas station or [T] to walk back to Town.");
            if (Input.GetKeyDown(KeyCode.G)) { myState = States.gasstation; } else if (Input.GetKeyDown(KeyCode.R)) { myState = States.highway_01; }
        }
    }

    void Sewer_b() { // Sewer
        text.text = ("As you get closer to the back of the sewer access tunnel you start to see light creeping in from an exit a little further up. When you get to the end of the tunnel you " +
                    "find the access door open and a private helicopterpad where sure enough the black helicopter has landed for refueling. You look around and find the pilot busy working on " +
                    "fueling the chopper. This is it, your chance to get to safety. You put the flashlight and gun away in your backpack, and step out into the open of the landing pad...\n\n" +
                    "Press [SPACE] to continue...");
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.helicopterpad; }
    }

    void Gasstation() { // Gas station
        text.text = ("You start walking towards gas station as the sun starts to set. A loud rustling noise from the bushes nearby break the silence and you immediately go on guard. A large " +
                    "group of zombies come pouring out of the bushes surrounding you on the road. You quickly look around, scanning your immediate environment and start to formulate a plan. " +
                    "You can fight the group of zombies or you can try to run away. What will you do?\n\n" +
                    "Press [F] to Fight the zombies or [R] to try to Run away.");
        if (Input.GetKeyDown(KeyCode.F)) { myState = States.highway_01a; } else if (Input.GetKeyDown(KeyCode.R)) { myState = States.highway_01b; }
    }

    void Helicopterpad() { // Helicopter pad
        text.text = ("As you are walking up the pilot notices you and immediately pulls out a gun and aims it right at you. 'Don't come any closer or I'll shoot!' he shouts. You put your hands up to show " +
                    "that you mean no threat to the pilot and say, 'Please help me. I'm not one of those... things.' The pilot looks you over cautiously and then slowly lowers his weapon and gets into the helicopter. " +
                    "'Hurry and get in. We need to get to the...' he shouts under the noise of the helicopter blades, but before he can finish a group of zombies emerges from the sewers and begins running towards you. " +
                    "You run and jump into the helicopter right as it lifts off the ground. You hold on for your life as the helicopter floats into the sky, the zombies narrowly missing their chance to feast...\n\n" +
                    "Press [SPACE] to continue...");
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.sky; }
    }

    void Sky() { // Sky
        text.text = ("Up in the sky you sit down in one of the cargo seats, buckle in, and start to relax a bit. You close your eyes and think about your friends and family, hoping that they too " +
                    "were able to find a way to safety. What will you do now, and where will you go? Have any other cities been attacked? Will there be anywhere that is safe from this threat? You " +
                    "open your eyes and look around at the sun setting around you, the crimson rays painting the clouds in the sky. For today, you have survived the threat, but what will tomorrow bring?\n\n" +
                    "Press [SPACE] to continue...");
        if (Input.GetKeyDown(KeyCode.Space)) { myState = States.win; }
    }

    #endregion
}
