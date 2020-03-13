using System;

using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using Game.Common.Controller.Interfaces;

using static UnityEngine.Rigidbody;

namespace Game.Common.Controller
{
	public sealed class PlayerMovementController : BaseController, IPlayerMovementController
	{
		public int moveSpeed = 5;
		
		public KeyCode fwdKey = KeyCode.W;
		public KeyCode leftKey = KeyCode.A;
		public KeyCode backKey = KeyCode.S;
		public KeyCode rightKey = KeyCode.D;
		public KeyCode space = KeyCode.Space;
		
		public float sensitivityX = 15F;
		public float sensitivityY = 15F;
		 
		public float jumpForce = 6;
		public bool jumpPossible = true;

		public float minimumX = -360F;
		public float maximumX = 360F;
		
		public float minimumY = -60F;
		public float maximumY = 60F;
		
		private float rotationX = 0F;
		private float rotationY = 0F;
		
		private Quaternion originalRotation;
		
		private Vector3 result;
		
		private GameObject playerGameObject;
		
		private Rigidbody rb;
		
		public override void OnEnabled()
		{
			playerGameObject = Common.Context.playerGameObject;
			rb = playerGameObject.GetComponent<Rigidbody>();
			playerGameObject.GetComponent<Rigidbody>().freezeRotation = true;
			originalRotation = playerGameObject.transform.localRotation;
		}
		
		public override void OnDisabled() { }
		
		public override void OnUpdate()
		{
			rotationX += Input.GetAxis("Mouse X") * sensitivityX;
			rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
			
			rotationX = ClampAngle(rotationX, minimumX, maximumX);
			rotationY = ClampAngle(rotationY, minimumY, maximumY);
			
			Quaternion xQuaternion = Quaternion.AngleAxis(rotationX, Vector3.up);
			Quaternion yQuaternion = Quaternion.AngleAxis(rotationY, -Vector3.right);
			
			playerGameObject.transform.localRotation = originalRotation * xQuaternion * yQuaternion;
			
			result = (new Vector3(playerGameObject.transform.forward.x, Vector3.forward.y, playerGameObject.transform.forward.z)) 
				* Time.deltaTime * moveSpeed;

			if (Input.GetKey(KeyCode.W)) playerGameObject.transform.position += result;
			else if (Input.GetKey(KeyCode.S)) playerGameObject.transform.position -= result;

			if (canJump() == true && Input.GetKeyDown(KeyCode.Space))
			{				
				rb.AddForce(Vector3.up*jumpForce, ForceMode.Impulse);
			}
		}
		private float ClampAngle(float angle, float min, float max)
		{
			if (angle < -360F) angle += 360F;
			if (angle > 360F) angle -= 360F;
			
			return Mathf.Clamp(angle, min, max);
		}

		public bool canJump()
		{
			return Physics.Raycast(playerGameObject.transform.position, Vector3.down, 2.1f);
		}

	}
}
