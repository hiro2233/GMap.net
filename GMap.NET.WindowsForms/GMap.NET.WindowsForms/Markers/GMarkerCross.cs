﻿
namespace GMap.NET.WindowsForms.Markers
{
   using System.Drawing;

   public class GMarkerCross : GMapMarker
   {
      public Pen Pen;

      public GMarkerCross(PointLatLng p)
         : base(p)
      {
#if !PocketPC
         Pen = new Pen(Brushes.Red, 1);
#else
         Pen = new Pen(Color.Red, 1);
#endif
      }

      public override void OnRender(Graphics g)
      {
         System.Drawing.Point p1 = new System.Drawing.Point(TopLeft.X, TopLeft.Y);
         p1.Offset(0, -10);
         System.Drawing.Point p2 = new System.Drawing.Point(TopLeft.X, TopLeft.Y);
         p2.Offset(0, 10);

         System.Drawing.Point p3 = new System.Drawing.Point(TopLeft.X, TopLeft.Y);
         p3.Offset(-10, 0);
         System.Drawing.Point p4 = new System.Drawing.Point(TopLeft.X, TopLeft.Y);
         p4.Offset(10, 0);

         g.DrawLine(Pen, p1.X, p1.Y, p2.X, p2.Y);
         g.DrawLine(Pen, p3.X, p3.Y, p4.X, p4.Y);
      }
   }
}