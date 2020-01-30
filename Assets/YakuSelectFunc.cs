using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YakuSelectFunc : MonoBehaviour {

	GameObject refRes;

	private Toggle toggle;

	// 初期処理
	// トグル/計算結果ボタンオブジェクト取得
	void Start () {
		toggle = GetComponent<Toggle> ();

		refRes = GameObject.Find ("CalcButton");
	}

	// トグルにチェックが入ったら役判定して翻数カウント
	public void OnToggleChanged() {
		if (toggle.isOn) {
			if (toggle.tag == "1han") {
				refRes.GetComponent<CalcFunc> ().hansu = refRes.GetComponent<CalcFunc> ().hansu + 1;
			} else if (toggle.tag == "2han") {
				refRes.GetComponent<CalcFunc> ().hansu = refRes.GetComponent<CalcFunc> ().hansu + 2;
			} else if (toggle.tag == "3han") {
				refRes.GetComponent<CalcFunc> ().hansu = refRes.GetComponent<CalcFunc> ().hansu + 3;
			} else if (toggle.tag == "4han") {
				refRes.GetComponent<CalcFunc> ().hansu = refRes.GetComponent<CalcFunc> ().hansu + 4;
			} else if (toggle.tag == "6han") {
				refRes.GetComponent<CalcFunc> ().hansu = refRes.GetComponent<CalcFunc> ().hansu + 6;
			}
		} else {
			if (refRes.GetComponent<CalcFunc> ().hansu > 0) {
				if (toggle.tag == "1han") {
					refRes.GetComponent<CalcFunc> ().hansu = refRes.GetComponent<CalcFunc> ().hansu - 1;
				} else if (toggle.tag == "2han") {
					refRes.GetComponent<CalcFunc> ().hansu = refRes.GetComponent<CalcFunc> ().hansu - 2;
				} else if (toggle.tag == "3han") {
					refRes.GetComponent<CalcFunc> ().hansu = refRes.GetComponent<CalcFunc> ().hansu - 3;
				} else if (toggle.tag == "4han") {
					refRes.GetComponent<CalcFunc> ().hansu = refRes.GetComponent<CalcFunc> ().hansu - 4;
				} else if (toggle.tag == "6han") {
					refRes.GetComponent<CalcFunc> ().hansu = refRes.GetComponent<CalcFunc> ().hansu - 6;
				}
			}
		}
	}
}
