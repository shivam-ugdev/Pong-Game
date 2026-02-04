using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    public GameManager gm;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("LeftBorder"))
        {
            gm.ComputerScore();
        }
        if (collision.gameObject.CompareTag("RightBorder"))
        {
            gm.PlayerScore();
        }
    }
}
