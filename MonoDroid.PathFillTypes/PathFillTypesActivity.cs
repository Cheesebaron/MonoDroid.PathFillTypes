using Android.App;
using Android.Content;
using Android.OS;

namespace MonoDroid.PathFillTypes
{
    [Activity(Label = "PathFill Types", MainLauncher = true, Icon = "@drawable/icon")]
    public class PathFillTypesActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(new PathFillSampleView(this));
        }
    }
}