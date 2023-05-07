using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class hardObstaclePool : PoolBase, IPoolable
{
    public void Free()
    {
        throw new System.NotImplementedException();
    }

    public void New()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void RecycleInstance(GameObject instance)
    {

    }

    protected override void AddNewInstanceToPool()
    {
        throw new System.NotImplementedException();
    }
}