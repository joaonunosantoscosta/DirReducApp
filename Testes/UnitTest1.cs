using DirReducApp;
using System;
using Xunit;

namespace Testest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            string[] expected = new string[] { "WEST", "WEST" };
            string[] array = new string[] { "NORTH", "EAST", "WEST", "SOUTH", "WEST", "WEST" };

            Directions d = new Directions();
            string[] result = d.DirReduc_versionClojure(array);

            Assert.Equal(expected, result);
        }


        [Fact]
        public void Test2()
        {
            string[] expected = new string[] { "WEST", "WEST", "NORTH", "NORTH" };
            string[] array = new string[] { "NORTH", "EAST", "WEST", "SOUTH", "WEST", "WEST", "NORTH", "NORTH", "N", "N" };

            Directions d = new Directions();
            string[] result = d.DirReduc_versionClojure(array);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            string[] expected = null;
            string[] array = new string[] { "NORTH", "EAST", "WEST", "SOUTH", "WEST", "WEST", "NORTH", "NORTH", "N", "N", "SOUTH", "SOUTH", "EAST", "EAST" };

            Directions d = new Directions();
            string[] result = d.DirReduc_versionClojure(array);

            Assert.Equal(expected, result);
        }


        [Fact]
        public void Test4()
        {
            string[] expected = null;
            string[] array = new string[] { };

            Directions d = new Directions();
            string[] result = d.DirReduc_versionClojure(array);

            Assert.Equal(expected, result);
        }


        [Fact]
        public void Test5()
        {
            string[] expected = null;
            string[] array = null;

            Directions d = new Directions();
            string[] result = d.DirReduc_versionClojure(array);

            Assert.Equal(expected, result);
        }


        [Fact]
        public void Test6()
        {
            string[] expected = null;
            string[] array = new string[] { "Hello" };

            Directions d = new Directions();
            string[] result = d.DirReduc_versionClojure(array);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test7()
        {
            string expected = "Resultado = [WEST , WEST]"; 
            string[] array = new string[] { "NORTH", "EAST", "WEST", "SOUTH", "WEST", "WEST" };

            Directions d = new Directions();
            string[] result = d.DirReduc_versionClojure(array);

            string stringResult = StringConstruction.getString(result);

            Assert.Equal(expected, stringResult);
        }

        [Fact]
        public void Test8()
        {
            string expected = "Resultado = null";
            string[] array = new string[] { };

            Directions d = new Directions();
            string[] result = d.DirReduc_versionClojure(array);

            string stringResult = StringConstruction.getString(result);

            Assert.Equal(expected, stringResult);
        }


    }
}
