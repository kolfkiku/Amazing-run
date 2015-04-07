using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	public float speed = 0.5f;

	// Use this for initialization
	void Start () {
		transform.position = new Vector2 (0,0);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector2 (0,10);
	}
}
