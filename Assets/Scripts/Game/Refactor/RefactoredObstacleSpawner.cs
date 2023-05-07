using UnityEngine;

public class RefactoredObstacleSpawner : ObstacleSpawnerBase
{
    [SerializeField]
    private GameObject[] obstaclePrefabs;

    protected GameObject[] ObstaclePrefabs { get => obstaclePrefabs; }

    private static RefactoredObstacleSpawner instance;

    private RefactoredObstacleSpawner()
    {

    }

    public static RefactoredObstacleSpawner Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new RefactoredObstacleSpawner();
                DontDestroyOnLoad(instance);
            }
            return instance;
        }
    }

    protected int ObjectIndex
    {
        get
        {
            int result = 0;

            if (obstaclePrefabs.Length > 1)
            {
                result = Random.Range(result, obstaclePrefabs.Length);
            }

            return result;
        }
    }
    /*
    [SerializeField]
    private PoolBase obstacleLowPool;

    [SerializeField]
    private PoolBase obstacleMidPool;

    [SerializeField]
    private PoolBase obstacleHardPool;
    */
    protected override void SpawnObject()
    {
        throw new System.NotImplementedException();
    }
}
