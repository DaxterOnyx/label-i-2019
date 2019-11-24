using UnityEngine;

public class EnnemySpawner : MonoBehaviour
{
	public Vector2 Min =new Vector2(-100,-100);
	public Vector2 Max =new Vector2(100,100);

	internal float cpt;
	/// <summary>
	/// seuil
	/// </summary>
	public float threshold;
	public GameObject EnnemyPrefab;
	public int ennemy_max;
	public int ennemy_nb;
	// Start is called before the first frame update
	void Start()
	{
		cpt = 0;
		ennemy_nb = 0;
		ennemy_max = 60;

	}

	// Update is called once per frame
	void Update()
	{
		if (ennemy_nb < ennemy_max) {
			if (cpt >= threshold) {
				Vector3 pos = new Vector3(Random.Range(Min.x, Max.x), 0.5f, Random.Range(Min.y, Max.y));
				Instantiate(EnnemyPrefab,pos,Quaternion.identity,transform);
				ennemy_nb += 1;
				cpt = 0;
			} 
		}
		cpt += Time.deltaTime;
	}
}
