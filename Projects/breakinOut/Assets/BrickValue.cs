using UnityEngine;
using UnityEngine.Rendering.Universal;
using System.Collections;

public class BrickValue : MonoBehaviour
{
    public int pointValue = 1;
    public float fadeDuration = 3f; 
    private int hits = 0; 
    private SpriteRenderer spriteRenderer;
    private Color originalColor;
    
    private Light2D brickLight; 

    private bool isLit = false; 

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        brickLight = GetComponent<Light2D>(); 

        if (spriteRenderer != null)
        {
            originalColor = spriteRenderer.color;
        }

        if (brickLight != null)
        {
            brickLight.intensity = 0f; 
        }
    }

    public void TakeHit()
    {
        if (!isLit)
        {
            
            hits++;
            isLit = true;

            if (spriteRenderer != null)
            {
                spriteRenderer.color = Color.yellow;  
            }

            if (brickLight != null)
            {
                brickLight.intensity = 1f; 
            }
            
            StartCoroutine(FadeToOriginalColor());
        }
        else
        {
            hits++;
            if (hits >= 2)
            {
                gameManagement.S.AddPoint(pointValue);
                Destroy(gameObject);
            }
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
                spriteRenderer.color = Color.Lerp(Color.yellow, originalColor, t);
            }

            if (brickLight != null)
            {
                brickLight.intensity = Mathf.Lerp(1f, 0f, t);
            }

            yield return null;  
        }
        
        isLit = false;
    }
}