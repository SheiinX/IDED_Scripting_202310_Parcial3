using UnityEngine;

public class RefactoredPlayerController : PlayerControllerBase
{
    [SerializeField]
    private RefactoredUIManager uiManager;

    protected Rigidbody selectedBullet;

    private static RefactoredPlayerController instance;

    protected override bool NoSelectedBullet => selectedBullet == null;

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
                DontDestroyOnLoad(instance);
            }
            return instance;
        }
    }

    private void OnScoreChangedEvent(int scoreAdd)
    {
        base.UpdateScore(scoreAdd);
    }

    private void OnBulletSelected(int index)
    {

    }

    protected override void Shoot()
    {

        if (NoSelectedBullet)
        {
            return;
        }
        Instantiate(selectedBullet, spawnPos.position, spawnPos.rotation).AddForce(transform.forward * shootForce, ForceMode.Force);
    }

    protected override void SelectBullet(int index)
    {
        selectedBullet = bulletPrefabs[GameUtils.GetClampedValue(index, bulletPrefabs.Length)];
        uiManager.SendMessage("EnableIcon", index);
    }
}
