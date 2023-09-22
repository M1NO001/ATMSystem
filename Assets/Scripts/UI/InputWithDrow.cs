using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class InputWithDrow : MonoBehaviour
{
    public Button depositBtn;
    public InputField txtInputMoney;
    public GameObject PopUpUI;
    public GameObject CashUI;
    public GameObject UserInfo;
    public int InputMoneyInt = 0;

    public void DepositBtnClick()
    {
        InputMoneyInt = int.Parse(txtInputMoney.text);
        if (InputMoneyInt > GameManager.Instance.defaultBalance)
        {
            PopUpUI.SetActive(true);
        }
        else
        {
            GameManager.Instance.WithDrow(InputMoneyInt);
            CashUI.GetComponent<CashUI>().ChangeCashText(GameManager.Instance.defaultCash);
            UserInfo.GetComponent<UserInfoUI>().ChangeBalanceText(GameManager.Instance.defaultBalance);
        }
    }
}

