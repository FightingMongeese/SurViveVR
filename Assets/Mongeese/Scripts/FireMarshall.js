#pragma strict

var fireState : String = "none";
var flame : Light;

var flicker : float = 1.0;
var rate : float = 1.0;
var phi : float = 1.0;

//Start
function Start () {

}

//Update
function Update () {
	if (Input.GetKeyDown ("space")){ fireState="mid";}
	if (Input.GetKeyUp ("space")){ fireState="old"; }
	FSM(fireState);
}

//FSM
function FSM (fireState : String) {
	switch (fireState) {
		case "none": 	
		break;

		case "sparked":
		break;

		case "new":
		break;

		case "mid":
		FlameLightFlicker();
		break;

		case "old":
		FlameLightFade();
		Debug.Log("OLD");
		break;

		case "dead":
		break;
	}
}


//FlameLightFlicker
function FlameLightFlicker()  {
	phi = Time.time / rate * 2 * Mathf.PI;
	flicker = Mathf.PerlinNoise(phi, 0.0);
	flame.intensity = flicker;
}


//FlameLightFade
function FlameLightFade() {
	phi = Time.time / rate * 2 * Mathf.PI;
	flicker = Mathf.PerlinNoise(phi, 0.0);
	flame.intensity = flicker * Mathf.Lerp(1.0, 0.0, 5);
}