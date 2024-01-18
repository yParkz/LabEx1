using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabEx1 : MonoBehaviour
{
    [SerializeField]
    private int muffinsSold;

    [SerializeField]
    private int donutsSold;

    private int muffinPrice = 5;
    private int donutPrice = 3;
    // Start is called before the first frame update
    void Start()
    {
        CalculateSales();

   }

    // Update is called once per frame
    void CalculateSales()
    {
        float totalMuffinAmount = muffinsSold * muffinPrice;
        float totalDonutAmount = donutsSold * donutPrice;

        int totalItemsSold = muffinsSold + donutsSold;
        float totalAmountCollected = totalMuffinAmount + totalDonutAmount;

        // Display results in Unity Console
        Debug.Log("Muffin price: " + muffinPrice);
        Debug.Log("Quantity of Muffins Sold: " + muffinsSold);
        Debug.Log("Donut price: " + donutPrice);
        Debug.Log("Quantity of Donut Sold: " + donutsSold);
        Debug.Log("Total Amount (Muffins): $" + totalMuffinAmount.ToString("F2"));  
        Debug.Log("Total Amount (Donuts): $" + totalDonutAmount.ToString("F2"));    
        Debug.Log("A total of " + totalItemsSold + " items were sold");
        Debug.Log("$" + totalAmountCollected.ToString("F2") + " was collected in sales"); 


    }
}
