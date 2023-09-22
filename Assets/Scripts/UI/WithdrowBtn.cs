using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WithdrowBtn : MonoBehaviour
{
    public GameObject defaultUI;
    public GameObject WithdrowUI;

    private void Start()
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(WithdrowBtnClick);
        }
    }

    public void WithdrowBtnClick()
    {
        defaultUI.SetActive(false);
        WithdrowUI.SetActive(true);
    }
}
