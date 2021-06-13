using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using IGExtensions.Framework.Controls;

namespace IGExtensions.Common.Controls
{
    [TemplatePart(Name = NavigationButtonImageName, Type = typeof(Image))]
    [TemplatePart(Name = NavigationButtonTextBlockName, Type = typeof(TextBlock))]
    public class NavigationSampleLink : NavigationButton
    {
        public NavigationSampleLink()
        {
            this.DefaultStyleKey = typeof(NavigationSampleLink);
            this.Loaded += new RoutedEventHandler(NavigationSampleLink_Loaded);
        }
        void NavigationSampleLink_Loaded(object sender, RoutedEventArgs e)
        {
            if (this.NavigationButtonImage != null)
                this.NavigationButtonImage.Source = new BitmapImage(this.GetComponentImageUri());
            if (this.NavigationButtonTextBlock != null)
                this.NavigationButtonTextBlock.Text = this.GetComponentName();
            this.NavigationUri = this.GetComponentSampleUri();
        }

        #region Properties
        public const string ComponentPropertyName = "Component";
        public static readonly DependencyProperty ComponentProperty = DependencyProperty.Register(
            ComponentPropertyName, typeof(InfragisticsComponents), typeof(NavigationSampleLink),
         new PropertyMetadata(InfragisticsComponents.DataChart, (sender, e) =>
         {
             (sender as NavigationSampleLink).OnPropertyChanged(new PropertyChangedEventArgs(ComponentPropertyName));
         }));
        /// <summary>
        /// Gets or sets the Component property 
        /// </summary>
        public InfragisticsComponents Component
        {
            get { return (InfragisticsComponents)GetValue(ComponentProperty); }
            set { SetValue(ComponentProperty, value); }
        }

        private void OnPropertyChanged(PropertyChangedEventArgs ea)
        {
            if (ea.PropertyName == ComponentPropertyName)
            {
                if (!IsTemplateApplied) return;

                if (this.NavigationButtonImage != null)
                    this.NavigationButtonImage.Source = new BitmapImage(this.GetComponentImageUri());
                if (this.NavigationButtonTextBlock != null)
                    this.NavigationButtonTextBlock.Text = this.GetComponentName();
                this.NavigationUri = this.GetComponentSampleUri();
            }
        } 
        #endregion
        protected const string NavigationButtonImageName = "NavigationButtonImage";
        protected const string NavigationButtonTextBlockName = "NavigationButtonTextBlock";

        protected Image NavigationButtonImage;
        protected TextBlock NavigationButtonTextBlock;

        protected bool IsTemplateApplied;
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            NavigationButtonImage = base.GetTemplateChild(NavigationButtonImageName) as Image;
            NavigationButtonTextBlock = base.GetTemplateChild(NavigationButtonTextBlockName) as TextBlock;

            IsTemplateApplied = true;
        }


        #region Component Image

        private string GetComponentImagePath()
        {
            var path = "/IGExtensions.Common;component/Assets/Images/Controls/IG";

            if (this.Component == InfragisticsComponents.InfragisticsExcel)
                path += "Excel";
            else if (this.Component == InfragisticsComponents.InfragisticsMath)
                path += "MathLibrary";
            else if (this.Component == InfragisticsComponents.InfragisticsCompression)
                path += "Compression";
            else if (this.Component == InfragisticsComponents.InfragisticsWord)
                path += "Word";
            else if (this.Component == InfragisticsComponents.SyntaxParsingEngine)
                path += "SyntaxEditor";
            else
                path += this.Component;

            path += ".png";
            return path;
        }
        private Uri GetComponentImageUri()
        {
            var path = new Uri(GetComponentImagePath(), UriKind.RelativeOrAbsolute);
            return path;
        }
        #endregion
        #region Component Name
        private string GetComponentName()
        {
            var name = "";
            if (this.Component == InfragisticsComponents.BarcodeReader)
                name += "BarcodeReader";
            else if (this.Component == InfragisticsComponents.BulletGraph)
                name += "BulletGraph";
            else if (this.Component == InfragisticsComponents.CalculationManager)
                name += "CalculationManager";
            else if (this.Component == InfragisticsComponents.CarouselListbox)
                name += "CarouselListbox";
            else if (this.Component == InfragisticsComponents.CarouselPanel)
                name += "CarouselPanel";
            else if (this.Component == InfragisticsComponents.ColorPicker)
                name += "ColorPicker";
            else if (this.Component == InfragisticsComponents.InfragisticsCompression)
                name += "Infragistics Compression";
            else if (this.Component == InfragisticsComponents.ComboEditor)
                name += "ComboEditor";
            else if (this.Component == InfragisticsComponents.ContextMenu)
                name += "ContextMenu";
            else if (this.Component == InfragisticsComponents.DataCards)
                name += "DataCards";
            else if (this.Component == InfragisticsComponents.DataCarousel)
                name += "DataCarousel";
            else if (this.Component == InfragisticsComponents.DataChart)
                name += "DataChart";
            else if (this.Component == InfragisticsComponents.DataGrid)
                name += "DataGrid";
            else if (this.Component == InfragisticsComponents.DataPresenter)
                name += "DataPresenter";
            else if (this.Component == InfragisticsComponents.DataTree)
                name += "DataTree";
            else if (this.Component == InfragisticsComponents.DatePicker)
                name += "DatePicker";
            else if (this.Component == InfragisticsComponents.DialogWindow)
                name += "DialogWindow";
            else if (this.Component == InfragisticsComponents.DockManager)
                name += "DockManager";
            else if (this.Component == InfragisticsComponents.DragDropFramework)
                name += "Drag & Drop Framework";
            else if (this.Component == InfragisticsComponents.InfragisticsExcel)
                name += "Infragistics Excel";
            else if (this.Component == InfragisticsComponents.FormulaEditor)
                name += "FormulaEditor";
            else if (this.Component == InfragisticsComponents.GeographicMap)
                name += "GeographicMap";
            else if (this.Component == InfragisticsComponents.HtmlViewer)
                name += "HtmlViewer";
            else if (this.Component == InfragisticsComponents.InfragisticsMath)
                name += "Infragistics Math";
            else if (this.Component == InfragisticsComponents.MonthCalendar)
                name += "MonthCalendar";
            else if (this.Component == InfragisticsComponents.MultiColumnCombo)
                name += "MultiColumnCombo";
            else if (this.Component == InfragisticsComponents.NetworkNode)
                name += "NetworkNode";
            else if (this.Component == InfragisticsComponents.OrgChart)
                name += "OrgChart";
            else if (this.Component == InfragisticsComponents.OutlookBar)
                name += "OutlookBar";
            else if (this.Component == InfragisticsComponents.PersistenceFramework)
                name += "Persistence Framework";
            else if (this.Component == InfragisticsComponents.PieChart)
                name += "PieChart";
            else if (this.Component == InfragisticsComponents.PivotGrid)
                name += "PivotGrid";
            else if (this.Component == InfragisticsComponents.Reporting)
                name += "Reporting Framework";
            else if (this.Component == InfragisticsComponents.ResourceWasher)
                name += "ResourceWasher";
            else if (this.Component == InfragisticsComponents.SpellChecker)
                name += "SpellChecker";
            else if (this.Component == InfragisticsComponents.SyntaxEditor)
                name += "SyntaxEditor";
            else if (this.Component == InfragisticsComponents.SyntaxParsingEngine)
                name += "Syntax Parsing Engine";
            else if (this.Component == InfragisticsComponents.TabControl)
                name += "TabControl";
            else if (this.Component == InfragisticsComponents.TagCloud)
                name += "TagCloud";
            else if (this.Component == InfragisticsComponents.TileManager)
                name += "TileManager";
            else if (this.Component == InfragisticsComponents.TileView)
                name += "TileView";
            else if (this.Component == InfragisticsComponents.UndoRedo)
                name += "Undo / Redo Framework";
            else if (this.Component == InfragisticsComponents.VirtualCollection)
                name += "Virtual Collection";
            else if (this.Component == InfragisticsComponents.InfragisticsWord)
                name += "Infragistics Word";
            else
                name += this.Component;

            if (this.Component != InfragisticsComponents.InfragisticsMath &&
                this.Component != InfragisticsComponents.InfragisticsExcel &&
                this.Component != InfragisticsComponents.InfragisticsWord &&
                this.Component != InfragisticsComponents.InfragisticsCompression &&
                this.Component != InfragisticsComponents.DragDropFramework &&
                this.Component != InfragisticsComponents.ResourceWasher &&
                this.Component != InfragisticsComponents.UndoRedo &&
                this.Component != InfragisticsComponents.PersistenceFramework &&
                this.Component != InfragisticsComponents.VirtualCollection &&
                this.Component != InfragisticsComponents.Reporting &&
                this.Component != InfragisticsComponents.SyntaxParsingEngine)
                name = "Xam" + name;

            return name;
        }

        #endregion
        #region Component Sample
        private Uri GetComponentSampleUri()
        {
            var path = new Uri(GetComponentSamplePath(), UriKind.Absolute);
            return path;
        }

        private string GetComponentSamplePath()
        {
            var path = "http://www.infragistics.com/products/";
            
#if SILVERLIGHT
            path += "silverlight/";
#else
            path += "wpf/";
#endif
            var culture = NavigationApp.CurrentCultureName().ToLower();
            if (culture.Contains("jp"))
                path = "http://samples.jp.infragistics.com/sllob/";
            
            if (this.Component == InfragisticsComponents.BarcodeReader)
                path += "Barcode-Reader";
            else if (this.Component == InfragisticsComponents.BulletGraph)
                path += "Bullet-Graph";
            else if (this.Component == InfragisticsComponents.CalculationManager)
                path += "Calculation-Manager";
            else if (this.Component == InfragisticsComponents.CarouselListbox)
                path += "Carousel-Listbox";
            else if (this.Component == InfragisticsComponents.CarouselPanel)
                path += "Carousel-Panel";
            else if (this.Component == InfragisticsComponents.ColorPicker)
                path += "Color-Picker";
            else if (this.Component == InfragisticsComponents.InfragisticsCompression)
                path += "Infragistics-Compression";
            else if (this.Component == InfragisticsComponents.ComboEditor)
                path += "Combo-Editor";
            else if (this.Component == InfragisticsComponents.ContextMenu)
                path += "Context-Menu";
            else if (this.Component == InfragisticsComponents.DataCards)
                path += "Data-Cards";
            else if (this.Component == InfragisticsComponents.DataCarousel)
                path += "Data-Carousel";
            else if (this.Component == InfragisticsComponents.DataChart)
                path += "Data-Chart";
            else if (this.Component == InfragisticsComponents.DataGrid)
                path += "Data-Grid";
            else if (this.Component == InfragisticsComponents.DataPresenter)
                path += "Data-Presenter";
            else if (this.Component == InfragisticsComponents.DataTree)
                path += "Data-Tree";
            else if (this.Component == InfragisticsComponents.DatePicker)
                path += "Date-Picker";
            else if (this.Component == InfragisticsComponents.DialogWindow)
                path += "Dialog-Window";
            else if (this.Component == InfragisticsComponents.DockManager)
                path += "Dock-Manager";
            else if (this.Component == InfragisticsComponents.DragDropFramework)
                path += "Drag-Drop-Framework";
            else if (this.Component == InfragisticsComponents.InfragisticsExcel)
                path += "infragistics-Excel";
            else if (this.Component == InfragisticsComponents.FormulaEditor)
                path += "Formula-Editor";
            else if (this.Component == InfragisticsComponents.GeographicMap)
                path += "Geographic-Map";
            else if (this.Component == InfragisticsComponents.HtmlViewer)
                path += "Html-Viewer";
            else if (this.Component == InfragisticsComponents.InfragisticsMath)
                path += "infragistics-Math";
            else if (this.Component == InfragisticsComponents.MonthCalendar)
                path += "Month-Calendar";
            else if (this.Component == InfragisticsComponents.MultiColumnCombo)
                path += "MultiColumn-Combo";
            else if (this.Component == InfragisticsComponents.NetworkNode)
                path += "Network-Node";
            else if (this.Component == InfragisticsComponents.OrgChart)
                path += "Org-Chart";
            else if (this.Component == InfragisticsComponents.OutlookBar)
                path += "Outlook-Bar";
            else if (this.Component == InfragisticsComponents.PersistenceFramework)
                path += "Persistence-Framework";
            else if (this.Component == InfragisticsComponents.PieChart)
                path += "Pie-Chart";
            else if (this.Component == InfragisticsComponents.PivotGrid)
                path += "Pivot-Grid";
            else if (this.Component == InfragisticsComponents.Reporting)
                path += "wpf-reporting";
            else if (this.Component == InfragisticsComponents.ResourceWasher)
                path += "Resource-Washer";
            else if (this.Component == InfragisticsComponents.SpellChecker)
                path += "Spell-Checker";
            else if (this.Component == InfragisticsComponents.SyntaxEditor)
                path += "Syntax-Editor";
            else if (this.Component == InfragisticsComponents.SyntaxParsingEngine)
                path += "Syntax-Parsing-Engine";
            else if (this.Component == InfragisticsComponents.TabControl)
                path += "Tab-Control";
            else if (this.Component == InfragisticsComponents.TagCloud)
                path += "Tag-Cloud";
            else if (this.Component == InfragisticsComponents.TileManager)
                path += "Tile-Manager";
            else if (this.Component == InfragisticsComponents.TileView)
                path += "TileView";
            else if (this.Component == InfragisticsComponents.UndoRedo)
                path += "Undo";
            else if (this.Component == InfragisticsComponents.VirtualCollection)
                path += "Virtual-Collection";
            else if (this.Component == InfragisticsComponents.InfragisticsWord)
                path += "infragistics-Word";
            else
                path += this.Component;

            return path.ToLower();
        }

        #endregion
    }

    public enum InfragisticsComponents
    {
        Barcode,
        BarcodeReader,
        BulletGraph,
        CalculationManager,
        Calendar,
        CarouselListbox,
        CarouselPanel,
        ColorPicker,
        ComboEditor,
        InfragisticsCompression,
        ContextMenu,
        DataCards,
        DataCarousel,
        DataChart,
        DataGrid,
        DataPresenter,
        DataTree,
        DatePicker,
        DialogWindow,
        DockManager,
        DragDropFramework,
        Editors,
        InfragisticsExcel,
        FormulaEditor,
        FunnelChart,
        Gantt,
        Gauge,
        // TODO add support
        //RadialGauge,
        //LinearGauge,
        //RadialGauge, 
        GeographicMap,
        Grid,
        HtmlViewer,
        Inputs,
        Map,
        InfragisticsMath,
        //MathLibrary,
        Menu,
        MonthCalendar,
        MultiColumnCombo,
        NetworkNode,
        OrgChart,
        OutlookBar,
        PersistenceFramework,
        PieChart,
        PivotGrid,
        Reporting,
        ResourceWasher,
        Ribbon,
        Schedule,
        Slider,
        Sparkline,
        SpellChecker,
        SyntaxEditor,
        SyntaxParsingEngine,
        TabControl,
        TagCloud,
        TileManager,
        TileView,
        Timeline,
        Tree,
        Treemap,
        UndoRedo,
        VirtualCollection,
        // WebChart,
        InfragisticsWord,
        Zoombar,
    }

}