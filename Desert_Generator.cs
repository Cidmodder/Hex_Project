using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desert_Generator : MonoBehaviour
{
	public GameObject sandTile;
	public int desertSize=7;
	public int x=0;
	public int z=0;
	private int skip=0;
	private RaycastHit hit;

	//still need to fix an edge case where it spawns deserts uner the water tile. the raycast seems to sill think it is hitting grass. not sure why.

	//destroy what is underneath
	void destroyTile(){

		if(x%2==0){
			if (Physics.Raycast(new Vector3(-.75f*x,1f,0-.86f*z), Vector3.down,out hit, 2f)){

				//checks if hit water tile. be sure to use IEnumerator on the previous step if needs to be completed first
				if (hit.collider.gameObject.name=="Water(Clone)"){
					skip++;

				}
				if(skip!=1){
				hit.transform.gameObject.SendMessage("destroySelf");

				}
			}
		}

		if(x%2==1){

			if (Physics.Raycast(new Vector3(-.75f*x,1f,-.43f-.86f*z), Vector3.down,out hit, 2f)){
				
				if (hit.collider.gameObject.name=="Water(Clone)"){
					skip++;

				}
				if(skip!=1){
				hit.transform.gameObject.SendMessage("destroySelf");
				}

			}

		}
	}


	//spawns a sand tile
	void createTile(){



		if(x%2==0 && skip==0){
			GameObject tile = Instantiate(sandTile, new Vector3(-.75f*x,0f,-.86f*z), Quaternion.identity);
			gameObject.GetComponent<Resource_Placer>().DesertTilePosition.Add(tile.transform.position);
		}

		if(x%2==1 && skip==0){
			GameObject tile = Instantiate(sandTile, new Vector3(-.75f*x,0f,-.43f-.86f*z), Quaternion.identity);
			gameObject.GetComponent<Resource_Placer>().DesertTilePosition.Add(tile.transform.position);
		}

		if(skip==1){
			skip--;
		}

	}

   

	public void makeDesert(int xmapmax, int zmapmax){

		x=Random.Range(2,xmapmax-2);
		z=Random.Range(2,zmapmax-2);

		for (int col=1; col<4; col++){

			//place leftmost tiles
			if (col==1){

				//place two tiles one below the other
				for (int t=1; t<3; t++){
					z++;
					destroyTile();
					createTile();
				}

			
			}

			if (col==2){
				//step to the right one
				x++;

				if (x%2==0){
				z++;
				destroyTile();
				createTile();
				z--;
				destroyTile();
				createTile();
				z--;
				destroyTile();
				createTile();
				}

				else{
					z=z-2;
					destroyTile();
					createTile();
					z++;
					destroyTile();
					createTile();
					z++;
					destroyTile();
					createTile();
				}

			}


			if (col==3){
				//step to the right one
				x++;
				//place two tiles one above the other
				z=z+1;
				destroyTile();
				createTile();
				z--;
				destroyTile();
				createTile();

			}
		}

		//spawn hills here
		gameObject.GetComponent<Hill_Generator>().makeHill(xmapmax, zmapmax);
		//yield return null;
	}

}
