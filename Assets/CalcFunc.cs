using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalcFunc : MonoBehaviour {

	public int hansu = 0;
	public int husu = 0;
	public int dora = 0;
	public int totalhansu = 0;	// 加算ループ回避用
	private float tmppoints = 0;
	private int koPoints = 0;	// 子支払い・子ロン
	private int oyaPoints = 0;	// 親支払い・親ロン
	private int manganFlag = 0;	// 満貫フラグ
	private string koPointsStr;
	private string oyaPointsStr;
	private Text hanNumText;
	private Text huNumText;
	private Text koPointsText;
	private Text oyaPointsText;
	private GameObject tmpgameobj;

	/*************************************************/
	/*            tsumoFlag: 0=ロン 1=ツモ           */
	/*        nakiFlag: 0=鳴きなし 1=鳴き有り        */
	/*               oyaFlag: 0=子 1=親              */
	/*  jantoFlag: 0=自風/場風/三元 1=連風 2=その他  */
	/* machiFlag: 0=辺張/嵌張/単騎/ノベタン 1=その他 */
	/*************************************************/
	public int oyaFlag = 0;
	public int tsumoFlag = 0;
	public int nakiFlag;
	public int jantoFlag = 0;
	public int machiFlag = 0;

	public int chunchanminko = 0;
	public int chunchananko = 0;
	public int chunchanminkan = 0;
	public int chunchanankan = 0;
	public int yaochuminko = 0;
	public int yaochuanko = 0;
	public int yaochuminkan = 0;
	public int yaochuankan = 0;

	// 初期処理
	void Start () {
		nakiFlag = 1;
	}
	
	// 点数計算関数
	public void OnClick () {
		// 1.符計算
		// 基本符
		husu = husu + 20;
		// 上がり方
		if (tsumoFlag == 0) {
			// 門前加符
			if (nakiFlag == 0) {
				husu = husu + 10;
			}
		} else {
			// ツモ符
			husu = husu + 2;
		}
		// 面子の種類
		husu = husu + (chunchanminko * 2);
		husu = husu + (chunchananko * 4);
		husu = husu + (chunchanminkan * 8);
		husu = husu + (chunchanankan * 16);
		husu = husu + (yaochuminko * 4);
		husu = husu + (yaochuanko * 8);
		husu = husu + (yaochuminkan * 16);
		husu = husu + (yaochuankan * 32);
		// 雀頭の種類
		if (jantoFlag == 0) {
			husu = husu + 2;
		} else if (jantoFlag == 1) {
			husu = husu + 2;			// 若しくは4符になる
		}
		// 待ちの種類
		if (machiFlag == 0) {
			husu = husu + 2;
		}
		// 切り上げ計算
		float tmp = (float)husu / 10;
		tmp = Mathf.CeilToInt (tmp);
		tmp = tmp * 10;
		husu = (int)tmp;

		// 2.翻数
		totalhansu = hansu + dora;	// ループ回避

		// 3.点数計算
		//満貫判定
		if (totalhansu >= 5) {
			manganFlag = 1;
		} else if (totalhansu == 4) {
			if (husu >= 40) {
				manganFlag = 1;
			}
		} else if (husu == 3) {
			if (husu >= 70) {
				manganFlag = 1;
			}
		}

		if (manganFlag == 0) {
			// 満貫未満
			if (oyaFlag == 1) {
				// 親
				if (tsumoFlag == 0) {
					// ロン
					oyaPoints = husu * (int)(Mathf.Pow (2, totalhansu + 2)) * 6;	// 右側のみ表示
				} else {
					// ツモ
					oyaPoints = husu * (int)(Mathf.Pow (2, totalhansu + 2)) * 2;	// 右側のみ表示
				}
			} else {
				// 子
				if (tsumoFlag == 0) {
					// ロン
					koPoints = husu * (int)(Mathf.Pow (2, totalhansu + 2)) * 4;	// 左側のみ表示
				} else {
					koPoints = husu * (int)(Mathf.Pow (2, totalhansu + 2));		// 左側のみ表示
					oyaPoints = husu * (int)(Mathf.Pow (2, totalhansu + 2)) * 2;	// 左側のみ表示
				}
			}
		} else {
			// 満貫以上
			if (tsumoFlag == 1) {
				// ツモ
				if (oyaFlag == 0) {
					// 子
					if (3 <= totalhansu && totalhansu <= 5) {
						koPoints = 2000;
						oyaPoints = 4000;
					} else if (6 <= totalhansu && totalhansu <= 7) {
						koPoints = 3000;
						oyaPoints = 6000;
					} else if (8 <= totalhansu && totalhansu <= 10) {
						koPoints = 4000;
						oyaPoints = 8000;
					} else if (11 <= totalhansu && totalhansu <= 12) {
						koPoints = 6000;
						oyaPoints = 12000;
					} else if (13 <= totalhansu) {
						koPoints = 8000;
						oyaPoints = 16000;
					}
				} else {
					// 親
					if (3 <= totalhansu && totalhansu <= 5) {
						koPoints = 3000;
						oyaPoints = 6000;
					} else if (6 <= totalhansu && totalhansu <= 7) {
						koPoints = 4500;
						oyaPoints = 9000;
					} else if (8 <= totalhansu && totalhansu <= 10) {
						koPoints = 6000;
						oyaPoints = 12000;
					} else if (11 <= totalhansu && totalhansu <= 12) {
						koPoints = 9000;
						oyaPoints = 18000;
					} else if (13 <= totalhansu) {
						koPoints = 12000;
						oyaPoints = 24000;
					}
				}
			} else {
				if (oyaFlag == 0) {
					// 子
					if (3 <= totalhansu && totalhansu <= 5) {
						koPoints = 8000;
					} else if (6 <= totalhansu && totalhansu <= 7) {
						koPoints = 12000;
					} else if (8 <= totalhansu && totalhansu <= 10) {
						koPoints = 16000;
					} else if (11 <= totalhansu && totalhansu <= 12) {
						koPoints = 24000;
					} else if (13 <= totalhansu) {
						koPoints = 32000;
					}
				} else {
					// 親
					if (3 <= totalhansu && totalhansu <= 5) {
						oyaPoints = 12000;
					} else if (6 <= totalhansu && totalhansu <= 7) {
						oyaPoints = 18000;
					} else if (8 <= totalhansu && totalhansu <= 10) {
						oyaPoints = 24000;
					} else if (11 <= totalhansu && totalhansu <= 12) {
						oyaPoints = 36000;
					} else if (13 <= totalhansu) {
						oyaPoints = 48000;
					}
				}
			}
		}


		// 切り上げ・文字列格納
		if (oyaPoints > 0) {
			tmppoints = (float)oyaPoints / 100;
			tmppoints = Mathf.CeilToInt (tmppoints);
			tmppoints = tmppoints * 100;
			oyaPoints = (int)tmppoints;
			oyaPointsStr = oyaPoints.ToString ();
		} else {
			oyaPointsStr = "";
		}
		if (koPoints > 0) {
			tmppoints = (float)koPoints / 100;
			tmppoints = Mathf.CeilToInt (tmppoints);
			tmppoints = tmppoints * 100;
			koPoints = (int)tmppoints;
			koPointsStr = koPoints.ToString ();
		} else {
			koPointsStr = "";
		}

		// テキスト更新
		tmpgameobj = GameObject.Find("HanNum");
		hanNumText = tmpgameobj.GetComponent<Text> ();
		tmpgameobj = GameObject.Find("HuNum");
		huNumText = tmpgameobj.GetComponent<Text> ();
		tmpgameobj = GameObject.Find("Result");
		koPointsText = tmpgameobj.GetComponent<Text> ();
		tmpgameobj = GameObject.Find("Result2");
		oyaPointsText = tmpgameobj.GetComponent<Text> ();
		hanNumText.text = totalhansu.ToString () + "翻";
		huNumText.text = husu.ToString () + "符";
		koPointsText.text = koPointsStr;
		oyaPointsText.text = oyaPointsStr;
		// リセット
		totalhansu = 0;
		husu = 0;
		koPoints = 0;
		oyaPoints = 0;
	}
}
