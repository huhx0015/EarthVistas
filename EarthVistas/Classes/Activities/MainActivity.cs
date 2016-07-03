using System;
using Android.App;
using Android.OS;
using CheeseBind;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Refit;
using System.Collections.Generic;
using Android.Util;
using Android.Widget;
using ReddOnXam;
using Android.Views;

namespace EarthVistas
{
    [Activity(Label = "Earth Vistas", MainLauncher = true, Theme = "@style/Theme.AppCompat.Light", Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity
    {

        /** CLASS VARIABLES ____________________________________________________________________ **/

        // IMAGE VARIABLES
        private static int MAX_EARTH_IMAGES = 10; // Sets the maximum number of images to load.

        // LOGGING VARIABLES
        private static String LOG_TAG = "MainActivity";

        // REFIT VARIABLES
        private static String BASE_URL = "https://www.reddit.com"; // Base API URL for Reddit.

        // VIEW INJECTION VARIABLES
        [BindView(Resource.Id.main_activity_progress_bar)]
        ProgressBar mainActivityProgressBar;
        [BindView(Resource.Id.main_activity_error_text)]
        TextView mainActivityErrorText;
        [BindView(Resource.Id.main_activity_viewpager)]
        ViewPager mainActivityViewPager;

        /** ANDROID LIFECYCLE METHODS _________________________________________________________ **/

        // onCreate(): The initial function that is called when the activity is run. onCreate() only runs
        // when the activity is first started.
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            initView(); // Initializes the view for this activity.
            fetchVistas(); 
        }

        /** LAYOUT METHODS __________________________________________________________________ **/

        // initView(): Initializes the view for this activity.
        private void initView()
        {
            SetContentView(Resource.Layout.Main); // Sets the AXML layout to this activity.
            Cheeseknife.Bind(this); // Binds this activity with Cheeseknife.
        }

        // initPager(): Initializes the ViewPager for this activity.
        private void initPager(List<String> titleList, List<String> imageList)
        {

            // Initializes and creates a new FragmentPagerAdapter object.
            PagerAdapter earthPagerAdapter = new EarthPagerAdapter(SupportFragmentManager, titleList, imageList);
            mainActivityViewPager.Adapter = earthPagerAdapter; // Sets the PagerAdapter object for the activity.
        }

        private async void fetchVistas()
        {
            Log.Debug(LOG_TAG, "fetchVistas(): Preparing Refit client to retrieve Reddit REST data...");

            var client = RestService.For<RetrofitInterface>(BASE_URL);
            RootObject redditPostsRoot = await client.ListVistas();

            if (redditPostsRoot != null && redditPostsRoot.data != null && redditPostsRoot.data.children != null && redditPostsRoot.data.children.Count > 0)
            {
                // Sets the Reddit post list.
                List<Child> redditPostList = redditPostsRoot.data.children;

                // Sets the Reddit post count size.
                int redditPostListSize = redditPostsRoot.data.children.Count;

                // Initializes the earth images list that will store the URLs to the earth vista images and names.
                List<String> earthTitleList = new List<String>();
                List<String> earthImageList = new List<String>();

                // Recursively parses through the post data to retrieve the String image names and URLs.
                for (int i = 0; i < MAX_EARTH_IMAGES; i++)
                {
                    // Parses through the post data to retrieve the image title and URL and adds it to the lists.
                    try {
                        String imageTitle = redditPostList[i].data.title;
                        String imageUrl = redditPostList[i].data.preview.images[0].source.url;

                        if (imageTitle != null && imageUrl != null) {
                            earthTitleList.Add(imageTitle);
                            earthImageList.Add(imageUrl);
                        }
                    }

                    // Null exception handler.
                    catch (NullReferenceException e)
                    {
                        Log.Error(LOG_TAG, "fetchVistas(): ERROR: Null pointer exception encountered while parsing through post " + i + ":" + e.Message);
                    }
                }

                mainActivityProgressBar.Visibility = ViewStates.Gone; // Hides the progress bar.
                initPager(earthTitleList, earthImageList); // Initializes the ViewPager.
            }

            else
            {
                mainActivityProgressBar.Visibility = ViewStates.Gone; // Hides the progress bar.
                mainActivityErrorText.Visibility = ViewStates.Visible; // Displays the error message.
                Log.Error(LOG_TAG, "fetchVistas(): ERROR: Reddit post data was null.");
            }
        }
    }
}

