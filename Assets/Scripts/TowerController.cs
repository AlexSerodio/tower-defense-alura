using UnityEngine;

public class TowerController : MonoBehaviour {

	public GameObject projectilePrefab; 	
	public float reloadTime = 1f;

	private float lastShotTime;

	void Update () {
		Shoot();
	}

	private void Shoot () {
		float currentTime = Time.time;
		if (currentTime > lastShotTime + reloadTime) {
			lastShotTime = currentTime;
			Transform shooterPoint = this.transform.Find("TowerCannon/ShooterPoint");
			Instantiate(projectilePrefab, shooterPoint.position, Quaternion.identity);
		}
	}
}
