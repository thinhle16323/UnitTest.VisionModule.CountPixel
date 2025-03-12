using ST4I.Vision.Module;
using ST4IVisionCoreNet;
using System.Collections.ObjectModel;

namespace ST4I.VisionModule.CountPixel
{
    [TestClass]
    public sealed class CoreTest
    {
        [TestMethod]
        public void CountPixel()
        {
            int numbPixelResult = 88716;
            double percPixelResult = 1.83;

            ST4I.Vision.Module.CountPixel countPixel = new ST4I.Vision.Module.CountPixel();

            //CountPixelColor pixelColor = new CountPixelColor();

            using (var img = Sv.ImRead(@"Images\Image 00089.jpg", ImreadModes.Grayscale))
            {
                countPixel.LowerValueThreshold = 153;
                countPixel.UpperValueThreshold = 255;
                CountPixelResult kq = countPixel.Count(img);
                int soluongpx = kq.NumberOfPixel;
                Collection<int> kq2 = countPixel.CalcHistogram(img);
                Collection<int> kq2_arr = new Collection<int>(kq2.ToList());
                if (soluongpx != numbPixelResult)
                {
                    Assert.Fail($"{soluongpx}><{numbPixelResult}");
                }
            }
            //{
            //    pixelColor.ColorSpace = CountPixelColor.ColorSpaceType.HLS;

                //    pixelColor.LowerValueChannel1 = 168;
                //    pixelColor.LowerValueChannel2 = 100;
                //    pixelColor.LowerValueChannel3 = 0;

                //    pixelColor.UpperValueChannel1 = 255;
                //    pixelColor.UpperValueChannel2 = 255;
                //    pixelColor.UpperValueChannel3 = 255;

                //    CountPixelResult kq = pixelColor.Count(img);
                //    int soluongpixel = kq.NumberOfPixel;
                //    double perc = kq.PercentageOfPixel;
                //    if (soluongpixel != numbPixelResult)
                //    {
                //        Assert.Fail("Kết quả mean không đúng");
                //    }
                //    if (Math.Round(perc, 2) != Math.Round(percPixelResult, 2))
                //    {
                //        Assert.Fail($"{perc}{percPixelResult}");
                //    }
                //}
        }
        [TestMethod]
        public void CountPixel2()
        {
            int numbPixelResult = 85678;
            double percPixelResult = 27.89;

            ST4I.Vision.Module.CountPixel countPixel = new ST4I.Vision.Module.CountPixel();

            //CountPixelColor pixelColor = new CountPixelColor();

            using (var img = Sv.ImRead(@"Images\Image 03305.jpg", ImreadModes.Grayscale))
            {
                countPixel.LowerValueThreshold = 153;
                countPixel.UpperValueThreshold = 255;
                CountPixelResult kq = countPixel.Count(img);
                int soluongpx = kq.NumberOfPixel;
                Collection<int> kq2 = countPixel.CalcHistogram(img);
                Collection<int> kq2_arr = new Collection<int>(kq2.ToList());
                if (soluongpx != numbPixelResult)
                {
                    Assert.Fail($"{soluongpx}><{numbPixelResult}>");
                }
            }
            //{
            //    pixelColor.ColorSpace = CountPixelColor.ColorSpaceType.HLS;

            //    pixelColor.LowerValueChannel1 = 168;
            //    pixelColor.LowerValueChannel2 = 100;
            //    pixelColor.LowerValueChannel3 = 0;

            //    pixelColor.UpperValueChannel1 = 255;
            //    pixelColor.UpperValueChannel2 = 255;
            //    pixelColor.UpperValueChannel3 = 255;

            //    CountPixelResult kq = pixelColor.Count(img);
            //    int soluongpixel = kq.NumberOfPixel;
            //    double perc = kq.PercentageOfPixel;
            //    if (soluongpixel != numbPixelResult)
            //    {
            //        Assert.Fail("Kết quả mean không đúng");
            //    }
            //    if (Math.Round(perc, 2) != Math.Round(percPixelResult, 2))
            //    {
            //        Assert.Fail($"{perc}{percPixelResult}");
            //    }
            //}
        }
        [TestMethod]
        public void CountPixel3()
        {
            int numbPixelResult = 76157;
            double percPixelResult = 24.79;

            ST4I.Vision.Module.CountPixel countPixel = new ST4I.Vision.Module.CountPixel();

            //CountPixelColor pixelColor = new CountPixelColor();

            using (var img = Sv.ImRead(@"Images\Image 07154.jpg", ImreadModes.Grayscale))
            {
                countPixel.LowerValueThreshold = 153;
                countPixel.UpperValueThreshold = 255;
                CountPixelResult kq = countPixel.Count(img);
                int soluongpx = kq.NumberOfPixel;
                Collection<int> kq2 = countPixel.CalcHistogram(img);
                Collection<int> kq2_arr = new Collection<int>(kq2.ToList());
                if (soluongpx != numbPixelResult)
                {
                    Assert.Fail($"{soluongpx}><{numbPixelResult}");
                }
            }
            //{
            //    pixelColor.ColorSpace = CountPixelColor.ColorSpaceType.HLS;

            //    pixelColor.LowerValueChannel1 = 168;
            //    pixelColor.LowerValueChannel2 = 100;
            //    pixelColor.LowerValueChannel3 = 0;

            //    pixelColor.UpperValueChannel1 = 255;
            //    pixelColor.UpperValueChannel2 = 255;
            //    pixelColor.UpperValueChannel3 = 255;

            //    CountPixelResult kq = pixelColor.Count(img);
            //    int soluongpixel = kq.NumberOfPixel;
            //    double perc = kq.PercentageOfPixel;
            //    if (soluongpixel != numbPixelResult)
            //    {
            //        Assert.Fail("Kết quả mean không đúng");
            //    }
            //    if (Math.Round(perc, 2) != Math.Round(percPixelResult, 2))
            //    {
            //        Assert.Fail($"{perc}{percPixelResult}");
            //    }
            //}
        }
        [TestMethod]
        public void TestHistoryData()
        {
            ST4I.Vision.Module.CountPixel countPixel = new ST4I.Vision.Module.CountPixel();
            countPixel.LowerValueThreshold = 153;
            countPixel.UpperValueThreshold = 255;


            using (var img = Sv.ImRead("Images/Image 00089.jpg", ImreadModes.Grayscale))
            {
                Collection<int> kq2 = countPixel.CalcHistogram(img);
                var KQ_DST = new int[]
        {
            38088,11271,7379,6005,5291,4622,3932,3364,2868,2558,2391,2180,1930,1901,1700,1694,1653,1513,1413,1201,1086,
            1009,991,930,923,874,808,863,792,812,769,773,749,747,703,666,720,668,630,631,598,624,592,637,603,596,619,589,
            611,623,620,607,628,617,643,601,607,597,622,617,607,615,576,588,580,595,633,576,599,559,563,545,551,554,573,650,
            831,899,1257,1360,1789,2352,3297,3367,3366,3172,3006,3606,4625,4087,3037,2566,1700,1518,1373,1125,952,914,626,666,
            654,649,638,720,730,642,685,672,716,705,705,685,759,722,588,674,643,583,614,581,627,578,534,517,489,514,487,468,419,
            421,431,402,381,370,345,388,348,329,364,367,342,321,314,305,354,317,283,316,324,326,309,305,320,307,307,322,288,292,
            313,306,269,284,296,284,315,291,284,290,280,297,264,266,283,262,280,278,292,255,258,267,258,282,269,255,268,242,265,
            250,265,248,269,260,271,251,266,261,274,297,281,295,285,246,219,265,278,236,261,241,251,228,205,222,226,230,220,254,
            217,242,224,224,240,240,213,216,225,230,221,214,208,187,210,233,259,229,244,237,256,286,286,303,319,344,373,413,501,
            485,636,681,826,860,1104,1239,1524,1850,2291,52702
        };
                string test = "";
                for (int id = 0; id < kq2.Count; id++)
                {
                    test += $"{kq2[id]},";
                }
                for (var idx = 0; idx < kq2.Count; idx++)
                {
                    if (KQ_DST[idx] != kq2[idx])
                    {
                        Assert.Fail($"Lỗi dữ liệu thứ {idx} - Dữ liệu mong muốn: {KQ_DST[idx]}, Dữ liệu thực tế: {test}");
                    }
                }
            }
        }

        [TestMethod]
        public void TestHistoryData2()
        {
            ST4I.Vision.Module.CountPixel countPixel = new ST4I.Vision.Module.CountPixel();
            countPixel.LowerValueThreshold = 153;
            countPixel.UpperValueThreshold = 255;


            using (var img = Sv.ImRead("Images\\Image 03305.jpg", ImreadModes.Grayscale))
            {
                Collection<int> kq2 = countPixel.CalcHistogram(img);
                var KQ_DST = new int[]
        {
            47422,14999,7970,7039,6103,5807,5105,4281,3900,3220,2948,2573,2234,1957,1759,1640,1552,1411,1371,1207,1089,
            1008,959,911,879,845,807,793,741,739,728,704,638,644,619,627,612,594,585,624,586,626,660,579,620,636,641,632,
            606,632,658,674,600,537,565,591,583,619,601,574,609,517,559,559,589,541,544,499,525,485,499,501,565,711,915,1134,
            1793,2158,2560,2693,2702,2681,2343,2003,2088,2632,2234,2028,1775,1363,1086,803,723,536,495,507,504,491,466,493,531,
            479,482,470,474,508,543,505,556,567,535,523,536,525,582,584,540,565,532,517,521,504,472,490,469,484,438,477,401,450,
            511,399,371,380,401,361,427,340,356,335,337,350,322,313,321,248,290,288,261,248,225,208,197,210,245,194,186,193,201,
            206,174,168,184,179,198,205,162,178,171,175,172,196,178,157,181,160,164,192,166,169,191,178,157,161,161,158,160,187,
            176,162,155,180,183,174,156,162,181,185,153,168,161,180,176,165,154,171,167,144,149,140,170,145,142,152,162,151,131,
            149,175,130,151,176,160,172,170,148,143,162,139,175,152,149,156,182,171,175,168,189,205,211,221,263,290,352,352,421,
            474,565,623,736,831,940,1172,1357,1543,60718,
        };
                string test = "";
                for (int id = 0; id < kq2.Count; id++)
                {
                    test += $"{kq2[id]},";
                }
                for (var idx = 0; idx < kq2.Count; idx++)
                {
                    if (KQ_DST[idx] != kq2[idx])
                    {
                        Assert.Fail($"Lỗi dữ liệu thứ {idx} - Dữ liệu mong muốn: {KQ_DST[idx]}, Dữ liệu thực tế: {test}");
                    }
                }
            }
        }

        [TestMethod]
        public void TestHistoryData3()
        {
            ST4I.Vision.Module.CountPixel countPixel = new ST4I.Vision.Module.CountPixel();
            countPixel.LowerValueThreshold = 153;
            countPixel.UpperValueThreshold = 255;


            using (var img = Sv.ImRead("Images\\Image 07154.jpg", ImreadModes.Grayscale))
            {
                Collection<int> kq2 = countPixel.CalcHistogram(img);
                var KQ_DST = new int[]
        {
            41789,13324,7670,6525,6248,5337,4363,3749,3231,2741,2563,2326,2081,1992,1883,1668,1601,1489,1377,1283,1170,
            1093,1085,1016,969,968,938,944,991,907,897,857,782,814,815,816,804,742,755,857,749,791,725,680,717,743,688,
            693,695,706,729,727,706,670,712,771,711,657,686,630,629,643,662,654,621,618,589,598,559,628,656,573,572,758,
            866,1013,1148,1171,1481,1990,2136,2474,3119,3108,2927,3256,2894,3035,4504,3796,2552,2388,2056,1699,1278,1094,
            803,745,616,671,600,671,645,705,667,675,716,712,680,670,724,658,676,603,642,641,635,569,593,551,518,545,525,475,
            461,463,465,404,354,340,372,318,307,299,320,299,255,290,307,294,268,237,254,261,248,207,242,260,220,251,233,251,
            241,235,211,214,251,202,253,233,223,245,213,228,221,182,202,212,213,193,215,185,225,212,193,196,215,222,187,179,
            174,200,222,191,208,191,181,179,225,199,216,185,207,215,212,203,240,201,179,234,183,197,180,169,194,191,182,221,
            183,175,192,213,188,193,170,178,181,177,201,182,186,152,187,179,183,183,210,180,163,195,200,200,176,193,197,214,
            205,218,220,217,261,280,309,320,377,420,458,593,626,687,855,985,1146,1415,1786,48209,
        };
                string test = "";
                for (int id = 0; id < kq2.Count; id++)
                {
                    test += $"{kq2[id]},";
                }
                for (var idx = 0; idx < kq2.Count; idx++)
                {
                    if (KQ_DST[idx] != kq2[idx])
                    {
                        Assert.Fail($"Lỗi dữ liệu thứ {idx} - Dữ liệu mong muốn: {KQ_DST[idx]}, Dữ liệu thực tế: {test}");
                    }
                }
            }
        }
    }
}
