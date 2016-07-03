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

        private void initImage()
        {
            // Loads the earth image URL and sets it to the earthImage ImageView.
            Picasso.With(Context)
                .Load(earthImageUrl)
                .Into(earthImage);
        }

        private void initText()
        {
            earthText.Text = earthImageName; // Sets the earth vista name to the TextView.
        }
    }
}