using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class XtoriumGradientPanel : Panel
{
    System.Drawing.Color mStartColor;
    System.Drawing.Color mEndColor;

    //Properties  STARTCOLOR and ENDCOLOR to give the Gradient Effect
    public System.Drawing.Color StartColor
    {
        get
        {
            return mStartColor;
        }
        set
        {
            mStartColor = value;
            PaintGradient();
        }
    }
    public System.Drawing.Color EndColor
    {
        get
        {
            return mEndColor;
        }
        set
        {
            mEndColor = value;
            PaintGradient();
        }
    }


    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
    }

    #region GradientPanel
    private void PaintGradient()
    {
        System.Drawing.Drawing2D.LinearGradientBrush gradBrush;
        gradBrush = new System.Drawing.Drawing2D.LinearGradientBrush(new Point(0, 0),
        new Point(this.Width, this.Height), StartColor, EndColor);
        Bitmap bmp = new Bitmap(this.Width, this.Height);
        Graphics g = Graphics.FromImage(bmp);
        g.FillRectangle(gradBrush, new Rectangle(0, 0, this.Width, this.Height));
        this.BackgroundImage = bmp;
        this.BackgroundImageLayout = ImageLayout.Stretch;
    }
    #endregion
}