using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalcFunc : MonoBehaviour {

	public int hansu = 0;
	public int husu = 0;
	public int dora = 0;
	public int totalhansu = 0;	// 加算ループ回避用
	public int pooints = 0;

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
		husu = 0;
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
		// ループ回避
		totalhansu = hansu + dora;
		Debug.Log (totalhansu);
		totalhansu = 0;
	}
}
