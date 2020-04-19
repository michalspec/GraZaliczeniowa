using UnityEngine;

public class BonusPonit : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            FindObjectOfType<GameManager>().points++;
            Destroy(gameObject);
        }
    }
    
}
