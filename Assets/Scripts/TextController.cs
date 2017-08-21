using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {menu, livingroom, livingroom_01, livingroom_02, livingroom_03, livingroom_04a, livingroom_04b, livingroom_05,
						livingroom_06a, livingroom_06b, livingroom_07a, livingroom_07b, livingroom_07c, livingroom_08, livingroom_09,
						livingroom_10a, livingroom_10b, livingroom_10c, attic, attic_01, attic_02a, attic_02b, attic_03a, attic_03b, attic_04a,
						attic_04b, attic_05a, attic_05b, attic_05c, attic_06a, attic_06b, kitchen_a, kitchen_b, kitchen_01a, kitchen_01b,
						kitchen_01c, kitchen_01d, kitchen_02a, kitchen_02b, kitchen_02c, kitchen_02d, neighborhood_a, neighborhood_b,
						neighborhood_c, neighbor, neighborleft, neighborright, neighborfront, neighborfront_01a, neighborfront_01b,
						neighborfront_01c, neighborfront_02a, neighborfront_02b, neighborfront_03a, neighborfront_03b, neighborfront_04a,
						neighborfront_04b, neighborfront_05a, neighborfront_05b, neighborfront_05c, neighborhouse_a, neighborhouse_b, neighborhouse_c,
						neighborhouse_d, neighborupstairs, neighborupstairs_a, neighborupstairs_b, neighborupstairs_c, neighborupstairs_01, neighborupstairs_02,
						neighborgarage, neighborgarage_a, neighborgarage_b, neighborgarage_c, city_a, city_b, subway, highway, sewer_a, sewer_b, gasstation,
						downtown, evacuationzone, helicopterpad, gameover, thankyou};
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


	// Use this for initialization
	void Start () {
		myState = States.menu;
		Flashlight = false;
		Backpack = false;
		Knife = false;
		Direction = false;
		Code = false;
		Medicine = false;
		Medkit = false;
		Boots = false;
		Gun = false;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		#region Menus
		if 		(myState == States.menu)					{menu ();}
		else if (myState == States.gameover) 				{gameover ();}
		else if (myState == States.thankyou) 				{thankyou ();}
		#endregion
		#region LivingRoom
		else if (myState == States.livingroom) 				{livingroom ();}
		else if (myState == States.livingroom_01) 			{livingroom_01 ();}
		else if (myState == States.livingroom_02) 			{livingroom_02 ();}
		else if (myState == States.livingroom_03)			{livingroom_03 ();}
		else if (myState == States.livingroom_04a) 			{livingroom_04a ();}
		else if (myState == States.livingroom_04b) 			{livingroom_04b ();}
		else if (myState == States.livingroom_05) 			{livingroom_05 ();}
		else if (myState == States.livingroom_06a) 			{livingroom_06a ();}
		else if (myState == States.livingroom_06b) 			{livingroom_06b ();}
		else if (myState == States.livingroom_07a)			{livingroom_07a ();}
		else if (myState == States.livingroom_07b) 			{livingroom_07b ();}
		else if (myState == States.livingroom_07c) 			{livingroom_07c ();}
		else if (myState == States.livingroom_08) 			{livingroom_08 ();}
		else if (myState == States.livingroom_09) 			{livingroom_09 ();}
		else if (myState == States.livingroom_10a) 			{livingroom_10a ();}
		else if (myState == States.livingroom_10b) 			{livingroom_10b ();}
		else if (myState == States.livingroom_10c) 			{livingroom_10c ();}
		#endregion
		#region Attic
		else if (myState == States.attic) 					{attic ();}
		else if (myState == States.attic_01) 				{attic_01 ();}
		else if (myState == States.attic_02a) 				{attic_02a ();}
		else if (myState == States.attic_02b) 				{attic_02b ();}
		else if (myState == States.attic_03a) 				{attic_03a ();}
		else if (myState == States.attic_03b) 				{attic_03b ();}
		else if (myState == States.attic_04a) 				{attic_04a ();}
		else if (myState == States.attic_04b) 				{attic_04b ();}
		else if (myState == States.attic_05a) 				{attic_05a ();}
		else if (myState == States.attic_05b) 				{attic_05b ();}
		else if (myState == States.attic_05c) 				{attic_05c ();}
		else if (myState == States.attic_06a) 				{attic_06a ();}
		else if (myState == States.attic_06b) 				{attic_06b ();}
		#endregion
		#region Kitchen
		else if (myState == States.kitchen_a) 				{kitchen_a ();}
		else if (myState == States.kitchen_b) 				{kitchen_b ();}
		else if (myState == States.kitchen_01a) 			{kitchen_01a ();}
		else if (myState == States.kitchen_01b) 			{kitchen_01b ();}
		else if (myState == States.kitchen_01c) 			{kitchen_01c ();}
		else if (myState == States.kitchen_01d) 			{kitchen_01d ();}
		else if (myState == States.kitchen_02a) 			{kitchen_02a ();}
		else if (myState == States.kitchen_02b) 			{kitchen_02b ();}
		else if (myState == States.kitchen_02c) 			{kitchen_02c ();}
		else if (myState == States.kitchen_02d) 			{kitchen_02d ();}
		#endregion
		#region Neighborhood
		else if (myState == States.neighborhood_a) 			{neighborhood_a ();}
		else if (myState == States.neighborhood_b) 			{neighborhood_b ();}
		else if (myState == States.neighborhood_c)			{neighborhood_c ();}
		else if (myState == States.neighbor) 				{neighbor ();}
		else if (myState == States.neighborleft) 			{neighborleft ();}
		else if (myState == States.neighborright) 			{neighborright ();}
		else if (myState == States.neighborfront_01a) 		{neighborfront_01a ();}
		else if (myState == States.neighborfront_01b) 		{neighborfront_01b ();}
		else if (myState == States.neighborfront_01c) 		{neighborfront_01c ();}
		else if (myState == States.neighborfront_02a) 		{neighborfront_02a ();}
		else if (myState == States.neighborfront_02b) 		{neighborfront_02b ();}
		else if (myState == States.neighborfront_03a) 		{neighborfront_03a ();}
		else if (myState == States.neighborfront_03b) 		{neighborfront_03b ();}
		else if (myState == States.neighborfront_04a) 		{neighborfront_04a ();}
		else if (myState == States.neighborfront_04b) 		{neighborfront_04b ();}
		else if (myState == States.neighborfront_05a) 		{neighborfront_05a ();}
		else if (myState == States.neighborfront_05b) 		{neighborfront_05b ();}
		else if (myState == States.neighborfront_05c) 		{neighborfront_05c ();}
		else if (myState == States.neighborhouse_a) 		{neighborhouse_a ();}
		else if (myState == States.neighborhouse_b) 		{neighborhouse_b ();}
		else if (myState == States.neighborhouse_c) 		{neighborhouse_c ();}
		else if (myState == States.neighborhouse_d) 		{neighborhouse_d ();}
		else if (myState == States.neighborupstairs) 		{neighborupstairs ();}
		else if (myState == States.neighborupstairs_a) 		{neighborupstairs_a ();}
		else if (myState == States.neighborupstairs_b) 		{neighborupstairs_b ();}
		else if (myState == States.neighborupstairs_c) 		{neighborupstairs_c ();}
		else if (myState == States.neighborupstairs_01) 	{neighborupstairs_01 ();}
		else if (myState == States.neighborupstairs_02) 	{neighborupstairs_02 ();}
		else if (myState == States.neighborgarage) 			{neighborgarage ();}
		else if (myState == States.neighborgarage_a) 		{neighborgarage_a ();}
		else if (myState == States.neighborgarage_b) 		{neighborgarage_b ();}
		else if (myState == States.neighborgarage_c) 		{neighborgarage_c ();}
		#endregion
		#region City
		else if (myState == States.city_a) 					{city_a ();}
		else if (myState == States.city_b) 					{city_b ();}
		else if (myState == States.subway)					{subway ();}
		else if (myState == States.downtown) 				{downtown ();}
		else if (myState == States.evacuationzone)			{evacuationzone ();}
		#endregion
		#region Highway
		else if (myState == States.highway) 				{highway ();}
		else if (myState == States.sewer_a) 				{sewer_a ();}
		else if (myState == States.sewer_b) 				{sewer_b ();}
		else if (myState == States.gasstation) 				{gasstation ();}
		else if (myState == States.helicopterpad) 			{helicopterpad ();}
		#endregion
	}

	// Functions

	#region Menus
	void menu () {
		text.text = ("\n\n\n\t\t\t\t\t\t\t\t\t\tPRESS ENTER TO START GAME \n\n\n\n\n\n\n" +          
        			"\t\t\t\t\t\t   © 2017 ImagiTech Studios, LLC. All Rights Reserved.");
		if 		(Input.GetKeyDown (KeyCode.Return)) 		{myState = States.livingroom;}
	}

	void gameover () {
		text.text = ("\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tGAME OVER\n\n\n" +
					"\t\t\t\t\t\t\t\t\t\t\t\t\t\t   Try Again?\n\n\n" +
					"\t\t\t\t\t\t\t\t\t\t\tPress [Y] for Yes or [N] for No.");
		if 		(Input.GetKeyDown(KeyCode.Y)) 				{myState = States.menu;}
		else if (Input.GetKeyDown(KeyCode.N)) 				{myState = States.thankyou;}
	}

	void thankyou () {
		text.text = ("\n\t\t\t\t\t\tA BIG SPECIAL THANK YOU FOR PLAYING THE GAME!!\n\n" +
					"\t\t\t\t\t\t\t\t\t  WE HOPE YOU ENJOYED PLAYING!!\n\n\n" +
					"\t\t\t\t\t\t\t\t\t\t\t\t\t  Press SPACE to exit...\n\n\n" +
					"\t\t\t\t\t  For more of our games please visit www.imagitechstudios.com");
		if 		(Input.GetKeyDown(KeyCode.Space))			Application.Quit();
	}

	#endregion
	#region LivingRoom
	void livingroom () {
		text.text = ("The morning started off just like any other… well almost.\n\n " +
					"You awoke on your couch in the middle of your dimly lit living room. The curtains " +
					"were still drawn from last night's video game binge session, a sliver of light peeking " +
					"through their cracks. The only notable items in the room are a half-eaten pizza, a 2-liter " +
					"of root beer, an XBOX controller, and a TV remote lying on the coffee table in front of " +
					"you. What do you want to do?\n\n" +
					"Press [P] for Pizza, [R] for Root beer, [X] for Xbox controller, or [T] for TV remote.");
		if 		(Input.GetKeyDown (KeyCode.P)) 				{myState = States.livingroom_01;}
		else if (Input.GetKeyDown(KeyCode.R)) 				{myState = States.livingroom_02;}
		else if (Input.GetKeyDown(KeyCode.X)) 				{myState = States.livingroom_03;}
		else if (Input.GetKeyDown(KeyCode.T)) 				{myState = States.livingroom_08;}
	}

	void livingroom_01 () {
		text.text = ("That old pizza sure looks tasty. You eat the leftover pizza. Your stomach rumbles and you let " +
					"out a big fart!!...\n\nThe only notable items left in the room are a 2-liter of root beer, " +
					"an XBOX controller, and a TV remote lying on the coffee table in front of you. What do you " +
					"want to do?\n\nPress [R] for Root beer, [X] for Xbox controller, or [T] for TV remote.");
		if 		(Input.GetKeyDown(KeyCode.R)) 				{myState = States.livingroom_04a;}
		else if (Input.GetKeyDown(KeyCode.X)) 				{myState = States.livingroom_05;}
		else if (Input.GetKeyDown(KeyCode.T)) 				{myState = States.livingroom_08;}
	}

	void livingroom_02 () {
		text.text = ("That root beer sure looks refreshing. You drink the root beer. Your stomach rumbles " +
					"and you let out a big burp!!...\n\nThe only notable items left in the room are a half-eaten " +
					"pizza, an XBOX controller, and a TV remote lying on the coffee table in front of you. " +
					"What do you want to do?\n\nPress [P] for Pizza, [X] for Xbox controller, or [T] for TV remote.");
		if 		(Input.GetKeyDown(KeyCode.P)) 				{myState = States.livingroom_04b;}
		else if (Input.GetKeyDown(KeyCode.X)) 				{myState = States.livingroom_06a;}
		else if (Input.GetKeyDown(KeyCode.T)) 				{myState = States.livingroom_08;}
	}

	void livingroom_03 () {
		text.text = ("You didn't get enough game time last night so you pick up the XBOX controller " +
					"and play for a bit. You soon get bored and put the XBOX controller back down.\n\nThe only " +
					"notable items left in the room are a half-eaten pizza, a 2-liter of root beer, " +
					"and a TV remote lying on the coffee table in front of you. What do you want to do?\n\n" +
					"Press [P] for Pizza, [R] for Root beer, or [T] for TV remote.");
		if 		(Input.GetKeyDown(KeyCode.P)) 				{myState = States.livingroom_05;}
		else if (Input.GetKeyDown(KeyCode.R)) 				{myState = States.livingroom_06b;}
		else if (Input.GetKeyDown(KeyCode.T))				{myState = States.livingroom_08;}
	}

	void livingroom_04a () {
		text.text = ("That root beer sure looks refreshing. You drink the root beer. Your stomach rumbles " +
					"and you let out a big burp!!...\n\nThe only notable items left in the room are an XBOX " +
					"controller and a TV remote lying on the coffee table in front of you. What do you want to do?\n\n" +
					"Press [X] for Xbox controller, or [T] for TV remote.");
		if 		(Input.GetKeyDown(KeyCode.X)) 				{myState = States.livingroom_07c;}
		else if (Input.GetKeyDown(KeyCode.T)) 				{myState = States.livingroom_08;}
	}

	void livingroom_04b () {
		text.text = ("That old pizza sure looks tasty. You eat the leftover pizza. Your stomach rumbles and you let " +
					"out a big fart!!...\n\nThe only notable items left in the room are an XBOX " +
					"controller and a TV remote lying on the coffee table in front of you. What do you want to do?\n\n" +
					"Press [X] for Xbox controller, or [T] for TV remote.");
		if 		(Input.GetKeyDown(KeyCode.X)) 				{myState = States.livingroom_07c;}
		else if (Input.GetKeyDown(KeyCode.T)) 				{myState = States.livingroom_08;}
	}

	void livingroom_05 () {
		text.text = ("That old pizza sure looks tasty. You eat the leftover pizza. Your stomach rumbles and you let " +
					"out a big fart!!...\n\nThe only notable items in the room are a 2-liter of root beer and a TV " +
					"remote lying on the coffee table in front of you. What do you want to do?\n\nPress [R] for Root " +
					"beer or [T] for TV remote.");
		if 		(Input.GetKeyDown(KeyCode.R)) 				{myState = States.livingroom_07b;}
		else if (Input.GetKeyDown(KeyCode.T))				{myState = States.livingroom_08;}
	}

	void livingroom_06a () {
		text.text = ("You didn't get enough game time last night so you pick up the XBOX controller and play for a bit. " +
					"You soon get bored and put the XBOX controller back down.\n\nThe only notable items in the room are " +
					"a half-eaten pizza and a TV remote lying on the coffee table in front of you. What do you want to do?\n\n" +
					"Press [P] for Pizza or [T] for TV remote.");
		if 		(Input.GetKeyDown(KeyCode.P)) 				{myState = States.livingroom_07a;}
		else if (Input.GetKeyDown(KeyCode.T)) 				{myState = States.livingroom_08;}
	}

	void livingroom_06b () {
		text.text = ("That root beer sure looks refreshing. You drink the root beer. Your stomach rumbles and you let out a " +
					"big burp!!...\n\nThe only notable items left in the room are a half-eaten pizza and a TV remote lying " +
					"on the coffee table in front of you. What do you want to do?\n\nPress [P] for Pizza or [T] for TV remote.");
		if 		(Input.GetKeyDown(KeyCode.P)) 				{myState = States.livingroom_07a;}
		else if (Input.GetKeyDown(KeyCode.T)) 				{myState = States.livingroom_08;}
	}

	void livingroom_07a () {
		text.text = ("That old, stale pizza sure looks tasty. You eat the leftover pizza. Your stomach rumbles and you let " +
					"out a big fart!!...\n\nThe only notable item left in the room is a TV remote lying on the coffee " +
					"table in front of you. What do you want to do?\n\nPress [T] for TV remote.");
		if 		(Input.GetKeyDown(KeyCode.T)) 				{myState = States.livingroom_08;}
	}

	void livingroom_07b () {
		text.text = ("That root beer sure looks refreshing. You drink the root beer. Your stomach rumbles " +
					"and you let out a big burp!!...\n\nThe only notable item left in the room is a TV " +
					"remote lying on the coffee table in front of you. What do you want to do?\n\nPress " +
					"[T] for TV remote.");
		if 		(Input.GetKeyDown(KeyCode.T)) 				{myState = States.livingroom_08;}
	}

	void livingroom_07c () {
		text.text = ("You didn't get enough game time last night. You pick up the XBOX controller " +
					"and play for a bit. You get bored and put the XBOX controller down.\n\nThe only " +
					"notable item left in the room is a TV remote lying on the coffee table in front of " +
					"you. What do you want to do?\n\nPress [T] for TV remote.");
		if 		(Input.GetKeyDown(KeyCode.T)) 				{myState = States.livingroom_08;}
	}

	void livingroom_08 () {
		text.text = ("You pick up the TV remote and change the channel to watch anime. As you're watching an " +
					"emergency news broadcast interupts your show. 'This is an emergency announcement!... " +
					"Zombies have taken over the city... I repeat... Zombies... Yes, zombies... have taken " +
					"over the city... All citizens are advised to... and stay calm... gather your loved ones... " +
					"and head to the evacuation zone in downtown... Soldiers... assist you to safety. Get out " +
					"while you still can!!'\n\nPress SPACE to continue.");
		if 		(Input.GetKeyDown(KeyCode.Space)) 			{myState = States.livingroom_09;} 
	}

	void livingroom_09 () {
		text.text = ("Suddenly the power goes out and the television shuts off. You jump to your feet, everything in the" +
					"house eerily quiet around you. Zombie apocalypse you think?! You better get to safety before its too " +
					"late!! But first maybe you should check for supplies.\n\nYou can go upstairs to the attic, into the " +
					"kitchen, or leave the house. What will you do?\n\nPress [A] to check the Attic, [K] to check the Kitchen, " +
					"or [L] to Leave the house.");
		if 		(Input.GetKeyDown(KeyCode.A)) 				{myState = States.attic;}
		else if (Input.GetKeyDown(KeyCode.K)) 				{myState = States.kitchen_a;}
		else if (Input.GetKeyDown(KeyCode.L)) 				{myState = States.neighborhood_a;} 
	}

	void livingroom_10a () { // After Attic
		text.text = ("You went back to the living room. You can go into the kitchen or leave the house. What will you do?\n\n" +
					"Press [K] to check the Kitchen, or [L] to Leave the house.");
		if 		(Input.GetKeyDown(KeyCode.K)) 				{myState = States.kitchen_b;}
		else if (Input.GetKeyDown(KeyCode.L)) 				{myState = States.neighborhood_a;} 
	}

	void livingroom_10b () { // After Kitchen
		text.text = ("You went back to the living room. You can go upstairs to the attic or leave the house. What will you do?\n\n" +
					"Press [A] to check the Attic, or [L] to Leave the house.");
		if 		(Input.GetKeyDown(KeyCode.A)) 				{myState = States.attic_01;}
		else if (Input.GetKeyDown(KeyCode.L)) 				{myState = States.neighborhood_a;}
	}

	void livingroom_10c () { // After Attic and Kitchen 
		text.text = ("You went back to the living room. What will you do?\n\nPress [L] to Leave the house.");
		if 		(Input.GetKeyDown(KeyCode.A)) 				{myState = States.attic;}
		else if (Input.GetKeyDown(KeyCode.L)) 				{myState = States.neighborhood_a;}
	}
	#endregion
	#region Attic
	void attic () { //Before Kitchen
		text.text = ("You decide to go upstairs to the attic to look for supplies. You find the hideaway stairs to the attic " +
					"already pulled down and get a bad feeling. Will you continue on?\n\nPress [C] to Continue up to the attic or " +
					"[B] to go Back.");
		if 		(Input.GetKeyDown(KeyCode.C)) 				{myState = States.attic_02a;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.livingroom_10a;}
	}

	void attic_01 () { // After Kitchen
		text.text = ("You decide to go upstairs to the attic to look for supplies. You find the hideaway stairs to the attic " +
					"already pulled down and get a bad feeling. Will you continue on?\n\nPress [C] to Continue up to the attic or " +
					"[B] to go Back.");
		if 		(Input.GetKeyDown(KeyCode.C)) 				{myState = States.attic_02b;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.livingroom_10c;}
	}

	void attic_02a () { // Before Kitchen
		text.text = ("You continue up to the attic to look for supplies. The attic is dark and dusty causing you to cough. " +
					"Without warning the attic creaks from the back corner! You stand perfectly still without breathing and " +
					"listen. Nothing? Maybe just your imagination? You can walk forward, inspect the floor around you, or go " +
					"back.\n\nPress [W] to Walk forward, [I] to Inspect the floor, or [B] to go Back.");
		if 		(Input.GetKeyDown(KeyCode.W)) 				{Flashlight = true; myState = States.attic_03a;}
		else if (Input.GetKeyDown(KeyCode.I)) 				{Flashlight = true; myState = States.attic_04a;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.livingroom_10a;}
	}

	void attic_02b () { // After Kitchen
		text.text = ("You continue up to the attic to look for supplies. The attic is dark and dusty causing you to cough. " +
					"Without warning the attic creaks from the back corner! You stand perfectly still without breathing and " +
					"listen. Nothing? Maybe just your imagination? You can walk forward, inspect the floor around you, or go " +
					"back.\n\nPress [W] to Walk forward, [I] to Inspect the floor, or [B] to go Back.");
		if 		(Input.GetKeyDown(KeyCode.W)) 				{Flashlight = true; myState = States.attic_03b;}
		else if (Input.GetKeyDown(KeyCode.I)) 				{Flashlight = true; myState = States.attic_04b;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.livingroom_10c;}
	}

	void attic_03a () { // Before Kitchen
		text.text = ("You walk forward into the dark and kick something with your foot. You slowly bend down and feel around until " +
					"your hand finds a round object. You pick it up. It's a flashlight! You can turn on the flashlight, feel around " +
					"in the dark some more, or go back downstairs. What will you do?\n\nPress [T] to Turn on flashlight, [F] to feel " +
					"around in the dark, or [B] to go Back downstairs.");
		if 		(Input.GetKeyDown(KeyCode.T)) 				{myState = States.attic_05a;}
		else if (Input.GetKeyDown(KeyCode.F)) 				{Backpack = true; myState = States.attic_06a;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.livingroom_10a;}
	}

	void attic_03b () { // After Kitchen
		text.text = ("You walk forward into the dark and kick something with your foot. You slowly bend down and feel around until " +
					"your hand finds a round object. You pick it up. It's a flashlight! You can turn on the flashlight, feel around " +
					"in the dark some more, or go back downstairs. What will you do?\n\nPress [T] to Turn on flashlight, [F] to feel " +
					"around in the dark, or [B] to go Back downstairs.");
		if 		(Input.GetKeyDown(KeyCode.T)) 				{myState = States.attic_05b;}
		else if (Input.GetKeyDown(KeyCode.F)) 				{Backpack = true; myState = States.attic_06b;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.livingroom_10c;}
	}

	void attic_04a () { // Before Kitchen
		text.text = ("You reach down and inspect the floor until eventually your hand finds a round object. You pick it up. It's a " +
					"flashlight! You can turn on the flashlight, feel around in the dark some more, or go back downstairs. What will " +
					"you do?\n\nPress [T] to Turn on flashlight, [F] to feel around in the dark, or [B] to go Back downstairs.");
		if 		(Input.GetKeyDown(KeyCode.T)) 				{myState = States.attic_05a;}
		else if (Input.GetKeyDown(KeyCode.F)) 				{Backpack = true; myState = States.attic_06a;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.livingroom_10a;}
	}

	void attic_04b () { // After Kitchen
		text.text = ("You reach down and inspect the floor until eventually your hand finds a round object. You pick it up. It's a " +
					"flashlight! You can turn on the flashlight, feel around in the dark some more, or go back downstairs. What will " +
					"you do?\n\nPress [T] to Turn on flashlight, [F] to feel around in the dark, or [B] to go Back downstairs.");
		if 		(Input.GetKeyDown(KeyCode.T)) 				{if (Knife == true) {myState = States.attic_05c;}
															else {myState = States.attic_05b;}}
		else if (Input.GetKeyDown(KeyCode.F)) 				{Backpack = true; myState = States.attic_06b;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.livingroom_10a;}
	}

	void attic_05a () { // Before Kitchen
		text.text = ("You turn on the flashlight and right in front of you is a zombie! You try to back up and trip over a loose " +
					"floorboard dropping the flashlight on the floor. The zombie falls on top of you biting and scratching for your brains. You struggle, trying to throw the " +
					"zombie off of you, but eventually he gets a good bite in and you scream before everything goes black...\n\nPress [SPACE] " +
					"to continue...");
		if 		(Input.GetKeyDown(KeyCode.Space)) 				{myState = States.gameover;}
	}

	void attic_05b () { // After Kitchen without Knife
		text.text = ("You turn on the flashlight and right in front of you is a zombie! You try to back up and trip over a loose " +
					"floorboard dropping the flashlight on the floor. The zombie falls on top of you biting and scratching for your brains. You struggle, trying to throw the " +
					"zombie off of you, but eventually he gets a good bite in and you scream before everything goes black.\n\nPress SPACE " +
					"to continue...");
		if 		(Input.GetKeyDown(KeyCode.Space)) 				{myState = States.gameover;}
	}

	void attic_05c () { // After Kitchen with Knife
		text.text = ("You turn on the flashlight and right in front of you is a zombie! You try to back up and trip over a loose " +
					"floorboard, dropping the knife and flashlight on the floor. The zombie falls on top of you biting and scratching " +
					"for your brains. You struggle, trying to throw the zombie off of you. You reach around on the floor while holding " +
					"the zombie at bay and feel the knife so you pick it up. You attack over and over with the knife and the zombie " +
					"eventually stops moving. You push the zombie off and climb to your feet. You pick up the flashlight and leave the " +
					"attic.\n\nPress SPACE to continue.");
		if 		(Input.GetKeyDown(KeyCode.Space)) 				{myState = States.livingroom_10c;}
	}

	void attic_06a () { // Before Kitchen
		text.text = ("You walk slowly, feeling around in the dark some more, until you find a coat hangar with a backpack on it! You throw " +
					"the backpack on your back. You can turn on the flashlight or go back downstairs. What will you do?\n\nPress [T] to Turn " +
					"on the flashlight or [B] to go Back downstairs.");
		if 		(Input.GetKeyDown(KeyCode.T)) 				{myState = States.attic_05a;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.livingroom_10a;}
	}

	void attic_06b () { // After Kitchen
		text.text = ("You walk slowly, feeling around in the dark some more, until you find a coat hangar with a backpack on it! You throw " +
					"the backpack on your back. You can turn on the flashlight or go back downstairs. What will you do?\n\nPress [T] to Turn " +
					"on the flashlight or [B] to go Back downstairs.");
		if 		(Input.GetKeyDown(KeyCode.T)) 				{if (Knife == true) {myState = States.attic_05c;}
															else {myState = States.attic_05b;}}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.livingroom_10c;}
	}
	#endregion
	#region Kitchen
	void kitchen_a () { // Before Attic
		text.text = ("You decide to go into the kitchen to look for supplies. In the kitchen you find blood smeared on the " +
					"outside of the kitchen window. You look out, but don't see anything. you look at the back door. Still " +
					"locked. Around the kitchen nothing really stands out. You can inspect the drawers, open the refrigerator, " +
					"leave out the back door, or go back to the living room. What will you do?\n\nPress [I] to Inspect the drawers, " +
					"[O] to Open the refrigerator, [L] to Leave out the back door, or [B] to go Back.");
		if 		(Input.GetKeyDown(KeyCode.I)) 				{Knife = true; myState = States.kitchen_01a;}
		else if (Input.GetKeyDown(KeyCode.O)) 				{myState = States.kitchen_02a;}
		else if (Input.GetKeyDown(KeyCode.L)) 				{myState = States.neighborhood_a;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.livingroom_10b;}
	}

	void kitchen_b () { // After Attic
		text.text = ("You decide to go into the kitchen to look for supplies. In the kitchen you find blood smeared on the " +
					"outside of the kitchen window. You look out, but don't see anything. you look at the back door. Still " +
					"locked. Around the kitchen nothing really stands out. You can inspect the drawers, open the refrigerator, " +
					"leave out the back door, or go back to the living room. What will you do?\n\nPress [I] to Inspect the drawers, " +
					"[O] to Open the refrigerator, [L] to Leave out the back door, or [B] to go Back.");
		if 		(Input.GetKeyDown(KeyCode.I)) 				{Knife = true; myState = States.kitchen_01c;}
		else if (Input.GetKeyDown(KeyCode.O)) 				{myState = States.kitchen_02c;}
		else if (Input.GetKeyDown(KeyCode.L)) 				{myState = States.neighborhood_a;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.livingroom_10c;}
	}

	void kitchen_01a () { // Inspect Drawers Before Refrigerator And Before Attic
		text.text = ("You decide to rummage through the drawers and find a knife! You equip yourself for danger and move on. " +
					"You can open the refrigerator, leave out the back door, or go back to the living room. What will you do?\n\n" +
					"Press [O] to Open the refrigerator, [L] to Leave out the back door, or [B] to go Back to the living room.");
		if 		(Input.GetKeyDown(KeyCode.O)) 				{myState = States.kitchen_02b;}
		else if (Input.GetKeyDown(KeyCode.L)) 				{myState = States.neighborhood_a;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.livingroom_10b;}
	}

	void kitchen_01b () { // Inspect Drawers After Refrigerator But Before Attic
		text.text = ("You decide to rummage through the drawers and find a knife! You equip yourself for danger and move on. " +
					"You can leave out the back door or go back to the living room. What will you do?\n\nPress [L] to Leave out " +
					"the back door or [B] to go Back to the living room.");
		if 		(Input.GetKeyDown(KeyCode.L)) 				{myState = States.neighborhood_a;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.livingroom_10b;}
	}

	void kitchen_01c () { // Inspect Drawers Before Refrigerator But After Attic
		text.text = ("You decide to rummage through the drawers and find a knife! You equip yourself for danger and move on. " +
					"You can open the refrigerator, leave out the back door, or go back to the living room. What will you do?\n\n" +
					"Press [O] to Open the refrigerator, [L] to Leave out the back door, or [B] to go Back to the living room.");
		if 		(Input.GetKeyDown(KeyCode.O)) 				{myState = States.kitchen_02d;}
		else if (Input.GetKeyDown(KeyCode.L)) 				{myState = States.neighborhood_a;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.livingroom_10c;}
	}

	void kitchen_01d () { // Inspect Drawers After Refrigerator And After Attic
		text.text = ("You decide to rummage through the drawers and find a knife! You equip yourself for danger and move on. " +
					"You can open the refrigerator, leave out the back door, or go back to the living room. What will you do?\n\n" +
					"Press [L] to Leave out the back door or [B] to go Back to the living room.");
		if 		(Input.GetKeyDown(KeyCode.L)) 				{myState = States.neighborhood_a;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.livingroom_10c;}
	}

	void kitchen_02a () { // Open Refrigerator Before Drawers And Before Attic
		text.text = ("You open the fridge to get some supplies. It is mostly empty except for some old leftovers. You close the fridge " +
					"and move on. You can inspect the drawers, leave out the back door, or go back to the living room. What will you do?\n\n" +
					"Press [I] to Inspect the drawers, [L] to Leave out the back door, or [B] to go back to the living room.");
		if 		(Input.GetKeyDown(KeyCode.I)) 				{Knife = true; myState = States.kitchen_01b;}
		else if (Input.GetKeyDown(KeyCode.L)) 				{myState = States.neighborhood_a;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.livingroom_10b;}
	}

	void kitchen_02b () { // Open Refrigerator After Drawers But Before Attic
		text.text = ("You open the fridge to get some supplies. It is mostly empty except for some old leftovers. You close the fridge " +
					"and move on. You can leave out the back door, or go back to the living room. What will you do?\n\nPress [L] to Leave " +
					"out the back door or [B] to go back to the living room.");
		if 		(Input.GetKeyDown(KeyCode.L)) 				{myState = States.neighborhood_a;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.livingroom_10b;}
	}

	void kitchen_02c () { // Open Refrigerator Before Drawers But After Attic
		text.text = ("You open the fridge to get some supplies. It is mostly empty except for some old leftovers. You close the fridge " +
					"and move on. You can leave out the back door, or go back to the living room. What will you do?\n\nPress [L] to Leave " +
					"out the back door or [B] to go back to the living room.");
		if 		(Input.GetKeyDown(KeyCode.I)) 				{Knife = true; myState = States.kitchen_01d;}
		else if	(Input.GetKeyDown(KeyCode.L)) 				{myState = States.neighborhood_a;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.livingroom_10c;}
	}

	void kitchen_02d () { // Open Refrigerator After Drawers And After Attic
		text.text = ("You open the fridge to get some supplies. It is mostly empty except for some old leftovers. You close the fridge " +
					"and move on. You can leave out the back door, or go back to the living room. What will you do?\n\nPress [L] to Leave " +
					"out the back door or [B] to go back to the living room.");
		if 		(Input.GetKeyDown(KeyCode.L)) 				{myState = States.neighborhood_a;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.livingroom_10c;}
	}
	#endregion
	#region Neighborhood
	void neighborhood_a () {
		text.text = ("You decide to leave the house. When you walk out into the neighborhood you can see plumes of smoke blanketing " +
					"the city off in the distance. Down the street a couple zombies are feasting on something while black crows caw " +
					"overhead. You walk up to your car in the drive way and pull out your keys, but hesitate. You can inspect the " +
					"neighbor's house, go into the city, take the highway out of town, or go back inside your house. What will you do?\n\n" +
					"Press [N] for Neighbor's house, [C] to go into the City, [H] to take the Highway out of town, or [B] to go Back inside " +
					"your house.");
		if 		(Input.GetKeyDown(KeyCode.N)) 				{myState = States.neighbor;}
		else if (Input.GetKeyDown(KeyCode.C)) 				{myState = States.city_a;}
		else if (Input.GetKeyDown(KeyCode.H)) 				{myState = States.highway;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.neighborhood_c;}
	}

	void neighborhood_b () {
		text.text = ("You walk back to your car. Down the street a couple zombies are feasting on something while black crows caw " +
					"overhead. You can go into the city, take the highway out of town, or go back inside your house. What will you do?\n\n" +
					"Press [C] to go into the City, [H] to take the Highway out of town, or [B] to go Back inside your house.");
		if 		(Input.GetKeyDown(KeyCode.C)) 				{myState = States.city_a;}
		else if (Input.GetKeyDown(KeyCode.H)) 				{myState = States.highway;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.neighborhood_c;}
	}

	void neighborhood_c () {
		text.text = ("You walk back to the house. When you open the door a zombie leaps forward attacking you!! He scrapes your arm as " +
					"you try to get away, causing you to stumble. He grabs you from behind and bites down on your shoulder. You scream and " +
					"everything goes black...\n\nPress [SPACE] to continue...");
		if 		(Input.GetKeyDown(KeyCode.Space)) 			{myState = States.gameover;}
	}

	void neighbor () {
		text.text = ("You decide to check the neighbor's house for supplies before leaving, but which neighbor's house should you check? " +
					"You can pick the nieghbor to the left of your house, or the neighbor to the right of your house. What do you want to " +
					"do?\n\nPress [L] for the left neighbor's house and [R] for the right neighbor's house.");
		if 		(Input.GetKeyDown(KeyCode.L))		 		{Direction = true; myState = States.neighborleft;}
		else if (Input.GetKeyDown(KeyCode.R)) 				{Direction = false; myState = States.neighborright;}

	}

	void neighborleft () {
		text.text = ("You choose the neighbor's house on the left. You cautiously walk up the sidewalk towards the front door, eyes looking " +
					"back over your shoulders. A stray breeze starts to blow and the leaves in the trees above you start to rustle. You approach " +
					"the front door and stand on the welcome mat. To the left, the curtains are drawn in the window. You can try to get in " +
					"through the window, ring the doorbell, turn the doorknob, or go back to your car. What will you do?\n\nPress [W] to try the " +
					"Window, [R] to Ring the doorbell, [T] to Turn the doorknob, or [B] to go Back to your car.");
		if 		(Input.GetKeyDown(KeyCode.W))		 		{myState = States.neighborfront_01a;}
		else if (Input.GetKeyDown(KeyCode.R)) 				{myState = States.neighborfront_01b;}
		else if (Input.GetKeyDown(KeyCode.T)) 				{myState = States.neighborfront_01c;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.neighborhood_b;}
	}

	void neighborright () {
		text.text = ("You choose the neighbor's house on the right. You cautiously walk up the sidewalk towards the front door, eyes looking " +
					"back over your shoulders. A stray breeze starts to blow and the leaves in the trees above you start to rustle. You approach " +
					"the front door and stand on the welcome mat. To the right, the curtains are drawn in the window. You can try to get in " +
					"through the window, ring the doorbell, turn the doorknob, or go back to your car. What will you do?\n\nPress [W] to try the " +
					"Window, [R] to Ring the doorbell, [T] to Turn the doorknob, or [B] to go Back to your car.");
		if 		(Input.GetKeyDown(KeyCode.W))		 		{myState = States.neighborfront_01a;}
		else if (Input.GetKeyDown(KeyCode.R)) 				{myState = States.neighborfront_01b;}
		else if (Input.GetKeyDown(KeyCode.T)) 				{myState = States.neighborfront_01c;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.neighborhood_b;}
	}

	void neighborfront_01a () { // Try the window first
		text.text = ("You try to get in the window. The window is locked and won't open. You try to see in but the curtains make it almost impossible to " +
					"see anything. You can ring the doorbell, turn the doorknob, or go back to your car. What will you do?\n\nPress [R] to Ring the " +
					"doorbell, [T] to Turn the doorknob, or [B] to go Back to your car.");
		if 		(Input.GetKeyDown(KeyCode.R)) 				{myState = States.neighborfront_02a;}
		else if (Input.GetKeyDown(KeyCode.T)) 				{myState = States.neighborfront_02b;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.neighborhood_b;}
	}

	void neighborfront_01b () { // Ring the doorbell first
		text.text = ("You ring the doorbell. You hear the bell chime and then nothing... Silence... I guess no one is home. You can try to get in through the " +
					"window, turn the doorknob, or go back to your car. What will you do?\n\nPress [W] to try the Window, [T] to Turn the doorknob, or [B] to go " +
					"Back to your car.");
		if 		(Input.GetKeyDown(KeyCode.W)) 				{myState = States.neighborfront_03a;}
		else if (Input.GetKeyDown(KeyCode.T)) 				{myState = States.neighborfront_03b;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.neighborhood_b;}
	}

	void neighborfront_01c () { // // Turn the doorknob first
		text.text = ("You turn the doorknob. The door is locked and won't budge. You can try to get in through the window, ring the doorbell, or go back to your " +
					"car. What will you do?\n\nPress [W] to try the Window, [R] to Ring the doorbell, or [B] to go Back to your car.");
		if 		(Input.GetKeyDown(KeyCode.W)) 				{myState = States.neighborfront_04a;}
		else if (Input.GetKeyDown(KeyCode.R)) 				{myState = States.neighborfront_04b;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.neighborhood_b;}
	}

	void neighborfront_02a () { // Ring doorbell after trying window
		text.text = ("You ring the doorbell. You hear the bell chime and then nothing... Silence... I guess no one is home. You can turn the doorknob, or go back " +
					"to your car. What will you do?\n\nPress [W] to try the Window, [T] to Turn the doorknob, or [B] to go Back to your car.");
		if 		(Input.GetKeyDown(KeyCode.T)) 				{myState = States.neighborfront_05a;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.neighborhood_b;}
	}

	void neighborfront_02b () { // Turn doorknob after trying window
		text.text = ("You turn the doorknob. The door is locked and won't budge. You can ring the doorbell or go back to your car. What will you do?\n\nPress [R] to " +
					"Ring the doorbell or [B] to go Back to your car.");
		if 		(Input.GetKeyDown(KeyCode.R)) 				{myState = States.neighborfront_05b;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.neighborhood_b;}
	}

	void neighborfront_03a () { // Try window after doorbell
		text.text = ("You try to get in the window. The window is locked and won't open. You can turn the doorknob or go back to your car. What will you do?\n\nPress " +
					"[T] to Turn the doorknob or [B] to go Back to your car.");
		if 		(Input.GetKeyDown(KeyCode.T)) 				{myState = States.neighborfront_05a;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.neighborhood_b;}
	}

	void neighborfront_03b () { // Turn doorknob after doorbell
		text.text = ("You turn the doorknob. The door is locked and won't budge. You can try to get in through the window or go back to your car. What will you do?\n\n" +
					"Press [W] to try the Window or [B] to go Back to your car.");
		if 		(Input.GetKeyDown(KeyCode.W)) 				{myState = States.neighborfront_05c;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.neighborhood_b;}
	}

	void neighborfront_04a () { // Try window after doorknob
		text.text = ("You try to get in the window. The window is locked and won't open. You can ring the doorbell or go back to your car. What will you do?\n\nPress " +
					"[R] to Ring the doorbell or [B] to go Back to your car.");
		if 		(Input.GetKeyDown(KeyCode.R)) 				{myState = States.neighborfront_05b;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.neighborhood_b;}
	}

	void neighborfront_04b () { // Try doorbell after doorknob
		text.text = ("You ring the doorbell. You hear the bell chime and then nothing... Silence... I guess no one is home. You can try to get in through the window or " +
					"go back to your car. What will you do?\n\nPress [W] to try the Window or [B] to go Back to your car.");
		if 		(Input.GetKeyDown(KeyCode.W)) 				{myState = States.neighborfront_05c;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.neighborhood_b;}
	}

	void neighborfront_05a () { // Turn doorknob last
		text.text = ("You turn the doorknob. The door is locked and won't budge. You can check under the welcome mat or go back to your car. What will you do?\n\nPress " +
					"[C] to Check under the welcome mat or [B] to go Back to your car.");
		if 		(Input.GetKeyDown(KeyCode.C)) 				{myState = States.neighborhouse_a;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.neighborhood_b;}
	}

	void neighborfront_05b () { // Ring doorbell last
		text.text = ("You ring the doorbell. You hear the bell chime and then nothing... Silence... I guess no one is home. You can check under the welcome mat or go back " +
					"to your car. What will you do?\n\nPress [C] to Check under the welcome mat or [B] to go Back to your car.");
		if 		(Input.GetKeyDown(KeyCode.C)) 				{myState = States.neighborhouse_a;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.neighborhood_b;}
	}

	void neighborfront_05c () { // Try window last
		text.text = ("You try to get in the window. The window is locked and won't open. You can check under the welcome mat or go back to your car. What will you do?\n\n" +
					"Press [C] to Check under the welcome mat or [B] to go Back to your car.");
		if 		(Input.GetKeyDown(KeyCode.C)) 				{myState = States.neighborhouse_a;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.neighborhood_b;}
	}

	void neighborhouse_a () { // Check under welcome mat
		text.text = ("You check under the welcome mat and find a spare key! What luck! You use the key to unlock the front door and step inside. You find the house in shambles. " +
					"To your left are some stairs and to the right is a door to the garage. You can search upstairs, search the garage, or go back to your car. What will you " +
					"do?\n\nPress [U] to search Upstairs, [G] to search to the Garage, or [B] to go Back to your car.");
		if 		(Input.GetKeyDown(KeyCode.U)) 				{myState = States.neighborupstairs;}
		else if (Input.GetKeyDown(KeyCode.G)) 				{myState = States.neighborgarage;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.neighborhouse_b;}
	}

	void neighborhouse_b () { // Go back to your car
		text.text = ("You turn to leave the house and the front door slams in front of you locking you in. You try the doorknob, but something is jamming it. On the floor in " +
					"front of you is a note. You can search upstairs, search the garage, or read the note. What will you do?\n\nPress [U] to search " +
					"Upstairs, [L] to search the Living room, [G] to search the Garage, or [R] to Read the note.");
		if 		(Input.GetKeyDown(KeyCode.U)) 				{myState = States.neighborupstairs;}
		else if (Input.GetKeyDown(KeyCode.G)) 				{myState = States.neighborgarage;}
		else if (Input.GetKeyDown(KeyCode.R)) 				{Code = true; myState = States.neighborhouse_c;}
	}

	void neighborhouse_c () { // Pickup and read note
		text.text = ("You pickup the note and read it. On the note are the words 'Sewer Access' and a code '56132'. You tuck the note in your pocket, unsure of how it will help. " +
					"You turn around and face the dark, empty house. You can search upstairs or search the garage. What will you do?\n\nPress [U] to search Upstairs or [G] " +
					"to search the garage.");
		if 		(Input.GetKeyDown(KeyCode.U)) 				{myState = States.neighborupstairs;}
		else if (Input.GetKeyDown(KeyCode.G)) 				{myState = States.neighborgarage;}
	}

	void neighborhouse_d () { // Go back to main house from upstairs
		text.text = ("You walk back downstairs. You can still search the garage. What will you do?\n\nPress [G] to search the Garage.");
		if 		(Input.GetKeyDown(KeyCode.G)) 				{myState = States.neighborgarage;}
	}

	void neighborupstairs () { // pain medicine / medkit
		text.text = ("You decide to see what's upstairs. You walk up the stairs, each stair creaking under your feet. At the top of the stairs is a hallway with two bedroom doors " +
					"and a bathroom door. You can open the left bedroom door, open the bathroom door, open the right bedroom door, or go downstairs. What will you do?\n\n" +
					"Press [L] for the Left bedroom door, [M] for the Middle bathroom door, [R] for the Right bedroom door, or [D] to go Downstairs.");
		if 		(Input.GetKeyDown(KeyCode.L)) 				{myState = States.neighborupstairs_a;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.neighborupstairs_b;}
		else if (Input.GetKeyDown(KeyCode.R)) 				{myState = States.neighborupstairs_c;}
		else if (Input.GetKeyDown(KeyCode.D)) 				{myState = States.neighborhouse_b;}
	}

	void neighborupstairs_a () { // Left bedroom door
		if (Knife == true) {
			text.text = ("You choose to open the left bedroom door. As soon as you walk in you wish you hadn't. A group of zombies in the room are alerted to your presence " +
			"and lunge forward to attack. You pull out your knife and strike the first zombie, dropping it to the floor and tripping the other zombies. You quickly " +
			"turn and run out the doorway, slamming the door behind you, and barely escaping with your life. You can only go downstairs. What will you do?\n\nPress " +
			"[D] to go Downstairs.");
			if (Input.GetKeyDown (KeyCode.D)) 					{myState = States.neighborhouse_d;}
		} else {
			text.text = ("You choose to open the left bedroom door. As soon as you walk in you wish you hadn't. A group of zombies in the room are alerted to your presence " +
			"and lunge forward to attack. You turn to run out the doorway, but it is too late. A zombie grabs you from behind and pulls you down onto the ground. The other zombies " +
			"fall on top of you and begin biting and scratching. You scream and everything goes black...\n\nPress [SPACE] to continue...");
			if (Input.GetKeyDown (KeyCode.Space)) 				{myState = States.gameover;}
		}
	}

	void neighborupstairs_b () { // Middle bathroom door
		text.text = ("You choose to open the bathroom door. In the bathroom you don't see anything particularly useful. You can check the medicine cabinet, check under the sink, or " +
					"go downstairs. What will you do?\n\nPress [M] to check the Medicine cabinet, [S] to check under the Sink, or [D] to go Downstairs.");
		if 		(Input.GetKeyDown(KeyCode.M)) 				{myState = States.neighborupstairs_01;}
		else if (Input.GetKeyDown(KeyCode.S)) 				{myState = States.neighborupstairs_02;}
		else if (Input.GetKeyDown(KeyCode.D)) 				{myState = States.neighborhouse_d;}
	}

	void neighborupstairs_c () { // Right bedroom door
		if (Knife == true) {
			text.text = ("You choose to open the right bedroom door. As soon as you walk in you wish you hadn't. A group of zombies in the room are alerted to your presence " +
			"and lunge forward to attack. You pull out your knife and strike the first zombie, dropping it to the floor and tripping the other zombies. You quickly " +
			"turn and run out the doorway, slamming the door behind you, and barely escaping with your life. You can only go downstairs. What will you do?\n\nPress " +
			"[D] to go Downstairs.");
			if (Input.GetKeyDown (KeyCode.D)) 					{myState = States.neighborhouse_d;}
		} else {
			text.text = ("You choose to open the right bedroom door. As soon as you walk in you wish you hadn't. A group of zombies in the room are alerted to your presence " +
			"and lunge forward to attack. You turn to run out the doorway, but it is too late. A zombie grabs you from behind and pulls you down onto the ground. The other zombies " +
			"fall on top of you and begin biting and scratching. You scream and everything goes black...\n\nPress [SPACE] to continue...");
			if (Input.GetKeyDown (KeyCode.Space)) 				{myState = States.gameover;}
		}
	}

	void neighborupstairs_01 () { // Medicine cabinet
		if (Direction == true) {
			text.text = ("You decide to check the medicine cabinet. You open the mirrored door and find a bootle of pain medicine. You grab it and slip it into your backpack. You " +
						"can only go downstairs. What will you do?\n\nPress [D] to go Downstairs.");
			if 		(Input.GetKeyDown (KeyCode.D)) 				{Medicine = true; myState = States.neighborhouse_d;}
		} else {
			text.text = ("You decide to check the medicine cabinet. You open the mirrored door and find a medkit. You grab it and slip it into your backpack. You can only go " +
						"downstairs. What will you do?\n\nPress [D] to go Downstairs.");
			if 		(Input.GetKeyDown (KeyCode.D)) 				{Medkit = true; myState = States.neighborhouse_d;}
		}
	}

	void neighborupstairs_02 () { // Sink
		text.text = ("You decide to check under the sink. You open the cabinet and a rat squeaks and runs past you. You don't see anything useful. You can check the medicine cabinet " +
					"or go downstairs. What will you do?\n\nPress [M] to check the Medicine cabinet or [D] to go Downstairs.");
		if 		(Input.GetKeyDown (KeyCode.M)) 				{myState = States.neighborupstairs_01;}
		else if (Input.GetKeyDown(KeyCode.D)) 				{myState = States.neighborhouse_d;}
	}

	void neighborgarage () {

		if (Flashlight == true) {
			text.text = ("You decide to see what's in the garage. You open the door to the garage and walk through. In the garage it is very dark. You can hear the sounds of leaking " +
						"pipes and some sort of scratching noise. You can turn on your flashlight, search around in the dark, or open the garage door. What will you do?\n\nPress [F] " +
						"to turn on the Flashlight, [S] to search in the dark, or [O] to Open the garage door.");
			if 		(Input.GetKeyDown(KeyCode.F)) 					{Boots = true; myState = States.neighborgarage_a;}
			else if (Input.GetKeyDown(KeyCode.S)) 					{myState = States.neighborgarage_b;}
			else if (Input.GetKeyDown(KeyCode.O)) 					{myState = States.neighborgarage_c;}
		} else {
			text.text = ("You decide to see what's in the garage. You open the door to the garage and walk through. In the garage it is very dark. You can hear the sounds of leaking " +
						"pipes and some sort of scratching noise. You can search around in the dark or open the garage door. What will you do?\n\nPress [S] to search in the dark or " +
						"[O] to Open the garage door.");
			if 		(Input.GetKeyDown(KeyCode.S)) 					{myState = States.neighborgarage_b;}
			else if (Input.GetKeyDown(KeyCode.O)) 					{myState = States.neighborgarage_c;}
		}
	}

	void neighborgarage_a () { // Turn on the flashlight
		text.text = ("You take out your flashlight and turn it on. You start searching the back wall of the garage and come across a dark figure in the corner. It turns around and " +
					"starts running at you. You throw the flashlight at its head and the zombie falls to the ground like a sack of potatoes. You quickly run over to the garage door and lift " +
					"it up with your hands illuminating the garage with sunlight. You turn back around and the zombie is motionless on the floor. You cautiosly walk back to pick up your " +
					"flashlight. Next to your flashlight on the ground is a pair of boots. You look down at your sandals and realize how underprepared you are for the zombie apocalypse. You grab " +
					"the boots and your flashlight and leave the garage before the zombie wakes up.\n\nPress [SPACE] to continue...");
		if (Input.GetKeyDown (KeyCode.Space)) 					{myState = States.neighborhood_b;}
	}

	void neighborgarage_b () { // Search in the dark
		text.text = ("You start searching the back wall of the garage in the dark. You come across a dark figure in the corner. It turns around and starts running at you. You grab " +
					"some shelving next to you and throw it down on top of the zombie, pinning it to the ground. You quickly run over to the garage door and lift it up with your " +
					"hands illuminating the garage with sunlight. You turn back around and the zombie is pinned and motionless on the floor. You turn and leave the garage before " +
					"the zombie wakes up.\n\nPress [SPACE] to continue...");
		if (Input.GetKeyDown (KeyCode.Space)) 					{myState = States.neighborhood_b;}
	}

	void neighborgarage_c () { // Open the garage door
		text.text = ("You walk over to the garage door and lift it up with your hands illuminating the garage with sunlight. You turn back around and see a zombie in the corner " +
					"start running towards you. You grab some shelving next to you and throw it down on top of the zombie, pinning it to the ground. You turn and leave the garage " +
					"before the zombie wakes up.\n\nPress [SPACE] to continue...");
		if (Input.GetKeyDown (KeyCode.Space)) 					{myState = States.neighborhood_b;}
	}

	#endregion
	#region City
	void city_a () {
		text.text = ("You get in your car and take off in the direction of the city, oldies playing on the radio. The closer you get the darker " +
					"and thicker the smoke gets. When you arrive the city is battered and torn like the aftermath of a riot. You pull down the " +
					"main street towards downtown and immediately find a group of zombies surrounding a crashed car. You try to swerve to avoid " +
					"the wreckage and veer off into the railing on the left. Dazed and disoriented you unbuckle and can see the subway entrance " +
					"out the driver door, and signs for downtown out the passenger door. You can search the glove box, go out the driver door, or " +
					"go out the passenger door. What will you do?\n\nPress [S] to search the glovebox, [D] for the Driver door, and [P] for the " +
					"passenger door.");
		if 		(Input.GetKeyDown(KeyCode.S)) 				{Gun = true; myState = States.city_b;}
		else if (Input.GetKeyDown(KeyCode.D)) 				{myState = States.subway;}
		else if (Input.GetKeyDown(KeyCode.P)) 				{myState = States.downtown;}
	}

	void city_b () { // Search the Glovebox
		text.text = ("");
		if 		(Input.GetKeyDown(KeyCode.D)) 				{myState = States.subway;}
		else if (Input.GetKeyDown(KeyCode.P)) 				{myState = States.downtown;}
	}

	void subway () {

	}

	void downtown () {

	}

	void evacuationzone () {

	}
	#endregion
	#region Highway
	void highway () {

	}

	void sewer_a () {
		text.text = ("");
		if (Input.GetKeyDown (KeyCode.T)) {
			if (Flashlight == true && Backpack == true && Knife == true && Code == true && (Medicine == true || Medkit == true) && Boots == true && Gun == true) {
				myState = States.sewer_b;
			} else {
				myState = States.gasstation;
			}
		}
		if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.gasstation;
		}
	}

	void sewer_b () {

	}

	void gasstation () {

	}

	void helicopterpad () {

	}
	#endregion
}
