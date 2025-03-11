using UnityEngine;

public class XRayItem : MonoBehaviour
{
    private Color _originalColor;
    private SpriteRenderer _spriteRenderer;
    private bool _isMarked = false;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _originalColor = _spriteRenderer.color;
    }

    private void OnMouseEnter()
    {
        _spriteRenderer.color = _isMarked ? Color.red : Color.white; // Highlight effect
    }

    private void OnMouseExit()
    {
        _spriteRenderer.color = _isMarked ? Color.red : _originalColor; // Reset color when mouse leaves
    }

    private void OnMouseDown()
    {
        _isMarked = !_isMarked; // Toggle state
        _spriteRenderer.color = _isMarked ? Color.red : _originalColor; // Change color accordingly
        Debug.Log($"{gameObject.name} is now {(_isMarked ? "marked as suspicious" : "cleared")}!");
    }
}