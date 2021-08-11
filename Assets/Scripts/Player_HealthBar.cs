using UnityEngine;
using UnityEngine.UI;

public class Player_HealthBar : MonoBehaviour
{
    [SerializeField] private Player_Health playerHealth;
    [SerializeField] private Image totalHealthBar;
    [SerializeField] private Image currentHealthBar;

    private void Start()
    {
        totalHealthBar.fillAmount = playerHealth.currentHealth / 3;

    }

    private void Update()
    {
        currentHealthBar.fillAmount = playerHealth.currentHealth / 3;
    }
}
