namespace GettingStarted
{
    using Syncfusion.Maui.ProgressBar;
    using System.Collections.ObjectModel;

    public class ViewModel
    {
        /// <summary>
        /// The Step progress bar item collection.
        /// </summary>
        private ObservableCollection<StepProgressBarItem> stepProgressItem;

        /// <summary>
        /// The Step progress bar item collection.
        /// </summary>
        public ObservableCollection<StepProgressBarItem> StepProgressItem
        {
            get
            {
                return stepProgressItem;
            }
            set
            {
                stepProgressItem = value;
            }
        }

        public ViewModel()
        {
            stepProgressItem = new ObservableCollection<StepProgressBarItem>();
            stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Cart" });
            stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Address" });
            stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Delivery" });
            stepProgressItem.Add(new StepProgressBarItem() { PrimaryText = "Ordered" });
        }
    }
}