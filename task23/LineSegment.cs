using static System.Net.Mime.MediaTypeNames;

internal class LineSegment
{
    private double x;
    private double y;

    public LineSegment()
    {
        x = 0;
        y = 1;
    }
    public LineSegment(double x, double y)
    {
        if (x <= y)
        {
            this.x = x;
            this.y = y;
        }
        else
        {
            throw new ArgumentException("Координата начала не может быть больше координаты конца");
        }
    }

    public static double operator !(LineSegment sec)
    {
        return sec.y - sec.x;
    }
    public static LineSegment operator ++(LineSegment sec)
    {
        return new LineSegment(--sec.x, ++sec.y);
    }
    //явное
    public static explicit operator double(LineSegment sec)
    {
        return (double)sec.y;
    }
    //неявное
    public static implicit operator int(LineSegment sec)
    {
        return (int)sec.x;
    }
    public static LineSegment operator -(LineSegment sec, int num)
    {
        return new LineSegment(sec.x - num, sec.y);
    }
    public static LineSegment operator -(int num, LineSegment sec)
    {
        return new LineSegment(sec.x, sec.y - num);
    }
    public static bool operator <(LineSegment sec1, LineSegment sec2)
    {
        if (sec1.x <= sec2.y && sec2.x <= sec1.y)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool operator >(LineSegment sec1, LineSegment sec2)
    {
        if (sec1.x <= sec2.y && sec2.x <= sec1.y)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public override string ToString()
    {
        return "[" + x + "; " + y + "]";
    }
}