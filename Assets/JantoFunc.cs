using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JantoFunc : MonoBehaviour {

	GameObject refRes;

	private Toggle toggle;

	// 初期処理
	// トグル/計算結果ボタンオブジェクト取得
	void Start () {
		toggle = GetComponent<Toggle> ();

		refRes = GameObject.Find ("CalcButton");
	}

	// トグルにチェックが入ったら雀頭判定してフラグセット
	public void OnToggleChanged() {
		if (toggle.isOn) {
			if (toggle.tag == "2Hu_Janto") {
				refRes.GetComponent<CalcFunc> ().jantoFlag = 0;
			} else if (toggle.tag == "4Hu_Janto") {
				refRes.GetComponent<CalcFunc> ().jantoFlag = 1;
			} else {
				refRes.GetComponent<CalcFunc> ().jantoFlag = 2;
			}
		}
	}
}
