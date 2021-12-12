namespace AdventOfCode2021.Day_12
{
    public class CaveMapReader
    {
        public List<Cave> ReadCavesFromFile(string file)
        {
            var lines = File.ReadAllLines(file);
            return ReadCaves(lines);
        }

        public List<Cave> ReadCaves(string[] cavesAndConnections)
        {
            var caves = new List<Cave>();

            foreach (var connection in cavesAndConnections)
            {
                var splittedConnection = connection.Trim().Split('-', StringSplitOptions.TrimEntries);

                Cave? cave1 = caves.Find(cave => cave.Designation == splittedConnection[0]);
                Cave? cave2 = caves.Find(cave => cave.Designation == splittedConnection[1]);

                // new cave, add to collection
                if (cave1 == null)
                {
                    cave1 = new Cave(splittedConnection[0], splittedConnection[0].Any(char.IsUpper));
                    caves.Add(cave1);
                }

                // new cave, add to collection
                if (cave2 == null)
                {
                    cave2 = new Cave(splittedConnection[1], splittedConnection[1].Any(char.IsUpper));
                    caves.Add(cave2);
                }

                // connect caves to each other.
                cave1.AddConnectedCave(cave2);
                cave2.AddConnectedCave(cave1);
            }

            return caves;
        }

        public int CountAllStartToEndPaths(List<Cave> map)
        {
            // find start node;
            var startCave = map.First(c => c.Designation == "start");

            // find end node;
            var endCave = map.First(c => c.Designation == "end");

            // find all paths;
            var path = new List<Cave>();
            var x = FindAllPaths(path, startCave, endCave);
            
            /*
            // print all paths.
            foreach (var pathToEnd in x)
            {
                foreach (var cave in pathToEnd)
                {
                    Console.Write($"{cave.Designation}, ");
                }
                Console.Write($"{Environment.NewLine}");
            }
            */
            return x.Count;
        }

        public int CountAllStartToEndPathsPart2(List<Cave> map)
        {
            // find start node;
            var startCave = map.First(c => c.Designation == "start");

            // find end node;
            var endCave = map.First(c => c.Designation == "end");

            // find all paths;
            var path = new List<Cave>();
            var x = FindAllPathsPart2(path, startCave, endCave);
            /*
            foreach (var pathToEnd in x)
            {
                foreach (var cave in pathToEnd)
                {
                    Console.Write($"{cave.Designation}, ");
                }
                Console.Write($"{Environment.NewLine}");
            }
            */
            return x.Count;
        }

        private List<List<Cave>> FindAllPathsPart2(List<Cave> path, Cave cave, Cave endCave)
        {
            var paths = new List<List<Cave>>();
            path.Add(cave);

            if (cave.Designation == endCave.Designation)
            {
                // target cave reached.
                paths.Add(path);
                return paths;
            }

            var s = path.Select(c => c.Designation).Aggregate((x, y) => $"{x},{y}" );

            var connectedCaves = cave.ConnectedCaves;
            foreach (var newCave in connectedCaves)
            {
                if (newCave.Designation == "start")
                {
                    continue;
                }

                if (!newCave.IsLargeCave && path.Contains(newCave))
                {
                    var smallCaves = path.Where(c => !c.IsLargeCave);
                    var count = smallCaves.GroupBy(smallCaves => smallCaves.Designation).Select(g => g.Count()).Max();
                    
                    if (count == 2)
                    {
                        continue;
                    }
                }

                var newPaths = FindAllPathsPart2(new List<Cave>(path), newCave, endCave);

                if (newPaths != null) // path(s) to end cave found
                {
                    paths.AddRange(newPaths);
                }
            }

            if (paths.Count > 0)
            {
                return paths;
            }

            return null;
        }

        private List<List<Cave>> FindAllPaths(List<Cave> path, Cave cave, Cave endCave)
        {
            var paths = new List<List<Cave>>();
            path.Add(cave);           

            if(cave.Designation == endCave.Designation)
            {
                // target cave reached.
                paths.Add(path);
                return paths;
            }

            var connectedCaves = cave.ConnectedCaves;
            foreach (var newCave in connectedCaves)
            {
                if(path.Contains(newCave) && !newCave.IsLargeCave)
                {
                    continue;
                }

                var newPaths = FindAllPaths(new List<Cave>(path), newCave, endCave);
                
                if(newPaths != null) // path(s) to end cave found
                {
                    paths.AddRange(newPaths);
                }
            }

            if(paths.Count > 0)
            {
                return paths;
            }

            return null;
        }
    }
}
