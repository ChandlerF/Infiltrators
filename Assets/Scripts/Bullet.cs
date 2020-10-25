using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;
    public float BulletsDamage;

    void Start()
    {
        Speed *= 10;
        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(Speed, 0) * Time.deltaTime, Space.Self);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<Demon>().Damage(BulletsDamage);
        Destroy(gameObject);
    }
}
