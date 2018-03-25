using UnityEngine;

public class EndDetector : MonoBehaviour {

	[SerializeField]
	private PlayerController player;

	void OnTriggerEnter (Collider other)
	{
		if (other.CompareTag ("Enemy")) {
			Destroy(other.gameObject);
			player.LoseHealth();
		}
	}
}
