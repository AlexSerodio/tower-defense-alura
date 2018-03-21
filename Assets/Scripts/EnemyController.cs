using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {

	// Use this for initialization
	void Start () {

		NavMeshAgent agent = GetComponent<NavMeshAgent>();
		GameObject endOfTheRoad = GameObject.Find("EndOfTheRoad");
		agent.SetDestination (endOfTheRoad.transform.position);
	}
}
