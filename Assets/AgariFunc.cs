using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgariFunc : MonoBehaviour {

	GameObject refRes;

	private Toggle toggle;

	// 初期処理
	// トグル/計算結果ボタンオブジェクト取得
	void Start () {
		toggle = GetComponent<Toggle> ();

		refRes = GameObject.Find ("CalcButton");
	}

	// トグルにチェックが入ったらアガリ判定してフラグセット
	public void OnToggleChanged() {
		if (toggle.isOn) {
			if (toggle.tag == "Tsumo") {
				refRes.GetComponent<CalcFunc> ().tsumoFlag = 1;
			} else {
				refRes.GetComponent<CalcFunc> ().tsumoFlag = 0;
			}
		}
	}
}
