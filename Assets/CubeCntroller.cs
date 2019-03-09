using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCntroller : MonoBehaviour {

	//キューブの移動速度
	private float speed = -0.2f;

	//消滅位置
	private float deadLine = -10;

	//キューブ音
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent <AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		//キューブを移動させる
		transform.Translate (this.speed, 0, 0);

		//画面外に出たら破棄する
		if (transform.position.x < this.deadLine) {
			Destroy (gameObject);
		}
	}

	//キューブがグラウンドかキューブ同士と接触した時
	void OnCollisionEnter2D (Collision2D other) {
		//グラウンドタグに接触した時
		if (other.gameObject.tag == "GroundTag") {
				//音を鳴らす
				audioSource.Play ();
		}
		//キューブタグに接触した時
		if (other.gameObject.tag == "CubeTag") {
				//音を鳴らす
				audioSource.Play ();
		}
		
	}
}
