using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public static class GameManager
{
    public static int income;
    public static int people;
    public static int buildings;
    public static List<Building> buildingList = new List<Building>();

    public static void IncreaseIncome()
    {
        
    }

    public static void IncreasePeople()
    {
        Debug.Log("click");
    }

    public static void AddBuilding(Building newBuilding)
    {
        buildingList.Add(newBuilding);
    }
}