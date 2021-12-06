using UnityEngine;

public class AudioHandler : MonoBehaviour {
	public AudioClip track;
	public AudioClip click;
	public AudioClip error;
	public AudioClip success;

	public AudioSource source;

	private void Start() {
		PlayTrack();
	}
	
	public void Pause() {
		source.Pause();
	}

	public void PlayTrack() {
		source.clip = track;
		source.loop = true;
		source.Play();
	}
	
	public void PlayClick() {
		source.PlayOneShot(click);
	}
	
	public void PlaySuccess() {
		source.PlayOneShot(success);
	}
	
	public void PlayError() {
		source.PlayOneShot(error);
	}
}