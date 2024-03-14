using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginFingerPrint : MonoBehaviour
{
    public float time;
    private bool IsStart = false;
    private float LastTime = 0;
    void Update()
    {
        if (IsStart && time > 0 && LastTime > 0 && Time.time - LastTime > time)
        {
            Debug.Log("长按触发");
            IsStart = false;
            LastTime = 0;
        }
    }
    public void LongPress(bool bStart)
    {
        IsStart = bStart;
        if (IsStart)
        {
            LastTime = Time.time;
            Debug.Log("长按开始");
        }
        else if (LastTime != 0)
        {
            LastTime = 0;
            Debug.Log("长按取消");
        }
    }

}
