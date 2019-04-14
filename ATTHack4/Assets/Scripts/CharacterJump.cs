using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPGCharacterAnims
{
    public class CharacterJump  : MonoBehaviour
    {

        RPGCharacterControllerFREE rpgCharacterController;
        RPGCharacterMovementControllerFREE rpgCharacterMovementController;

        // Start is called before the first frame update
        void Start()
        {
            InvokeRepeating("Attack", 1f, Random.Range(0.25f, 5f));
            rpgCharacterController = GetComponent<RPGCharacterControllerFREE>();
            rpgCharacterMovementController = GetComponent<RPGCharacterMovementControllerFREE>();
        }

        void Attack()
        {
            if (rpgCharacterMovementController.canJump)
            {
                rpgCharacterMovementController.currentState = RPGCharacterStateFREE.Jump;
                rpgCharacterMovementController.rpgCharacterState = RPGCharacterStateFREE.Jump;
            }

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
