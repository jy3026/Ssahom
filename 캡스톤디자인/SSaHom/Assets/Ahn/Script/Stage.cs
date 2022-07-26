using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Stage : MonoBehaviour
{
    GameObject StageSet;

    
    public Text text0;
    //public GameObject ChangeLoad;
    NoticeUI _notice;

    int stage;
    void Awake()
    {
        stage = PlayerPrefs.GetInt("SStage");
        _notice = FindObjectOfType<NoticeUI>();
        StageSet = GameObject.Find("StageSet");
        //ChangeLoad = GameObject.Find("ChangeLoad");
    }
    void Start()
    {

        // ChangeLoad.SetActive(false);
        StageSet.SetActive(false);
    }
    private void Update()
    {
        if (StageSet)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
                StageSet.SetActive(false);
        }
    }
    public void Stage01()
    {
        PlayerPrefs.SetInt("Stage", 0);
        StageSet.SetActive(true);
        //SceneManager.LoadScene("Loading");
        text0.text = "�溹�� ����";
    }
    public void Stage02()
    {
        PlayerPrefs.SetInt("Stage", 5);
        StageSet.SetActive(true);
        //SceneManager.LoadScene("Loading");
        text0.text = "â��� ����";
    }
    public void Stage03()
    {
        PlayerPrefs.SetInt("Stage", 10);
        StageSet.SetActive(true);
        // SceneManager.LoadScene("Loading");
        text0.text = "â���� ����";
    }
    public void Stage04()
    {
        PlayerPrefs.SetInt("Stage", 15);
        StageSet.SetActive(true);
        // SceneManager.LoadScene("Loading");
        text0.text = "���� ����";
    }
    public void Stage05()
    {
        PlayerPrefs.SetInt("Stage", 20);
        StageSet.SetActive(true);
        // SceneManager.LoadScene("Loading");
        text0.text = "�źϼ� ����";
    }

    public void PlayStage()
    {
        StageSet.SetActive(true);
    }
    public void ClosePlayStage()
    {
        StageSet.SetActive(false);
    }
    public void PlayBtn()
    {
        
        string S_S = EventSystem.current.currentSelectedGameObject.name.ToString();
        switch(S_S)
        {
            case "s1-1":
                PlayerPrefs.SetInt("Small_Stage", 0);
                
                SceneManager.LoadScene("Loading");
                break;
            case "s1-2":
                PlayerPrefs.SetInt("Small_Stage", 1);
                if (stage >= 1)
                {
                    SceneManager.LoadScene("Loading");
                }
                else
                {
                    _notice.SUB("���밡 ������ �ʾҽ��ϴ�.");
                }
                break;
            case "s1-3":
                PlayerPrefs.SetInt("Small_Stage", 2);
                if (stage >= 2)
                {
                    SceneManager.LoadScene("Loading");
                }
                else
                {
                    _notice.SUB("���밡 ������ �ʾҽ��ϴ�.");
                }
                break;
            case "s1-4":
                PlayerPrefs.SetInt("Small_Stage", 3);
                if (stage >= 3)
                {
                    SceneManager.LoadScene("Loading");
                }
                else
                {
                    _notice.SUB("���밡 ������ �ʾҽ��ϴ�.");
                }
                break;
            case "s1-5":
                PlayerPrefs.SetInt("Small_Stage", 4);
                if (stage >= 4)
                {
                    SceneManager.LoadScene("Loading");
                }
                else
                {
                    _notice.SUB("���밡 ������ �ʾҽ��ϴ�.");
                }
                break;

        }
        //SceneManager.LoadScene("Loading");
    }

    public void CloseBtn()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            StageSet.SetActive(false);
    }

}
