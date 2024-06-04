using UnityEngine;

public class GameUISystem : MonoBehaviour
{
    [SerializeField] Transform _playerLives;


    // Called when the gameObject is Enabled
    private void OnEnable()
    {
        // Add itself to the subject's list of observers
        PlayerController.OnHealthGain += AddHealth;
        PlayerController.OnHealthLost += SubtractHealth;
    }

    // Called when the gameObject is Disabled
    private void OnDisable()
    {
        // Remove itself to the subject's list of observers
        PlayerController.OnHealthGain -= AddHealth;
        PlayerController.OnHealthLost -= SubtractHealth;
    }

    private void AddHealth()
    {
        UpdateHealth(_playerLives, 1);
        Debug.Log("Adding Health");
    }

    private void SubtractHealth()
    {
        UpdateHealth(_playerLives, -1);
        Debug.Log("Subtracting Health");
    }

    // Function to get the last child of a parent GameObject based on its activity
    public void UpdateHealth(Transform parent, int health)
    {
        // Loop through all child objects of the parent
        for (int i = parent.childCount - 1; i >= 0; i--)
        {
            GameObject child = parent.GetChild(i).gameObject;

            // Check if the child meets the specified activity type
            if ((health == -1 && child.activeInHierarchy) || (health == 1 && !child.activeInHierarchy))
            {
                child.SetActive(health == 1);
                break;
            }
        }
    }
}
