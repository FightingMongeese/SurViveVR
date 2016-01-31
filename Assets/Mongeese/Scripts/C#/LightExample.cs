using UnityEngine;
using System.Collections;

public class LightExample : MonoBehaviour {
	public float duration = 1.0F;
	public Light lt;
	void Start() {
		lt = GetComponent<Light>();
	}
	void Update() {
		float phi = Time.time / duration * 2 * Mathf.PI;
		//float amplitude = Mathf.Cos(phi) * 0.5F + 0.5F;
		float flicker = Mathf.PerlinNoise(phi, 0.0F);
		//lt.intensity = flicker;
		lt.intensity = flicker * Mathf.Lerp(1f, 0f, Time.time / 5);
	}
}