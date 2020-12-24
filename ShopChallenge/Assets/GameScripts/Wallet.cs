using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    int totalAmount;

    public int startAmount;

    private void Start()
    {
        SetTotal(startAmount);
    }

    private void Update()
    {
        if (totalAmount <= 0)
        {
            totalAmount = 0;
        }
    }

    public void Buy(int price)
    {
        totalAmount = totalAmount - price;
    }

    public void Sell (int price)
    {
        totalAmount = totalAmount + price;
    }

    public int GetTotal()
    {
        return totalAmount;
    }

    public void SetTotal(int amount)
    {
        totalAmount = amount;
    }
}
