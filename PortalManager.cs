using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalManager : MonoBehaviour
{
    // References to both portals
    public PortalCheck redPortal;
    public PortalCheck bluePortal;

    // Reference to the Level Complete UI or message
    public GameObject levelCompleteMessage;

    // This method checks if both players are inside their respective portals
    public void CheckLevelCompletion()
    {
        // Check if both players are inside their respective portals
        if (redPortal.isPlayerInPortal && bluePortal.isPlayerInPortal)
        {
            CompleteLevel();
        }
    }

    // This method handles level completion when both players are in their portals
    private void CompleteLevel()
    {
        Debug.Log("Level 1 complete!");

        if (levelCompleteMessage != null)
        {
            levelCompleteMessage.SetActive(true);
        }
        else
        {
            Debug.LogError("Level Complete Message is not assigned in the Inspector!");
        }
    }
}
