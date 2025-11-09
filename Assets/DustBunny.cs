using UnityEngine;

public class DustBunny : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;
    private SpriteRenderer spriteRenderer;
    private bool isDying = false;

    private void Start()
    {
        currentHealth = maxHealth;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage(int amount)
    {
        if (isDying) return;

        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            StartCoroutine(FadeOutAndDestroy());
        }
    }

    private System.Collections.IEnumerator FadeOutAndDestroy()
    {
        isDying = true;
        float fadeDuration = 1.5f;
        float elapsed = 0f;
        Color originalColor = spriteRenderer.color;

        while (elapsed < fadeDuration)
        {
            float alpha = Mathf.Lerp(1f, 0f, elapsed / fadeDuration);
            spriteRenderer.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);
            elapsed += Time.deltaTime;
            yield return null;
        }

        Destroy(gameObject);
    }
}
