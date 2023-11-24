using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clutter_Generator : MonoBehaviour
{
    //all clutter object here. list might be easier.
	public GameObject grass1;
	public GameObject grass2;
	public GameObject grass3;
	public GameObject desert1;
	public GameObject desert2;
	public GameObject water1;
	public GameObject rock1;

	private RaycastHit hit;
	private int roll=0;


	public IEnumerator createClutter(int xmapmax, int zmapmax){

		//check to see what was hit. once something was hit, roll to decide what gets placed.
		//place that cluter where the object that got hit was.




		for (float x=0; x<xmapmax; x++){
			if (x%2==0){

				for(float z=0; z<zmapmax; z++){

					if (Physics.Raycast(new Vector3(-.75f*x,1f,0-.86f*z), Vector3.down,out hit, 3f)){

						if (hit.collider.gameObject.name=="Water(Clone)"){
							roll = Random.Range(1,4);
							if (roll==1){

								Instantiate(water1, hit.transform.position, Quaternion.Euler(new Vector3(0,Random.Range(0,6)*60,0)));
							}
						}

						if (hit.collider.gameObject.name=="Grass(Clone)"){
							roll = Random.Range(1,6);
							if (roll==1){

								Instantiate(grass1, hit.transform.position, Quaternion.Euler(new Vector3(0,Random.Range(0,6)*60,0)));
							}

							if (roll==2){

								Instantiate(grass2, hit.transform.position, Quaternion.Euler(new Vector3(0,Random.Range(0,6)*60,0)));
							}

							if (roll==3){

								Instantiate(grass3, hit.transform.position, Quaternion.Euler(new Vector3(0,Random.Range(0,6)*60,0)));
							}


						}

						if (hit.collider.gameObject.name=="Rock(Clone)"){
							roll = Random.Range(1,3);
							if (roll==1){

								Instantiate(rock1, hit.transform.position, Quaternion.Euler(new Vector3(0,Random.Range(0,6)*60,0)));
							}

							}

						if (hit.collider.gameObject.name=="Desert(Clone)"){
							roll = Random.Range(1,5);
							if (roll==1){

								Instantiate(desert1, hit.transform.position, Quaternion.Euler(new Vector3(0,Random.Range(0,6)*60,0)));
							}

							if (roll==2){
								Instantiate(desert2, hit.transform.position, Quaternion.Euler(new Vector3(0,Random.Range(0,6)*60,0)));
							}

						}

					//Instantiate(grasstile, new Vector3(-.75f*x,0,0-.86f*z), Quaternion.identity);

					}
				}
			
			}

			if (x%2==1){

				for(float z=0; z<zmapmax; z++){

					if (Physics.Raycast(new Vector3(-.75f*x,1f,-.43f-.86f*z), Vector3.down,out hit, 3f)){

						if (hit.collider.gameObject.name=="Water(Clone)"){
							roll = Random.Range(1,4);
							if (roll==1){

								Instantiate(water1, hit.transform.position, Quaternion.identity);
							}
						}

						if (hit.collider.gameObject.name=="Grass(Clone)"){
							roll = Random.Range(1,3);
							if (roll==1){

								Instantiate(grass1, hit.transform.position, Quaternion.identity);
							}

						}

						if (hit.collider.gameObject.name=="Rock"||hit.collider.gameObject.name=="Rock (1)"||hit.collider.gameObject.name=="Rock (2)"||hit.collider.gameObject.name=="Rock (3)"){
							roll = Random.Range(1,3);
							if (roll==1){

								Instantiate(rock1, hit.transform.position, Quaternion.identity);
							}

						}

						if (hit.collider.gameObject.name=="Sand(Clone)"){
							roll = Random.Range(1,3);
							if (roll==1){

								Instantiate(desert1, hit.transform.position, Quaternion.identity);
							}

						}

						//Instantiate(grasstile, new Vector3(-.75f*x,0,0-.86f*z), Quaternion.identity);

					}
				}
					//Instantiate(grasstile, new Vector3(-.75f*x,0,-.43f-.86f*z), Quaternion.identity);

				}
			}

		yield return null;
		StartCoroutine(gameObject.GetComponent<Resource_Placer>().placeWoods(xmapmax, zmapmax));
		}

		
	}



