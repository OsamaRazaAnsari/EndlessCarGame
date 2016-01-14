using UnityEngine;
using System.Collections;

public class Destroy_coin : MonoBehaviour {

	Generate_coin  get_coin;
	Endless_track get_player;
	float distance;
	 Transform _player;
	void Start () {
	
		get_player = GetComponent<Endless_track> ();
		get_coin= GetComponent<Generate_coin>();
		_player=get_player.player;

		//Debug.Log();
	}
	void FixedUpdate(){
		//Debug.Log (_player.position.z);
		if(distance>500){
			foreach(Transform obj in get_coin._clone)
				Destroy(obj.gameObject);
		}
		if(get_coin._clone[0]!=null){
			//Debug.Log(true);
			foreach(Transform obj in get_coin._clone)
			{
				if(obj!=null){
				//distance=Vector3.Distance(_player.transform.position,obj.transform.position);
					distance=_player.transform.position.z-get_coin._clone[0].position.z;
				//Debug.Log(distance);
				}
			}
			//distance=Vector3.Distance(_player.transform.position,get_coin._clone[0].transform.position);
		}
		if(distance>10 && get_coin._clone[0]!=null){

			foreach(Transform obj in get_coin._clone)
			{
				if(obj!=null)
				Destroy(obj.gameObject);
				//Debug.Log(distance);
		
			}
		}

	}
	
	// Update is called once per frame

}	
	

