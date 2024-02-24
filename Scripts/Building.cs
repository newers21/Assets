using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    [SerializeField] private Sprite buildingAsset;
    [SerializeField] private bool cost;
    [SerializeField] private int moneyPerResident;
    [SerializeField] private int maxResidents;
    [SerializeField] private int residentsPerSecond;
    [SerializeField] private Animation buildingAnimationComponent;
    private bool isCreate;

    private Image buildingImageComponent;
    private Animation animationBuildingComponent;

    public void Start()
    {
        buildingImageComponent = GetComponent<Image>();
        animationBuildingComponent = GetComponent<Animation>();
        if (buildingImageComponent == null)
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

    public void OnClick()
    {
        if (isCreate)
        {
            return;
        }

        isCreate = true;
        GameManager.AddBuilding(this); 
    }
}

