using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    [SerializeField] private Sprite buildingAsset;
    [SerializeField] private bool cost;
    [SerializeField] private Animation buildingAnimationComponent;

    private Image buildingImageComponent;
    [SerializeField] private bool isCreate;

    public void Awake()
    {
        buildingImageComponent = GetComponent<Image>();
    }

    public void OnClick()
    {
        if (buildingImageComponent == null) 
        {
            Debug.LogError("!!!");
            return;
        }

        GameManager.AddBuilding(this);
        isCreate = true;
    }
}

