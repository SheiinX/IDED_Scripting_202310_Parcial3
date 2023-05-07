using UnityEngine;

public sealed class RefactoredGameController : GameControllerBase
{
    [SerializeField]
    private RefactoredUIManager uiManager;

    [SerializeField]
    private RefactoredPlayerController playerController;

    [SerializeField]
    private RefactoredObstacleSpawner obstacleSpawner;

    private static RefactoredGameController instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private RefactoredGameController()
    {

    }
    public static RefactoredGameController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new RefactoredGameController();
                DontDestroyOnLoad(instance);
            }
            return instance;
        }
    }

    protected override PlayerControllerBase PlayerController => playerController;

    protected override UIManagerBase UiManager => uiManager;

    protected override ObstacleSpawnerBase Spawner => obstacleSpawner;

    protected override void OnScoreChanged(int scoreAdd)
    {
        PlayerController?.SendMessage("UpdateScore", scoreAdd);
        UiManager?.SendMessage("UpdateScoreLabel");
        /*
        OnObstacleDestroyed(scoreAdd);
        UiManager?.SendMessage("UpdateScoreLabel");*/
    }

    protected override void SetGameOver()
    {
        UiManager?.SendMessage("OnGameOver");
        PlayerController?.SendMessage("OnGameOver");
        Spawner?.SendMessage("OnGameOver");
        base.SetGameOver();
    }
}
