using UnityEngine;

public class DreamTorch : MonoBehaviour
{
	[SerializeField]
	private bool _startLit = true;
	[Space]
	[SerializeField]
	private LightSensor _lightSensor;
	[SerializeField]
	private InteractReceiver _interactReceiver;
	[SerializeField]
	private OWLightController _lightController;
	[SerializeField]
	private ParticleSystem _flameParticles;
}
