using UnityEngine;
using System.Collections;

public class MoveSample : MonoBehaviour
{	
	void Start(){
		//iTween.MoveBy(gameObject, iTween.Hash("x", 2, "easeType", "easeInOutExpo", "loopType", "pingPong", "delay", .1));
        iTween.ScaleBy(gameObject, iTween.Hash(
                "amount", new Vector3(3, 3, 3),
                "easeType", iTween.EaseType.easeOutBounce,
                "time", 0.5f,
                "delay", 0.5f
            ));
	}
}

