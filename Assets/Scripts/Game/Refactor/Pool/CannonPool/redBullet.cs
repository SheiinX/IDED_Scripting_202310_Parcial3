using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RedBullet : PoolBase
{
    [SerializeField]
    private Rigidbody redBulletPrefab;

    private string red = "RED";

    //private GameObject blueBulletGO;
    //private int i = 0;

    protected override void AddNewInstanceToPool()
    {
        //blueBulletGO = new GameObject($"BlueBullet ({i++})");
        OnObjectToRecycle(gameObject);
        Rigidbody newInstance = Instantiate(redBulletPrefab, transform.position, Quaternion.identity);

        RecycleInstance(newInstance, red);
    }
}