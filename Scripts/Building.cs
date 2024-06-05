using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    public GameObject buildingMain;
    [SerializeField] public int moneyPerResident;
    [SerializeField] public int maxResidents;
    [SerializeField] public int residentsPerSecond;
    [SerializeField] public int buildingCost;

    private SpriteRenderer spriteRenderer;
    public int currentResidents;
    private bool isCreate;

    //private Image buildingImageComponent;
    private Animation animationBuildingComponent;

    public void Start()
    {
        currentResidents = 1;

        spriteRenderer = GetComponent<SpriteRenderer>();
        animationBuildingComponent = GetComponent<Animation>();

        if (spriteRenderer == null)
        {
            Debug.LogError("missing buildingimageComponent");
            return;
        }

        if (animationBuildingComponent == null)
        {
            Debug.LogError("missing animationBuildingComponent");
            return;
        }

    }

    public void OnMouseDown()
    {
        Debug.Log("click");
        var buildingView = FindObjectOfType<BuildingView>();
        if (buildingView != null)
        {
            buildingView.Show(this);
        }

        else
        {
            Debug.LogError("No BuildingView");
        }
    }

    public void Build()
    {
        if (isCreate)
        {
            return;
        }

        isCreate = true;
        GameManager.AddBuilding(this);
        buildingMain.SetActive(true);
    }
}

