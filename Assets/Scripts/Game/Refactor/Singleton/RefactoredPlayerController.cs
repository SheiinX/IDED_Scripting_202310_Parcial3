using System.Collections;
using UnityEngine;

public class RefactoredPlayerController : PlayerControllerBase
{/*
    [SerializeField]
    private float timeBeforeDestroy = 5f;*/

    [SerializeField]
    private RefactoredUIManager uiManager;

    protected Rigidbody selectedBullet;

    private static RefactoredPlayerController instance;

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
        //Instantiate(selectedBullet, spawnPos.position, spawnPos.rotation).AddForce(transform.forward * shootForce, ForceMode.Force);
        if (selectedBullet == bulletPrefabs[GameUtils.GetClampedValue(0, bulletPrefabs.Length)])
        {
            Rigidbody retrieveBullet = RedBullet.Instance.RetrieveInstanceBullet("RED");
            retrieveBullet.transform.position = spawnPos.position;
            retrieveBullet.transform.rotation = spawnPos.rotation;
            //StartCoroutine(RecycleBullet(retrieveBullet));
        }
        else if (selectedBullet == bulletPrefabs[GameUtils.GetClampedValue(1, bulletPrefabs.Length)])
        {
            Rigidbody retrieveBullet = GreenBullet.Instance.RetrieveInstanceBullet("GREEN");
            retrieveBullet.transform.position = spawnPos.position;
            retrieveBullet.transform.rotation = spawnPos.rotation;
            //StartCoroutine(RecycleBullet(retrieveBullet));
        }
        else if (selectedBullet == bulletPrefabs[GameUtils.GetClampedValue(2, bulletPrefabs.Length)])
        {
            Rigidbody retrieveBullet = BlueBullet.Instance.RetrieveInstanceBullet("BLUE");
            retrieveBullet.transform.position = spawnPos.position;
            retrieveBullet.transform.rotation = spawnPos.rotation;
            //StartCoroutine(RecycleBullet(retrieveBullet));
        }
    }

    protected override void SelectBullet(int index)
    {
        selectedBullet = bulletPrefabs[GameUtils.GetClampedValue(index, bulletPrefabs.Length)];
        uiManager.SendMessage("EnableIcon", index);
    }
    /*
    private IEnumerator RecycleBullet(Rigidbody bullet)
    {
        yield return new WaitForSeconds(timeBeforeDestroy);
        PoolBase.Instance.RecycleInstance(bullet, "BLUE");
    }*/
}
