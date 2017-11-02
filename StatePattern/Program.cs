using System;
using System.Collections.Generic;
using System.Linq;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var levelManager = new LevelManager();
            var level = new Level();
            Console.WriteLine(level.LocationState());
            levelManager.AddLevelState(level);
            Console.WriteLine(level.LocationState());
            Console.Read();
        }
    }

    class LevelManager
    {
        private IList<Level> _Levels;

        public Action<Level> AddLevelState { get; set; }

        public LevelManager()
        {
            this._Levels = new List<Level>();
            this.AddLevelState = this.AddFirstLevel;
        }

        private void AddFirstLevel(Level level)
        {
            level.AsBottom();
            this._Levels.Add(level);
            this.AddLevelState = this.AddLevel;
        }

        private void AddLevel(Level level)
        {
            this._Levels.Last().AsMiddle();
            this._Levels.Add(level);
        }

        public void ClassicAddLevel(Level level)
        {
            if (!this._Levels.Any())
            {
                this._Levels.Add(level.AsBottom());
            }
            else
            {
                this._Levels.Add(level.AsMiddle());
            }
        }
    }

    class Level
    {
        public Func<string> LocationState { get; set; }

        public Level()
        {
            this.LocationState = () => string.Empty;
        }

        public Level AsTop()
        {
            this.LocationState = () => "I am top";
            return this;
        }

        public Level AsBottom()
        {
            this.LocationState = () => "I am bottom";
            return this;
        }

        public Level AsMiddle()
        {
            this.LocationState = () => "I am middle";
            return this;
        }
    }
}
