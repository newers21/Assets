using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager
{
    private static int income;
    private static int people;
    private static int buildings;
    private static List<Building> buildingList = new List<Building>();

    public static void IncreaseIncome()
    {
        
    }

    public static void IncreasePeople()
    {
        
    }

    public static void AddBuilding(Building newBuilding)
    {
        buildingList.Add(newBuilding);
    }
}