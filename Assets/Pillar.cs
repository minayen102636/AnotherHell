using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour {
    public Sprite pillarOn;
    public bool isPlayerOn;
    public int pillarNo;
    public GameObject Core;

    public int f; //有無被點擊過ㄉ標準

	void Start () {
        isPlayerOn = false;
        f = 0; //遊戲開始沒有被點擊過
	}
	

	void Update () {
        if ( isPlayerOn && Input.GetKeyUp(KeyCode.Space) && f==0 ) //尚未被按過
        {
            bool correct = Core.GetComponent<GameController>().CheckPillar(pillarNo);
            if (correct)
            {
                GetComponent<SpriteRenderer>().sprite = pillarOn;
            }
            f = 1;
        }

        else if (isPlayerOn && Input.GetKeyUp(KeyCode.Space) && f == 1) //已經被按過
        {
                GetComponent<SpriteRenderer>().sprite = pillarOn;

            f = 1;
        }


    }

    void OnTriggerEnter2D(Collider2D other )
    {
        Debug.Log("detect trigger signal");
        isPlayerOn = true;
        Debug.Log("Enter");
    }
    void OnTriggerExit2D(Collider2D other)
    {
        isPlayerOn = false;
        Debug.Log("Exit");
    }

   

}
