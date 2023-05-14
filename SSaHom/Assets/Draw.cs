using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{

    NoticeUI _notice;
    public bool on = false;
    public GameObject DrawShop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OneDrawStat()
    {
        this.on = false;
        DrawShop.SetActive(true);
        _notice.SUB("엽전이 부족합니다!");

    }

    }
