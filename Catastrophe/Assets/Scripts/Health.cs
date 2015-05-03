using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	public RectTransform healthTransform;
	private float cachedY;
	private float minXValue;
	private float maxXValue;
	private int currentHealth;

	public int CurrentHealth {
		get {return currentHealth;}
		set {currentHealth = value;
			HandleHealth ();
		}
	}

	public int maxHealth;
	public Text healthText;
	public Image visualHealth;

	// Use this for initialization
	void Start () {
		cachedY = healthTransform.position.y;
		maxXValue = healthTransform.position.x;
		minXValue = healthTransform.position.x - healthTransform.rect.width;
		currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.collider.tag == "Table") {
			if(currentHealth > 0)
			CurrentHealth -= 5;
		}
	}

	private void HandleHealth()
	{
		//healthText.text = "Health: " + currentHealth;

		float currentXValue = MapValues (currentHealth, 0, maxHealth, minXValue, maxXValue);

		healthTransform.position = new Vector3 (currentXValue, cachedY);

		if (currentHealth > maxHealth / 2) 
		{
			visualHealth.color = new Color32((byte)MapValues (currentHealth, maxHealth/2, maxHealth, 255, 0), 255, 0, 255);
		} else 
		{
			visualHealth.color = new Color32(255, (byte)MapValues(currentHealth,0,maxHealth/2,0,255),0,255); 
		}
	}

	private float MapValues(float x, float inMin, float inMax, float outMin, float outMax)
	{
		return (x - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
	}
}
