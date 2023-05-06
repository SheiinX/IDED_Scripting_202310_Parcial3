public class RefactoredPlayerController : PlayerControllerBase
{
    private static RefactoredPlayerController instance;

     private RefactoredPlayerController()
    {
        
    }

    public static RefactoredPlayerController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new RefactoredPlayerController();
            }
            return instance;
        }
    }

 
    protected override bool NoSelectedBullet => throw new System.NotImplementedException();

    protected override void Shoot()
    {
        //base.Shoot();
    }

    protected override void SelectBullet(int index)
    {
        //base.SelectBullet(index);
    }
}
