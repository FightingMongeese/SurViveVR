#pragma strict

private gameState : string = "enter"

//Start
function Start () {

}

//Update
function Update () {
	FSM(gameState);
}

//FSM
function FSM (gameState: string) {
	switch {
		case:"enter"
				break;
		case:"execute"
				break;
		case:"exit"
				break;
	}
}