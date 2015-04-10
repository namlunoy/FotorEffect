using FotorEffect.Common;
using Nokia.Graphics.Imaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace FotorEffect
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EditImagePage : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();
        private double h = 0;
        private double w = 0;
        public EditImagePage()
        {
            this.InitializeComponent();

            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;

            HieuUngXoay90.Completed += HieuUngXoay90_Completed;
            xImage.Source = App.photo.OriginalBitmap;

        }

        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }


        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        { }

        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        { }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            h = xImage.ActualHeight;
            w = xImage.ActualWidth;

            Debug.WriteLine("xh = "+h+"\nxw = "+w);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        { }


        private void clickRotateImage(object sender, RoutedEventArgs e)
        {
            btRotateImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
           // btCropImage.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            btAcceptRotate.Visibility = Windows.UI.Xaml.Visibility.Visible;
            btRotate.Visibility = Windows.UI.Xaml.Visibility.Visible;
            btCancel.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }

        private void clickRotate(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Trước:\nh = " + xImage.ActualHeight + "\nw = " + xImage.ActualWidth);

            HieuUngXoay90.Begin();

        }
        private void clickCancelRotate(object sender, RoutedEventArgs e)
        {
            btRotateImage.Visibility = Visibility.Visible;
           // btCropImage.Visibility = Visibility.Visible;

            btAcceptRotate.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            btRotate.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            btCancel.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            begin.Value = 0;
            end.Value = 0;
            HieuUngXoay90.Begin();
        }

        private async void clickAcceptRotateImage(object sender, RoutedEventArgs e)
        {
            btRotateImage.Visibility = Visibility.Visible;
          //  btCropImage.Visibility = Visibility.Visible;

            btAcceptRotate.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            btRotate.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            btCancel.Visibility = Windows.UI.Xaml.Visibility.Collapsed;


            await App.photo.ApplyRotationFilterAsync(-begin.Value);
            Debug.WriteLine("Thưc hiện quay: " + (-begin.Value));
            App.photo.IsSaved = false;
            begin.Value = 0;
            end.Value = 0;
            xImage.Source = App.photo.OriginalBitmap;

            HieuUngXoay90.Begin();
        }



        void HieuUngXoay90_Completed(object sender, object e)
        {
            //xImage.Source = App.photo.OriginalBitmap;

            begin.Value = end.Value;
            end.Value = end.Value - 90;
            Debug.WriteLine("begin = " + begin.Value + " - end = " + end.Value);
        }

        private void CanLaiAnh()
        {
            Debug.WriteLine("Sau:\nh = " + xImage.ActualHeight + "\nw = " + xImage.ActualWidth);

            //xImage.Height = xImage.ActualWidth;
            //xImage.Width = xImage.ActualHeight;
        }

        private void clickCropImage(object sender, RoutedEventArgs e)
        {

        }









    }
}
