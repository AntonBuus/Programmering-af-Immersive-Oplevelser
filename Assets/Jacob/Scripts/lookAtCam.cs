using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtCam : MonoBehaviour
{
	//[SerializeField] private transform cam;
	[SerializeField] private Transform cam_;

	void LateUpdate() {
		transform.LookAt(transform.position + cam_.rotation * Vector3.forward, cam_.rotation * Vector3.up);
	}
}
