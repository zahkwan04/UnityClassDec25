using UnityEngine;
using UnityEditor.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] vehicle;
    public Transform spawnPoint;
    public int vehicleNum = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject.Instantiate(vehicle[0], spawnPoint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetVehicleNum(int vehicleNumIn)
    {
        vehicleNum = vehicleNumIn;
    }

    public void Spawn(int numtoSpawn)
    {
        GameObject.Instantiate(vehicle[vehicleNum], spawnPoint);
    }
}
