using System.Collections;
using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public GameManager gameManager;
    
    [SerializeField] int countdownTime = 5;
    [SerializeField] TextMeshProUGUI countdownDisplay;

    void Start()
    {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {

        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        countdownDisplay.text = "PONG!";

        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);
        gameManager.RoundReset();
    }
}
