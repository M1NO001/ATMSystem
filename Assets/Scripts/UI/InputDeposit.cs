using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class InputDeposit : MonoBehaviour
{
    public Button depositBtn;
    public TMP_InputField txtInputMoney;
    public GameObject PopUpUI;
    public GameObject CashUI;
    public GameObject UserInfo;
    public int InputMoneyInt=0;

    public void DepositBtnClick()
    {
        InputMoneyInt = int.Parse(txtInputMoney.text);
        if (InputMoneyInt > GameManager.Instance.defaultCash)
        {
            PopUpUI.SetActive(true);
        }
        else
        {
            GameManager.Instance.Deposit(InputMoneyInt);
            CashUI.GetComponent<CashUI>().ChangeCashText(GameManager.Instance.defaultCash);
            UserInfo.GetComponent<UserInfoUI>().ChangeBalanceText(GameManager.Instance.defaultBalance);
        }
    }
}
