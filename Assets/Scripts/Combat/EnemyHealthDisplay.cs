using RPG.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace RPG.Combat
{
    public class EnemyHealthDisplay : MonoBehaviour
    {
        Fighter fighter;
        Health health;

        private void Awake()
        {
            fighter = GameObject.FindWithTag("Player").GetComponent<Fighter>();
        }

        private void Update()
        {
            if (fighter.GetTarget() != null)
            {
                GetComponent<Text>().text = "No Target";
            }
            health = fighter.GetTarget();
            GetComponent<Text>().text = health.GetPercentage().ToString("F0") + "%";
        }
    }
}
