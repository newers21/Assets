using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI moneyResident;
    [SerializeField] public TextMeshProUGUI residentSecond;
    [SerializeField] public TextMeshProUGUI residentsNow;

    private Building currentBuilding;

    private void Update()
    {
        if (currentBuilding != null)
        {
            moneyResident.text = "Money/resident: " + currentBuilding.moneyPerResident;
            residentSecond.text = "Residents/second: " + currentBuilding.residentsPerSecond;
            residentsNow.text = "Current Residents: " + currentBuilding.currentResidents;
        }
    }

    public void SetCurrentBuilding(Building building)
    {
        currentBuilding = building;
    }
}
