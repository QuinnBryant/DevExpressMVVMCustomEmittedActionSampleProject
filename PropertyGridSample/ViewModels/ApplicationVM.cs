using System.Collections.Generic;
using DevExpress.Mvvm.DataAnnotations;

namespace PropertyGridSample.ViewModels
{
    [POCOViewModel]
    public class ApplicationViewModel
    {
        /// <summary>
        /// The list of all viewModels that will be displayed in the property grid.
        /// </summary>
        public virtual List<object> SelectedViewModels { get; set; } = new List<object>();

        public ApplicationViewModel()
        {
            var rectangle = RectangleViewModel.Create();
            rectangle.Name = "Rectangle 1";

            SelectedViewModels.Add(rectangle);
        }

    }
}