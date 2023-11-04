using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<StudentTrigger>(out StudentTrigger studentTrigger))
        {
            studentTrigger.
        }
    }
}
