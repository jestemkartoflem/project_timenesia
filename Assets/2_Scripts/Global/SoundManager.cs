using UnityEngine;

namespace _2_Scripts.Global
{
	public class SoundManager : MonoBehaviour
	{
		public AudioSource EffectsSource;
		public AudioSource MusicSource;
		// Random pitch adjustment range.
		public float LowPitchRange = .95f;
		public float HighPitchRange = 1.05f;
	
		public static SoundManager Instance = null;
	
		private void Awake()
		{
			if (Instance == null)
			{
				Instance = this;
			}
			else if (Instance != this)
			{
				Destroy(gameObject);
			}
			DontDestroyOnLoad (gameObject);
		}
	
		// Play a single clip through the sound effects source.
		public void Play(AudioClip clip)
		{
			EffectsSource.clip = clip;
			EffectsSource.Play();
		}
	
		// Play a single clip through the sound effects source.
		public void PlayOnce(AudioClip clip)
		{
			EffectsSource.PlayOneShot(clip);
		}
	
		// Play a single clip through the music source.
		public void PlayMusic(AudioClip clip)
		{
			MusicSource.clip = clip;
			MusicSource.Play();
		}
	
		// Play a random clip from an array, and randomize the pitch slightly.
		public void RandomSoundEffect(params AudioClip[] clips)
		{
			int randomIndex = Random.Range(0, clips.Length);
			float randomPitch = Random.Range(LowPitchRange, HighPitchRange);
			EffectsSource.pitch = randomPitch;
			EffectsSource.clip = clips[randomIndex];
			EffectsSource.Play();
		}
	}
}