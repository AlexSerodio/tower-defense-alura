using UnityEngine;
using UnityEngine.UI;

public class HealthHandle : MonoBehaviour {

	private Text healthText;
	[SerializeField]
	private PlayerController player;

	void Start () 
	{
		healthText = GetComponent<Text> ();
	}

	void Update () 
	{
		healthText.text = "Vida: " + player.Health;
	}
}
