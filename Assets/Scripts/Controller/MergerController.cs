using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public abstract class MergerController : MonoBehaviour
{
    
    static List<MergerController> mergers = new List<MergerController>();
    public static MergerController GetMetObject(MergerController checkObject)
    {
        MergerController result = null;
        float minDistance = 1000;
        foreach (MergerController merge in mergers)
        {
            if (merge == checkObject) continue;
            float distance = Vector3.Distance(merge.transform.position, checkObject.transform.position);
            if (checkObject.CheckMerge(merge) && (distance <= minDistance || result == null))
            {
                Debug.Log("bat dau merger");
                result = merge;
                minDistance = distance;
            }
        }
        return result;
    }

    public abstract bool CheckMerge(MergerController merge);
    private void Awake()
    {
        mergers.Add(this);
    }
    //protected abstract void Merge("");
    //protected abstract void Merge("");
}
public class Merger : SingletonMonoBehaviour<MergerController>
{

}
