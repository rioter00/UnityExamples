using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class shootLimitedProjectile : MonoBehaviour
{
    // Text Mesh Pro Text Object for Number of Collected Ammo
    public TMP_Text AmmoText;

    // Project Prefab
    public GameObject projectile;

    // Where to fire projectile from
    public Transform shootPoint;

    // Shoot Button
    [SerializeField] private KeyCode shootButton;

    // Number of collected projectiles
    public int numProjectiles;

    // Max number of Projectiles
    public int maxProjectiles;

    // Reference to the UI Images representing the collected projectiles
    public Image[] projectileImages;


    private void Start()
    {
        // disable the project images UI
        foreach(var image in projectileImages)
        {
            image.enabled = false;
        }
    }

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
                if (numProjectiles > 0)
                {
                    // the direction of the instantiation is linked to the object's transfom.rotation
                    Instantiate(projectile, shootPoint.position, transform.rotation);


                    // disable the last fired UI project image
                    projectileImages[numProjectiles - 1].enabled = false;

                    // subtract one from the number of available projectiles
                    numProjectiles--;
                    UpdateAmmoText();
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Collectible") && numProjectiles < maxProjectiles)
        {

            // increase number of available projectiles by one
            numProjectiles++;
            // enable the appropriate project UI image
            projectileImages[numProjectiles-1].enabled = true;
            UpdateAmmoText();
        }
    }

    private void UpdateAmmoText()
    {
        AmmoText.text = "Ammo: " + numProjectiles.ToString();
    }
}
