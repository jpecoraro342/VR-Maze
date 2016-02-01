#pragma strict
var opening:AudioClip;

function OnTriggerEnter (obj : Collider) {
	var thedoor = gameObject.FindWithTag("SF_Door8");
	thedoor.GetComponent.<Animation>().Play("open");
	GetComponent.<AudioSource>().clip = opening;
	GetComponent.<AudioSource>().Play();
	yield WaitForSeconds (3);
	GetComponent.<AudioSource>().Stop();
}

function OnTriggerExit (obj : Collider) {
	var thedoor = gameObject.FindWithTag("SF_Door8");
	thedoor.GetComponent.<Animation>().Play("close");
}