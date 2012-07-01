using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ProjectEuler1
{
    [TestFixture]
    class Runner
    {
        private EulerListGenerator _generator;

        static void Main(string[] args)
        {
            Runner r = new Runner();
            r.TestSetup();
            r.TestListGeneration();
            r.TestSum();

        }

        [TestFixtureSetUp]
        public void TestSetup()
        {
            _generator = new EulerListGenerator();
        }

        [Test]
        public void TestListGeneration()
        {
            IList<int> ex = _generator.GetList(2000);
            foreach (int e in ex)
            {
                Assert.AreEqual(0, Math.Min(e % 3, e % 5));
                Console.Write(e + ",");
            }
        }

        [Test]
        public void TestSum()
        {
            int ex2 = _generator.GetSum(1000);
            Assert.AreEqual(233168, ex2);
        }

    }

    class EulerListGenerator
    {
        private IList<int> _list;
        
        public EulerListGenerator()
        {
            _list = new List<int>();
        }
        
        public IList<int> GetList(int limit)
        {
            IList<int> result;
            var last = _list.Count > 0 ? _list[_list.Count - 1] : -1;
            for (int i = last + 1; i < limit; i++)
                _list.Add(i);


            if (_list[_list.Count - 1] > limit)
                result = new List<int>(_list.Where<int>(x => x < limit));
            else
                result = _list;

            result = new List<int>(result.Where(x => x % 3 == 0 || x % 5 == 0));

            return result;
        }

        public IList<int> GetList2(int limit)
        {
            IList<int> result;
            var last = _list.Count > 0 ? _list[_list.Count - 1] : -1;
            for (int i = last + 1; i < limit; i++)
            {
                if (i % 3 == 0) _list.Add(i);
                else if (i % 5 == 0) _list.Add(i);
            }

            if (_list[_list.Count - 1] > limit)
                result = new List<int>(_list.Where<int>(x => x < limit));
            else
                result = _list;

            return result;
        }

        public int GetSum(int limit)
        {
            var list = GetList(limit);
            
            int total = 0;

            foreach (int i in list)
            {
                total += i;
            }

            return total;
        }
    }
    
}
