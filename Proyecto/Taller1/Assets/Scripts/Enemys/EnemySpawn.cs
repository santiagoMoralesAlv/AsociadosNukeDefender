using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemies;
    [SerializeField]
    private float maximunSpawnTime;
    [SerializeField]
    private float minimunSpawnTime;

    private float spawnTime;
    [SerializeField]
    private float time;
    [SerializeField]
    private int numEnemiesInField;
    


    void Start()
    {
        ResetSpawnTime();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= spawnTime && numEnemiesInField<6)
        {
            Spawn();
        }
        
    }

    

    public void Spawn()
    {
        int numRandom = Random.Range(0, enemies.Length);
        GameObject t_enemy = Instantiate(enemies[numRandom], this.gameObject.transform.position, Quaternion.identity);
        //t_enemy.GetComponent<Enemy>().e_Death += CoreGame.Instance.UpdateEnemiesKilled;
        t_enemy.GetComponent<Enemy>().e_Death += UpdateListEnemys;
        numEnemiesInField += 1;
        ResetSpawnTime();
        time = 0;
    }

    public void UpdateListEnemys() {
        numEnemiesInField -= 1;
    }

    private void ResetSpawnTime()
    {
        spawnTime = Random.Range(minimunSpawnTime, maximunSpawnTime);
    }
   

}
