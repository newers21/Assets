using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainThread : MonoBehaviour
{
    private int allMoney;

    void FixedUpdate()
    {
        allMoney = 0;

        foreach (Building building in GameManager.buildingList)
        {

            if (building.currentResidents < building.maxResidents)
            {
                building.currentResidents += building.residentsPerSecond;
                allMoney += building.moneyPerResident * building.residentsPerSecond;
            }
        }

        GameManager.income += allMoney;
        Debug.Log("Money:" + allMoney);
    }
}
