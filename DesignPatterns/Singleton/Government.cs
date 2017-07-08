using System;

namespace DesignPatterns.Singleton
{
    public class Government
    {
        private static Government _government;
        private Guid _guid;

        private Government()
        {
            _guid = new Guid();
        }

        /// <summary>
        /// You should only ever have 1 government
        /// </summary>
        public static Government Instance => _government ?? (_government = new Government());

        public override string ToString()
        {
            return _guid.ToString();
        }
    }
}