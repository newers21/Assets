using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour
{
    public GameObject buildingMain;
    [SerializeField] public bool cost;
    [SerializeField] public int moneyPerResident;
    [SerializeField] public int maxResidents;
    [SerializeField] public int residentsPerSecond;
    //[SerializeField] private Animation buildingAnimationComponent;
    private SpriteRenderer spriteRenderer;
    public int currentResidents;
    private bool isCreate;

    //private Image buildingImageComponent;
    private Animation animationBuildingComponent;

    public void Start()
    {

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
        if (isCreate)
        {
            return;
        }
        isCreate = true;
        GameManager.AddBuilding(this);

        buildingMain.SetActive(true);

    }
}

