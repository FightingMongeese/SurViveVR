using UnityEngine;
using System.Collections;

public class FireManager : MonoBehaviour {
	public int fireState = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
//	void Update () {
//		
//		FireStateMachine (fireState);
//	}
//
//	private void FireStateMachine (int i) {
//		switch (i) {
//		case 1:
//			break;
//		case 2:
//			break;
//		case 3:
//			break;
//		case 4:
//			break;
//		default:
//			break;
//		}
//	}
//
//	private void LightBehavior () {
//		float phi = Time.time / duration * 2 * Mathf.PI;
//		//float amplitude = Mathf.Cos(phi) * 0.5F + 0.5F;
//		float flicker = Mathf.PerlinNoise (phi, 0.0F);
//		//lt.intensity = flicker;
//		lt.intensity = flicker * Mathf.Lerp (1f, 0f, Time.time / 5);
//	}
}
