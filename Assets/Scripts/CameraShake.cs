using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
  
    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 orignalPosition = UnityEngine.GameObject.Find("Main Camera").transform.position;
        float elapsed = 0f;
        
        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;
            UnityEngine.GameObject.Find("Main Camera").transform.position = new Vector3(x, y, -10f);
            elapsed += UnityEngine.Time.deltaTime;
            yield return 0;
        }
        UnityEngine.GameObject.Find("Main Camera").transform.position = orignalPosition;
    }
   
}

