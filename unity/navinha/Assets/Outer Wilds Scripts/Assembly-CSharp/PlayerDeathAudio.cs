using UnityEngine;

[RequireComponent(typeof(OWAudioSource))]
public class PlayerDeathAudio : MonoBehaviour
{
	[SerializeField]
	private OWAudioSource _deathSource;
	[SerializeField]
	private OWAudioSource _helmetCrackSource;
	[SerializeField]
	private OWAudioSource _shipGroanSource;
}
