using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainThread : MonoBehaviour
{
    [SerializeField] public int allMoney;
    [SerializeField] public TextMeshProUGUI moneyText;

    void FixedUpdate()
    {

        foreach (Building building in GameManager.buildingList)
        {

            allMoney += building.moneyPerResident * building.residentsPerSecond;

            if (building.currentResidents < building.maxResidents)
            {
                building.currentResidents += building.residentsPerSecond;
            }

        }

        GameManager.income += allMoney;
        Debug.Log("Money:" + allMoney);
        moneyText.text = "Money: " + allMoney;
    }
}
