using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class XP : MonoBehaviour {

	public GameObject player;
	public RectTransform xpTransform;
	private float cachedY;
	private float minXValue;
	private float maxXValue;
	private int currentXP;
	public int CurrentXP {
		get {return currentXP;}
		set {currentXP = value;
			HandleXP ();
		}
	}

	public int presetXPMax;
	public static int realXP = 0;

	public Text XPText;

	void Start(){
		cachedY = xpTransform.position.y;
		maxXValue = xpTransform.position.x;
		minXValue = xpTransform.position.x - xpTransform.rect.width;
		currentXP = presetXPMax;
		XPText.text = "XP: " + realXP + "/" + presetXPMax;
	}

	void Update(){
		if (realXP == presetXPMax) {
			currentXP = 0;
			realXP = 0;
			player.GetComponent<Levels>().level += 1;


		}
	}

	private void HandleXP()
	{

		XPText.text = "XP: " + realXP + "/" + presetXPMax;

		float currentXVulue = MapValues (currentXP, 0, presetXPMax, minXValue, maxXValue);

		xpTransform.position = new Vector3 (currentXVulue, cachedY); 
	}

	private float MapValues(float x, float inMin, float inMax, float outMin, float outMax)
	{
		return (x - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
	}

}
