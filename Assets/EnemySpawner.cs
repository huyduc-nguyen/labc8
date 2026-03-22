using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyVariants; // Kéo các loại Variant vào đây
    public float spawnTime = 2f; // Cứ 2 giây sinh 1 lần

    void Start()
    {
        // Gọi hàm SpawnEnemy liên tục sau mỗi spawnTime
        InvokeRepeating("SpawnEnemy", 1f, spawnTime);
    }

    void SpawnEnemy()
    {
        // Chọn ngẫu nhiên 1 loại quái trong mảng
        int randomIndex = Random.Range(0, enemyVariants.Length);

        // Sinh quái tại vị trí của Spawner
        Instantiate(enemyVariants[randomIndex], transform.position, Quaternion.identity);
    }
}