using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Life))]
public class Ennemy : MonoBehaviour
{
	Life life;

	// Start is called before the first frame update
	void Start()
    {
		life = GetComponent<Life>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
