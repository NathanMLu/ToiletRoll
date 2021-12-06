using UnityEngine;

public class AudioHandler : MonoBehaviour {
	public AudioClip track;
	public AudioClip roll;
	public AudioClip click;
	public AudioClip win;
	public AudioClip funny;

	private AudioSource source;

	private void Start() {
		source = GetComponent<AudioSource>();
		BackgroundMusic();
	}

	public void BackgroundMusic() {
		source.PlayOneShot(track);
	}
}