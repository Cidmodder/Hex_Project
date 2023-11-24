using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class River_Generator : MonoBehaviour
{
	public GameObject waterTile;
	public int riverLength=10;
	public int x=0;
	public int z=0;
	private int side=0;
	private RaycastHit hit;

	//destroys the tile in the way
	void destroyTile(){

		if(x%2==0){
			if (Physics.Raycast(new Vector3(-.75f*x,1f,0-.86f*z), Vector3.down,out hit, 2f)){

				hit.transform.gameObject.SendMessage("destroySelf");
			}
		}

		if(x%2==1){
										
				if (Physics.Raycast(new Vector3(-.75f*x,1f,-.43f-.86f*z), Vector3.down,out hit, 2f)){

					hit.transform.gameObject.SendMessage("destroySelf");
				}

		}
	}

	//spawns a water tile
	void createTile(){

		if(x%2==0){
			GameObject tile = Instantiate(waterTile, new Vector3(-.75f*x,0f,-.86f*z), Quaternion.identity);
			gameObject.GetComponent<Resource_Placer>().RiverTilePosition.Add(tile.transform.position);
		}

		if(x%2==1){
			GameObject tile = Instantiate(waterTile, new Vector3(-.75f*x,0f,-.43f-.86f*z), Quaternion.identity);
			gameObject.GetComponent<Resource_Placer>().RiverTilePosition.Add(tile.transform.position);
		}

	}

	public IEnumerator makeRivers(int xmapmax, int zmapmax){

		//there is still an edge case with side===3 after placing the first two tiles. Seems similar to the side=2


		//generate the start point
		for (float r=0; r<riverLength; r++){

			//first river tile here
			if ( r==0){
				//pick a column first
				x=Random.Range(0,xmapmax);

				//if on the left or the right board edge
				if ( x==0 || x==xmapmax){
					//pick how far up or down the column to go
					z=Random.Range(0,zmapmax);
					//destroy the tile in the way
					destroyTile();
					//spawn the water tile in the same place
					createTile();
					//print("side "+side +"tile number: "+r+"("+x+","+z+")"); 	
						}
				//end left or right board edge

				//anywhere in the middle of the board and top bottom edge

				if (x!=0 && x!=xmapmax){

					//choose how far up or down to go
					z=Random.Range(0, zmapmax);
					//destroy the tile in the way
					destroyTile();
					//spawn the water tile in the same place
					createTile();
					//print("side "+side +"tile number: "+r+"("+x+","+z+")");
				}
				//end of first tile in the middle or bottom and top edge
			}
			//end of first river tile


			//second river tile here
				if (r==1){

					//top left corner
					if(x==0 && z==0){
						//choose the side of the hex to spawn the next one
						side=3;
						//shift x and z to the new location based on the side
						x=x+1;
						z=z+1;
					//destroy the tile in the way
					destroyTile();
					//spawn a tile in the same place
					createTile();
					//print("side "+side +"tile number: "+r+"("+x+","+z+")");
					}
					//end top left corner


					//left board edge

					if(x==0 && z!=0 && z!=zmapmax){
						side=Random.Range(2,3);

						if (side==2){
							x=x+1;
							z=z-0;

						destroyTile();

						createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");
						}

						if (side==3){

							x=x+1;
							z=z+1;

						destroyTile();

						createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");
						}



					}
					//end left board edge


					//bottom left corner

					if(x==0 && z==zmapmax){
						side=2;
						x=x+1;
						z=z-1;
						
						destroyTile();

						createTile();
					//print("side "+side +"tile number: "+r+"("+x+","+z+")");
					}

					//end bottom left corner

					//top board edge

					if (x!=0 && z==0){
						side=4;
						x=x+0;
						z=z+1;

					destroyTile();

					createTile();
					//print("side "+side +"tile number: "+r+"("+x+","+z+")");


					}

					//end top board edge

					//top right corner

					if(x==xmapmax && z==0){
						side=5;
						x=x-1;
						z=z+1;
						
						destroyTile();

						createTile();
					//print("side "+side +"tile number: "+r+"("+x+","+z+")");

					}

					//end top right corner

					//right board edge

					if(x==xmapmax && z!=0 && z!=zmapmax){
						side=Random.Range(5,6);

						if (side==5){
							x=x-1;
							z=z+1;

							destroyTile();

							createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");
						}

						if (side==6){

							x=x-1;
							z=z-1;

							destroyTile();

							createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");
						}



					}
					//end right board edge

					//bottom right corner

					if(x==xmapmax && z==zmapmax){
						side=6;
						x=x-1;
						z=z-1;

						destroyTile();

						createTile();
					//print("side "+side +"tile number: "+r+"("+x+","+z+")");
					}

					//end bottom right corner

					//bottom board edge

					if (x!=0 && z==zmapmax){
						side=1;
						x=x+0;
						z=z-1;

						destroyTile();

						createTile();
					//print("side "+side +"tile number: "+r+"("+x+","+z+")");
					

					}

					//end top board edge


					//middle of the board spawn
					if (x!=0 && x!=xmapmax && z!=0 && z!=zmapmax){
						side=Random.Range(1,6);

						if (side ==1){
							x=x+0;
							z=z-1;
							destroyTile();

							createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");

						}

						if (side==2){
							
						if(x%2==0){
							x=x+1;
							z=z-0;

						}

						else{
							x=x+1;
							z=z-0;
						}
							destroyTile();

							createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");
						}

						if (side==3){

							x=x+1;
							z=z+1;
							destroyTile();

							createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");
						}

						if (side==4){

							x=x+0;
							z=z+1;
							destroyTile();

							createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");
						}

						if (side==5){
							x=x-1;
							z=z+1;
							destroyTile();

							createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");
						}

						if (side==6){

							x=x-1;
							z=z-1;
							destroyTile();

							createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");
						}

					}
					//end middle of board spawn

				}

			//end of second river tile

			//generate the rest of the tiles here

			if( r!=0 && r!=1){


				//use previous side to determine which way to go next
				//if last side was 1
				if (side==1){

					side= Random.Range(1,3);
						
					if (side==1){

						x=x+0;
						z=z-1;

						destroyTile();

						createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");

					}

					if (side==2){

						if (x%2==0){
						x=x+1;
						z=z-0;

						}

						else{
							x=x+1;
							z=z-0;

						}
						destroyTile();

						createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");
					
					}


				}


				//end last side 1

				//last side 2
				if (side==2){

					side= Random.Range(1,3);
					//start side 1
					if (side==1){

						x=x+0;
						z=z-1;

						destroyTile();

						createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");

					}
					//end side 1
					//start side 2
					if (side==2){
						if (x%2==0){
						x=x+1;
						z=z-0;
						}

						else{
							x=x+1;
							z=z-0;
						}

						destroyTile();

						createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");

					}
					//end side 2


					//start side 3

					if (side==3){

						x=x+1;
						z=z+1;

						destroyTile();

						createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");

					}

					//end side 3


				}

				//end last side 2

				//last side 3
				if (side==3){

					side= Random.Range(2,4);
					//start side 4
					if (side==4){

						x=x+0;
						z=z+1;

						destroyTile();

						createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");
					}
					//end side 4
					//start side 2
					if (side==2){
						if (x%2==0){
						x=x+1;
						z=z-0;
						}

						else{
							x=x+1;
							z=z-1;
						}

						destroyTile();

						createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");

					}
					//end side 2


					//start side 3

					if (side==3){

						x=x+1;
						z=z+1;

						destroyTile();

						createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");
					}

					//end side 3


				}


				//end last side 3

				//last side 4
				if (side==4){

					side= Random.Range(3,5);
					//start side 4
					if (side==4){

						x=x+0;
						z=z+1;

						destroyTile();

						createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");

					}
					//end side 4
					//start side 5
					if (side==5){

						x=x-1;
						z=z+1;

						destroyTile();

						createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");
					}
					//end side 5


					//start side 3

					if (side==3){

						x=x+1;
						z=z+1;

						destroyTile();

						createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");

					}

					//end side 3


				}


				//end last side 4

				//last side 5

				if (side==5){

					side= Random.Range(4,6);
					//start side 4
					if (side==4){

						x=x+0;
						z=z+1;

						destroyTile();

						createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");
					}
					//end side 4
					//start side 5
					if (side==5){

						x=x-1;
						z=z+1;

						destroyTile();

						createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");
					}
					//end side 5


					//start side 6

					if (side==6){

						x=x-1;
						z=z-1;

						destroyTile();

						createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");
					}

					//end side 6


				}


				//end last side 5

				//last side 6

				if (side==6){

					side= Random.Range(5,6);

					//start side 5
					if (side==5){

						x=x-1;
						z=z+1;

						destroyTile();

						createTile();
						//print("side "+side +"tile number: "+r+"("+x+","+z+")");
					}
					//end side 5


					//start side 6

					if (side==6){

						x=x-1;
						z=z-1;

						destroyTile();

						createTile();

						//print("side "+side +"tile number: "+r+"("+x+","+z+")");
					}

					//end side 6


				}



				//end last side 6



			}



			//end generate rest of tiles
		


		}
		//pause for one frame
		yield return null;

		//generate sand here. pass through xmapmax and zmapmax
		gameObject.GetComponent<Desert_Generator>().makeDesert(xmapmax, zmapmax);
	}
}
