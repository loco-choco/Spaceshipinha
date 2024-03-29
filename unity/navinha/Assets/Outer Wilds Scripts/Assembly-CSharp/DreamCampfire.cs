using UnityEngine;

public class DreamCampfire : Campfire
{
	[Space]
	[SerializeField]
	private DreamArrivalPoint.Location _dreamArrivalLocation;
	[SerializeField]
	private OWTriggerVolume[] _entrywayVolumes;
	[SerializeField]
	private CustomCollisionChecker _collisionChecker;
	[SerializeField]
	private OWTriggerVolume _dreamOnDeathVolume;
	[SerializeField]
	private AlarmBell _alarmBell;
	[SerializeField]
	private OWFlameController _mummyCircleFlameController;
	[SerializeField]
	private OWLightController _houseLightController;
}
