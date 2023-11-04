using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "StudentInformation", menuName = "ScriptableObjects/StudentInformation")]
public class StudentInformation : ScriptableObject
{
    [SerializeField] private int _intelligence;
    [SerializeField] private int _strength;
    [SerializeField] private int _selfConfidence;
    [SerializeField] private int _sociability;
    [SerializeField] private int _positivity;

}
