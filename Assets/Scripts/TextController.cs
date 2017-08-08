using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {menu, livingroom, livingroom_01, livingroom_02, livingroom_03, livingroom_04, livingroom_05, livingroom_06, 
						livingroom_07a, livingroom_07b, livingroom_07c, livingroom_08, livingroom_09, attic, kitchen, neighborhood,
						neighborhouse, neighborhouseleft, neighborhouseright, neighborhouseupstairs, neighborhousegarage, city, subway,
						highway, sewer, gasstation, downtown, evacuationzone, helicopterpad};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.menu;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.menu) 						{state_menu ();}
		else if (myState == States.livingroom) 				{state_livingroom ();}
		else if (myState == States.livingroom_01) 			{state_livingroom_01 ();}
		else if (myState == States.livingroom_02) 			{state_livingroom_02 ();}
		else if (myState == States.livingroom_03)			{state_livingroom_03 ();}
		else if (myState == States.livingroom_04) 			{state_livingroom_04 ();}
		else if (myState == States.livingroom_05) 			{state_livingroom_05 ();}
		else if (myState == States.livingroom_06) 			{state_livingroom_06 ();}
		else if (myState == States.livingroom_07a)			{state_livingroom_07a ();}
		else if (myState == States.livingroom_07b) 			{state_livingroom_07b ();}
		else if (myState == States.livingroom_07c) 			{state_livingroom_07c ();}
		else if (myState == States.livingroom_08) 			{state_livingroom_08 ();}
		else if (myState == States.livingroom_09) 			{state_livingroom_09 ();}
		else if (myState == States.attic) 					{state_attic ();}
		else if (myState == States.kitchen) 				{state_kitchen ();}
		else if (myState == States.neighborhood) 			{state_neighborhood ();}
		else if (myState == States.neighborhouse) 			{state_neighborhouse ();}
		else if (myState == States.neighborhouseleft) 		{state_neighborhouseleft ();}
		else if (myState == States.neighborhouseright) 		{state_neighborhouseright ();}
		else if (myState == States.neighborhouseupstairs) 	{state_neighborhouseupstairs ();}
		else if (myState == States.neighborhousegarage) 	{state_neighborhousegarage ();}
		else if (myState == States.city) 					{state_city ();}
		else if (myState == States.subway)					{state_subway ();}
		else if (myState == States.highway) 				{state_highway ();}
		else if (myState == States.sewer) 					{state_sewer ();}
		else if (myState == States.gasstation) 				{state_gasstation ();}
		else if (myState == States.downtown) 				{state_downtown ();}
		else if (myState == States.evacuationzone)			{state_evacuationzone ();}
		else if (myState == States.helicopterpad) 			{state_helicooterpad ();}
	}

	void state_menu () {
		text.text = ("\n\n\n\t\t\t\t\t\t\t\t\t\tPRESS ENTER TO START GAME \n\n\n\n\n\n\n" +          
        			"\t\t\t\t\t\t   © 2017 ImagiTech Studios, LLC. All Rights Reserved.");
		if (Input.GetKeyDown (KeyCode.Return)) 				{myState = States.livingroom;}
	}

	void state_livingroom () {
		text.text = ("The morning started off just like any other… well almost.\n\n " +
					"You awoke on your couch in the middle of your dimly lit living room. The curtains " +
					"were still drawn from last night's video game binge session, a sliver of light peeking " +
					"through their cracks. The only notable items in the room are a half-eaten pizza, a 2-liter " +
					"of root beer, an XBOX controller, and a TV remote lying on the coffee table in front of " +
					"you. What do you want to do?\n\n" +
					"Press [P] for pizza, [R] for root beer, [X] for Xbox controller, or [T] for TV remote.");
		if (Input.GetKeyDown (KeyCode.P)) 					{myState = States.livingroom_01;}
		else if (Input.GetKeyDown(KeyCode.R)) 				{myState = States.livingroom_02;}
		else if (Input.GetKeyDown(KeyCode.X)) 				{myState = States.livingroom_03;}
		else if (Input.GetKeyDown(KeyCode.T)) 				{myState = States.livingroom_08;}
	}

	void state_livingroom_01 () {
		text.text = ("That old pizza sure looks tasty. You eat the leftover pizza. Your stomach rumbles and you let " +
					"out a big fart!!...\n\nThe only notable items left in the room are a 2-liter of root beer, " +
					"an XBOX controller, and a TV remote lying on the coffee table in front of you. What do you " +
					"want to do?\n\nPress [R] for root beer, [X] for Xbox controller, or [T] for TV remote.");
		if (Input.GetKeyDown(KeyCode.R)) 					{myState = States.livingroom_04;}
		else if (Input.GetKeyDown(KeyCode.X)) 				{myState = States.livingroom_05;}
		else if (Input.GetKeyDown(KeyCode.T)) 				{myState = States.livingroom_08;}
	}

	void state_livingroom_02 () {
		text.text = ("That root beer sure looks refreshing. You drink the root beer. Your stomach rumbles " +
					"and you let out a big burp!!...\n\nThe only notable items left in the room are a half-eaten " +
					"pizza, an XBOX controller, and a TV remote lying on the coffee table in front of you. " +
					"What do you want to do?\n\nPress [P] for pizza, [X] for Xbox controller, or [T] for TV remote.");
		if (Input.GetKeyDown(KeyCode.P)) 					{myState = States.livingroom_04;}
		else if (Input.GetKeyDown(KeyCode.X)) 				{myState = States.livingroom_06;}
		else if (Input.GetKeyDown(KeyCode.T)) 				{myState = States.livingroom_08;}
	}

	void state_livingroom_03 () {
		text.text = ("You didn't get enough game time last night. You pick up the XBOX controller " +
					"and play for a bit. You get bored and put the XBOX controller down.\n\nThe only " +
					"notable items left in the room are a half-eaten pizza, a 2-liter of root beer, " +
					"and a TV remote lying on the coffee table in front of you. What do you want to do?\n\n" +
					"Press [P] for pizza, [R] for root beer, or [T] for TV remote.");
		if (Input.GetKeyDown(KeyCode.P)) 					{myState = States.livingroom_05;}
		else if (Input.GetKeyDown(KeyCode.R)) 				{myState = States.livingroom_06;}
		else if (Input.GetKeyDown(KeyCode.T))				{myState = States.livingroom_08;}
	}

	void state_livingroom_04 () {
		text.text = ("That root beer sure looks refreshing. You drink the root beer. Your stomach rumbles " +
					"and you let out a big burp!!...\n\nThe only notable items left in the room are an XBOX " +
					"controller and a TV remote lying on the coffee table in front of you. What do you want to do?\n\n" +
					"Press [X] for Xbox controller, or [T] for TV remote.");
		if (Input.GetKeyDown(KeyCode.X)) 					{myState = States.livingroom_07c;}
		else if (Input.GetKeyDown(KeyCode.T)) 				{myState = States.livingroom_08;}
	}

	void state_livingroom_05 () {
		text.text = ("That old pizza sure looks tasty. You eat the leftover pizza. Your stomach rumbles and you let " +
					"out a big fart!!...\n\nThe only notable items in the room are a 2-liter of root beer and a TV " +
					"remote lying on the coffee table in front of you. What do you want to do?\n\nPress [R] for root " +
					"beer or [T] for TV remote.");
		if (Input.GetKeyDown(KeyCode.R)) 					{myState = States.livingroom_07b;}
		else if (Input.GetKeyDown(KeyCode.T))				{myState = States.livingroom_08;}
	}

	void state_livingroom_06 () {
		text.text = ("The only notable items in the room are a 2-liter of root beer, an " +
					"XBOX controller, and a TV remote lying on the coffee table in front of " +
					"you. What do you want to do?\n\n" +
					"Press [P] for pizza or [T] for TV remote.");
		if (Input.GetKeyDown(KeyCode.P)) 					{myState = States.livingroom_07a;}
		else if (Input.GetKeyDown(KeyCode.T)) 				{myState = States.livingroom_08;}
	}

	void state_livingroom_07a () {
		text.text = ("That old, stale pizza sure looks tasty. You eat the leftover pizza. Your stomach rumbles and you let " +
					"out a big fart!!...\n\nThe only notable item left in the room is a TV remote lying on the coffee " +
					"table in front of you. What do you want to do?\n\nPress [T] for TV remote.");
		if (Input.GetKeyDown(KeyCode.T)) 					{myState = States.livingroom_08;}
	}

	void state_livingroom_07b () {
		text.text = ("That root beer sure looks refreshing. You drink the root beer. Your stomach rumbles " +
					"and you let out a big burp!!...\n\nThe only notable item left in the room is a TV " +
					"remote lying on the coffee table in front of you. What do you want to do?\n\nPress " +
					"[T] for TV remote.");
		if (Input.GetKeyDown(KeyCode.T)) 					{myState = States.livingroom_08;}
	}

	void state_livingroom_07c () {
		text.text = ("You didn't get enough game time last night. You pick up the XBOX controller " +
					"and play for a bit. You get bored and put the XBOX controller down.\n\nThe only " +
					"notable item left in the room is a TV remote lying on the coffee table in front of " +
					"you. What do you want to do?\n\nPress [T] for TV remote.");
		if (Input.GetKeyDown(KeyCode.T)) 					{myState = States.livingroom_08;}
	}

	void state_livingroom_08 () {
		text.text = ("You pick up the TV remote and change the channel to watch anime. As you're watching an " +
					"emergency news broadcast interupts your show. 'This is an emergency announcement!... " +
					"Zombies have taken over the city... I repeat... Zombies... Yes, zombies... have taken " +
					"over the city... All citizens are advised to... and stay calm... gather your loved ones... " +
					"and head to the evacuation zone in downtown... Soldiers... assist you to safety. Get out " +
					"while you still can!!'\n\nPress SPACE to continue.");
		if (Input.GetKeyDown(KeyCode.Space)) 				{myState = States.livingroom_09;} 
	}

	void state_livingroom_09 () {
		text.text = ("Suddenly the power goes out and the television shuts off. You jump to your feet, everything in the" +
					"house eerily quiet around you. Zombie apocalypse you think?! You better get to safety before its too " +
					"late!!\n\nYou turn around and see the front door, stairs, and kitchen door. What will you do?\n\nPress " +
					"[A] to check for supplies in the attic, [K] to check for supplies in the kitchen, or [L] to leave " +
					"without checking for supplies.");
		if (Input.GetKeyDown(KeyCode.A)) 					{myState = States.attic;}
		else if (Input.GetKeyDown(KeyCode.K)) 				{myState = States.kitchen;}
		else if (Input.GetKeyDown(KeyCode.L)) 				{myState = States.neighborhood;} 
	}

	void state_attic () {

	}

	void state_kitchen () {

	}

	void state_neighborhood () {

	}

	void state_neighborhouse () {

	}

	void state_neighborhouseleft () {

	}

	void state_neighborhouseright () {

	}

	void state_neighborhouseupstairs () {

	}

	void state_neighborhousegarage () {

	}

	void state_city () {

	}

	void state_subway () {

	}

	void state_highway () {

	}

	void state_sewer () {

	}

	void state_gasstation () {

	}

	void state_helicooterpad () {

	}

	void state_downtown () {

	}

	void state_evacuationzone () {

	}
}
