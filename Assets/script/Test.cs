using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] array = {10, 20, 30, 40, 50, };

		// 配列の要素数のぶんだけ処理を繰り返す
		for (int i = 0; i < array.Length; i++) {
			
				Debug.Log (array [i]);
			}
		for (int j = 4; -1 < j; j--) {

		    	Debug.Log (array [j]);
	
    }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
