using UnityEngine;

[RequireComponent(typeof(Animator))]
public class KidRockController : CharacterAnimController
{
	[SerializeField]
	private OWRigidbody _rockBody;
	[SerializeField]
	private Collider _rockCollider;
	[SerializeField]
	private OWRenderer _proxyRock;
}
