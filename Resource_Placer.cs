using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource_Placer : MonoBehaviour
{
	public List<Vector3> GrassTilePosition = new List<Vector3>();
	public List<Vector3> RiverTilePosition = new List<Vector3>();
	public List<Vector3> HillTilePosition = new List<Vector3>();
	public List<Vector3> MountainTilePosition = new List<Vector3>();
	public List<Vector3> DesertTilePosition = new List<Vector3>();
	public GameObject woods1;
	public GameObject iron1;
	public GameObject stone1;
	public GameObject mana1;
	public GameObject food1;
	//private int x=0;
	//private int z=0;
	//private int skip=0;
	private RaycastHit hit;


	public IEnumerator placeWoods (int xmapmax, int zmapmax){

		//int density = 8; might use later to add randomness

		//woods should only place on grassland tiles. More patterns can be added later.

		int pos = Random.Range(0, GrassTilePosition.Count);
		//private RayCast hit.collider.gameObject.name;

		//add a check to see what is there
		if (Physics.Raycast(GrassTilePosition[pos] + new Vector3(0,2,0), Vector3.down,out hit, 3f)){
			//print("can place:"+hit.collider.gameObject.name);

			if (hit.collider.gameObject.name == "Grass_Clutter1(Clone)" || hit.collider.gameObject.name == "Grass_Clutter2(Clone)" || hit.collider.gameObject.name == "Grass_Clutter3(Clone)" || hit.collider.gameObject.name == "Grass(Clone)"){
				hit.transform.gameObject.SendMessage("clearClutter");
				Instantiate(woods1, GrassTilePosition[pos], Quaternion.Euler(new Vector3(0,Random.Range(0,6)*60,0)));
				gameObject.GetComponent<Town_Placer>().WoodsPosition.Add(hit.transform.position);
			}

			else {
				//print ("not the right tile:" +hit.collider.gameObject.name);
			}
		}

		if (Physics.Raycast(GrassTilePosition[pos+1] + new Vector3(0,2,0), Vector3.down,out hit, 3f)){
			//print("can place:"+hit.collider.gameObject.name);

			if (hit.collider.gameObject.name == "Grass_Clutter1(Clone)" || hit.collider.gameObject.name == "Grass_Clutter2(Clone)" || hit.collider.gameObject.name == "Grass_Clutter3(Clone)" || hit.collider.gameObject.name == "Grass(Clone)"){
				hit.transform.gameObject.SendMessage("clearClutter");
				Instantiate(woods1, GrassTilePosition[pos+1], Quaternion.Euler(new Vector3(0,Random.Range(0,6)*60,0)));
				gameObject.GetComponent<Town_Placer>().WoodsPosition.Add(hit.transform.position);
			}

			else {
				//print ("not the right tile:" +hit.collider.gameObject.name);
			}
		}


		if (Physics.Raycast(GrassTilePosition[pos+2] + new Vector3(0,2,0), Vector3.down,out hit, 3f)){
			//print("can place:"+hit.collider.gameObject.name);

			if (hit.collider.gameObject.name == "Grass_Clutter1(Clone)" || hit.collider.gameObject.name == "Grass_Clutter2(Clone)" || hit.collider.gameObject.name == "Grass_Clutter3(Clone)" || hit.collider.gameObject.name == "Grass(Clone)"){
				hit.transform.gameObject.SendMessage("clearClutter");
				Instantiate(woods1, GrassTilePosition[pos+2], Quaternion.Euler(new Vector3(0,Random.Range(0,6)*60,0)));
				gameObject.GetComponent<Town_Placer>().WoodsPosition.Add(hit.transform.position);
			}

			else {
				//print ("not the right tile:" +hit.collider.gameObject.name);
			}
		}

		if (Physics.Raycast(GrassTilePosition[pos+29] + new Vector3(0,2,0), Vector3.down,out hit, 3f)){
			//print("can place:"+hit.collider.gameObject.name);

			if (hit.collider.gameObject.name == "Grass_Clutter1(Clone)" || hit.collider.gameObject.name == "Grass_Clutter2(Clone)" || hit.collider.gameObject.name == "Grass_Clutter3(Clone)" || hit.collider.gameObject.name == "Grass(Clone)"){
				hit.transform.gameObject.SendMessage("clearClutter");
				Instantiate(woods1, GrassTilePosition[pos+29], Quaternion.Euler(new Vector3(0,Random.Range(0,6)*60,0)));
				gameObject.GetComponent<Town_Placer>().WoodsPosition.Add(hit.transform.position);
			}

			else {
			//	print ("not the right tile:" +hit.collider.gameObject.name);
			}
		}

		if (Physics.Raycast(GrassTilePosition[pos+30] + new Vector3(0,2,0), Vector3.down,out hit, 3f)){
			//print("can place:"+hit.collider.gameObject.name);

			if (hit.collider.gameObject.name == "Grass_Clutter1(Clone)" || hit.collider.gameObject.name == "Grass_Clutter2(Clone)" || hit.collider.gameObject.name == "Grass_Clutter3(Clone)" || hit.collider.gameObject.name == "Grass(Clone)"){
				hit.transform.gameObject.SendMessage("clearClutter");
				Instantiate(woods1, GrassTilePosition[pos+30], Quaternion.Euler(new Vector3(0,Random.Range(0,6)*60,0)));
				gameObject.GetComponent<Town_Placer>().WoodsPosition.Add(hit.transform.position);
			}

			else {
				//print ("not the right tile:" +hit.collider.gameObject.name);
			}
		}

		if (Physics.Raycast(GrassTilePosition[pos+31] + new Vector3(0,2,0), Vector3.down,out hit, 3f)){
			//print("can place:"+hit.collider.gameObject.name);

			if (hit.collider.gameObject.name == "Grass_Clutter1(Clone)" || hit.collider.gameObject.name == "Grass_Clutter2(Clone)" || hit.collider.gameObject.name == "Grass_Clutter3(Clone)" || hit.collider.gameObject.name == "Grass(Clone)"){
				hit.transform.gameObject.SendMessage("clearClutter");
				Instantiate(woods1, GrassTilePosition[pos+31], Quaternion.Euler(new Vector3(0,Random.Range(0,6)*60,0)));
				gameObject.GetComponent<Town_Placer>().WoodsPosition.Add(hit.transform.position);
			}

			else {
				//print ("not the right tile:" +hit.collider.gameObject.name);
			}
		}

		if (Physics.Raycast(GrassTilePosition[pos-29] + new Vector3(0,2,0), Vector3.down,out hit, 3f)){
			//print("can place:"+hit.collider.gameObject.name);

			if (hit.collider.gameObject.name == "Grass_Clutter1(Clone)" || hit.collider.gameObject.name == "Grass_Clutter2(Clone)" || hit.collider.gameObject.name == "Grass_Clutter3(Clone)" || hit.collider.gameObject.name == "Grass(Clone)"){
				hit.transform.gameObject.SendMessage("clearClutter");
				Instantiate(woods1, GrassTilePosition[pos-29], Quaternion.Euler(new Vector3(0,Random.Range(0,6)*60,0)));
				gameObject.GetComponent<Town_Placer>().WoodsPosition.Add(hit.transform.position);
			}

			else {
				//print ("not the right tile:" +hit.collider.gameObject.name);
			}
		}

		if (Physics.Raycast(GrassTilePosition[pos-30] + new Vector3(0,2,0), Vector3.down,out hit, 3f)){
			//print("can place:"+hit.collider.gameObject.name);

			if (hit.collider.gameObject.name == "Grass_Clutter1(Clone)" || hit.collider.gameObject.name == "Grass_Clutter2(Clone)" || hit.collider.gameObject.name == "Grass_Clutter3(Clone)" || hit.collider.gameObject.name == "Grass(Clone)"){
				hit.transform.gameObject.SendMessage("clearClutter");
				Instantiate(woods1, GrassTilePosition[pos-30], Quaternion.Euler(new Vector3(0,Random.Range(0,6)*60,0)));
				gameObject.GetComponent<Town_Placer>().WoodsPosition.Add(hit.transform.position);
			}

			else {
				//print ("not the right tile:" +hit.collider.gameObject.name);
			}
		}

		if (Physics.Raycast(GrassTilePosition[pos-31] + new Vector3(0,2,0), Vector3.down,out hit, 3f)){
			//print("can place:"+hit.collider.gameObject.name);

			if (hit.collider.gameObject.name == "Grass_Clutter1(Clone)" || hit.collider.gameObject.name == "Grass_Clutter2(Clone)" || hit.collider.gameObject.name == "Grass_Clutter3(Clone)" || hit.collider.gameObject.name == "Grass(Clone)"){
				hit.transform.gameObject.SendMessage("clearClutter");
				Instantiate(woods1, GrassTilePosition[pos-31], Quaternion.Euler(new Vector3(0,Random.Range(0,6)*60,0)));
				gameObject.GetComponent<Town_Placer>().WoodsPosition.Add(hit.transform.position);
			}

			else {
				//print ("not the right tile:" +hit.collider.gameObject.name);
			}
		}


		//repeat for however many woods there needs to be

		//place iron next
		yield return StartCoroutine(placeIron());
	}

	private IEnumerator placeIron (/*int xmapmax, int zmapmax*/) {


		//iron will place on mountains tiles
		int pos = Random.Range(1, 3);

		for (int i=0; i< 2; i++){

		if (Physics.Raycast(MountainTilePosition[pos+i] + new Vector3(0,2,0), Vector3.down,out hit, 3f)){
			//print("can place:"+hit.collider.gameObject.name);

			if (hit.collider.gameObject.name == "Mountain_Clutter1(Clone)" || hit.collider.gameObject.name == "Rock" || hit.collider.gameObject.name == "Dirt"){
				hit.transform.gameObject.SendMessage("clearClutter");
				Instantiate(iron1, hit.transform.position, Quaternion.Euler(new Vector3(0,Random.Range(0,6)*60,0)));
				gameObject.GetComponent<Town_Placer>().IronPosition.Add(hit.transform.position);
			}

			else {
				//print ("not the right tile:" +hit.collider.gameObject.name);
			}
		}

		}

		//save location to town placer list

		//repeat for as many as desired

		//place stone next


		yield return StartCoroutine(placeStone());
	}


	private IEnumerator placeStone (){

		//stone will place next to hill tiles, above or below them

		int pos = 0; /*Random.Range(0, HillTilePosition.Count);*/

		for (int i=0; i< 1; i++){

			if (Physics.Raycast(HillTilePosition[pos+i] + new Vector3(0,2,0), Vector3.down,out hit, 3f)){
				//print("can place:"+hit.collider.gameObject.name);
				//need to add a check for all the tiles. Maybe checking the parent works better?
				//then can place randomly in the area
				if (hit.collider.gameObject.name == "Grass"){
					hit.transform.gameObject.SendMessage("clearClutter");
					Instantiate(stone1, hit.transform.position, Quaternion.Euler(new Vector3(0,Random.Range(0,6)*60,0)));
					gameObject.GetComponent<Town_Placer>().StonePosition.Add(hit.transform.position);
				}

				else {
					//print ("not the right tile:" +hit.collider.gameObject.name);
				}
			}

		}

		//save location to town placer list

		//place as many stone as desired

		//place mana next

		yield return StartCoroutine(placeMana());
	}

	private IEnumerator placeMana(){

		int which = Random.Range(0,2);

		if (which == 1){

			if (Physics.Raycast(MountainTilePosition[0] + new Vector3(0,2,0), Vector3.down,out hit, 3f)){
				//print("can place:"+hit.collider.gameObject.name);
				//need to add a check for all the tiles. Maybe checking the parent works better?
				//then can place randomly in the area
				if (hit.collider.gameObject.name == "Rock" || hit.collider.gameObject.name == "Mountain_Clutter1(Clone)"){
					hit.transform.gameObject.SendMessage("clearClutter");
					Instantiate(mana1, hit.transform.position, Quaternion.Euler(new Vector3(0,Random.Range(0,6)*60,0)));
					gameObject.GetComponent<Town_Placer>().ManaPosition.Add(hit.transform.position);
				}

				else {
					//print ("not the right tile:" +hit.collider.gameObject.name);
				}
			}

		}

		if (which == 0){
			int pos= Random.Range(0, DesertTilePosition.Count);

			if (Physics.Raycast(DesertTilePosition[pos] + new Vector3(0,2,0), Vector3.down,out hit, 3f)){
				//print("can place:"+hit.collider.gameObject.name);
				//need to add a check for all the tiles. Maybe checking the parent works better?
				//then can place randomly in the area
				if (hit.collider.gameObject.name == "Sand(Clone)" || hit.collider.gameObject.name == "Desert_Clutter1(Clone)"){
					hit.transform.gameObject.SendMessage("clearClutter");
					Instantiate(mana1, hit.transform.position, Quaternion.Euler(new Vector3(0,Random.Range(0,6)*60,0)));
					gameObject.GetComponent<Town_Placer>().ManaPosition.Add(hit.transform.position);
				}

				else {
					//print ("not the right tile:" +hit.collider.gameObject.name);
				}
			}
		}

		//mana spawns in deserts and on mountain peaks at height 7-9

		//save location to town palcer list

		//place as many as desired

		//place towns next

		yield return null;
		StartCoroutine(gameObject.GetComponent<Town_Placer>().placeVillages());
	}

	private IEnumerator placeFood (int xmapmax, int zmapmax){

		//this needs to be moved to the town manager on individual towns

		yield return null;
	}
}
