using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoraCountFunc : MonoBehaviour {

	GameObject refRes;

	private Button button;
	private GameObject tmpgameobj;

	private Text doraNum;
	// 初期処理
	// 計算結果ボタンオブジェクト取得
	void Start () {
		button = GetComponent<Button> ();

		refRes = GameObject.Find ("CalcButton");
	}

	// ボタンが押されたら種類判定して値セット
	public void ButtonClick() {
		if (button.tag == "DoraPlus") {
			refRes.GetComponent<CalcFunc> ().dora = refRes.GetComponent<CalcFunc> ().dora + 1;
		} else if (button.tag == "DoraMinus") {
			if (refRes.GetComponent<CalcFunc> ().dora > 0) {
				refRes.GetComponent<CalcFunc> ().dora = refRes.GetComponent<CalcFunc> ().dora - 1;
			}
		}

		// テキスト更新チュンチャンパイ面子数
		tmpgameobj = GameObject.Find ("doraNumText");
		this.doraNum = tmpgameobj.GetComponent<Text> ();
		doraNum.text = refRes.GetComponent<CalcFunc> ().dora.ToString();
	}
}
