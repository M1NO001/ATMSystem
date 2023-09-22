using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SamManwonDeposit : MonoBehaviour
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
            button.onClick.AddListener(DepositSamManwon);
        }
    }

    public void DepositSamManwon()
    {
        if (GameManager.Instance.defaultCash < 30000)
        {
            PopUp.SetActive(true);
        }
        else
        {
            GameManager.Instance.defaultCash -= 30000;
            GameManager.Instance.defaultBalance += 30000;
            CashUI.GetComponent<CashUI>().ChangeCashText(GameManager.Instance.defaultCash);
            UserInfoUI.GetComponent<UserInfoUI>().ChangeBalanceText(GameManager.Instance.defaultBalance);
        }
    }
}
