using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;

namespace PropertyGridSample.ViewModels
{
    [POCOViewModel]
    public class RectangleViewModel : ViewModelBase
    {
        private Unit _mass = new Unit("gram");

        /// <summary>
        /// Length and Widht Unit properties show the new and ideal Unit setup when the InjectedSetMethod is passed as a parameter in the ViewModelSource.Create() method.
        /// </summary>
        public virtual Unit Length { get; set; }
        public virtual Unit Width { get; set; }

        /// <summary>
        /// The Mass Unit property here shows extra setter logic that was needed to allow a Unit property to trigger PropertyChanged events from it's sub-property (Value).
        /// This is not the ideal implementation due to readability.
        /// </summary>
        public virtual Unit Mass
        {
            get { return _mass; }
            set
            {
                InjectedSetMethod(_mass, value, this, "Mass");
                _mass = value;
            }
        }

        public static RectangleViewModel Create()
        {
            // Old ViewModelSource.Create call. 
            //var newRectangle = ViewModelSource.Create<RectangleViewModel>();

            //Modified ViewModelSource.Create method that will take a method as a parameter which is injected into all property setters in the MSIL.
            //This is similar to how DevExpressMVVM.WPF injects PropertyChanged methods.
            //We kept the paramters of the expected action general so that this functionality can be used in other situations.
            // Comment this line and Uncomment the line above to see previous functionality without the injected method.
            var newRectangle = ViewModelSource.Create<RectangleViewModel>(InjectedSetMethod);

            newRectangle.Width = new Unit("meter");
            newRectangle.Length = new Unit("meter");
            newRectangle.Mass = new Unit("gram");

            return newRectangle;
        }

    }
}