using UnityEngine;

public class GhostEffects : MonoBehaviour
{
	public enum MovementStyle
	{
		Normal,
		Stalk,
		Chase
	}

	public enum DeathAnimStyle
	{
		Random = -1,
		Reaching = 0,
		Reaching_Jittery = 1,
		Crunchy = 2,
		DramaClub = 3,
	}

	[SerializeField]
	private Sector _sector;
	[Space]
	[SerializeField]
	private DeathAnimStyle _deathAnimStyle = DeathAnimStyle.Random;
	[SerializeField]
	private bool _ignoreSleepAnimation;
	[Header("Audio")]
	[SerializeField]
	private OWAudioSource _lanternAudioSource;
	[SerializeField]
	private OWAudioSource _voiceAudioSourceNear;
	[SerializeField]
	private OWAudioSource _voiceAudioSourceFar;
	[SerializeField]
	private OWAudioSource _feetAudioSourceNear;
	[SerializeField]
	private OWAudioSource _feetAudioSourceFar;
	[Header("Visuals")]
	[SerializeField]
	private OWRenderer[] _dissolveRenderers;
	[SerializeField]
	private OWRenderer[] _ditherRenderers;
	[SerializeField]
	private OWEmissiveRenderer[] _eyeRenderers;
	[SerializeField]
	private ParticleSystem _deathParticleSystem;
	[Header("IK")]
	[SerializeField]
	private GhostIK _ghostIKController;
	[SerializeField]
	private Transform _ikTargetHoldingLantern;
	[SerializeField]
	private Transform _ikHintHoldingLantern;
}
