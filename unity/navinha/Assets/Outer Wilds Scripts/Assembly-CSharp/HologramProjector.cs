using UnityEngine;

public class HologramProjector : MonoBehaviour
{
	[SerializeField]
	private Transform _hologramSpawnPoint;
	[SerializeField]
	private Transform _hologramDisplayPoint;
	[Space]
	[SerializeField]
	private OWAudioSource _oneShotAudioSource;
	[SerializeField]
	private OWAudioSource _loopingAudioSource;
	[Space]
	[SerializeField]
	private Renderer _poolRenderer;
	[SerializeField]
	private Material _poolInactiveMaterial;
	[SerializeField]
	private Material _poolActiveMaterial;
	[SerializeField]
	private float _poolTransitionLength = 1f;
}
