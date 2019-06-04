using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour {
    public Transform target;
    [SerializeField]
    float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(target.position, Vector3.up, speed);
	
	}
}
