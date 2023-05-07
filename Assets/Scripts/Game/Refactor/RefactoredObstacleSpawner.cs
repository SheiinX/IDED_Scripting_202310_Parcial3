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

    protected override void SpawnObject()
    {
        Instantiate(ObstaclePrefabs[ObjectIndex], new Vector2(Random.Range(MinX, MaxX), YPos), Quaternion.identity);
    }
}
