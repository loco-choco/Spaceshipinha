using UnityEngine;

public class ExplosionController : MonoBehaviour
{
	[SerializeField]
	private RadialForceVolume _forceVolume;
	[SerializeField]
	private MeshRenderer _renderer;
	[SerializeField]
	private Light _light;
	[Space]
	[SerializeField]
	private float _length = 1f;
}
