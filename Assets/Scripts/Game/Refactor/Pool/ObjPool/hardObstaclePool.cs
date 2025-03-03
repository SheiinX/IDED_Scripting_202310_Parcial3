using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HardObstaclePool : PoolBase
{
    [SerializeField]
    private GameObject hardObstaclePrefab;

    //private GameObject blueBulletGO;
    //private int i = 0;

    protected override void AddNewInstanceToPool()
    {
        //blueBulletGO = new GameObject($"BlueBullet ({i++})");
        OnObjectToRecycle(gameObject);
        GameObject newInstance = Instantiate(hardObstaclePrefab, transform.position, Quaternion.identity);

        RecycleInstance(newInstance);
    }
}