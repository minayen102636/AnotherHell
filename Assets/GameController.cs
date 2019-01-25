using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public int[ ] order;
    public int index;
    public GameObject [] pillars;
    public Sprite pillarOff;

    public GameObject Chest;
    public Sprite chestOpen;
    public GameObject Coin;

	
	void Start () {
        ResetAllPillars();
        Coin.SetActive(false);
	}
	
	
	void Update () {
		
	}

    public void ResetAllPillars()
    {
        index = 0;
        for (int i = 0; i < 3; i++)
        {
            pillars[i].GetComponent<SpriteRenderer>().sprite = pillarOff;
        }
    }

    public bool CheckPillar (int pillarNo)
    {
        if (order[index] == pillarNo) //使用index來拿出order的資料，判斷 pillarNo 是否順序正確
        {
            if (index == 2) //若正確，再判斷index是否為2
            {
                //Win
                Win();
            }
            index = index + 1;
            return true;
        }

        else
        {
            ResetAllPillars();
            return false;
        }
    }

    public void Win()
    {
        Chest.GetComponent<SpriteRenderer>().sprite = chestOpen;
        Coin.SetActive(true);
    }

}
