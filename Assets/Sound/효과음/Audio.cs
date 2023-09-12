using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio: MonoBehaviour {

	public int[] number = { 0, 2, 1, 1 };
	public float[] seconds = { 0, 2.0f, 5.0f, 5.0f };
	int num;
	float sec;
	public AudioClip[] source = new AudioClip[4];
	public AudioSource audio1;
	public static int which =0;

	void Start(){
		audio1 = gameObject.GetComponent<AudioSource> ();
	}

	void Update(){
		for (int i = 1; i < 4; i++) {
			if (which == i) {
				audio1.clip = source [i];
				num = number [i];
				sec = seconds [i];
				StartCoroutine (playSound ());
				which = 0;
			}
		}

	}
		

	IEnumerator playSound() {
		yield return new WaitForSeconds (1.0f);
		int x=0;
		while (x <num) {
			audio1.Play (0);
			yield return new WaitForSeconds(sec);
			audio1.Stop();
			x++;
		}

	}

}
