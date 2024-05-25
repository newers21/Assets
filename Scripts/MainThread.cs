using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainThread : MonoBehaviour
{
    [SerializeField] public int allMoney;

    void FixedUpdate()
    {
        int money = 0;

        foreach (Building building in GameManager.buildingList)
        {

            if (building.currentResidents < building.maxResidents)
            {
                building.currentResidents += building.residentsPerSecond;
                money += building.moneyPerResident * building.residentsPerSecond;
            }
        }

        GameManager.income += money;
        Debug.Log("Money:" + allMoney);
    }
}
