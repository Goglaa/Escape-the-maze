using UnityEngine;

public class MazeGenerator : MonoBehaviour
{
    public Texture2D mazeTexture;  // Assign your PNG here
    public GameObject wallPrefab;  // Assign a wall prefab
    public float wallHeight = 2f;  // Adjust as needed
    public GameObject groundPrefab;

    public static Vector3 groundPosition;

    void Start()
    {
        GenerateMaze();
        AdjustGround();
    }

    void GenerateMaze()
    {
        for (int x = 0; x < mazeTexture.width; x++)
        {
            for (int y = 0; y < mazeTexture.height; y++)       
            {
                Color pixelColor = mazeTexture.GetPixel(x, y);

                // Assuming black is for walls
                if (pixelColor == Color.black)
                {
                    Vector3 wallPosition = new Vector3(x, 5, y);
                    Instantiate(wallPrefab, wallPosition, Quaternion.identity, transform);
                }
            }
        }
    }
    void AdjustGround()
    {
        if (groundPrefab != null)
        {
            GameObject ground = Instantiate(groundPrefab, new Vector3(mazeTexture.width / 2f, 0, mazeTexture.height / 2f), Quaternion.identity);

            ground.transform.localScale = new Vector3(mazeTexture.width, 1, mazeTexture.height);
            
            groundPosition = ground.transform.localPosition;
        }
    }
}
