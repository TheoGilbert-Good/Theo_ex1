using UnityEngine;

public class ProjectileOrbite : MonoBehaviour

{

    public float vitesseRotation = 0.3f;
    public Transform FormeCible;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(FormeCible.position, Vector3.forward, vitesseRotation);
    }
}
