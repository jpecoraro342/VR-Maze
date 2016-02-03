using UnityEngine;
using System.Collections;

public class Deathwing : MonoBehaviour {

	public AudioSource dragonSound;
	public ParticleSystem flameParticles;

	public float flameDuration;
	public float particleSystemDelay;

	private float timeWeHaveWeBeenFlaming;

	private bool isFlaming;
	private bool particlesStartedPlaying;

	// Use this for initialization
	void Start () {
		stopAllFlaming();
	}
	
	// Update is called once per frame
	void Update () {
		if (isFlaming) {
			timeWeHaveWeBeenFlaming += Time.deltaTime;

			if (timeWeHaveWeBeenFlaming >= particleSystemDelay && !particlesStartedPlaying) {
				startFlameParticleSystem();
			}

			if (timeWeHaveWeBeenFlaming >= flameDuration) {
				stopAllFlaming();
			}
		}
	}

	void OnTriggerEnter(Collider other) {
		if (!isFlaming) {
			startFlaming();
		}
	}

	void startFlaming() {
		isFlaming = true;
		timeWeHaveWeBeenFlaming = 0;
		dragonSound.Play();
	}

	void startFlameParticleSystem() {
		particlesStartedPlaying = true;
		flameParticles.gameObject.SetActive(true);
	}

	void stopAllFlaming() {
		isFlaming = false;
		particlesStartedPlaying = false;
		timeWeHaveWeBeenFlaming = 0;
		dragonSound.Stop();
		flameParticles.gameObject.SetActive(false);
	}
			
}
