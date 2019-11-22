using System.Collections.ObjectModel;
using System.Windows;
using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.Xpf.Editors.Validation;

namespace PropertyGridSample
{
    //public class PropertyGridValidationBehavior : Behavior<PropertyGridControlEx>
    //{
    //    #region Fields

    //    public static readonly DependencyProperty ErrorsFromPropertyGridProperty =
    //        DependencyProperty.Register(
    //            "ErrorsFromPropertyGrid",
    //            typeof(ReadOnlyObservableCollection<BaseValidationError>),
    //            typeof(StackPanelValidationBehavior),
    //            new PropertyMetadata(null, OnErrorsFromPropertyGridChangedCallback));

    //    //public static readonly DependencyProperty ErrorsToVMProperty =
    //    //  DependencyProperty.Register("ErrorsToVM",
    //    //      typeof(ObservableCollection<MyErrorObject>),
    //    //      typeof(StackPanelValidationBehavior),
    //    //      new PropertyMetadata(new ObservableCollection<MyErrorObject>()));

    //    #endregion Fields

    //    #region Properties

    //    /// <summary>
    //    /// Gets or sets the backing collection used to manage validation errors associated with the dock panel validation container.
    //    /// </summary>
    //    public ReadOnlyObservableCollection<BaseValidationError> ErrorsFromPropertyGrid
    //    {
    //        get { return (ReadOnlyObservableCollection<BaseValidationError>)GetValue(ErrorsFromPropertyGridProperty); }
    //        set { SetValue(ErrorsFromPropertyGridProperty, value); }
    //    }

    //    //public ObservableCollection<MyErrorObject> ErrorsToVM
    //    //{
    //    //    get { return (ObservableCollection<MyErrorObject>)GetValue(ErrorsToVMProperty); }
    //    //    set { SetValue(ErrorsToVMProperty, value); }
    //    //}

    //    #endregion Properties

    //    #region Methods

    //    private static void OnErrorsFromPropertyGridChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
    //    {
    //        var propGrid = d as PropertyGridControlEx;

    //        if (Compare(e.NewValue, e.OldValue))
    //        {

    //            //Messenger.Default.Send<ValidationsChangedMessage>(new ValidationsChangedMessage());
    //        }
    //    }

    //    private static bool Compare(object newValue, object oldValue)
    //    {
    //        try
    //        {
    //            if (newValue == null)
    //            {
    //                return false;
    //            }

    //            if (oldValue == null)
    //            {
    //                return true;
    //            }

    //            var newValueCollection = (ReadOnlyObservableCollection<BaseValidationError>)newValue;
    //            var oldValueCollection = (ReadOnlyObservableCollection<BaseValidationError>)oldValue;
    //            var newMessages = newValueCollection.Where(x => x != null).Select(x => x.ErrorContent.ToString());
    //            var oldMessages = oldValueCollection.Where(x => x != null).Select(x => x.ErrorContent.ToString());

    //            var ids = newMessages.Except(oldMessages);
    //            var ids2 = oldMessages.Except(newMessages);
    //            return ids.Count() > 0 || ids2.Count() > 0;
    //        }
    //        catch
    //        {
    //            return false;
    //        }
    //    }
    //    #endregion Methods
    //}
}

