using UnityEngine;

public class RefactoredObstacleSpawner : ObstacleSpawnerBase
{
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
            }
            return instance;
        }
    }

    [SerializeField]
    private PoolBase obstacleLowPool;

    [SerializeField]
    private PoolBase obstacleMidPool;

    [SerializeField]
    private PoolBase obstacleHardPool;

    protected override void SpawnObject()
    {
        throw new System.NotImplementedException();
    }
}
