using UnityEngine;

namespace Roux {
    public static class Vector {
        public static Vector2 Xy(this Vector3 vector) {
            return new Vector2(vector.x, vector.y);
        }
        public static Vector2 Xz(this Vector3 vector) {
            return new Vector2(vector.x, vector.z);
        }
    }
}