using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OManwonDeposit : MonoBehaviour
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
            button.onClick.AddListener(DepositOManwon);
        }
    }

    // Update is called once per frame
    public void DepositOManwon()
    {
        if (GameManager.Instance.defaultCash < 50000)
        {
            PopUp.SetActive(true);
        }
        else
        {
            GameManager.Instance.defaultCash -= 50000;
            GameManager.Instance.defaultBalance += 50000;
            CashUI.GetComponent<CashUI>().ChangeCashText(GameManager.Instance.defaultCash);
            UserInfoUI.GetComponent<UserInfoUI>().ChangeBalanceText(GameManager.Instance.defaultBalance);
        }
        
    }
}
