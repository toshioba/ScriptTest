using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class Boss1 {        
		private int mp = 53;          // 魔力
		
	
		// 魔法の関数
	　　 public  void Magic() { 
		if (mp >= 5) {
			mp = mp - 5; 
			Debug.Log( "魔法攻撃をした。残りmpは" + mp);
		}else{
			Debug.Log ("Mpが足りないため魔法が使えない");
		}
		}

		
		
	　}

　
public class  BossTes: MonoBehaviour {
		void Start () {
			// Bossクラスの変数を宣言してインスタンスを代入
			
		  
		Boss1 lastboss = new Boss1 ();  
		for(int i = 0; i < 11; i++){
			lastboss.Magic();
		}


			
			//if(i<=0){
				//Debug.Log("Mpが足りないため魔法が使えない");	
			//lastboss.magic();
		}

		// Update is called once per frame
		void Update () {

		}
	}

