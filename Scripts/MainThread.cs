using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainThread : MonoBehaviour
{
    private int allMoney;

    void FixedUpdate()
    {

    }

    private void allMoneyCount(int amount)
    {
        allMoney += amount;
    }
}
