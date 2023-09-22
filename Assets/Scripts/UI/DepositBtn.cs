using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DepositBtn : MonoBehaviour
{
    public GameObject defaultUI;
    public GameObject DepositUI;
    private void Start()
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(DepositBtnClick);
        }
    }
    public void DepositBtnClick()
    {
        defaultUI.SetActive(false);
        DepositUI.SetActive(true);
    }



}
