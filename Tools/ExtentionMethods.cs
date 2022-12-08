using System.ComponentModel.DataAnnotations;
namespace Tools
{
	public class ExtentionMethods
	{
		public ExtentionMethods()
		{
		}
	}

    /**
     * Custom method for validating the Birthdate in the WebAPI using a custom RangeAttribute
     * that uses the constants Minimum and Maximum age.
     */
    public class RangeValidAge : RangeAttribute
    {
        // uses the current time and creates a lower and upper range based on the constants MinimumAge and MaximumAge
        private static string upperLimit = Convert.ToString(DateTime.Now.AddYears(-Constants.MaximumAge));
        private static string lowerLimit = Convert.ToString(DateTime.Now.AddYears(-Constants.MinimumAge));
        //private static string upperLimit = Convert.ToString(Convert.ToDateTime(DateTime.Now.Year - Constants.MaximumAge));
        //private static string lowerLimit = Convert.ToString(Convert.ToDateTime(DateTime.Now.Year - Constants.MinimumAge));

        public RangeValidAge() : base(typeof(DateTime), upperLimit, lowerLimit)
        {

        }
    }
}

