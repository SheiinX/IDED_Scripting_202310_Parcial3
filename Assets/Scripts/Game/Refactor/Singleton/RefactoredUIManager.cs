using UnityEngine;

public class RefactoredUIManager : UIManagerBase
{
    [SerializeField]
    private RefactoredPlayerController playerController;

    [SerializeField]
    private GameControllerBase gameController;

    private static RefactoredUIManager instance;

    private RefactoredUIManager()
    {

    }

    public static RefactoredUIManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new RefactoredUIManager();
                DontDestroyOnLoad(instance);
            }
            return instance;
        }
    }

    protected override PlayerControllerBase PlayerController => playerController;

    protected override GameControllerBase GameController => gameController;
}
