using UnityEngine;

public class Projectile : MonoBehaviour {

	[SerializeField]
	private int damage;
	private float speed = 10f;
	private GameObject target;

	void Start() 
	{
		GameObject[] targets = GameObject.FindGameObjectsWithTag("Enemy");
		if (targets.Length > 0)
			target = targets[0];
		SelfDestroy(5f);
	}

	void Update () 
	{
		Walk();	
		if (target != null)
			ChangeDirection();
	}

	private void Walk () 
	{
		transform.position += transform.forward * Time.deltaTime * speed; 
	}

	private void ChangeDirection () 
	{
		transform.rotation = Quaternion.LookRotation(target.transform.position - transform.position);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Enemy")) {
			Destroy(gameObject);
			EnemyController enemy = other.GetComponent<EnemyController>();
			enemy.LoseHealth(damage);
		}
	}

	private void SelfDestroy (float time) 
	{
		Destroy(gameObject, time);
	}
}
