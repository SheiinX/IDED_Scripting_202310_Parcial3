using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BlueBullet : PoolBase
{
    [SerializeField]
    private Rigidbody blueBulletPrefab;

    //private GameObject blueBulletGO;
    //private int i = 0;

    protected override void AddNewInstanceToPool()
    {
        //blueBulletGO = new GameObject($"BlueBullet ({i++})");
        OnObjectToRecycle(gameObject);
        Rigidbody newInstance = Instantiate(blueBulletPrefab, transform.position, Quaternion.identity);

        RecycleInstance(newInstance);
    }
}