using UnityEngine;

public class PositionsProjectiles : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float positionXaléatoire = Random.Range(-15f, 8f);
        float positionYaléatoire = Random.Range(-8f, 8f);

        transform.position = new Vector2(positionXaléatoire, positionYaléatoire);
        Debug.Log(positionXaléatoire);
        Debug.Log(positionYaléatoire);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
