using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/*public abstract class PoolBase<T> : MonoBehaviour
    where T : IPool*/
public abstract class PoolBase : PoolableObject
{
    private static PoolBase instance;

    [SerializeField]
    private int count = 0;

    [SerializeField]
    private GameObject basePrefab;

    private List<GameObject> instances = new List<GameObject>();
    private List<Rigidbody> instanceBulletBlue = new List<Rigidbody>();
    private List<Rigidbody> instanceBulletRed = new List<Rigidbody>();
    private List<Rigidbody> instanceBulletGreen = new List<Rigidbody>();

    public static PoolBase Instance { get => instance; private set => instance = value; }

    public void RecycleInstance(GameObject instance)
    {
        instance.gameObject.SetActive(false);
        instances.Add(instance);
    }

    public void RecycleInstance(Rigidbody instance, string bulletType)
    {
        if(bulletType == "BLUE")
        {
            instance.gameObject.SetActive(false);
            instanceBulletBlue.Add(instance);
        }
        else if(bulletType == "GREEN")
        {
            instance.gameObject.SetActive(false);
            instanceBulletGreen.Add(instance);
        }
        else if(bulletType == "RED")
        {
            instance.gameObject.SetActive(false);
            instanceBulletRed.Add(instance);
        }
    }

    public GameObject RetrieveInstanceObstacle()
    {
        if (basePrefab == null)
        {
            return default;
        }

        if (instances.Count < 1)
        {
            AddNewInstanceToPool();
            count++;
        }

        GameObject targetRetrieve = instances[0];
        instances.Remove(targetRetrieve);
        transform.parent = null;
        gameObject.SetActive(true);
        return targetRetrieve;
    }

    public Rigidbody RetrieveInstanceBullet(string bulletType)
    {
        if (basePrefab == null)
        {
            return default;
        }

        if (instances.Count < 1)
        {
            AddNewInstanceToPool();
        }

        if(bulletType == "BLUE")
        {
            Rigidbody targetRetrieve = instanceBulletBlue[0];
            instanceBulletBlue.Remove(targetRetrieve);
            transform.parent = null;
            gameObject.SetActive(true);
            return targetRetrieve;
        }
        else if (bulletType == "GREEN")
        {
            Rigidbody targetRetrieve = instanceBulletGreen[0];
            instanceBulletGreen.Remove(targetRetrieve);
            transform.parent = null;
            gameObject.SetActive(true);
            return targetRetrieve;
        }
        else if (bulletType == "RED")
        {
            Rigidbody targetRetrieve = instanceBulletRed[0];
            instanceBulletRed.Remove(targetRetrieve);
            transform.parent = null;
            gameObject.SetActive(true);
            return targetRetrieve;
        }
        else
        {
            return default;
        }
    }

    protected void Start()
    {
        PopulatePool();
    }

    private void PopulatePool()
    {
        for (int i = 0; i < count; i++)
        {/*
            instances.Add(Instantiate(basePrefab, transform.position, Quaternion.identity));
            instanceBulletBlue.Add(Instantiate(basePrefab, transform.position, Quaternion.identity));
            instanceBulletRed.Add(Instantiate(basePrefab, transform.position, Quaternion.identity));
            instanceBulletGreen.Add(Instantiate(basePrefab, transform.position, Quaternion.identity));*/
        }
    }

    protected abstract void AddNewInstanceToPool();
}