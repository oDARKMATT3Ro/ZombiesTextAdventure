using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {menu, livingroom, livingroom_01, livingroom_02, livingroom_03, livingroom_04a, livingroom_04b, livingroom_05,
						livingroom_06a, livingroom_06b, livingroom_07a, livingroom_07b, livingroom_07c, livingroom_08, livingroom_09,
						livingroom_10a, livingroom_10b, livingroom_10c, attic, attic_01, attic_02a, attic_02b, attic_03a, attic_03b, attic_04a,
						attic_04b, attic_05a, attic_05b, attic_05c, attic_06a, attic_06b, kitchen_a, kitchen_b, kitchen_01, kitchen_02, 
						neighborhood, neighbor, neighborleft, neighborright, neighborupstairs, neighborgarage, city, subway, highway, sewer,
						sewer_01, gasstation, downtown, evacuationzone, helicopterpad, gameover, thankyou};
	private States myState;
	private bool Flashlight;
	private bool Backpack;
	private bool Knife;
	private bool Code;
	private bool Medicine;
	private bool Medkit;
	private bool Boots;
	private bool Gasmask;
	private bool Gun;

	// Use this for initialization
	void Start () {
		myState = States.menu;
		Flashlight = false;
		Backpack = false;
		Knife = false;
		Code = false;
		Medicine = false;
		Medkit = false;
		Boots = false;
		Gasmask = false;
		Gun = false;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if 		(myState == States.menu) 					{menu ();}
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
		else if (myState == States.kitchen_a) 				{kitchen_a ();}
		else if (myState == States.kitchen_b) 				{kitchen_b ();}
		else if (myState == States.kitchen_01) 				{kitchen_01 ();}
		else if (myState == States.kitchen_02) 				{kitchen_02 ();}
		else if (myState == States.neighborhood) 			{neighborhood ();}
		else if (myState == States.neighbor) 				{neighbor ();}
		else if (myState == States.neighborleft) 			{neighborleft ();}
		else if (myState == States.neighborright) 			{neighborright ();}
		else if (myState == States.neighborupstairs) 		{neighborupstairs ();}
		else if (myState == States.neighborgarage) 			{neighborgarage ();}
		else if (myState == States.city) 					{city ();}
		else if (myState == States.subway)					{subway ();}
		else if (myState == States.highway) 				{highway ();}
		else if (myState == States.sewer) 					{sewer ();}
		else if (myState == States.sewer_01) 				{sewer_01 ();}
		else if (myState == States.gasstation) 				{gasstation ();}
		else if (myState == States.downtown) 				{downtown ();}
		else if (myState == States.evacuationzone)			{evacuationzone ();}
		else if (myState == States.helicopterpad) 			{helicooterpad ();}
		else if (myState == States.gameover) 				{gameover ();}
		else if (myState == States.thankyou) 				{thankyou ();}
	}

	void menu () {
		text.text = ("\n\n\n\t\t\t\t\t\t\t\t\t\tPRESS ENTER TO START GAME \n\n\n\n\n\n\n" +          
        			"\t\t\t\t\t\t   © 2017 ImagiTech Studios, LLC. All Rights Reserved.");
		if 		(Input.GetKeyDown (KeyCode.Return)) 		{myState = States.livingroom;}
	}

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
		else if (Input.GetKeyDown(KeyCode.L)) 				{myState = States.neighborhood;} 
	}

	void livingroom_10a () { // After Attic
		text.text = ("You went back to the living room. You can go into the kitchen or leave the house. What will you do?\n\n" +
					"Press [K] to check the Kitchen, or [L] to Leave the house.");
		if 		(Input.GetKeyDown(KeyCode.K)) 				{myState = States.kitchen_b;}
		else if (Input.GetKeyDown(KeyCode.L)) 				{myState = States.neighborhood;} 
	}

	void livingroom_10b () { // After Kitchen
		text.text = ("You went back to the living room. You can go upstairs to the attic or leave the house. What will you do?\n\n" +
					"Press [A] to check the Attic, or [L] to Leave the house.");
		if 		(Input.GetKeyDown(KeyCode.A)) 				{myState = States.attic_01;}
		else if (Input.GetKeyDown(KeyCode.L)) 				{myState = States.neighborhood;}
	}

	void livingroom_10c () { // After Attic and Kitchen 
		text.text = ("You went back to the living room. What will you do?\n\nPress [L] to Leave the house.");
		if 		(Input.GetKeyDown(KeyCode.A)) 				{myState = States.attic;}
		else if (Input.GetKeyDown(KeyCode.L)) 				{myState = States.neighborhood;}
	}

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
					"zombie off of you, but eventually he gets a good bite in and you scream before everything goes black.\n\nPress SPACE " +
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

	void kitchen_a () { // Before Attic
		text.text = ("You decide to go into the kitchen to look for supplies. In the kitchen you find blood smeared on the " +
					"outside of the kitchen window. You look out, but don't see anything. you look at the back door. Still " +
					"locked. Around the kitchen nothing really stands out. You can inspect the drawers, open the refrigerator, " +
					"leave out the back door, or go back to the living room. What will you do?\n\nPress [I] to Inspect the drawers, " +
					"[O] to Open the refrigerator, [L] to Leave out the back door, or [B] to go Back.");
		if 		(Input.GetKeyDown(KeyCode.I)) 				{Knife = true; myState = States.kitchen_01;}
		else if (Input.GetKeyDown(KeyCode.O)) 				{myState = States.kitchen_02;}
		else if (Input.GetKeyDown(KeyCode.L)) 				{myState = States.neighborhood;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.livingroom_10b;}
	}

	void kitchen_b () { // After Attic
		text.text = ("You decide to go into the kitchen to look for supplies. In the kitchen you find blood smeared on the " +
					"outside of the kitchen window. You look out, but don't see anything. you look at the back door. Still " +
					"locked. Around the kitchen nothing really stands out. You can inspect the drawers, open the refrigerator, " +
					"leave out the back door, or go back to the living room. What will you do?\n\nPress [I] to Inspect the drawers, " +
					"[O] to Open the refrigerator, [L] to Leave out the back door, or [B] to go Back.");
		if 		(Input.GetKeyDown(KeyCode.I)) 				{Knife = true; myState = States.kitchen_01;}
		else if (Input.GetKeyDown(KeyCode.O)) 				{myState = States.kitchen_02;}
		else if (Input.GetKeyDown(KeyCode.L)) 				{myState = States.neighborhood;}
		else if (Input.GetKeyDown(KeyCode.B)) 				{myState = States.livingroom_10c;}
	}

	void kitchen_01 () {
		text.text = ("");
	}

	void kitchen_02 () {
		text.text = ("");
	}

	void neighborhood () {
		text.text = ("You decide to leave the house.");
	}

	void neighbor () {

	}

	void neighborleft () {

	}

	void neighborright () {

	}

	void neighborupstairs () {

	}

	void neighborgarage () {

	}

	void city () {

	}

	void subway () {

	}

	void highway () {

	}

	void sewer () {
		text.text = ("");
		if (Input.GetKeyDown (KeyCode.T)) {
			if (Flashlight == true && Backpack == true && Knife == true && Code == true && (Medicine == true || Medkit == true) && Boots == true && Gasmask == true && Gun == true) {
				myState = States.sewer_01;
			} else {
				myState = States.gasstation;
			}
		}
		if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.gasstation;
		}
	}

	void sewer_01 () {

	}

	void gasstation () {

	}

	void helicooterpad () {

	}

	void downtown () {

	}

	void evacuationzone () {

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
}
