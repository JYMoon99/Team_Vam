using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 50000;
    [SerializeField] int Damage;

    MeshRenderer mesh;

    void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        
    }


    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Enemy enemy = other.GetComponent<Enemy>();

            health -= enemy.damage;

            StartCoroutine(OnDamage());
        }
    }

    IEnumerator OnDamage()
    {
        mesh.material.color = Color.red;
        
        yield return new WaitForSeconds(0.3f);

        mesh.material.color = Color.white;

        yield return new WaitForSeconds(0.3f);
    }



}
