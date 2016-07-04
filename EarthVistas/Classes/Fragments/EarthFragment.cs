using System;
using Android.OS;
using Android.Views;
using Android.Widget;
using CheeseBind;
using Square.Picasso;
using ReddOnXam;

namespace EarthVistas
{
    public class EarthFragment : Android.Support.V4.App.Fragment
    {

        /** CLASS VARIABLES ____________________________________________________________________ **/

        // IMAGE VARIABLES
        private static int MAX_IMAGE_WIDTH = 1080;
        private static int MAX_IMAGE_HEIGHT = 720;
        private String earthImageName;
        private String earthImageUrl;

        // VIEW INJECTION VARIABLES
        [BindView(Resource.Id.earth_fragment_image)]
        ImageView earthImage;
        [BindView(Resource.Id.earth_fragment_text)]
        TextView earthText;

        /** CONSTRUCTOR METHODS ________________________________________________________________ **/

        // EarthFragment(): Constructor method for Earth Fragment. Sets an initial name and image URL
        // for the EarthFragment.            
        public EarthFragment(String imageName, String imageUrl)
        {
            this.earthImageName = imageName;
            this.earthImageUrl = imageUrl;
        }

        /** FRAGMENT LIFECYCLE METHODS _________________________________________________________ **/

        // OnCreateView(): Creates and returns the view hierarchy associated with the fragment.
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View earthFragmentView = inflater.Inflate(Resource.Layout.EarthFragment, container, false);
            Cheeseknife.Bind(this, earthFragmentView); // Binds this fragment with Cheeseknife. 

            initImage();
            initText();

            return earthFragmentView;
        }

        /** LAYOUT METHODS _____________________________________________________________________ **/

        // initImage(): Initializes the ImageView.
        private void initImage()
        {
            // Loads the earth image URL and sets it to the earthImage ImageView.
            Picasso.With(Context)
                .Load(earthImageUrl)
                .Resize(MAX_IMAGE_WIDTH, MAX_IMAGE_HEIGHT)
                .CenterCrop()
                .Into(earthImage);
        }

        // initText(): Initializes the TextView.
        private void initText()
        {
            earthText.Text = earthImageName; // Sets the earth vista name to the TextView.
        }
    }
}