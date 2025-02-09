namespace TrinitySceneEditor
{
    public static class Math
    {
        public static double ConvertRadiansToDegrees(float radians)
        {
            double degrees = (180 / System.Math.PI) * radians;
            return (degrees);
        }
    }
}
