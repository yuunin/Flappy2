using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	//変数の定義と初期化
	public float flap = 550f;
	public float scroll = 0.14f;
	//シーン中のフレーム毎新居呼ばれる関数
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame_シーン中のフレーム毎に呼ばれる関数
	void Update () {
		//(1,0)方向にscrollスピードで移動
		transform.Translate (Vector2.right * scroll);
		//spacekeyが押されたら
		if (Input.GetKeyDown ("space")) {
			//落下速度リセット  GetComponent ()... は誤り
			GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
			//(0,1)方向に瞬間的に力を加えて跳ねさせる
			GetComponent <Rigidbody2D> ().AddForce (Vector2.up * flap, ForceMode2D.Impulse);
		}
	}
}
