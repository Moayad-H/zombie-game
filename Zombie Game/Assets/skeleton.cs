using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.AI;



public class skeleton: MonoBehaviour

{
    Game_Manager game_controller;
    public Generate_enemy spawn;
    public Health thePlayer;
    public Game_Manager GameIsOver;
    public float invulTime = 2f;
    private bool invulnerable = false;
    private bool ColEnemy = false;
   // public ParticleSystem hit_effect;
    public float health = 20f;
    public float delay = 4f;

    private Transform player;
    private CapsuleCollider zombie;

    public void TakeDamage(float amount)
    {
        Debug.Log("Skeleton taking damage");
       // Instantiate(hit_effect, transform.position, Quaternion.identity);
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }
    public void Die()

    {

        zombie = GetComponent<CapsuleCollider>();
        zombie.enabled = !zombie.enabled;
        spawn.enemiesKiled++;

        if (spawn.enemiesKiled >= spawn.enemyCount)
        {
            spawn.enemiesKiled = 0;
            //spawn.enemySpawnAmount+=5;
           spawn.NextWave();
        }

        gameObject.GetComponent<Animator>().Play("die");

        //Destroy(gameObject);
    }
    private NavMeshAgent agent;

    //public bool can_move = true;

    public float enemyDistance = 0.7f;



    private void Start()

    {
        game_controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<Game_Manager>();
        spawn = game_controller.GetComponentInChildren<Generate_enemy>();
        player = GameObject.FindWithTag("Player").transform;

        agent = GetComponent<NavMeshAgent>();

    }


    public void OnTriggerEnter(Collider Player)

    {
        if (Player.CompareTag("Player") && health > 0f && GameIsOver == false)
        {

            if (!invulnerable && GameObject.Find("Player").GetComponent<Health>().player_is_dead == false)
            {
                GameObject.Find("Player").GetComponent<Health>().PlayerHealth -= 10.0f;
                Debug.Log("damage to player");
                StartCoroutine(JustHurt());
            }
            gameObject.GetComponent<NavMeshAgent>().velocity = Vector3.zero;
            gameObject.GetComponent<Animator>().Play("attack");
            ColEnemy = true;

        }
    }
    private void OnTriggerStay(Collider Player)
    {
        if (Player.CompareTag("Player") && GameIsOver == false)
        {
            gameObject.GetComponent<NavMeshAgent>().velocity = Vector3.zero;
            ColEnemy = true;
        }
    }
    private void OnTriggerExit(Collider Player)
    {
        if (Player.CompareTag("Player") && GameIsOver == false)
            ColEnemy = false;
        Debug.Log("Collision =false");
    }
    IEnumerator JustHurt()
    {
        invulnerable = true;
        ColEnemy = true;
        yield return new WaitForSeconds(invulTime);
        invulnerable = false;
    }
    void Update()

    {
        if (GameIsOver != true)
        {
            if (ColEnemy == false && GameObject.Find("Player").GetComponent<Health>().player_is_dead == false)
            {
                transform.LookAt(player);
                agent.SetDestination(player.transform.position);

            }


            if (health <= 0f)
            {

                gameObject.GetComponent<NavMeshAgent>().velocity = Vector3.zero;
            }
        }
    }
}







