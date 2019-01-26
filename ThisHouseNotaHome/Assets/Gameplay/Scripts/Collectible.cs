using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour {
    [SerializeField]
    public readonly int itemId;
    [SerializeField]
    public readonly AudioClip collectionSound;
}
