using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidObstaclePool : PoolBase
{
    [SerializeField]
    private GameObject lowObstaclePrefab;

    //private GameObject blueBulletGO;
    //private int i = 0;

    protected override void AddNewInstanceToPool()
    {
        //blueBulletGO = new GameObject($"BlueBullet ({i++})");
        OnObjectToRecycle(gameObject);
        GameObject newInstance = Instantiate(lowObstaclePrefab, transform.position, Quaternion.identity);

        RecycleInstance(newInstance);
    }
}
