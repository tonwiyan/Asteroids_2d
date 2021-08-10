
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public Asteroid asteroidPrefab;
    public float spawnRate = 2.0f; 
    public int spawnAmount = 1;
    public float spawnDistance = 15.0f;
    public float trajectoryVariances = 15.0f;
   

   private void Start(){
       InvokeRepeating(nameof(Spawn),this.spawnRate,this.spawnRate);
   }
   private void Spawn(){
       for (int i = 0; i< this.spawnAmount; i++){
           Vector3 spawnDiraction = Random.insideUnitCircle.normalized*this.spawnDistance;

           Vector3 spawnPoint = this.transform.position + spawnDiraction;
           float variance = Random.Range(-this.trajectoryVariances, this.trajectoryVariances);

           Quaternion rotation = Quaternion.AngleAxis(variance, Vector3.forward);

           Asteroid asteroid = Instantiate(this.asteroidPrefab, spawnPoint,rotation);

           asteroid.size = Random.Range(asteroid.minSize, asteroid.maxSize);
           asteroid.SetTrajectory(rotation * -spawnDiraction); 
       }
   }
}
