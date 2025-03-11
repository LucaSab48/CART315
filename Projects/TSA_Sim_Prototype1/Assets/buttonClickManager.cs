using UnityEngine;

public class buttonClickManager : MonoBehaviour
{
    private Vector3 _ogScale;

    private void Awake()
    {
        _ogScale = transform.localScale;
    }

    public void OnClick()
    {
        Debug.Log($"{gameObject.name} clicked!");
        transform.localScale = _ogScale * 0.8f;
        Invoke(nameof(ResetScale), 0.2f);
    }
    
    private void ResetScale()
    {
        transform.localScale = _ogScale;
    }
    
}
