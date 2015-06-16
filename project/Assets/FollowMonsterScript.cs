using UnityEngine;
using System.Collections;

public class FollowMonsterScript : MonoBehaviour {

	// Use this for initialization
	public Transform monster;
	Vector3 translate;
	void Start () {
		translate = monster.position - transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = monster.position - translate;
	}
}
