namespace RogueLike
{
	public struct Coordinate
	{
		public int x;
		public int z;
	}
	public struct Position
	{
		public Coordinate coordinate;
		public Map.MapLayer mapLayer;
	}
}