using System;
using System.Collections.Generic;
using UnityEngine;

namespace Core.Movement
{
    namespace Sys2D
    {
        public class Movement2D
        {
            static Vector2 clampedVelocity;

            /// <summary>
            /// This function returns a Vector2 Axis of Horixontal and Vertical Inputs.
            /// </summary>
            public static Vector2 Axis
            {
                get => new Vector2(Input.GetAxis("Horizontal"),
                        Input.GetAxis("Vertical"));
            }

            /// <summary>
            /// This function returns a Vector2 Axis of Horizontal and Vertical Inputs multiplied by Delta Time.
            /// </summary>
            public static Vector2 AxisDelta
            {
                get => new Vector2(Input.GetAxis("Horizontal"),
                        Input.GetAxis("Vertical")) * Time.deltaTime;
            }

            /// <summary>
            /// Moves the player in Horizontal multiplied by speed variable.
            /// </summary>
            /// <param name="t">Transform component of the player</param>
            /// <param name="speed">The move speed of the player</param>
            public static void SimpleMovement(Transform t, float speed)
            {
                t.Translate(Vector2.right * Axis.x * speed);
            }

            /// <summary>
            /// Moves the player in Horizontal multiplied by speed variable
            /// and Delta Time.
            /// </summary>
            /// <param name="t">Transform component of the player</param>
            /// <param name="speed">The move speed of the player</param>
            public static void DeltaMovement(Transform t, float speed)
            {
                t.Translate(Vector2.right * AxisDelta.x * speed);
            }

            /// <summary>
            /// Returns if player is touching jump button
            /// </summary>
            public static bool Btn_Jump
            {
                get => Input.GetButtonDown("Jump");
            }

            /// <summary>
            /// Makes player jumps with an impulse in rigidbody.
            /// </summary>
            /// <param name="rb2d">Rigidbody2D component of player.</param>
            /// <param name="jumpForce">The magnitude of the jump.</param>
            public static void PhysicJumpUp(Rigidbody2D rb2d, float jumpForce)
            {
                rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }

            /// <summary>
            /// Moves the player with physics on X.
            /// </summary>
            /// <param name="rb2d">Rigidbody2D component of player.</param>
            /// <param name="moveSpeed">The amount of force for movement in x.</param>
            /// <param name="maxSpeed">The max amount of player movement force in x.</param>
            public static void PhysicMovement(Rigidbody2D rb2d, float moveSpeed, float maxSpeed)
            {
                rb2d.AddForce(Vector2.right * moveSpeed * Axis.x, ForceMode2D.Impulse);
                clampedVelocity = Vector2.ClampMagnitude(rb2d.velocity, maxSpeed);

                rb2d.velocity = new Vector2(clampedVelocity.x, rb2d.velocity.y);
            }
        }
    }
    namespace Sys3D
    {
        public class Movement3D
        {
            /// <summary>
            /// Returns axis for 3D movement
            /// </summary>
            public static Vector3 Axis
            {
                get => new Vector3(Input.GetAxis("Horizontal"), 0f,
                        Input.GetAxis("Vertical"));
            }

            /// <summary>
            /// This function returns a Vector3 Axis of Horizontal and Vertical Inputs multiplied by Delta Time.
            /// </summary>
            public static Vector3 AxisDelta
            {
                get => new Vector3(Input.GetAxis("Horizontal"), 0f,
                        Input.GetAxis("Vertical")) * Time.deltaTime;
            }

            /// <summary>
            /// Moves the player in Horizontal multiplied by speed variable.
            /// </summary>
            /// <param name="t">Transform component of the player</param>
            /// <param name="speed">The move speed of the player</param>
            public static void SimpleMovement(Transform t, float speed)
            {
                t.Translate( Axis * speed);
            }

            /// <summary>
            /// Moves the player in Horizontal multiplied by speed variable
            /// and Delta Time.
            /// </summary>
            /// <param name="t">Transform component of the player</param>
            /// <param name="speed">The move speed of the player</param>
            public static void DeltaMovement(Transform t, float speed)
            {
                t.Translate(AxisDelta * speed);
            }

            /// <summary>
            /// Rotates and move the character in the facing direction.
            /// </summary>
            /// <param name="t">Transform of the character</param>
            /// <param name="speed">The move speed of the translation of the character</param>
            public static void MoveFacing(Transform t, float speed)
            {
                t.Translate(Vector3.forward * AxisDelta.magnitude * speed);
                if (Axis != Vector3.zero)
                {
                    t.rotation = Quaternion.LookRotation(Axis);
                }
            }
        }
    }

    namespace ControlUtils
    {
        public class ControlUtils
        {
            public static bool Button_A { get => Input.GetButtonDown("Submit"); }
        }
    }
}
