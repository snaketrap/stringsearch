using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringsearch
{
    class BruteForceAlgo
    {

        public delegate bool BruteForceTest(ref char[] testChars);

        public static bool BruteForce(string testChars, int startLength, int endLength, BruteForceTest testCallback)
        {
            for (int len = startLength; len <= endLength; ++len)
            {
                char[] chars = new char[len];

                for (int i = 0; i < len; ++i)
                    chars[i] = testChars[0];

                if (testCallback(ref chars))
                    return true;
