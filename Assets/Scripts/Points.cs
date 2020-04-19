
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Text bonusPoints;
    void Update()
    {
        bonusPoints.text = FindObjectOfType<GameManager>().points.ToString();
    }
}
