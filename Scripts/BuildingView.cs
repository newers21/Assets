using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuildingView : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private TextMeshProUGUI priceText; 
    [SerializeField] private Button buyButton;

    private Building currentBuilding;

    public void Show(Building building)
    {
        currentBuilding = building;
        priceText.text = building.buildingCost.ToString();
        menu.SetActive(true);
    }

    public void Buy()
    {
        if (GameManager.income >= currentBuilding.buildingCost)
        {
            GameManager.income -= currentBuilding.buildingCost;
            currentBuilding.Build();
            Close();
        }
    }

    public void Close()
    {
        menu.SetActive(false);
    }
}
