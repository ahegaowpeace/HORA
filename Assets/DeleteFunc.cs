using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteFunc : MonoBehaviour {

	GameObject refRes;
	private GameObject tmpdelgameobj;
	private Toggle[] yakuToggles;

	private Button DeleteButton;

	// Use this for initialization
	void Start () {
		refRes = GameObject.Find ("CalcButton");
	}
	
	// 結果消去
	public void OnClick () {
		// フラグリセット
		refRes.GetComponent<CalcFunc> ().tsumoFlag = 0;
		refRes.GetComponent<CalcFunc> ().nakiFlag = 1;
		refRes.GetComponent<CalcFunc> ().oyaFlag = 0;
		refRes.GetComponent<CalcFunc> ().jantoFlag = 0;
		refRes.GetComponent<CalcFunc> ().machiFlag = 0;
		// 値リセット
		refRes.GetComponent<CalcFunc> ().dora = 0;
		refRes.GetComponent<CalcFunc> ().hansu = 0;
		refRes.GetComponent<CalcFunc> ().totalhansu = 0;
		refRes.GetComponent<CalcFunc> ().chunchanminko = 0;
		refRes.GetComponent<CalcFunc> ().chunchananko = 0;
		refRes.GetComponent<CalcFunc> ().chunchanminkan = 0;
		refRes.GetComponent<CalcFunc> ().chunchanankan = 0;
		refRes.GetComponent<CalcFunc> ().yaochuminko = 0;
		refRes.GetComponent<CalcFunc> ().yaochuanko = 0;
		refRes.GetComponent<CalcFunc> ().yaochuminkan = 0;
		refRes.GetComponent<CalcFunc> ().yaochuankan = 0;
		// UIリセット
		tmpdelgameobj = GameObject.Find ("ToggleLon");
		tmpdelgameobj.GetComponent<Toggle> ().isOn = true;
		tmpdelgameobj = GameObject.Find ("ToggleNaita");
		tmpdelgameobj.GetComponent<Toggle> ().isOn = true;
		tmpdelgameobj = GameObject.Find ("ToggleKo");
		tmpdelgameobj.GetComponent<Toggle> ().isOn = true;
		tmpdelgameobj = GameObject.Find ("doraNumText");
		tmpdelgameobj.GetComponent<Text> ().text = refRes.GetComponent<CalcFunc> ().dora.ToString();
		tmpdelgameobj = GameObject.Find ("chunchanminkoNumText");
		tmpdelgameobj.GetComponent<Text> ().text = refRes.GetComponent<CalcFunc> ().chunchanminko.ToString();
		tmpdelgameobj = GameObject.Find ("chunchanankoNumText");
		tmpdelgameobj.GetComponent<Text> ().text = refRes.GetComponent<CalcFunc> ().chunchananko.ToString();
		tmpdelgameobj = GameObject.Find ("chunchanminkanNumText");
		tmpdelgameobj.GetComponent<Text> ().text = refRes.GetComponent<CalcFunc> ().chunchanminkan.ToString();
		tmpdelgameobj = GameObject.Find ("chunchanankanNumText");
		tmpdelgameobj.GetComponent<Text> ().text = refRes.GetComponent<CalcFunc> ().chunchanankan.ToString();
		tmpdelgameobj = GameObject.Find ("yaochuminkoNumText");
		tmpdelgameobj.GetComponent<Text> ().text = refRes.GetComponent<CalcFunc> ().yaochuminko.ToString();
		tmpdelgameobj = GameObject.Find ("yaochuankoNumText");
		tmpdelgameobj.GetComponent<Text> ().text = refRes.GetComponent<CalcFunc> ().yaochuanko.ToString();
		tmpdelgameobj = GameObject.Find ("yaochuminkanNumText");
		tmpdelgameobj.GetComponent<Text> ().text = refRes.GetComponent<CalcFunc> ().yaochuminkan.ToString();
		tmpdelgameobj = GameObject.Find ("yaochuankanNumText");
		tmpdelgameobj.GetComponent<Text> ().text = refRes.GetComponent<CalcFunc> ().yaochuankan.ToString();
		tmpdelgameobj = GameObject.Find ("JihuBahuSangen");
		tmpdelgameobj.GetComponent<Toggle> ().isOn = true;
		tmpdelgameobj = GameObject.Find ("ToggleNobePenKanTan");
		tmpdelgameobj.GetComponent<Toggle> ().isOn = true;
		// 役セレクトリセット

		tmpdelgameobj = GameObject.Find("ScrollView");

		yakuToggles = tmpdelgameobj.GetComponentsInChildren<Toggle> ();
		foreach(var a in yakuToggles) {
			a.isOn = false;
		}

	}
}
