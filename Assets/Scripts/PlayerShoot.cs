using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;
    public TMP_Text bulletText;
    public float fireDelay = 0.25f;
    public float bullets = 0;
    float cooldownTimer = 0;
    public float timer = 10f;
    public AudioSource pew;
    float timer1;
    void Start()
    {
        timer1 = timer;
    }
    void Update()
    {
        if (bullets > 0)
        {
            cooldownTimer -= Time.deltaTime;
            if(Input.GetButton("Fire1")&&cooldownTimer <= 0)
            {
                cooldownTimer = fireDelay;
                Vector3 bulletOffset = transform.rotation * new Vector3(0, 0.5f, 0);
                Instantiate(bullet,transform.position + bulletOffset,transform.rotation);
                bullets--;
                pew.Play();
            }
            
        }
        timer1 -= Time.deltaTime;
        if (timer1 <= 0)
        {
            bullets++;
            timer1 = timer; 
        }
        bulletText.text = "Bullets : "+bullets.ToString();
    }
}
