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
    [SerializeField] private MainThread mainThread;

    [SerializeField] private UImanager uiManager;
    private Building currentBuilding;

    private void Start()
    {
        buyButton.onClick.AddListener(Buy);
    }

    public void Show(Building building)
    {
        currentBuilding = building;
        priceText.text = building.buildingCost.ToString();
        menu.SetActive(true);

        uiManager.SetCurrentBuilding(building);
    }

    public void Buy()
    {
        if (mainThread.allMoney >= currentBuilding.buildingCost)
        {
            Debug.Log("Enough Money");
            mainThread.allMoney -= currentBuilding.buildingCost;
            currentBuilding.Build();
            Close();
        }
        else
        {
            Debug.Log("Not enough money");
        }
    }

    public void Close()
    {
        menu.SetActive(false);
    }
}
