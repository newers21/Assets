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
    private bool isCreate;

    private Image buildingImageComponent;

    public void Start()
    {
        buildingImageComponent = GetComponent<Image>();
    }

    public void OnClick()
    {
        if (isCreate)
        {
            return;
        }

        if (buildingImageComponent == null)
        {
            Debug.LogError("miss");
            return;
        }

        isCreate = true;
        GameManager.AddBuilding(this); 
    }
}

