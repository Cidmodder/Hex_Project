using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
  
	void Awake(){

		if (transform.position.x > 0 || transform.position.x < -40 || transform.position.z > 0 || transform.position.z <-40){
			print("x: "+transform.position.x + " z: "+transform.position.z);
			//Destroy(gameObject);
		}
	}

	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void destroySelf(){

		Destroy(gameObject);
	}
}
