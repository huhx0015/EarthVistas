using Android.Support.V4.App;
using System.Collections.Generic;
using System;
using Android.App;

namespace EarthVistas
{
    class EarthPagerAdapter : FragmentPagerAdapter
    {

        /** CLASS VARIABLES ____________________________________________________________________ **/

        // LIST VARIABLES            
        private List<String> earthImageTitleList;
        private List<String> earthImageUrlList;

        /** CONSTRUCTOR METHODS ________________________________________________________________ **/

        public EarthPagerAdapter(Android.Support.V4.App.FragmentManager fm, List<String> titleList, List<String> imageList) : base (fm)
        {
            this.earthImageTitleList = titleList;
            this.earthImageUrlList = imageList;
        }

        /** PAGER ADAPTER METHODS ______________________________________________________________ **/

        public override int Count
        {
            get
            {
                if (earthImageUrlList != null)
                {
                    return earthImageUrlList.Count;
                }

                else
                {
                    return 0;
                }
            }
        }

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            return new EarthFragment(earthImageTitleList[position], earthImageUrlList[position]);
        }
    }
}