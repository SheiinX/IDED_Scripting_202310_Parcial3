public class RefactoredUIManager : UIManagerBase
{
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


    protected override PlayerControllerBase PlayerController => throw new System.NotImplementedException();

    protected override GameControllerBase GameController => throw new System.NotImplementedException();
}
