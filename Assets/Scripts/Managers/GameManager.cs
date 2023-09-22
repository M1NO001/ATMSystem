using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager: MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance { get => _instance; }
    public GameObject MainSceneUI;
    public GameObject UserPrefab;
    public string UserName { get; private set; }
    public int defaultCash { get; set; }
    public int defaultBalance { get; set; }


    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        SetUser();
        SetUI();    
    }
    public void SetUser()
    {
        if (UserPrefab != null) // UserPrefab이 null이 아닌지 확인
        {
            GameObject user = Instantiate(UserPrefab, transform.position, Quaternion.identity);
            UserName = user.GetComponent<UserInfo>().UserName;
            defaultBalance = user.GetComponent<UserInfo>().balance;
            defaultCash = user.GetComponent<UserInfo>().cash;
        }
    }
    public void SetUI()
    {
        if (MainSceneUI != null)
        {
            MainSceneUI = Instantiate(MainSceneUI, transform.position, Quaternion.identity);
        }
    }
}
