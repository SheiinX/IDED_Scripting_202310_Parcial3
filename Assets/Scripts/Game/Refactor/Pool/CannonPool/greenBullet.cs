using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GreenBullet : PoolBase
{
    [SerializeField]
    private Rigidbody greenBulletPrefab;

    //private GameObject blueBulletGO;
    //private int i = 0;

    protected override void AddNewInstanceToPool()
    {
        //blueBulletGO = new GameObject($"BlueBullet ({i++})");
        OnObjectToRecycle(gameObject);
        Rigidbody newInstance = Instantiate(greenBulletPrefab, transform.position, Quaternion.identity);

        RecycleInstance(newInstance);
    }
}