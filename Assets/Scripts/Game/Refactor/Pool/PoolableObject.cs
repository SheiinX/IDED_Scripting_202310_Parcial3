using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolableObject : MonoBehaviour, IPool
{
    public void OnObjectToRecycle(GameObject instance)
    {
        instance.SetActive(false);
    }

    public void PrepareRetrieve()
    {
        gameObject.SetActive(true);
    }
}
