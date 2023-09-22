using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PopUpBtn : MonoBehaviour
{
    public GameObject PopUp;
    private void Start()
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(PopUpClose);
        }
    }
    public void PopUpClose()
    {
        PopUp.SetActive(false);
    }
}
