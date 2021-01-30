using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject arrowHead;
    public bool destroyed;
    [SerializeField]
    private Transform[] trapPositions;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(instance);
        destroyed = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (destroyed == true)
        {
            SpawnTrap();
            Debug.Log("ShootTrap");
        }
           
    }


    public void SpawnTrap()
    {
        destroyed = false;
        foreach (Transform trap in trapPositions)
        {
            Instantiate(arrowHead, trap.position, trap.rotation);
        }
    }
}
