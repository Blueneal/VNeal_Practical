using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform barrel;
    public GameObject projectile;
    public float timer;
    public float cooldown = 0.5f;

    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space))
        {
            Fire();
        }
    }

    public void Fire()
    {
        if (timer > cooldown)
        {
            timer = 0;
            Instantiate(projectile, barrel.position, projectile.transform.rotation);
        }
    }
}
