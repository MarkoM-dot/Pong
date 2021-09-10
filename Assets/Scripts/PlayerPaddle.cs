using UnityEngine;

public class PlayerPaddle : Paddle
{
    [SerializeField] PlayerDatabase playerDatabase;

    [SerializeField] SpriteRenderer paddleArt;

    private Touch touch;
    private float speedModifier = 0.01f;

    int selectedOption = 0;
    void Start()
    {
        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }
        UpdatePlayer(selectedOption);
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + touch.deltaPosition.y * speedModifier);
            }
        }

        CheckForbiddenZone();
    }
    // This script will contain features specific to the Player
    // Make the Kinematic object move in the fixed update
    void UpdatePlayer(int selectedOption)
    {
        Player player = playerDatabase.GetPlayer(selectedOption);
        paddleArt.sprite = player.paddleSprite;
    }
    void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }
}
