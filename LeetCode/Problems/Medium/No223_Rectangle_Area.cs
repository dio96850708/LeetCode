using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Medium
{
    public class No223_Rectangle_Area
    {
        public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
        {
            int Area1 = (ax2 - ax1) * (ay2 - ay1);
            int Area2 = (bx2 - bx1) * (by2 - by1);
            int overlapWidth = Math.Min(ax2, bx2) - Math.Max(ax1, bx1);
            int overlapHeight = Math.Min(ay2, by2) - Math.Max(ay1, by1);
            return Area1 + Area2 - Math.Max(overlapWidth, 0) * Math.Max(overlapHeight, 0);
        }
    }
}
