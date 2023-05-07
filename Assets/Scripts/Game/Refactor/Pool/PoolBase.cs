using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/*public abstract class PoolBase<T> : MonoBehaviour
    where T : IPool*/
public abstract class PoolBase : PoolableObject
{
    [SerializeField]
    private int count = 0;

    [SerializeField]
    private GameObject basePrefab;

    private List<GameObject> instances = new List<GameObject>();
    private List<Rigidbody> instanceBullet = new List<Rigidbody>();

    public void RecycleInstance(GameObject instance)
    {
        instance.gameObject.SetActive(false);
        instances.Add(instance);
    }

    public void RecycleInstance(Rigidbody instance)
    {
        instance.gameObject.SetActive(false);
        instanceBullet.Add(instance);
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

    public Rigidbody RetrieveInstanceBullet()
    {
        if (basePrefab == null)
        {
            return default;
        }

        if (instances.Count < 1)
        {
            AddNewInstanceToPool();
        }

        Rigidbody targetRetrieve = instanceBullet[0];
        instanceBullet.Remove(targetRetrieve);
        transform.parent = null;
        gameObject.SetActive(true);
        return targetRetrieve;
    }
    private void PopulatePool()
    {
        for (int i = 0; i < count; i++)
        {
            instances.Add(Instantiate(basePrefab, transform.position, Quaternion.identity));
        }
    }

    protected abstract void AddNewInstanceToPool();
}