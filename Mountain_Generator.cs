using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mountain_Generator : MonoBehaviour
{

	public GameObject mountain9;
	public GameObject mountain8;
	public GameObject mountain7;
	public GameObject mountain6;
	public GameObject mountain5;
	public GameObject mountain4;
	public GameObject mountain3;
	public GameObject mountain2;
	public GameObject mountain1;
	public int height=9;
	public int x=0;
	public int z=0;
	private int skip=0;
	private RaycastHit hit;
	private int placedTile=0;
	private int xstart=0;

	//skip if you hit water. Need to add a check that searches more area, maybe with spehere cast and try again?
	void destroyTile(){

		if(x%2==0){
			if (Physics.Raycast(new Vector3(-.75f*x,1f,0-.86f*z), Vector3.down,out hit, 3f)){

				//checks if hit water tile. be sure to use IEnumerator on the previous water step if needs to be completed first
				if (hit.collider.gameObject.name=="Water(Clone)"){
					skip++;

				}

			}
		}

		if(x%2==1){

			if (Physics.Raycast(new Vector3(-.75f*x,1f,-.43f-.86f*z), Vector3.down,out hit, 3f)){
				//print("I hit: "+hit.collider.gameObject.name);
				if (hit.collider.gameObject.name=="Water(Clone)"){
					skip++;

				}

			}

		}
	}


	//spawns a mountain tile based on height and create a tile above and below
	void createTile(){


		//for height 9
		if(x%2==0 && skip==0 && height==9){
			GameObject tile = Instantiate(mountain9, new Vector3(-.75f*x,0f,-.86f*z), Quaternion.identity);
			gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile.transform.position);
			height = height - Random.Range(1,3);

			if (height==8){
				GameObject tile2 = Instantiate(mountain8, new Vector3(-.75f*x,0f,-.86f*z-.86f), Quaternion.identity);
				gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile2.transform.position);
				placedTile++;

			}

			if (height==7){
				GameObject tile3 = Instantiate(mountain7, new Vector3(-.75f*x,0f,-.86f*z-.86f), Quaternion.identity);
				gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile3.transform.position);
				placedTile++;
			}

		}

		if(x%2==1 && skip==0 && height==9){
			GameObject tile = Instantiate(mountain9, new Vector3(-.75f*x,0f,-.43f-.86f*z), Quaternion.identity);
			gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile.transform.position);
			height = height - Random.Range(1,3);

			if (height==8){
				GameObject tile2 = Instantiate(mountain8, new Vector3(-.75f*x,0f,-.43f-.86f*z-.86f), Quaternion.identity);
				gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile2.transform.position);
				placedTile++;
			}

			if (height==7){

				GameObject tile3 = Instantiate(mountain7, new Vector3(-.75f*x,0f,-.43f-.86f*z-.86f), Quaternion.identity);
				gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile3.transform.position);
				placedTile++;
			}

		}
		//end for height 9

		//for height 8
		if(x%2==0 && skip==0 && height==8 && placedTile==0){
			GameObject tile = Instantiate(mountain8, new Vector3(-.75f*x,0f,-.86f*z), Quaternion.identity);
			gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile.transform.position);

			height = height - Random.Range(1,3);

			if (height==7){
				GameObject tile2 = Instantiate(mountain7, new Vector3(-.75f*x,0f,-.86f*z-.86f), Quaternion.identity);
				gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile2.transform.position);
				placedTile++;
			}

			if (height==6){
				GameObject tile3 = Instantiate(mountain6, new Vector3(-.75f*x,0f,-.86f*z-.86f), Quaternion.identity);
				gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile3.transform.position);
				placedTile++;
			}

		}

		if(x%2==1 && skip==0 && height==8 && placedTile==0){
			GameObject tile = Instantiate(mountain8, new Vector3(-.75f*x,0f,-.43f-.86f*z), Quaternion.identity);
			gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile.transform.position);
			height = height - Random.Range(1,3);

			if (height==7){
				GameObject tile2 = Instantiate(mountain7, new Vector3(-.75f*x,0f,-.43f-.86f*z-.86f), Quaternion.identity);
				gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile2.transform.position);
				placedTile++;
			}

			if (height==6){

				GameObject tile3 = Instantiate(mountain6, new Vector3(-.75f*x,0f,-.43f-.86f*z-.86f), Quaternion.identity);
				gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile3.transform.position);
				placedTile++;
			}

		}

		//end for height 8

		//for height 7
		if(x%2==0 && skip==0 && height==7 && placedTile==0){
			GameObject tile = Instantiate(mountain7, new Vector3(-.75f*x,0f,-.86f*z), Quaternion.identity);
			gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile.transform.position);

			height = height - Random.Range(1,3);

			if (height==6){
				GameObject tile2 = Instantiate(mountain6, new Vector3(-.75f*x,0f,-.86f*z-.86f), Quaternion.identity);
				gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile2.transform.position);
				placedTile++;
			}

			if (height==5){
				GameObject tile3 = Instantiate(mountain5, new Vector3(-.75f*x,0f,-.86f*z-.86f), Quaternion.identity);
				gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile3.transform.position);
				placedTile++;
			}

		}

		if(x%2==1 && skip==0 && height==7 && placedTile==0){
			GameObject tile = Instantiate(mountain7, new Vector3(-.75f*x,0f,-.43f-.86f*z), Quaternion.identity);
			gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile.transform.position);
			height = height - Random.Range(1,3);

			if (height==6){
				GameObject tile2 = Instantiate(mountain6, new Vector3(-.75f*x,0f,-.43f-.86f*z-.86f), Quaternion.identity);
				gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile2.transform.position);
				placedTile++;
			}

			if (height==5){

				GameObject tile3 = Instantiate(mountain5, new Vector3(-.75f*x,0f,-.43f-.86f*z-.86f), Quaternion.identity);
				gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile3.transform.position);
				placedTile++;
			}

		}

		//end for height 7

		//for height 6
		if(x%2==0 && skip==0 && height==6 && placedTile==0){
			GameObject tile = Instantiate(mountain6, new Vector3(-.75f*x,0f,-.86f*z), Quaternion.identity);
			gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile.transform.position);

			height = height - Random.Range(1,3);

			if (height==5){
				GameObject tile2 = Instantiate(mountain5, new Vector3(-.75f*x,0f,-.86f*z-.86f), Quaternion.identity);
				gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile2.transform.position);
				placedTile++;
			}

			if (height==4){
				GameObject tile3 = Instantiate(mountain4, new Vector3(-.75f*x,0f,-.86f*z-.86f), Quaternion.identity);
				gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile3.transform.position);
				placedTile++;
			}

		}

		if(x%2==1 && skip==0 && height==6 && placedTile==0){
			GameObject tile = Instantiate(mountain6, new Vector3(-.75f*x,0f,-.43f-.86f*z), Quaternion.identity);
			gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile.transform.position);
			height = height - Random.Range(1,3);

			if (height==5){
				GameObject tile2 = Instantiate(mountain5, new Vector3(-.75f*x,0f,-.43f-.86f*z-.86f), Quaternion.identity);
				gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile2.transform.position);
				placedTile++;
			}

			if (height==4){

				GameObject tile3 = Instantiate(mountain4, new Vector3(-.75f*x,0f,-.43f-.86f*z-.86f), Quaternion.identity);
				gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile3.transform.position);
				placedTile++;
			}

		}

		//end for height 6

		//for height 5
		if(x%2==0 && skip==0 && height==5 && placedTile==0){
			GameObject tile = Instantiate(mountain5, new Vector3(-.75f*x,0f,-.86f*z), Quaternion.identity);
			gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile.transform.position);

			height = height - Random.Range(1,3);

			if (height==4){
				GameObject tile2 = Instantiate(mountain4, new Vector3(-.75f*x,0f,-.86f*z-.86f), Quaternion.identity);
				gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile2.transform.position);
				placedTile++;
			}

			if (height==3){
				Instantiate(mountain3, new Vector3(-.75f*x,0f,-.86f*z-.86f), Quaternion.identity);
				placedTile++;
			}

		}

		if(x%2==1 && skip==0 && height==5 && placedTile==0){
			GameObject tile = Instantiate(mountain5, new Vector3(-.75f*x,0f,-.43f-.86f*z), Quaternion.identity);
			gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile.transform.position);
			height = height - Random.Range(1,3);

			if (height==4){
				GameObject tile2 = Instantiate(mountain4, new Vector3(-.75f*x,0f,-.43f-.86f*z-.86f), Quaternion.identity);
				gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile2.transform.position);
				placedTile++;
			}

			if (height==3){

				Instantiate(mountain3, new Vector3(-.75f*x,0f,-.43f-.86f*z-.86f), Quaternion.identity);
				placedTile++;
			}

		}

		//end for height 5

		//for height 4
		if(x%2==0 && skip==0 && height==4 && placedTile==0){
			GameObject tile = Instantiate(mountain4, new Vector3(-.75f*x,0f,-.86f*z), Quaternion.identity);
			gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile.transform.position);

			height = height - Random.Range(1,3);

			if (height==3){
				Instantiate(mountain3, new Vector3(-.75f*x,0f,-.86f*z-.86f), Quaternion.identity);
				placedTile++;
			}

			if (height==2){
				Instantiate(mountain2, new Vector3(-.75f*x,0f,-.86f*z-.86f), Quaternion.identity);
				placedTile++;
			}

		}

		if(x%2==1 && skip==0 && height==4 && placedTile==0){
			GameObject tile = Instantiate(mountain4, new Vector3(-.75f*x,0f,-.43f-.86f*z), Quaternion.identity);
			gameObject.GetComponent<Resource_Placer>().MountainTilePosition.Add(tile.transform.position);
			height = height - Random.Range(1,3);

			if (height==3){
				Instantiate(mountain3, new Vector3(-.75f*x,0f,-.43f-.86f*z-.86f), Quaternion.identity);
				placedTile++;
			}

			if (height==2){

				Instantiate(mountain2, new Vector3(-.75f*x,0f,-.43f-.86f*z-.86f), Quaternion.identity);
				placedTile++;
			}

		}

		//end for height 4

		//for height 3
		if(x%2==0 && skip==0 && height==3 && placedTile==0){
			Instantiate(mountain3, new Vector3(-.75f*x,0f,-.86f*z), Quaternion.identity);

			height = height - Random.Range(1,3);

			if (height==2){
				Instantiate(mountain2, new Vector3(-.75f*x,0f,-.86f*z-.86f), Quaternion.identity);
				placedTile++;
			}

			if (height==1){
				Instantiate(mountain1, new Vector3(-.75f*x,0f,-.86f*z-.86f), Quaternion.identity);
				placedTile++;
			}

		}

		if(x%2==1 && skip==0 && height==3 && placedTile==0){
			Instantiate(mountain3, new Vector3(-.75f*x,0f,-.43f-.86f*z), Quaternion.identity);
			height = height - Random.Range(1,3);

			if (height==2){
				Instantiate(mountain2, new Vector3(-.75f*x,0f,-.43f-.86f*z-.86f), Quaternion.identity);
				placedTile++;
			}

			if (height==1){

				Instantiate(mountain1, new Vector3(-.75f*x,0f,-.43f-.86f*z-.86f), Quaternion.identity);
				placedTile++;
			}

		}

		//end for height 3

		//for height 2

		if(x%2==0 && skip==0 && height==2 && placedTile==0){
			Instantiate(mountain2, new Vector3(-.75f*x,0f,-.86f*z), Quaternion.identity);

			height = height - Random.Range(1,3);

			if (height==1){
				Instantiate(mountain1, new Vector3(-.75f*x,0f,-.86f*z-.86f), Quaternion.identity);
				placedTile++;
			}

			if (height==0){
				
				placedTile++;
			}

		}

		if(x%2==1 && skip==0 && height==2 && placedTile==0){
			Instantiate(mountain2, new Vector3(-.75f*x,0f,-.43f-.86f*z), Quaternion.identity);
			height = height - Random.Range(1,3);

			if (height==1){
				Instantiate(mountain1, new Vector3(-.75f*x,0f,-.43f-.86f*z-.86f), Quaternion.identity);
				placedTile++;
			}

			if (height==0){


				placedTile++;
			}

		}

		//end for height 2

		//for height 1

		if(x%2==0 && skip==0 && height==1 && placedTile==0){
			Instantiate(mountain1, new Vector3(-.75f*x,0f,-.86f*z), Quaternion.identity);
			height--;
			placedTile++;

		}

		if(x%2==1 && skip==0 && height==9 && placedTile==0){
			Instantiate(mountain9, new Vector3(-.75f*x,0f,-.43f-.86f*z), Quaternion.identity);
			height--;
			placedTile++;

		}

		//end for height 1


		//skip if water
		if(skip==1){
			skip--;
		}

	}



	public IEnumerator makeMountain (int xmapmax, int zmapmax){

		//spawn the peak at height 9.
		//createTile() automatically places tiles above the start at different height.


		//pick the start point
		x=Random.Range(8,xmapmax-6);
		xstart=x;
		z=Random.Range(	8, zmapmax-6);


		for (int n=0; n<2; n++){

			if (n==0){
				for (int i=0; i < 10; i++){


					if (placedTile!=0){
						//move to the right
						x=x+1;
						placedTile=0;
					}


					destroyTile();
					createTile();

					}	
				}

			else {

				//go back to the start point
				x= xstart;
				height =8;
				placedTile=1;

				for (int i=0; i < 10; i++){


					if (placedTile!=0){
						//move to the left
						x=x-1;
						placedTile=0;
					}


					destroyTile();
					createTile();

				}	

			}
		}




		yield return null;

		StartCoroutine(gameObject.GetComponent<Clutter_Generator>().createClutter(xmapmax, zmapmax));
	}

	//gameObject.GetComponent<Clutter_Generator>().makeClutter(xmapmax, zmapmax);
}
