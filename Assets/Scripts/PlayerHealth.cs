using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int vidas = 3;
    public TMP_Text vidasText;
    public TMP_Text gameOverText;

    private void Start()
    {
        ActualizarUI();
        gameOverText.text = "";
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            PerderVida();
        }
    }

    void PerderVida()
    {
        vidas--;
        ActualizarUI();

        if (vidas <= 0)
        {
            GameOver();
        }
    }

    void ActualizarUI()
    {
        vidasText.text = "Vidas: " + vidas;
    }

    void GameOver()
    {
        gameOverText.text = "GAME OVER";
        Time.timeScale = 0;
    }
}
