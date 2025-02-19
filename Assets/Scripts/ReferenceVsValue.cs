using UnityEngine;

public class ReferenceVsValue : MonoBehaviour {
    struct ValueStruct {
        public int number;
    }

    class ReferenceClass {
        public int number;
    }

    void Start() 
    {
        ValueStruct v1 = new ValueStruct { number = 10 };
        ValueStruct v2 = v1; // Copy of data (value type)
        v2.number = 20;

        ReferenceClass r1 = new ReferenceClass { number = 10 };
        ReferenceClass r2 = r1; // Reference copy (same object)
        r2.number = 20;

        Debug.Log("Value Struct v1: " + v1.number); // Still 10
        Debug.Log("Value Struct v2: " + v2.number); // 20

        Debug.Log("Reference Class r1: " + r1.number); // 20 (changed)
        Debug.Log("Reference Class r2: " + r2.number); // 20 (same object)
    }
}