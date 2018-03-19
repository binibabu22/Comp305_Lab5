using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;
    
	void Start () {
        offset = transform.position - player.transform.position; // offset is obtained by subtacting the cameras transform position with player's transform position

	}

    //LateUpdate() used to run after all the child elements in the frame are runnned 
    void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
