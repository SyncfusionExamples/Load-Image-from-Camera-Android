using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Threading.Tasks;
using Android.Content;
using Syncfusion.SfImageEditor.Android;
using Android.Provider;
using Java.IO;
using Android.Net;
using Android.Graphics;
using System;
using Android.Content.PM;
using Environment = Android.OS.Environment;
using System.Collections.Generic;
using Uri = Android.Net.Uri;
using Android.Support.V4.Content;
using Android.Graphics.Drawables;
using System.IO;
using File = Java.IO.File;
using Java.Lang;

namespace IE_LoadFromCamera
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private File directory;
        private SfImageEditor editor;
        public Java.IO.File cameraFile;
        private Bitmap bitmap = null;

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (bitmap != null)
            {
                bitmap.Dispose();
            }
            bitmap = GetBitmap(cameraFile.Path);
            editor.Bitmap = bitmap;
        }

        public static Bitmap GetBitmap(string fileName)
        {
            BitmapFactory.Options options = new BitmapFactory.Options
            {
                InPurgeable = true,
                InJustDecodeBounds = false
            };
            Bitmap resizedBitmap = BitmapFactory.DecodeFile(fileName, options);

            return resizedBitmap;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            LinearLayout layout = new LinearLayout(this);
            layout.Orientation = Orientation.Vertical;
            Button button = new Button(this);
            button.Text = "Load image from camera";
            editor = new SfImageEditor(this);
            layout.AddView(button);

            layout.AddView(editor);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(layout);
            CreateDirectoryForPictures();
            button.Click += InitializeCamera;
        }

        private void CreateDirectoryForPictures()
        {
            directory = new File(Environment.GetExternalStoragePublicDirectory(Environment.DirectoryPictures), "CameraAppDemo");
            if (!directory.Exists())
            {
                directory.Mkdirs();
            }
        }

        private void InitializeCamera(object sender, EventArgs eventArgs)
        {

            Intent intent = new Intent(MediaStore.ActionImageCapture);
            var documentsDirectry = ApplicationContext.GetExternalFilesDir(Android.OS.Environment.DirectoryPictures);
            cameraFile = new Java.IO.File(documentsDirectry, "default_image" + "." + FileFormatEnum.JPEG.ToString());
            Android.Net.Uri photoURI = FileProvider.GetUriForFile(ApplicationContext, ApplicationContext.PackageName+".provider", cameraFile);
            intent.PutExtra(MediaStore.ExtraOutput, photoURI);        
            StartActivityForResult(intent, 0);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }

    public enum FileFormatEnum
    {
        PNG,
        JPEG
    }
}