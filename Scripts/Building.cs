using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    [SerializeField] private Sprite buildingAsset;
    [SerializeField] public bool cost;
    [SerializeField] public int moneyPerResident;
    [SerializeField] public int maxResidents;
    [SerializeField] public int residentsPerSecond;
    [SerializeField] private Animation buildingAnimationComponent;
    [SerializeField] public int currentResidents;
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

    private void OnMouseDown()
    {
        if (isCreate)
        {
            return;
        }

        isCreate = true;
        GameManager.AddBuilding(this);

        Debug.Log("click");
    }
}

