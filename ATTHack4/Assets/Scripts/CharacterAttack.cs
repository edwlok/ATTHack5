using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPGCharacterAnims
{
    public class CharacterAttack  : MonoBehaviour
    {

        RPGCharacterControllerFREE rpgCharacterController;

        // Start is called before the first frame update
        void Start()
        {
            InvokeRepeating("Attack", 1f, 4.25f);
            rpgCharacterController = GetComponent<RPGCharacterControllerFREE>();
        }

        void Attack()
        {
            rpgCharacterController.GetHit();    

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
