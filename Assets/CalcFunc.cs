using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalcFunc : MonoBehaviour {

	public int hansu = 0;
	public int husu = 0;
	public int dora = 0;
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
	public int nakiFlag = 1;
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
		
	}
	
	// 点数計算関数
	public void OnClick () {
		Debug.Log("ボタンが押されました");

	}
}
