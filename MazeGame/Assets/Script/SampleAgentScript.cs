using UnityEngine;
using System.Collections;

public class SampleAgentScript : MonoBehaviour {
	NavMeshAgent agent;
	private Vector3 target;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {

			RaycastHit hit;
				
			if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hit, 100)) {

				agent.destination = hit.point;
			}

		}



		//agent.SetDestination (target.position);
			
			
	}
}