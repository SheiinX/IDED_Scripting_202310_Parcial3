using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/*public class lowObstaclePool : PoolBase, IPoolable
{
    
    void Start()
    {
        //PopulatePool();
    }

    
    void Update()
    {

    }



    public virtual void RecycleInstance(GameObject instance) 
    {

    }
    
    public  GameObject RetrieveInstance()
    {
        GameObject instance = null;

       if (instances.Count > 0)
        {
            instance = instances[0];
            instance.SetActive(true);
            instances.RemoveAt(0);
        }
        else
        {
            instance = Instantiate(basePrefab, transform.position, Quaternion.identity);
            instance.GetComponent<PoolableObject>().Pool = this;
        }

        return instance;
    }

    public void OnDestroy() { }

    public void New()
    {
        throw new System.NotImplementedException();
    }

    public void Free()
    {
        throw new System.NotImplementedException();
    }

    protected override void AddNewInstanceToPool()
    {
        throw new System.NotImplementedException();
    }
}*/