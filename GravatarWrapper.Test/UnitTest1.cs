﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GravatarWrapper.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var req = GravatarWrapper.Request("test@mctest.com", 400, true);
            if (req != null)
            {
                req.Save(@"c:\users\test\Desktop\bmp.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}
