
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager game;

    private void OnTriggerEnter(Collider other)
    {
        game.CompleteLevel();
    }
}
