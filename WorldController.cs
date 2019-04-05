namespace MathSharp
{
    public class WorldController
    {
        public World targetWorld = new World(WorldType.TwoDirection,new Vector[2]{new Vector(_x:1,_y:1),new Vector(_x:2,_y:2)});
        public bool PlusVector(Vector _vector)
        {
            if(targetWorld.customVectors.Count < 20000000)
            {
                targetWorld.customVectors.Add(_vector);
                return true;
            }
            else
            {
                System.Console.WriteLine("DDF");
                throw new System.Exception("Too much vectors(more than 200),cannot add more");
            }
        }
        public static WorldController worldController = new WorldController();
        
    }
}