public class shootProjectile : MonoBehaviour
{
    [SerializeField] private GameObject projectile;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private KeyCode shootButton;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(shootButton))
        {
            if (projectile == null)
            {
                Debug.Log("No projectile Set");
            }
            else
            {
                // the direction of the instantiation is linked to the object's transfom.rotation
                Instantiate(projectile, shootPoint.position, transform.rotation);
            }
        }
    }
}
