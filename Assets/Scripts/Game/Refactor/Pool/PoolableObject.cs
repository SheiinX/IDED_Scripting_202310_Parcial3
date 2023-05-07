using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class PoolableObject : PoolBase
{
    public static PoolableObject Instance { get; private set; }

    public IPool RetrieveObject(System.Type type)
    {
        IPool result = null;

        if (type.Equals(typeof(PoolableObject)))
        {
            result = RetrieveCubeInstance();
        }
        else if (type.Equals(typeof(SimpleVFX)))
        {
            result = RetrieveVFXInstance();
        }

        return result;
    }

    public void RecycleObject(IPool obj)
    {
        if (obj is PoolableObject)
        {
            RecycleCube(obj as PoolableObject);
        }
        else if (obj is SimpleVFX)
        {
            RecycleVFX(obj as SimpleVFX);
        }
    }

    private PoolableGameObject RetrieveCubeInstance()
    {
        PoolableGameObject currentCube = CubePool.Instance.Retrieve();
        currentCube.transform.position = Vector3.zero;
        currentCube.transform.rotation = Quaternion.identity;

        return currentCube;
    }

    private void RecycleCube(PoolableGameObject target)
    {
        CubePool.Instance.Recycle(target);
    }

    private SimpleVFX RetrieveVFXInstance()
    {
        SimpleVFX currentVFX = VFXPool.Instance.Retrieve();
        currentVFX.transform.position = Vector3.zero;
        currentVFX.transform.rotation = Quaternion.identity;

        return currentVFX;
    }

    private void RecycleVFX(SimpleVFX vfx)
    {
        VFXPool.Instance.Recycle(vfx);
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    public void OnObjectToRecycle(GameObject instance)
    {

    }

    public void RecycleObject()
    {
        transform.parent = null;
        gameObject.SetActive(true);
    }   
}*/
