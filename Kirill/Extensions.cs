using System.Drawing;
using System.Drawing.Drawing2D;

public static class Extensions
{
    public static Image RotateImage(this Image img, float rotationAngle)
    {
        // тут кароче барабон как пустое изображение с учетом поворота
        Bitmap bmp = new Bitmap(img.Width, img.Height);
        using (Graphics g = Graphics.FromImage(bmp))
        {
            g.TranslateTransform((float)img.Width / 2, (float)img.Height / 2);
            g.RotateTransform(rotationAngle);
            g.TranslateTransform(-(float)img.Width / 2, -(float)img.Height / 2);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(img, new Point(0, 0));
        }
        return bmp;
    }
}