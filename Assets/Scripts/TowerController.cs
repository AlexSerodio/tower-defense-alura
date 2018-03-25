using UnityEngine;

public class TowerController : MonoBehaviour {

	public GameObject projectilePrefab; 	
	[Range(0,3)]
	public float reloadTime = 1f;

	private float lastShotTime;

	void Update () 
	{
		Shoot();
	}

	private void Shoot () 
	{
		float currentTime = Time.time;
		if (currentTime > lastShotTime + reloadTime) {
			lastShotTime = currentTime;
			Transform shooterPoint = this.transform.Find("TowerCannon/ShooterPoint");
			Instantiate(projectilePrefab, shooterPoint.position, Quaternion.identity);
		}
	}
}
