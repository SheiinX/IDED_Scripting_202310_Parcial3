public sealed class RefactoredGameController : GameControllerBase
{
    private static RefactoredGameController instance;

    public static RefactoredGameController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new RefactoredGameController();
            }
            return instance;
        }
    }

    private RefactoredGameController()
    {
        
    }

    protected override PlayerControllerBase PlayerController => throw new System.NotImplementedException();

    protected override UIManagerBase UiManager => throw new System.NotImplementedException();

    protected override ObstacleSpawnerBase Spawner => throw new System.NotImplementedException();

    protected override void OnObstacleDestroyed(int hp)
    {
        
        throw new System.NotImplementedException();
    }

    public void OnGameOver()
    {
        SetGameOver();
    }
}
