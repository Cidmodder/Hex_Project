using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Builder : MonoBehaviour
{
	public GameObject grasstile;
	public int xmapmax=10;
	public int zmapmax=10;

    // Start is called before the first frame update
    public void Start()
    {
		//make a sequence for creating a map by columns. All tiles placed should be grass and be located at y=0.
		//Tiles should start at (0,0,0) and go to (xmapmax,0,zmapmax)
		//start with 10x10 size grid.
		//To make grid, start with tiles in x=0 and shift each tile down by .865 for each step until zmapmax
		//then move to the next row shifted to the right .75 and down .4325 for the first tile and then down by .865 for each
		//every odd column should not be shifted down and every even column needs to be shifted.
		for (float x=0; x<xmapmax; x++){
			if (x%2==0){

					for(float z=0; z<zmapmax; z++){

					GameObject tile = Instantiate(grasstile, new Vector3(-.75f*x,0,0-.86f*z), Quaternion.identity);
					gameObject.GetComponent<Resource_Placer>().GrassTilePosition.Add(tile.transform.position);
				}
			}

			if (x%2==1){

					for(float z=0; z<zmapmax; z++){

					//Instantiate(grasstile, new Vector3(-.75f*x,0,-.43f-.86f*z), Quaternion.identity);
					GameObject tile = Instantiate(grasstile, new Vector3(-.75f*x,0,-.43f-.86f*z), Quaternion.identity);
					gameObject.GetComponent<Resource_Placer>().GrassTilePosition.Add(tile.transform.position);

				}
			}

		}


		//call to start river generation
		StartCoroutine(gameObject.GetComponent<River_Generator>().makeRivers(xmapmax, zmapmax));

		// (Legacy)insert a call here for a river generating script that will make the river(s) and then make desert tiles.
		//gameObject.GetComponent<River_Generator>().makeRivers(xmapmax, zmapmax);

    }

    
}
