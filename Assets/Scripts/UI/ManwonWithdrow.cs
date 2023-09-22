using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ManwonWithdrow : MonoBehaviour
{
    public GameObject CashUI;
    public GameObject UserInfoUI;
    public GameObject PopUp;
    // Start is called before the first frame update
    private void Start()
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(WithdrowManwon);
        }
    }

    // Update is called once per frame
    public void WithdrowManwon()
    {
        if (GameManager.Instance.defaultBalance < 10000)
        {
            PopUp.SetActive(true);
        }
        else
        {
            GameManager.Instance.defaultCash += 10000;
            GameManager.Instance.defaultBalance -= 10000;
            CashUI.GetComponent<CashUI>().ChangeCashText(GameManager.Instance.defaultCash);
            UserInfoUI.GetComponent<UserInfoUI>().ChangeBalanceText(GameManager.Instance.defaultBalance);
        }
    }
}
