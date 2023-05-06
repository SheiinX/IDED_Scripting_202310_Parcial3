using UnityEngine;

public class RefactoredUIManager : UIManagerBase
{
    [SerializeField]
    private PlayerController playerController;

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
            }
            return instance;
        }
    }


    protected override PlayerControllerBase PlayerController => playerController;

    protected override GameControllerBase GameController => gameController;
}
