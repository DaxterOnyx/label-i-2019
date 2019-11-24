using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
	internal int HealthPoints;
	internal int MaxHealth;
	public Image HealthBar;

	public void TakeDamage(int damage)
	{
		HealthPoints -= damage;
		HealthBar.fillAmount = (float)HealthPoints / MaxHealth;
	}

	//TODO BRICE REMOVE THAT
	private void OnCollisionEnter(Collision collision)
	{
		TakeDamage(10);
	}
}

