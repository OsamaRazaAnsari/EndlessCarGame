using UnityEngine;
using System.Collections;
public class Generate_coin : MonoBehaviour {
	Endless_track obj_Endless_track;
	public Transform coin;
	 Transform _player;
	float f_point_coin;
	int r=1;
	int i=0;
	//public Transform[] _clone =new Transform[6];
	public Transform[] _clone =new Transform[6];
	Destroy_coin Apply_script_coin;
	//float _player_pos_z;
	void Start () {
	
		obj_Endless_track = GetComponent<Endless_track> ();
		_player=obj_Endless_track.player;
		f_point_coin=Random.Range(-7f,7f);

	}
	// Update is called once per frame
	void Update () {
		
		if(_player.position.z>100*r &&_player.position.z<101*r){
			for(float f=_player.position.z+20;f<=_player.position.z+25f;f++){
				if(i<6){
					_clone[i]=Instantiate(coin,new Vector3(f_point_coin,1.25f,f+50),Quaternion.identity)as Transform;
				
					i++;

				}if(i==6){
					i=0;	
					r++;
				}

				
			}

		}

		
		
		
	}
	
	
	
	
}


