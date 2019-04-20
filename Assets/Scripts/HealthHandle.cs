using UnityEngine;
using UnityEngine.UI;

public class HealthHandle : MonoBehaviour {

	[SerializeField]
	private PlayerController player;
	private Text healthText;

	void Start() {
		healthText = GetComponent<Text>();
	}

	void Update() {
		healthText.text = "Vida: " + player.Health;
	}
}
