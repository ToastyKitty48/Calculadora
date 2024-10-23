using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Math : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Calculate()
    {
        GameObject[] Amounts = GameObject.FindGameObjectsWithTag("Quanty");
        GameObject[] Costs = GameObject.FindGameObjectsWithTag("Cost");
        float[] AmountsDoub = new float[Amounts.Length];
        float[] CostsDoub = new float[Costs.Length];
        float[] TotalCosts = new float[Amounts.Length];
        float FinalCost = new float();
        
        for (int i = 0; i < Amounts.Length; i++) {
            if (float.TryParse(Amounts[i].GetComponent<TMP_InputField>().text, out AmountsDoub[i]) == false) {
                Debug.Log("Don't use letters please or multiple decimal points :(");
                return;
            }
            if (float.TryParse(Costs[i].GetComponent<TMP_InputField>().text, out CostsDoub[i]) == false)
            {
                Debug.Log("Don't use letters please or multiple decimal points :(");
                return;
            }
            TotalCosts[i] = AmountsDoub[i] * CostsDoub[i];
        }

        for (int i = 0; i < TotalCosts.Length; i++) {
            FinalCost += TotalCosts[i];
        }

        Debug.Log(FinalCost);
    }
}
