using UnityEngine;

public class Projectile : MonoBehaviour {

	private float speed = 10f;
	private GameObject target;

	void Start() {
		target = GameObject.Find("Enemy");
	}

	void Update () {
		Walk();	
		ChangeDirection();
	}

	private void Walk () {
		transform.position += transform.forward * Time.deltaTime * speed; 
	}

	private void ChangeDirection () {
		transform.rotation = Quaternion.LookRotation(target.transform.position - transform.position);
	}
}
