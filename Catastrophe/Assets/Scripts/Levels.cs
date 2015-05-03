using UnityEngine;
using System.Collections;

public class Levels : MonoBehaviour {

	public GameObject player;
	public int level = 1;
	
	// Update is called once per frame
	void Update () {
		if (level == 2) {
			player.GetComponent<XP> ().presetXPMax = 900;
		} else if (level == 3) {
			player.GetComponent<XP> ().presetXPMax = 1300;
		} else if (level == 4) {
			player.GetComponent<XP> ().presetXPMax = 1700;
		} else if (level == 5) {
			player.GetComponent<XP> ().presetXPMax = 2300;
		} else if (level == 6) {
			player.GetComponent<XP> ().presetXPMax = 2900;
		} else if (level == 7) {
			player.GetComponent<XP> ().presetXPMax = 3500;
		} else if (level == 8) {
			player.GetComponent<XP> ().presetXPMax = 4100;
		} else if (level == 9) {
			player.GetComponent<XP> ().presetXPMax = 4700;
		} else if (level == 10) {
			player.GetComponent<XP> ().presetXPMax = 5500;
		} else if (level == 11) {
			player.GetComponent<XP> ().presetXPMax = 6300;
		} else if (level == 12) {
			player.GetComponent<XP> ().presetXPMax = 7100;
		} else if (level == 13) {
			player.GetComponent<XP> ().presetXPMax = 7900;
		} else if (level == 14) {
			player.GetComponent<XP> ().presetXPMax = 8700;
		} else if (level == 15) {
			player.GetComponent<XP> ().presetXPMax = 9700;
		} else if (level == 16) {
			player.GetComponent<XP> ().presetXPMax = 10700;
		} else if (level == 17) {
			player.GetComponent<XP> ().presetXPMax = 11700;
		} else if (level == 18) {
			player.GetComponent<XP> ().presetXPMax = 12700;
		} else if (level == 19) {
			player.GetComponent<XP> ().presetXPMax = 13700;
		} else if (level == 20) {
			player.GetComponent<XP> ().presetXPMax = 14900;
		} else if (level == 21) {
			player.GetComponent<XP> ().presetXPMax = 16100;
		} else if (level == 22) {
			player.GetComponent<XP> ().presetXPMax = 17300;
		} else if (level == 23) {
			player.GetComponent<XP> ().presetXPMax = 18500;
		} else if (level == 24) {
			player.GetComponent<XP> ().presetXPMax = 19700;
		} else if (level == 25) {
			player.GetComponent<XP> ().presetXPMax = 21100;
		} else if (level == 26) {
			player.GetComponent<XP> ().presetXPMax = 21500;
		} else if (level == 27) {
			player.GetComponent<XP> ().presetXPMax = 22900;
		} else if (level == 28) {
			player.GetComponent<XP> ().presetXPMax = 24300;
		} else if (level == 29) {
			player.GetComponent<XP> ().presetXPMax = 25700;
		} else if (level == 30) {
			player.GetComponent<XP> ().presetXPMax = 27300;
		} else if (level == 31) {
			player.GetComponent<XP> ().presetXPMax = 28900;
		} else if (level == 32) {
			player.GetComponent<XP> ().presetXPMax = 30500;
		}




		
	}
}
