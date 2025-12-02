using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject targetPrefab;
    public Vector3 spawnPosition;
    
   public void SpawnTarget()
    {
        GameObject clone = Instantiate(targetPrefab, spawnPosition, Quaternion.identity);
        Destroy(clone, 5f);
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
