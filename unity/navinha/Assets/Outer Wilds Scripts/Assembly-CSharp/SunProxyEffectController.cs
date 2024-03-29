using UnityEngine;

public class SunProxyEffectController : MonoBehaviour
{
	[SerializeField]
	private Renderer _atmosphere;
	[SerializeField]
	private Renderer _fog;
	[SerializeField]
	private TessellatedSphereRenderer _surface;
	[SerializeField]
	private SolarFlareEmitter _solarFlareEmitter;
	[SerializeField]
	private Transform _lightShaftRoot;
	[SerializeField]
	private SupernovaEffectController _proxySupernova;
	[SerializeField]
	protected float _rayleighCurveMinDistance = 45000f;
	[SerializeField]
	protected float _rayleighCurveMaxDistance = 1250000f;
	[SerializeField]
	protected float _rayleighCurveMinVal;
	[SerializeField]
	protected float _rayleighCurveMaxVal;
	[SerializeField]
	protected AnimationCurve _rayleighCurve;
}
