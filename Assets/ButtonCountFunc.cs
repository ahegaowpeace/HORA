using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCountFunc : MonoBehaviour {

	GameObject refRes;

	private Button button;
	private GameObject tmpgameobj;

	private Text chunchanminkoNum;
	private Text chunchanankoNum;
	private Text chunchanminkanNum;
	private Text chunchanankanNum;
	private Text yaochuminkoNum;
	private Text yaochuankoNum;
	private Text yaochuminkanNum;
	private Text yaochuankanNum;

	// 初期処理
	// 計算結果ボタンオブジェクト取得
	void Start () {
		button = GetComponent<Button> ();

		refRes = GameObject.Find ("CalcButton");
	}

	// ボタンが押されたら種類判定して値セット
	public void ButtonClick() {
		if (button.tag == "ChunChanMinkoPlus") {
			refRes.GetComponent<CalcFunc> ().chunchanminko = refRes.GetComponent<CalcFunc> ().chunchanminko + 1;
		} else if (button.tag == "ChunChanMinkoMinus") {
			if (refRes.GetComponent<CalcFunc> ().chunchanminko > 0) {
				refRes.GetComponent<CalcFunc> ().chunchanminko = refRes.GetComponent<CalcFunc> ().chunchanminko - 1;
			}
		} else if (button.tag == "ChunChanAnkoPlus") {
			refRes.GetComponent<CalcFunc> ().chunchananko = refRes.GetComponent<CalcFunc> ().chunchananko + 1;
		} else if (button.tag == "ChunChanAnkoMinus") {
			if (refRes.GetComponent<CalcFunc> ().chunchananko > 0) {
				refRes.GetComponent<CalcFunc> ().chunchananko = refRes.GetComponent<CalcFunc> ().chunchananko - 1;
			}
		} else if (button.tag == "ChunChanMinkanPlus") {
			refRes.GetComponent<CalcFunc> ().chunchanminkan = refRes.GetComponent<CalcFunc> ().chunchanminkan + 1;
		} else if (button.tag == "ChunChanMinkanMinus") {
			if (refRes.GetComponent<CalcFunc> ().chunchanminkan > 0) {
				refRes.GetComponent<CalcFunc> ().chunchanminkan = refRes.GetComponent<CalcFunc> ().chunchanminkan - 1;
			}
		} else if (button.tag == "ChunChanAnkanPlus") {
			refRes.GetComponent<CalcFunc> ().chunchanankan = refRes.GetComponent<CalcFunc> ().chunchanankan + 1;
		} else if (button.tag == "ChunChanAnkanMinus") {
			if (refRes.GetComponent<CalcFunc> ().chunchanankan > 0) {
				refRes.GetComponent<CalcFunc> ().chunchanankan = refRes.GetComponent<CalcFunc> ().chunchanankan - 1;
			}
		} else if (button.tag == "YaoChuMinkoPlus") {
			refRes.GetComponent<CalcFunc> ().yaochuminko = refRes.GetComponent<CalcFunc> ().yaochuminko + 1;
		} else if (button.tag == "YaoChuMinkoMinus") {
			if (refRes.GetComponent<CalcFunc> ().yaochuminko > 0) {
				refRes.GetComponent<CalcFunc> ().yaochuminko = refRes.GetComponent<CalcFunc> ().yaochuminko - 1;
			}
		} else if (button.tag == "YaoChuAnkoPlus") {
			refRes.GetComponent<CalcFunc> ().yaochuanko = refRes.GetComponent<CalcFunc> ().yaochuanko + 1;
		} else if (button.tag == "YaoChuAnkoMinus") {
			if (refRes.GetComponent<CalcFunc> ().yaochuanko > 0) {
				refRes.GetComponent<CalcFunc> ().yaochuanko = refRes.GetComponent<CalcFunc> ().yaochuanko - 1;
			}
		} else if (button.tag == "YaoChuMinkanPlus") {
			refRes.GetComponent<CalcFunc> ().yaochuminkan = refRes.GetComponent<CalcFunc> ().yaochuminkan + 1;
		} else if (button.tag == "YaoChuMinkanMinus") {
			if (refRes.GetComponent<CalcFunc> ().yaochuminkan > 0) {
				refRes.GetComponent<CalcFunc> ().yaochuminkan = refRes.GetComponent<CalcFunc> ().yaochuminkan - 1;
			}
		} else if (button.tag == "YaoChuAnkanPlus") {
			refRes.GetComponent<CalcFunc> ().yaochuankan = refRes.GetComponent<CalcFunc> ().yaochuankan + 1;
		} else if (button.tag == "YaoChuAnkanMinus") {
			if (refRes.GetComponent<CalcFunc> ().yaochuankan > 0) {
				refRes.GetComponent<CalcFunc> ().yaochuankan = refRes.GetComponent<CalcFunc> ().yaochuankan - 1;
			}
		}
			
		// テキスト更新チュンチャンパイ面子数
		tmpgameobj = GameObject.Find ("chunchanminkoNumText");
		this.chunchanminkoNum = tmpgameobj.GetComponent<Text> ();
		chunchanminkoNum.text = refRes.GetComponent<CalcFunc> ().chunchanminko.ToString();
		tmpgameobj = GameObject.Find ("chunchanankoNumText");
		this.chunchanankoNum = tmpgameobj.GetComponent<Text> ();
		chunchanankoNum.text = refRes.GetComponent<CalcFunc> ().chunchananko.ToString();
		tmpgameobj = GameObject.Find ("chunchanminkanNumText");
		this.chunchanminkanNum = tmpgameobj.GetComponent<Text> ();
		chunchanminkanNum.text = refRes.GetComponent<CalcFunc> ().chunchanminkan.ToString();
		tmpgameobj = GameObject.Find ("chunchanankanNumText");
		this.chunchanankanNum = tmpgameobj.GetComponent<Text> ();
		chunchanankanNum.text = refRes.GetComponent<CalcFunc> ().chunchanankan.ToString();
		// テキスト更新ヤオチューハイ面子数
		tmpgameobj = GameObject.Find ("yaochuminkoNumText");
		this.yaochuminkoNum = tmpgameobj.GetComponent<Text> ();
		yaochuminkoNum.text = refRes.GetComponent<CalcFunc> ().yaochuminko.ToString();
		tmpgameobj = GameObject.Find ("yaochuankoNumText");
		this.yaochuankoNum = tmpgameobj.GetComponent<Text> ();
		yaochuankoNum.text = refRes.GetComponent<CalcFunc> ().yaochuanko.ToString();
		tmpgameobj = GameObject.Find ("yaochuminkanNumText");
		this.yaochuminkanNum = tmpgameobj.GetComponent<Text> ();
		yaochuminkanNum.text = refRes.GetComponent<CalcFunc> ().yaochuminkan.ToString();
		tmpgameobj = GameObject.Find ("yaochuankanNumText");
		this.yaochuankanNum = tmpgameobj.GetComponent<Text> ();
		yaochuankanNum.text = refRes.GetComponent<CalcFunc> ().yaochuankan.ToString();
	}
}
