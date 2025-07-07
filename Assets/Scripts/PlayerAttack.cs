using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAttack : MonoBehaviour
{
    GameObject attackArea = default;

    bool attacking = false;

    float timeToAttack = 0.25f;
    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        attackArea = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }

        if (attacking)
        {
            timer += Time.deltaTime;

            if (timer >= timeToAttack)
            {
                timer = 0f;
                attacking = false;
                attackArea.SetActive(attacking);
            }
        }
    }
    void Attack()
    {
        attacking = true;
        attackArea.SetActive(attacking);
    }
}
