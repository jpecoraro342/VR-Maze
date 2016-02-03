using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour {

	Animator animator;

	public AudioSource zombieSound;
	public float lightDuration;
	public GameObject lightSource;

	bool isAttacking;
	float currentAttackingTime;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		resetValues();
	}
	
	// Update is called once per frame
	void Update () {
		if (isAttacking) {
			currentAttackingTime += Time.deltaTime;

			if (currentAttackingTime >= lightDuration) {
				resetValues();
			}
		}
	}

	void OnTriggerEnter(Collider col)
	{
		animator.SetTrigger("Attack");
		isAttacking = true;
		lightSource.SetActive(true);
		zombieSound.Play();
	}

	void resetValues() {
		lightSource.SetActive(false);
		isAttacking = false;
		currentAttackingTime = 0;
		zombieSound.Stop();
	}
}
