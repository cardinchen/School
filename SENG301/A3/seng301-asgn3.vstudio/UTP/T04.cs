﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UTP {

    /*
    T04:
        CREATE(5, 10, 25, 100; 3; 10; 10; 10)
        CONFIGURE([0] "Coke", 250; "water", 250; "stuff", 205)
        COIN_LOAD([0] 0; 5, 1)
        COIN_LOAD([0] 1; 10, 1)
        COIN_LOAD([0] 2; 25, 2)
        COIN_LOAD([0] 3; 100, 0)
        POP_LOAD([0] 0; "Coke", 1)
        POP_LOAD([0] 1; "water", 1)
        POP_LOAD([0] 2; "stuff", 1)
        PRESS([0] 0)
        EXTRACT([0])
        CHECK_DELIVERY(0)
        UNLOAD([0])
        CHECK_TEARDOWN(65; 0; "Coke", "water", "stuff")
    */

    [TestClass]
    public class T04 {

        [TestMethod]
        public void Test04() {
        }
    }
}