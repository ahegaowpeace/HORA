using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OyakoFunc : MonoBehaviour {

	GameObject refRes;

	private Toggle toggle;

	// 初期処理
	// トグル/計算結果ボタンオブジェクト取得
	void Start () {
		toggle = GetComponent<Toggle> ();

		refRes = GameObject.Find ("CalcButton");
	}

	// トグルにチェックが入ったら親子判定してフラグセット
	public void OnToggleChanged() {
		if (toggle.isOn) {
			if (toggle.tag == "Oya") {
				refRes.GetComponent<CalcFunc> ().oyaFlag = 1;
			} else {
				refRes.GetComponent<CalcFunc> ().oyaFlag = 0;
			}
		}
	}
}
