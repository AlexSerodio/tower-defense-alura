using UnityEngine;

public class Projectile : MonoBehaviour {

	private float speed = 10f;

	void Update () {
		Walk();
	}

	private void Walk () {
		transform.position += transform.forward * Time.deltaTime * speed; 
	}
}
