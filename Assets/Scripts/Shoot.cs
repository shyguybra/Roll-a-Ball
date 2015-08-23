using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	private Rigidbody rb;
	public GameObject reference;
	public float speed;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 movement = reference.transform.position;
		rb.AddForce (movement * speed);
	}
}
