using UnityEngine;

public class PickupSystem : MonoBehaviour
{
    private IPickupable pickupable;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            TryPickup();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        pickupable = collision.GetComponent<IPickupable>();
    }

    private void TryPickup()
    {

        if (pickupable != null)
        {
            pickupable.Pickup();
        }
    }
}

