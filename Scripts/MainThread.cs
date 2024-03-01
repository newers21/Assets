using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainThread : MonoBehaviour
{
    private int allMoney;

    void FixedUpdate()
    {
        allMoney += GameManager.income;

        foreach (Building building in GameManager.buildingList)
        {
            GameManager.income += building.moneyPerResident * building.currentResidents;

            if (building.currentResidents < building.maxResidents)
            {
                building.currentResidents += building.residentsPerSecond;
            }
        }
    }
}
