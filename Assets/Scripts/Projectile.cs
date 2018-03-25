using UnityEngine;

public class Projectile : MonoBehaviour {

	[SerializeField]
	private int damage;
	private float speed = 10f;
	private GameObject target;

	void Start() 
	{
		target = GameObject.Find("Enemy");
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

	/// <summary>
	/// OnTriggerEnter is called when the Collider other enters the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>
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
