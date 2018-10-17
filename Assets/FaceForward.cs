using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceForward : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
        Vector3 newRotation = Vector3.down * transform.parent.rotation.y;
        transform.eulerAngles = newRotation;
	}
}
