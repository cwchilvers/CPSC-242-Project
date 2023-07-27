using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER_Movement : MonoBehaviour
{
    public LayerMask groundLayer;
    public MeshCollider playerCollider;
    public Rigidbody playerRigidbody;
    public AudioSource playerAudio;
    public AudioClip jump;
    public Camera mainCamera;
    public bool isDead = false;

    private float _jumpSpeed = Constants.PLAYER_JUMP_SPEED;
    private float _jumpForce = Constants.PLAYER_JUMP_FORCE;
    private float _forwardForce = Constants.PLAYER_FORWARD_FORCE;

    private float _moveHorizontal;
    private float _moveVertical;

    void Update()
    {
        if (isDead == false)
        {
            GetInputs();
            CalculateJump();
            Jump();
            MoveForward();
        }
    }

    private void GetInputs()
    {
        _moveHorizontal = Input.GetAxis("Horizontal");
        _moveVertical = Input.GetAxis("Vertical");
    }

    private void CalculateJump()
    {
        Vector3 movementJump = new Vector3(_moveHorizontal, 0, _moveVertical);
        playerRigidbody.AddForce(movementJump * _jumpSpeed);
    }

    private void Jump()
    {
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            playerAudio.PlayOneShot(jump, 0.4f);
            playerRigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        }
    }

    private void MoveForward()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerRigidbody.AddForce(mainCamera.transform.forward * _forwardForce);
        }
    }

    private bool IsGrounded()
    {
        return Physics.CheckCapsule(playerCollider.bounds.center, new Vector3(playerCollider.bounds.center.x, playerCollider.bounds.min.y,
            playerCollider.bounds.center.z), playerCollider.contactOffset = .7f, groundLayer);
    }
}
