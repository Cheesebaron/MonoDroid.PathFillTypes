using Android.Content;
using Android.Util;
using Android.Views;
using Android.Graphics;

namespace MonoDroid.PathFillTypes
{
    public class PathFillSampleView : View
    {
        private Paint mPaint = new Paint(PaintFlags.AntiAlias);
        private Path mPath;

        public PathFillSampleView(Context context) : base(context) 
        {
            Initialize();
        }

        public PathFillSampleView(Context context, IAttributeSet attrs) :
            base(context, attrs)
        {
            Initialize();
        }

        public PathFillSampleView(Context context, IAttributeSet attrs, int defStyle) :
            base(context, attrs, defStyle)
        {
            Initialize();
        }

        private void Initialize()
        {
            mPath = new Path();
            mPath.AddCircle(40, 40, 45, Path.Direction.Ccw);
            mPath.AddCircle(80, 80, 45, Path.Direction.Ccw);
        }

        private void ShowPath(Canvas canvas, int x, int y, Path.FillType ft, Paint paint)
        {
            canvas.Save();
            canvas.Translate(x, y);
            canvas.ClipRect(0, 0, 120, 120);
            canvas.DrawColor(Color.White);
            mPath.SetFillType(ft);
            canvas.DrawPath(mPath, paint);
            canvas.Restore();
        }

        protected override void OnDraw(Canvas canvas)
        {
            Paint paint = mPaint;

            canvas.DrawColor(Color.Argb(255, 204, 204, 204));

            canvas.Translate(20, 20);
            paint.AntiAlias = true;

            ShowPath(canvas, 0, 0, Path.FillType.Winding, paint);
            ShowPath(canvas, 160, 0, Path.FillType.EvenOdd, paint);
            ShowPath(canvas, 0, 160, Path.FillType.InverseWinding, paint);
            ShowPath(canvas, 160, 160, Path.FillType.InverseEvenOdd, paint);
        }
    }
}