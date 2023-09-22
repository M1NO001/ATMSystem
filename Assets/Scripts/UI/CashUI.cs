using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CashUI : MonoBehaviour
{
    [SerializeField] private TMP_Text cashText;
    
    private void Start()
    {
        cashText.text = GameManager.Instance.defaultCash.ToString();
    }
    public void ChangeCashText(int cash)
    {
        cashText.text = cash.ToString();
    }
}
