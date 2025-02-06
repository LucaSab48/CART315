using UnityEngine;

public class BrickLayer : MonoBehaviour
{
    public GameObject brick;
    public int row, column;
    public float spacingH, spacingV;
    
    public int numBricks;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Lay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Lay()
    {
        for (int i = 0; i < column; i++)
        {
            for (int j = 0; j <= row; j++)
            {
                float xPos = -column + (i * spacingH);
                float yPos = row - (j * spacingV);
                
                GameObject go = Instantiate(brick, new Vector3(xPos, yPos, 0), transform.rotation, this.transform);

            }
        }
    }
}
