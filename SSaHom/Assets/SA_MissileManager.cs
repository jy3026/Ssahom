/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SA_MissileManager : MonoBehaviour
{

    public Transform _missilePool;

    public List<SA_MissileObj> _poolListSave = new List<SA_MissileObj>();

    public List<SA_MissileObj> _poolListUse = new List<SA_MissileObj>();



    void Awake()
    {
        SoonsoonData.Instance.SAMM = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        GetMissileList();
    }

    // Update is called once per frame
    void Update()
    {
        SSThread();
    }


    void SSThread()
    {
        if(_poolListUse.Count > 0 )
        {
            for ( var i = 0; i < _poolListUse.Count; i++)
            {
                if (!_poolListUse[i].gameObject.activeInHierarchy) return;
                SA_MissileObj tST = _poolListUse[i];
                tST._timer += Time.deltaTime;

                if(tST._timer > tST._timerForLim )
                {
                    tST.MissileDone();
                }
                else
                {
                    tST.DoMove();
                }
            }
        }
    }

    public void GetMissileList()
    {
        _poolListUse.Clear();
        _poolListSave.Clear();

        for(var i = 0; i<_missilePool.childCount; i++)
        {
            SA_MissileObj tObjST = _missilePool.GetChild(i).GetComponent<SA_MissileObj>();
            _poolListSave.Add(tObjST);
        }
    }

    public void FireMissile (SA_MissileObj.MissileType type, SA_Unit owner, SA_Unit target)
    {
        SA_MissileObj tMissile = null;

        foreach(var obj in _poolListSave)
        {
            if(!obj.gameObject.activeInHierarchy)
            {
                tMissile = obj;
                break;
            }
        }

        if(tMissile!=null)
        {
            tMissile.SetMissile(type, owner, target);
        }

    }


}*/
