using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoBackWithdrow: MonoBehaviour
{
    public GameObject defaultUI;
    public GameObject WithdrowUI;

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
        WithdrowUI.SetActive(false);
    }
}
