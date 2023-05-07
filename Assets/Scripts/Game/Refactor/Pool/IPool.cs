using UnityEngine;

public interface IPool
{
    public void PrepareRetrieve();

    public void OnObjectToRecycle(GameObject instance);
}