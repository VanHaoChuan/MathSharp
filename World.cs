namespace MathSharp
{
    public enum WorldType
    {
        TwoDirection,
        ThreeDirection
    };
    public class World
    {
        public Vector original = new Vector(0,0,0);
        public Vector[] baseVectors;
        public global::System.Collections.ArrayList customVectors = new global::System.Collections.ArrayList();
        public WorldType worldType;
        public World(WorldType _worldType,[System.Runtime.InteropServices.Optional] Vector[] _baseVector2D,[System.Runtime.InteropServices.Optional] Vector[] _baseVector3D)
        {            


            if(_worldType == WorldType.TwoDirection)
            {
                baseVectors = _baseVector2D;
                worldType = _worldType;
            }
            if(_worldType == WorldType.ThreeDirection)
            {
                baseVectors = _baseVector3D;
                worldType = _worldType;
            }
        }
    }
}