namespace MathSharp
{
    public class Vector
    {
        float x,y,z;
        public Vector(float _x,float _y,float _z = 0)
        {
                x = _x;
                y =_y;
                z =_z;
        }
        public static float CrossProduct(Vector _vectorA,Vector _vectorB)
        {
            return _vectorA.x * _vectorB.x + _vectorA.y * _vectorB.y; 
        }
        public static float GetDistancefromOriginal(Vector _vector)
        {
            return global::System.MathF.Sqrt(_vector.x * _vector.x + _vector.y * _vector.y); 
        }
        public static float GetDistancefromTwoVectors(Vector _vectorA,Vector _vectorB)
        {
            return global::System.MathF.Sqrt(global::System.MathF.Pow(_vectorB.x - _vectorA.x,2)+global::System.MathF.Pow(_vectorB.y - _vectorA.y,2));
        }
    }
}