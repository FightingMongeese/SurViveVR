#pragma strict

var gameState : String = "enter";

//Start
function Start () {

}

//Update
function Update () {
	FSM(gameState);
}

//FSM
function FSM (gameState: String) {
	switch (gameState){
		case "enter":
				break;
		case "execute":
				break;
		case "exit":
				break;
	}
}