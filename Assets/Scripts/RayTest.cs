using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		if(Input.GetMouseButtonDown(0))//左クリックされた時
		{
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);//マウスの位置から飛ぶRayを作成→変数mouseRayに格納

			RaycastHit hit;//Rayの衝突情報格納の為の変数を宣言(Raycasthit型)

			if(Physics.Raycast(mouseRay, out hit))//mouseRayが何かに当たったら(衝突情報は変数hitの中)
			{
				Debug.Log("This is " + hit.collider.gameObject.name);
			}
		}
	}
}
