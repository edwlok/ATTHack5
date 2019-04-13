using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPGCharacterAnims
{
    public class CharacterAttack : MonoBehaviour
    {

        RPGCharacterControllerFREE rpgCharacterController;

        // Start is called before the first frame update
        void Start()
        {
            InvokeRepeating("Attack", 1f, 2.5f);
            rpgCharacterController = GetComponent<RPGCharacterControllerFREE>();
        }

        void Attack()
        {
            rpgCharacterController.AttackKick(1);

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
