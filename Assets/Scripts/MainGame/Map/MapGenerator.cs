using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using RogueLikeProject.Utils;

namespace RogueLikeProject.Map
{
	[System.Serializable]
	public class MapGenerator
	{
		// パラメータとメソッドが多すぎる．class分割を検討

		// DungeonDirectorにRoomの情報を受け渡す

		// 本体
		TerrainType[,] map;

		// mapのサイズ
		int dungeonXSsize = 54;
		int dungeonZSize = 30;

		[SerializeField, Range(0, 10)]
		int frameBreadth = 1;
		[SerializeField, Range(1, 100)]
		int maxRoomNum = 20;
		[SerializeField, Range(1, 100)]
		int minRoomNum = 5;
		[SerializeField, Range(5, 100)]
		int maxRoomSize = 100;
		[SerializeField, Range(5, 100)]
		int minRoomSize = 5;

		Utils.Rect mainMap; //map without frame
		int maxEntranceNum = 3;
		int minEntranceNum = 1;
		Queue<Node> nodes;
		int roomNowItr = 0;
		int splitFrequency;
		List<Utils.Rect> splittableRects;
		List<Utils.Rect> indivisibleRects;
		System.Random random;


		public TerrainType[,] GenerateMap(Dictionary<int, Room> rooms)
		{
			map = new TerrainType[this.dungeonZSize, this.dungeonXSsize];
			for (var zi = 0; zi < this.dungeonZSize; zi++)
				for (var xi = 0; xi < dungeonXSsize; xi++)
					this.map[zi, xi] = TerrainType.Wall;

			// frameを除いた実際に使用できる範囲のmapを定義する
			mainMap = new Utils.Rect() { start = new Coordinate() { x = frameBreadth, z = frameBreadth }, end = new Coordinate() { x = this.dungeonXSsize - 1 - frameBreadth, z = this.dungeonZSize - 1 - frameBreadth } };

			splittableRects = new List<Utils.Rect>();
			indivisibleRects = new List<Utils.Rect>();
			nodes = new Queue<Node>();
			random = new System.Random();

			splittableRects.Add(mainMap);

			//分割する回数
			splitFrequency = random.Next(minRoomNum, maxRoomNum);
			splitFrequency -= 1;
			// 分割できるだけ分割する
			while (splitFrequency > 0 && splittableRects.Count != 0)
				if (DivideMap())
					splitFrequency--;
			indivisibleRects.AddRange(splittableRects);
			while (indivisibleRects.Count > 0)
			{
				bool isGenerating = random.Next(0, 2) > 0;
				// if (isGenerating)
				GenerateRoom(indivisibleRects[0], rooms);
				indivisibleRects.RemoveAt(0);
			}
			foreach (var room in rooms)
			{
				var thisEntranceNum = random.Next(minEntranceNum, maxEntranceNum + 1);
				while (thisEntranceNum-- > 0)
				{
					var limit = 20;
					while (GenerateEntrance(room.Value, Utils.Random.RandomFourDirection()) == false && limit-- > 0)
					{ }
				}
			}
			while (nodes.Count != 0)
				GenerateWay(nodes.Dequeue(), true, false, TerrainType.Way, TerrainType.InsideWall, TerrainType.Wall);

			// splitterを壁で埋める
			for (var hi = 0; hi < map.GetLength(0); hi++)
				for (var wi = 0; wi < map.GetLength(1); ++wi)
					if (map[hi, wi] == TerrainType.Splitter)
						map[hi, wi] = TerrainType.Wall;

			// 内壁を埋める
			for (var hi = 0; hi < map.GetLength(0); ++hi)
				for (var wi = 0; wi < map.GetLength(1); ++wi)
					if (map[hi, wi] == TerrainType.Way)
						for (int dy = -1; dy <= 1; ++dy)
							for (int dx = -1; dx <= 1; ++dx)
								if (map[hi + dy, wi + dx] == TerrainType.Wall)
									map[hi + dy, wi + dx] = TerrainType.InsideWall;

			return map;
		}
		bool DivideMap()
		{
			int itr = random.Next(0, splittableRects.Count);
			Utils.Rect rect = splittableRects[itr];
			splittableRects.RemoveAt(itr);
			bool isHorizontally = random.Next(0, 2) > 0;

			if (rect.end.x - rect.start.x < minRoomSize * 2 + 1 && rect.end.z - rect.start.z < minRoomSize * 2 + 1)
			{
				indivisibleRects.Add(rect);
				return false;
			}
			else if (rect.end.x - rect.start.x < minRoomSize * 2 + 1)
			{
				isHorizontally = true;
			}
			else if (rect.end.z - rect.start.z < minRoomSize * 2 + 1)
			{
				isHorizontally = false;
			}
			if (isHorizontally)//split horizon
			{
				int xAxis = random.Next(rect.start.z + minRoomSize, rect.end.z - minRoomSize);
				for (var i = rect.start.x; i <= rect.end.x; ++i)
				{
					map[xAxis, i] = TerrainType.Splitter;
				}
				Utils.Rect top = new Utils.Rect() { start = rect.start, end = new Coordinate() { x = rect.end.x, z = xAxis - 1 } };
				Utils.Rect bottom = new Utils.Rect() { start = new Coordinate() { x = rect.start.x, z = xAxis + 1 }, end = rect.end };
				splittableRects.Add(top);
				splittableRects.Add(bottom);
				return true;
			}
			else//split vertical
			{
				int zAxis = random.Next(rect.start.x + minRoomSize, rect.end.x - minRoomSize);
				for (var i = rect.start.z; i <= rect.end.z; ++i)
				{
					map[i, zAxis] = TerrainType.Splitter;
				}
				Utils.Rect left = new Utils.Rect() { start = rect.start, end = new Coordinate() { x = zAxis - 1, z = rect.end.z } };
				Utils.Rect right = new Utils.Rect() { start = new Coordinate() { x = zAxis + 1, z = rect.start.z }, end = rect.end };
				splittableRects.Add(left);
				splittableRects.Add(right);
				return true;
			}
		}
		void GenerateRoom(Utils.Rect rect, Dictionary<int, Room> rooms)
		{
			Utils.Rect roomRect = new Utils.Rect();
			roomRect.start.x = random.Next(rect.start.x, rect.end.x - minRoomSize + 1);
			roomRect.start.z = random.Next(rect.start.z, rect.end.z - minRoomSize + 1);
			roomRect.end.x = random.Next(roomRect.start.x + minRoomSize - 1, (rect.end.x <= roomRect.start.x + maxRoomSize - 1 ? rect.end.x : roomRect.start.x + maxRoomSize - 1));
			roomRect.end.z = random.Next(roomRect.start.z + minRoomSize - 1, (rect.end.z <= roomRect.start.z + maxRoomSize - 1 ? rect.end.z : roomRect.start.z + maxRoomSize - 1));
			for (var hi = roomRect.start.z; hi <= roomRect.end.z; ++hi)
			{
				for (var wi = roomRect.start.x; wi <= roomRect.end.x; ++wi)
				{
					if (wi == roomRect.start.x || wi == roomRect.end.x || hi == roomRect.start.z || hi == roomRect.end.z)
						map[hi, wi] = TerrainType.InsideWall;
					else
						map[hi, wi] = TerrainType.Room;
				}
			}
			rooms[roomNowItr] = new Room() { rect = roomRect, entrances = new List<Coordinate>() };
			if (rect.end.x - rect.start.x == mainMap.end.x - mainMap.start.x)
			{
				if (rect.start.z != mainMap.start.z) while (GenerateEntrance(rooms[roomNowItr], Direction.North) == false) { }
				if (rect.end.z != mainMap.end.z) while (GenerateEntrance(rooms[roomNowItr], Direction.South) == false) { }
			}
			else if (rect.end.z - rect.start.z == mainMap.end.z - mainMap.start.x)
			{
				if (rect.start.x != mainMap.start.x) while (GenerateEntrance(rooms[roomNowItr], Direction.West) == false) { }
				if (rect.end.x != mainMap.end.x) while (GenerateEntrance(rooms[roomNowItr], Direction.East) == false) { }
			}
			roomNowItr += 1;
		}
		bool GenerateEntrance(Room room, Direction dir)
		{
			Coordinate point = new Coordinate();
			switch (dir)
			{
				case Direction.North:
					point.x = random.Next(room.rect.start.x + 1, room.rect.end.x - 1);
					point.z = room.rect.start.z;
					if (map[point.z, point.x - 1] == TerrainType.Way || map[point.z, point.x] == TerrainType.Way || map[point.z, point.x + 1] == TerrainType.Way)
					{
						return false;
					}
					break;
				case Direction.South:
					point.x = random.Next(room.rect.start.x + 1, room.rect.end.x - 1);
					point.z = room.rect.end.z;
					if (map[point.z, point.x - 1] == TerrainType.Way || map[point.z, point.x] == TerrainType.Way || map[point.z, point.x + 1] == TerrainType.Way)
					{
						return false;
					}
					break;
				case Direction.East:
					point.x = room.rect.end.x;
					point.z = random.Next(room.rect.start.z + 1, room.rect.end.z - 1);
					if (map[point.z + 1, point.x] == TerrainType.Way || map[point.z, point.x] == TerrainType.Way || map[point.z - 1, point.x] == TerrainType.Way)
					{
						return false;
					}
					break;
				case Direction.West:
					point.x = room.rect.start.x;
					point.z = random.Next(room.rect.start.z + 1, room.rect.end.z - 1);
					if (map[point.z + 1, point.x] == TerrainType.Way || map[point.z, point.x] == TerrainType.Way || map[point.z - 1, point.x] == TerrainType.Way)
					{
						return false;
					}
					break;
				default:
					return false;
			}
			if (GenerateWay(new Node() { direction = dir, coordinate = point }, true, true, TerrainType.Splitter, TerrainType.Way))
				return true;
			else
				return false;
		}
		bool GenerateWay(Node node, bool isEnqueue, bool isIncludeDestination, params TerrainType[] destination)
		{
			int dx = 0, dz = 0;
			bool CheckDestination(TerrainType nowPosition)
			{
				for (var i = 0; i < destination.GetLength(0); ++i)
				{
					if (nowPosition == destination[i])
					{
						return true;
					}
				}
				return false;
			}
			switch (node.direction)
			{
				case Direction.North:
					dz = -1;
					break;
				case Direction.South:
					dz = 1;
					break;
				case Direction.East:
					dx = 1;
					break;
				case Direction.West:
					dx = -1;
					break;
				default:
					return false;
			}
			for (var i = 0; ; i++)
			{
				if (node.coordinate.z + i * dz >= mainMap.end.z || node.coordinate.z + i * dz <= mainMap.start.z || node.coordinate.x + i * dx <= mainMap.start.x || node.coordinate.x + i * dx >= mainMap.end.x)
				{
					return false;
				}
				else if (CheckDestination(map[node.coordinate.z + i * dz, node.coordinate.x + dx * i]))
				{
					if (isIncludeDestination == false)
					{
						i -= 1;
					}
					if (isEnqueue)
					{
						if (map[node.coordinate.z + i * dz + 1, node.coordinate.x + dx * i] == TerrainType.Splitter)
						{
							nodes.Enqueue(new Node() { direction = Direction.South, coordinate = new Coordinate() { z = node.coordinate.z + i * dz + 1, x = node.coordinate.x + dx * i } });
						}
						if (map[node.coordinate.z + i * dz - 1, node.coordinate.x + dx * i] == TerrainType.Splitter)
						{
							nodes.Enqueue(new Node() { direction = Direction.North, coordinate = new Coordinate() { z = node.coordinate.z + i * dz - 1, x = node.coordinate.x + dx * i } });
						}
						if (map[node.coordinate.z + i * dz, node.coordinate.x + dx * i - 1] == TerrainType.Splitter)
						{
							nodes.Enqueue(new Node() { direction = Direction.West, coordinate = new Coordinate() { z = node.coordinate.z + i * dz, x = node.coordinate.x + dx * i - 1 } });
						}
						if (map[node.coordinate.z + i * dz, node.coordinate.x + dx * i + 1] == TerrainType.Splitter)
						{
							nodes.Enqueue(new Node() { direction = Direction.East, coordinate = new Coordinate() { z = node.coordinate.z + i * dz, x = node.coordinate.x + dx * i + 1 } });
						}
					}
					while (i >= 0)
					{
						map[node.coordinate.z + i * dz, node.coordinate.x + i * dx] = TerrainType.Way;
						i -= 1;
					}
					return true;
				}
			}
		}
	}
}