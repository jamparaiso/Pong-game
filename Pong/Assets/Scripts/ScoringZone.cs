using UnityEngine;
using UnityEngine.EventSystems;

public class ScoringZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            //gives the script more flexibility using events system
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(eventData);
        }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (this.ball.velocity.x > 0.0f)
    //    {
    //        //enemy score
    //        this.gameManager.ComputerScores();
    //    }
    //    else
    //    {
    //        //player score
    //        this.gameManager.PlayerScores();
    //    }
    //}
}
