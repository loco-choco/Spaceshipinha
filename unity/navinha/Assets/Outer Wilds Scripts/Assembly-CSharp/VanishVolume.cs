using UnityEngine;

[RequireComponent(typeof(Collider))]
public class VanishVolume : MonoBehaviour
{
	[SerializeField]
	private GameObject _vanishEffectPrefab;
	[SerializeField]
	private bool _onlyAffectsPlayerAndShip;
	[SerializeField]
	private bool _shrinkBodies = true;
}
