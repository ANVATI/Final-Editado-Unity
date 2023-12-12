using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantZone : MonoBehaviour
{
    BoxCollider2D _compBoxCollider2D;
    public GameManagerControl gameManager;
    // Start is called before the first frame update
    void Start()
    {
        _compBoxCollider2D = GetComponent<BoxCollider2D>();
    }
    void Awake()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        print("Hello my friend");
        GameObject newplant = Instantiate(gameManager.currentPlant, transform.position, transform.rotation);
        newplant.GetComponent<Planta>().enabled = false;
        Destroy(gameManager.currentPlant);
        gameManager.currentPlant = null;
    }
}
