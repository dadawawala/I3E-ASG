using UnityEngine;

public class KeycardPiece : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null)
            {
                player.CollectKeycard();
                Debug.Log("Keycard Collected!");
                Destroy(gameObject);
            }
        }
    }
}
