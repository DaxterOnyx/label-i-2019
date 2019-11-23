using UnityEngine;

public class Horseman : MonoBehaviour
{
	[SerializeField]
	private HorsemanData HorsemanData;
	private int HealthPoints;

	private void Start()
	{
		HealthPoints = HorsemanData.MaxHealthPoint;
	}
}