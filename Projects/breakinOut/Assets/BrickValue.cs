using UnityEngine;
using UnityEngine.Rendering.Universal;  // Import for Light2D
using System.Collections;

public class BrickValue : MonoBehaviour
{
    public int pointValue = 1;
    public float fadeDuration = 3f;  // Time for the light to fade
    private int hits = 0;  // Track how many hits the brick has taken
    private SpriteRenderer spriteRenderer;
    private Color originalColor;

    // For emitting light
    private Light2D brickLight;  // 2D Light for glowing effect

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        brickLight = GetComponent<Light2D>();  // Try to get the Light2D component if it exists

        if (spriteRenderer != null)
        {
            originalColor = spriteRenderer.color;
        }

        if (brickLight != null)
        {
            brickLight.intensity = 0f;  // Initially, no light
        }
    }

    public void TakeHit()
    {
        hits++;

        if (hits == 1)
        {
            // Light up the brick with color and light effect
            if (spriteRenderer != null)
            {
                spriteRenderer.color = Color.yellow;  // Change to lit color
            }

            // Turn on the light
            if (brickLight != null)
            {
                brickLight.intensity = 1f;  // Full light intensity when lit
            }

            // Start fading back to the original color and light intensity
            StartCoroutine(FadeToOriginalColor());
        }
        else if (hits == 2)
        {
            // Break the brick on the second hit if it's still lit
            gameManagement.S.AddPoint(pointValue);
            Destroy(gameObject);
        }
    }

    private IEnumerator FadeToOriginalColor()
    {
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / fadeDuration;

            if (spriteRenderer != null)
            {
                // Interpolate from yellow back to the original color
                spriteRenderer.color = Color.Lerp(Color.yellow, originalColor, t);
            }

            if (brickLight != null)
            {
                // Fade the light intensity back to 0
                brickLight.intensity = Mathf.Lerp(1f, 0f, t);
            }

            yield return null;  // Continue the loop over multiple frames
        }

        // After fading back, allow it to be lit again when hit
        // No need to reset the hits flag, just wait for a new hit to light up again.
    }
}
