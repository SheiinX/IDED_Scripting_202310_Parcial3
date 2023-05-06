using UnityEngine;

public class RefactoredPlayerController : PlayerControllerBase
{
    [SerializeField]
    private RefactoredUIManager uiManager;



    protected Rigidbody selectedBullet;

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

    private void Update()
    {
        //OnScoreChangedEvent(Score);
    }


    protected override bool NoSelectedBullet => selectedBullet == null;

    private void OnScoreChangedEvent(int scoreAdd)
    {
        base.UpdateScore(scoreAdd);
    }

    private void OnBulletSelected(int index)
    {

    }

    protected override void Shoot()
    {
        //base.Shoot();
    }

    protected override void SelectBullet(int index)
    {
        //base.SelectBullet(index);
    }
}
