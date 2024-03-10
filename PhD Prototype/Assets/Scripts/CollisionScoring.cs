using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionScoring : MonoBehaviour
{
    public GameObject sceneObjective;   // Set an in-game object as a scene objective

    public float objectiveScore = 100.0f;   // Set points awarded for collision with objective, 100 by default (changed in-client)

    // On start of script, multiply objective score by the difficulty multiplier
    private void Start()
    {
        objectiveScore = (objectiveScore * DifficultySetting.playerScoringSelection);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // If a scene objective has been set, award points when collision with target
        if (collision.gameObject == sceneObjective && sceneObjective != null)
        {
            print("Collided with objective! Adding points to score: +" + objectiveScore);
            ScoreBoard.playerScore += objectiveScore;
            sceneObjective = null;
        }
    }
}
