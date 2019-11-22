using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;

namespace PropertyGridSample.ViewModels
{
    [POCOViewModel]
    public class ViewModelBase
    {
        public virtual string Name { get; set; }

        /// <summary>
        /// This is our injected property that will be called each properties set method. 
        /// This specific method checks for Unit type properties, and registers the RaisePropertyChanged event as needed.
        /// </summary>
        /// <param name="oldPoperty">Old object before modification in the set method</param>
        /// <param name="newProperty">New object after modification in the set method</param>
        /// <param name="viewModel"></param> The viewmodel associated for with the associated property, needed for RaisePropertyChanged() calls.
        /// <param name="propertyName"></param> The property name, needed for RaisePropertyChanged calls.
        public static void InjectedSetMethod(object oldPoperty, object newProperty, object viewModel, string propertyName)
        {
            if (!Object.Equals(oldPoperty, newProperty))
            {
                if (oldPoperty is IUnit || newProperty is IUnit)
                {
                    var pocoVM = viewModel as IPOCOViewModel;

                    void Handler(object s, UnitValueChangedEventArgs e) => pocoVM?.RaisePropertyChanged(propertyName);

                    if (oldPoperty != null)
                    {
                        (oldPoperty as IUnit).ValueChanged -= Handler;
                    }

                    oldPoperty = newProperty;

                    if (newProperty != null)
                    {
                        (newProperty as IUnit).ValueChanged += Handler;
                    }

                    pocoVM?.RaisePropertyChanged(propertyName);
                }
            }
        }

    }

}