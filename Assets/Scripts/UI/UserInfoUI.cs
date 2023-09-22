using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UserInfoUI : MonoBehaviour
{
    [SerializeField] private TMP_Text balanceText;
    [SerializeField] private TMP_Text userNameText;
    private void Start()
    {
        balanceText.text = GameManager.Instance.defaultBalance.ToString();
        userNameText.text = GameManager.Instance.UserName;

    }

    public void ChangeBalanceText(int balance)
    {
        balanceText.text = balance.ToString();
    }
    public void ChangeNameText(string name)
    {
        userNameText.text = name;

    }
}
