using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Player : MonoBehaviour {
	
	float speed;
	public Text scoretext;
	public int score=0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate(0,0,speed+.25f);
		float _InputControl = Input.GetAxis ("Horizontal");
		//	_InputControl *= 9f;
		this.transform.Translate (_InputControl,0,speed);
		
	}
	void OnTriggerEnter(Collider p){
		
				if (p.gameObject.tag == "point") {
			    Destroy(p.gameObject);
			    score++;
			Debug.Log(score); 
			scoretext.text="Score:"+score.ToString();

				}

	}

}
