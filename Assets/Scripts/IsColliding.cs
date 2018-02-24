using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsColliding : MonoBehaviour
{
	[SerializeField] GameObject tree;
	
	private CameraFade cameraFade;

	private void Start()
	{
		cameraFade = tree.GetComponent<CameraFade>();
	}

	public void OnTriggerEnter(Collider other)
	{
		if (other.tag == "MainCamera")
		{
			cameraFade.CameraColliding = true;
		}
		if (other.tag == "Player")
		{
			cameraFade.PlayerColliding = true;
		}
	}

	public void OnTriggerExit(Collider other)
	{
		if (other.tag == "MainCamera")
		{
			cameraFade.CameraColliding = false;
		}
		if (other.tag == "Player")
		{
			cameraFade.PlayerColliding = false;
		}
	}
}
