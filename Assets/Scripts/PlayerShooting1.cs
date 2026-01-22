using UnityEngine;

public class PlayerShooting1 : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootingInterval = 0.2f;

    private float lastBulletTime;

    void Update()
    {
        
        {
            if (Time.time - lastBulletTime > shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }

    void ShootBullet()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
}
