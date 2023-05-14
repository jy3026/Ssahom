using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SA_Manager : MonoBehaviour
{
    public float _findTimer;

    public List<Transform> _unitPool = new List<Transform>();

    public List<SA_Unit> _p1UnitList = new List<SA_Unit>();

    public List<SA_Unit> _p2UnitList = new List<SA_Unit>();

    public List<SA_Unit> _p3UnitList = new List<SA_Unit>();

    public GameObject Clear;

    public GameObject Over;

    public GameObject enemy;

    public GameObject enemy1;

    void Awake()
    {
        SoonsoonData.Instance.SAM = this;

    }


    // Start is called before the first frame update
    void Start()
    {
        SetUnitList();

        //Score = GameObject.Find("myscore").GetComponent<Text>();
        //P2 = GameObject.Find("P2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetUnitList()
    {
        _p1UnitList.Clear();
        _p2UnitList.Clear();
        //_p3UnitList.Clear();

        for (var i = 0; i < _unitPool.Count; i++)
        {
            for (var j = 0; j < _unitPool[i].childCount; j++)
            {
                switch (i)
                {
                    case 0:
                        /*if (_unitPool[i].GetChild(j).GetComponent<SA_Unit>().gameObject.activeSelf == true)
                        {
                            _p1UnitList.Add(_unitPool[i].GetChild(j).GetComponent<SA_Unit>());
                            _unitPool[i].GetChild(j).gameObject.tag = "P1";
                        }*/
                        _p1UnitList.Add(_unitPool[i].GetChild(j).GetComponent<SA_Unit>());
                        _unitPool[i].GetChild(j).gameObject.tag = "P1";

                            break;
                       

                    case 1:
                        /*if (_unitPool[i].GetChild(j).GetComponent<SA_Unit>().gameObject.activeSelf == true)
                        {
                        _p2UnitList.Add(_unitPool[i].GetChild(j).GetComponent<SA_Unit>());
                        _unitPool[i].GetChild(j).gameObject.tag = "P2";
                        }*/
                        _p2UnitList.Add(_unitPool[i].GetChild(j).GetComponent<SA_Unit>());
                        _unitPool[i].GetChild(j).gameObject.tag = "P2";
                        break;

                    case 2:
                        _p3UnitList.Add(_unitPool[i].GetChild(j).GetComponent<SA_Unit>());
                        _unitPool[i].GetChild(j).gameObject.tag = "P3";
                        break;
                }

            }
        }
    }


    public SA_Unit GetTarget( SA_Unit unit)
    {
        SA_Unit tUnit = null;

        List<SA_Unit> tList = new List<SA_Unit>();
        switch (unit.tag)
        {
            case "P1": 
                if(enemy.activeSelf == true)
                {
                    tList = _p2UnitList;
                }
                if (enemy1.activeSelf == true)
                {
                    tList = _p3UnitList;
                }
                
                break;

            case "P2": tList = _p1UnitList; break;
            case "P3": tList = _p1UnitList; break;
        }

        float tSDis = 999999;

        for ( var i = 0 ; i < tList.Count; i++)
        {
            float tDis = ((Vector2)tList[i].transform.localPosition - (Vector2)unit.transform.localPosition).sqrMagnitude;
            if (tDis <= unit._unitFR * unit._unitFR)
            {
                if (tList[i].gameObject.activeInHierarchy)
                {
                    if (tList[i]._unitState!=SA_Unit.UnitState.death)
                    {
                        if (tDis < tSDis)
                        {
                            tUnit = tList[i];
                            tSDis = tDis;
                        }

                    }
                }
                
            }

        }


        /*if (_p1UnitList[0]._unitState == SA_Unit.UnitState.death)
        {
            
            if (_p1UnitList[1]._unitState == SA_Unit.UnitState.death)
            {
                
                if (_p1UnitList[2]._unitState == SA_Unit.UnitState.death)
                {
                    
                    if (_p1UnitList[3]._unitState == SA_Unit.UnitState.death)
                    {
                        Over.SetActive(true);
                    }
                }
            }
        }*/
        /*if (_p1UnitList.Count == 0)
        {
            Over.SetActive(true);
        }
        if (P2.activeSelf == true) { 
            if (_p2UnitList.Count == 0)
            {
                Clear.SetActive(true);
            }
        }*/

        if (_p1UnitList[0]._unitState == SA_Unit.UnitState.death)
        {

            if (_p1UnitList[1]._unitState == SA_Unit.UnitState.death)
            {

                if (_p1UnitList[2]._unitState == SA_Unit.UnitState.death)
                {

                    if (_p1UnitList[3]._unitState == SA_Unit.UnitState.death)
                    {
                        if (_p1UnitList[4]._unitState == SA_Unit.UnitState.death)
                        {

                            if (_p1UnitList[5]._unitState == SA_Unit.UnitState.death)
                            {

                                if (_p1UnitList[6]._unitState == SA_Unit.UnitState.death)
                                {

                                    if (_p1UnitList[7]._unitState == SA_Unit.UnitState.death)
                                    {
                                        if (_p1UnitList[8]._unitState == SA_Unit.UnitState.death)
                                        {

                                            if (_p1UnitList[9]._unitState == SA_Unit.UnitState.death)
                                            {

                                                if (_p1UnitList[10]._unitState == SA_Unit.UnitState.death)
                                                {

                                                    if (_p1UnitList[11]._unitState == SA_Unit.UnitState.death)
                                                    {
                                                        if (_p1UnitList[12]._unitState == SA_Unit.UnitState.death)
                                                        {

                                                            if (_p1UnitList[13]._unitState == SA_Unit.UnitState.death)
                                                            {

                                                                if (_p1UnitList[14]._unitState == SA_Unit.UnitState.death)
                                                                {
                                                                    Over.SetActive(true);
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


        if (_p2UnitList[0]._unitState == SA_Unit.UnitState.death)
            {

                if (_p2UnitList[1]._unitState == SA_Unit.UnitState.death)
                {

                    if (_p2UnitList[2]._unitState == SA_Unit.UnitState.death)
                    {

                        if (_p2UnitList[3]._unitState == SA_Unit.UnitState.death)
                        {
                        //Over.SetActive(true);

                            Clear.SetActive(true);
                        }
                    }
                }
            }

        if (_p3UnitList[0]._unitState == SA_Unit.UnitState.death)
        {

            if (_p3UnitList[1]._unitState == SA_Unit.UnitState.death)
            {

                if (_p3UnitList[2]._unitState == SA_Unit.UnitState.death)
                {

                    if (_p3UnitList[3]._unitState == SA_Unit.UnitState.death)
                    {
                        //Over.SetActive(true);

                        Clear.SetActive(true);
                    }
                }
            }
        }

        return tUnit;
    }
    

}
