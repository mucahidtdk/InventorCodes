                item.angle = -1*(Math.Atan2(item.vector2.Y - item.vector1.Y, item.vector2.X - item.vector1.X));
                //values go from -180 to 180. I convert from 0 to 360 with the code below.
                if (item.angle<0 && item.angle>-Math.PI)
                {
                    item.angle -= Math.PI;
                    item.angle *= -1;
                }
                else if (item.angle == -0|| item.angle == -Math.PI)
                {
                    item.angle *= -1;
                }
