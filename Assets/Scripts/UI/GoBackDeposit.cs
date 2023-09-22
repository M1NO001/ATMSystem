using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoBackDeposit : MonoBehaviour
{
    public GameObject defaultUI;
    public GameObject DepositUI;
    
    private void Start()
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(GoBackBtn);
        }
    }
    public void GoBackBtn()
    {
        defaultUI.SetActive(true);
        DepositUI.SetActive(false);
    }
}
