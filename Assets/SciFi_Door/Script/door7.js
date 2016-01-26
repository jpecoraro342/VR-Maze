#pragma strict


function OnTriggerEnter (obj : Collider) {
    var thedoor = gameObject.FindWithTag("SF_Door7");
    thedoor.GetComponent.<Animation>().Play("open");
}

    function OnTriggerExit (obj : Collider) {
        var thedoor = gameObject.FindWithTag("SF_Door7");
        thedoor.GetComponent.<Animation>().Play("close");
    }