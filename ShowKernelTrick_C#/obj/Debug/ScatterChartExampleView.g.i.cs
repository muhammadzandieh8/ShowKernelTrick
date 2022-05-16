﻿#pragma checksum "..\..\ScatterChartExampleView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1CDF89B17DCF0F6DC103C71018A0D5E674680D5085F6D1B194973693B1745EE0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using SciChart.Charting;
using SciChart.Charting.ChartModifiers;
using SciChart.Charting.Common;
using SciChart.Charting.Common.AttachedProperties;
using SciChart.Charting.Common.Databinding;
using SciChart.Charting.Common.Extensions;
using SciChart.Charting.Common.Helpers;
using SciChart.Charting.Common.MarkupExtensions;
using SciChart.Charting.DrawingTools;
using SciChart.Charting.DrawingTools.TradingAnnotations;
using SciChart.Charting.DrawingTools.TradingAnnotations.FibonacciAnnotation;
using SciChart.Charting.DrawingTools.TradingAnnotations.Models;
using SciChart.Charting.DrawingTools.TradingModifiers;
using SciChart.Charting.HistoryManagers;
using SciChart.Charting.Model;
using SciChart.Charting.Model.ChartData;
using SciChart.Charting.Model.ChartSeries;
using SciChart.Charting.Model.DataSeries;
using SciChart.Charting.Numerics;
using SciChart.Charting.Numerics.CoordinateCalculators;
using SciChart.Charting.Numerics.CoordinateProviders;
using SciChart.Charting.Numerics.DeltaCalculators;
using SciChart.Charting.Numerics.TickProviders;
using SciChart.Charting.Themes;
using SciChart.Charting.ViewportManagers;
using SciChart.Charting.Visuals;
using SciChart.Charting.Visuals.Annotations;
using SciChart.Charting.Visuals.Axes;
using SciChart.Charting.Visuals.Axes.DiscontinuousAxis;
using SciChart.Charting.Visuals.Axes.LabelProviders;
using SciChart.Charting.Visuals.Axes.LogarithmicAxis;
using SciChart.Charting.Visuals.PointMarkers;
using SciChart.Charting.Visuals.RenderableSeries;
using SciChart.Charting.Visuals.RenderableSeries.Animations;
using SciChart.Charting.Visuals.Shapes;
using SciChart.Charting.Visuals.TradeChart;
using SciChart.Charting.Visuals.TradeChart.MultiPane;
using SciChart.Core.AttachedProperties;
using SciChart.Core.MarkupExtensions;
using SciChart.Core.Utility.Mouse;
using SciChart.Data.Model;
using SciChart.Data.Numerics;
using SciChart.Drawing;
using SciChart.Drawing.Common;
using SciChart.Drawing.Extensions;
using SciChart.Drawing.HighQualityRasterizer;
using SciChart.Drawing.HighSpeedRasterizer;
using SciChart.Drawing.XamlRasterizer;
using SciChart.Examples.ExternalDependencies.Behaviors;
using SciChart.Examples.ExternalDependencies.Common;
using SciChart.Examples.ExternalDependencies.Controls.SciChart3DInteractionToolbar;
using SciChart.Examples.ExternalDependencies.Controls.SciChartInteractionToolbar;
using SciChart.Examples.ExternalDependencies.Controls.SciChartInteractionToolbar.Converters;
using SciChart.Examples.ExternalDependencies.Controls.SciChartInteractionToolbar.CustomModifiers;
using SciChart.Examples.ExternalDependencies.Controls.SciChartInteractionToolbar.Extension;
using SciChart.Examples.ExternalDependencies.Data;
using SciChart.Examples.ExternalDependencies.Helpers;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace SciChart.Examples.Examples.CreateSimpleChart {
    
    
    /// <summary>
    /// ScatterChartExampleView
    /// </summary>
    public partial class ScatterChartExampleView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 62 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_Guassian1_X_Mean;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_Guassian1_X_StdDev;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_Guassian1_Y_Mean;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_Guassian1_Y_StdDev;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_Guassian1_Count;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Guassian1;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_Guassian2_X_Mean;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_Guassian2_X_StdDev;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_Guassian2_Y_Mean;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_Guassian2_Y_StdDev;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_Guassian2_Count;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Guassian2;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio_Random;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radio_User;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_W1;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_W2;
        
        #line default
        #line hidden
        
        
        #line 169 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_bias;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox btn_EpockeNumber;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_StepByStep;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Automatic;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_Weight0;
        
        #line default
        #line hidden
        
        
        #line 189 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_Weight1;
        
        #line default
        #line hidden
        
        
        #line 191 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid_Values;
        
        #line default
        #line hidden
        
        
        #line 213 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_a;
        
        #line default
        #line hidden
        
        
        #line 214 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid_As;
        
        #line default
        #line hidden
        
        
        #line 216 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SciChart.Charting.Visuals.SciChartSurface sciChart_a;
        
        #line default
        #line hidden
        
        
        #line 220 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SciChart.Charting.Visuals.RenderableSeries.FastLineRenderableSeries lineRenderSeries_a;
        
        #line default
        #line hidden
        
        
        #line 250 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Weights;
        
        #line default
        #line hidden
        
        
        #line 251 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datagrid_Weights;
        
        #line default
        #line hidden
        
        
        #line 252 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SciChart.Charting.Visuals.SciChartSurface sciChart_Weights;
        
        #line default
        #line hidden
        
        
        #line 256 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SciChart.Charting.Visuals.RenderableSeries.FastLineRenderableSeries lineRenderSeries_Weights;
        
        #line default
        #line hidden
        
        
        #line 301 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_X1;
        
        #line default
        #line hidden
        
        
        #line 302 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_Y1;
        
        #line default
        #line hidden
        
        
        #line 303 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_X2;
        
        #line default
        #line hidden
        
        
        #line 304 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox_Y2;
        
        #line default
        #line hidden
        
        
        #line 306 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_DrawLine;
        
        #line default
        #line hidden
        
        
        #line 332 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SciChart.Charting.Visuals.SciChartSurface sciChart;
        
        #line default
        #line hidden
        
        
        #line 335 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SciChart.Charting.Visuals.RenderableSeries.XyScatterRenderableSeries scatterRenderSeries2;
        
        #line default
        #line hidden
        
        
        #line 342 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SciChart.Charting.Visuals.PointMarkers.EllipsePointMarker PointerColor2;
        
        #line default
        #line hidden
        
        
        #line 350 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SciChart.Charting.Visuals.RenderableSeries.XyScatterRenderableSeries scatterRenderSeries;
        
        #line default
        #line hidden
        
        
        #line 357 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SciChart.Charting.Visuals.PointMarkers.EllipsePointMarker PointerColor;
        
        #line default
        #line hidden
        
        
        #line 377 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SciChart.Charting.Visuals.Annotations.LineAnnotation LineAnnotion;
        
        #line default
        #line hidden
        
        
        #line 389 "..\..\ScatterChartExampleView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid_Summary;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LinearClassification;component/scatterchartexampleview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ScatterChartExampleView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\ScatterChartExampleView.xaml"
            ((SciChart.Examples.Examples.CreateSimpleChart.ScatterChartExampleView)(target)).Loaded += new System.Windows.RoutedEventHandler(this.ScatterChartExampleView_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtbox_Guassian1_X_Mean = ((System.Windows.Controls.TextBox)(target));
            
            #line 62 "..\..\ScatterChartExampleView.xaml"
            this.txtbox_Guassian1_X_Mean.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInputNumber);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtbox_Guassian1_X_StdDev = ((System.Windows.Controls.TextBox)(target));
            
            #line 63 "..\..\ScatterChartExampleView.xaml"
            this.txtbox_Guassian1_X_StdDev.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInputNumber);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtbox_Guassian1_Y_Mean = ((System.Windows.Controls.TextBox)(target));
            
            #line 64 "..\..\ScatterChartExampleView.xaml"
            this.txtbox_Guassian1_Y_Mean.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInputNumber);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtbox_Guassian1_Y_StdDev = ((System.Windows.Controls.TextBox)(target));
            
            #line 65 "..\..\ScatterChartExampleView.xaml"
            this.txtbox_Guassian1_Y_StdDev.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInputNumber);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtbox_Guassian1_Count = ((System.Windows.Controls.TextBox)(target));
            
            #line 66 "..\..\ScatterChartExampleView.xaml"
            this.txtbox_Guassian1_Count.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInputNumber);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_Guassian1 = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\ScatterChartExampleView.xaml"
            this.btn_Guassian1.Click += new System.Windows.RoutedEventHandler(this.Btn_Guassian1_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtbox_Guassian2_X_Mean = ((System.Windows.Controls.TextBox)(target));
            
            #line 98 "..\..\ScatterChartExampleView.xaml"
            this.txtbox_Guassian2_X_Mean.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInputNumber);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtbox_Guassian2_X_StdDev = ((System.Windows.Controls.TextBox)(target));
            
            #line 99 "..\..\ScatterChartExampleView.xaml"
            this.txtbox_Guassian2_X_StdDev.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInputNumber);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txtbox_Guassian2_Y_Mean = ((System.Windows.Controls.TextBox)(target));
            
            #line 100 "..\..\ScatterChartExampleView.xaml"
            this.txtbox_Guassian2_Y_Mean.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInputNumber);
            
            #line default
            #line hidden
            return;
            case 11:
            this.txtbox_Guassian2_Y_StdDev = ((System.Windows.Controls.TextBox)(target));
            
            #line 101 "..\..\ScatterChartExampleView.xaml"
            this.txtbox_Guassian2_Y_StdDev.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInputNumber);
            
            #line default
            #line hidden
            return;
            case 12:
            this.txtbox_Guassian2_Count = ((System.Windows.Controls.TextBox)(target));
            
            #line 102 "..\..\ScatterChartExampleView.xaml"
            this.txtbox_Guassian2_Count.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInputNumber);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btn_Guassian2 = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\ScatterChartExampleView.xaml"
            this.btn_Guassian2.Click += new System.Windows.RoutedEventHandler(this.Btn_Guassian2_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.radio_Random = ((System.Windows.Controls.RadioButton)(target));
            
            #line 144 "..\..\ScatterChartExampleView.xaml"
            this.radio_Random.Click += new System.Windows.RoutedEventHandler(this.radio_Random_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.radio_User = ((System.Windows.Controls.RadioButton)(target));
            
            #line 145 "..\..\ScatterChartExampleView.xaml"
            this.radio_User.Click += new System.Windows.RoutedEventHandler(this.radio_User_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.txtbox_W1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 155 "..\..\ScatterChartExampleView.xaml"
            this.txtbox_W1.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInputNumber);
            
            #line default
            #line hidden
            return;
            case 17:
            this.txtbox_W2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 156 "..\..\ScatterChartExampleView.xaml"
            this.txtbox_W2.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInputNumber);
            
            #line default
            #line hidden
            return;
            case 18:
            this.txtbox_bias = ((System.Windows.Controls.TextBox)(target));
            
            #line 169 "..\..\ScatterChartExampleView.xaml"
            this.txtbox_bias.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInputNumber);
            
            #line default
            #line hidden
            return;
            case 19:
            this.btn_EpockeNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 173 "..\..\ScatterChartExampleView.xaml"
            this.btn_EpockeNumber.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInputNumber);
            
            #line default
            #line hidden
            return;
            case 20:
            this.btn_StepByStep = ((System.Windows.Controls.Button)(target));
            
            #line 175 "..\..\ScatterChartExampleView.xaml"
            this.btn_StepByStep.Click += new System.Windows.RoutedEventHandler(this.btn_StepByStep_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            this.btn_Automatic = ((System.Windows.Controls.Button)(target));
            
            #line 176 "..\..\ScatterChartExampleView.xaml"
            this.btn_Automatic.Click += new System.Windows.RoutedEventHandler(this.btn_Automatic_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            this.lbl_Weight0 = ((System.Windows.Controls.Label)(target));
            return;
            case 23:
            this.lbl_Weight1 = ((System.Windows.Controls.Label)(target));
            return;
            case 24:
            this.DataGrid_Values = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 25:
            this.txt_a = ((System.Windows.Controls.TextBox)(target));
            return;
            case 26:
            this.datagrid_As = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 27:
            this.sciChart_a = ((SciChart.Charting.Visuals.SciChartSurface)(target));
            return;
            case 28:
            this.lineRenderSeries_a = ((SciChart.Charting.Visuals.RenderableSeries.FastLineRenderableSeries)(target));
            return;
            case 29:
            this.txt_Weights = ((System.Windows.Controls.TextBox)(target));
            return;
            case 30:
            this.datagrid_Weights = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 31:
            this.sciChart_Weights = ((SciChart.Charting.Visuals.SciChartSurface)(target));
            return;
            case 32:
            this.lineRenderSeries_Weights = ((SciChart.Charting.Visuals.RenderableSeries.FastLineRenderableSeries)(target));
            return;
            case 33:
            this.txtbox_X1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 34:
            this.txtbox_Y1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 35:
            this.txtbox_X2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 36:
            this.txtbox_Y2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 37:
            this.btn_DrawLine = ((System.Windows.Controls.Button)(target));
            
            #line 306 "..\..\ScatterChartExampleView.xaml"
            this.btn_DrawLine.Click += new System.Windows.RoutedEventHandler(this.btn_DrawLine_Click);
            
            #line default
            #line hidden
            return;
            case 38:
            this.sciChart = ((SciChart.Charting.Visuals.SciChartSurface)(target));
            return;
            case 39:
            this.scatterRenderSeries2 = ((SciChart.Charting.Visuals.RenderableSeries.XyScatterRenderableSeries)(target));
            return;
            case 40:
            this.PointerColor2 = ((SciChart.Charting.Visuals.PointMarkers.EllipsePointMarker)(target));
            return;
            case 41:
            this.scatterRenderSeries = ((SciChart.Charting.Visuals.RenderableSeries.XyScatterRenderableSeries)(target));
            return;
            case 42:
            this.PointerColor = ((SciChart.Charting.Visuals.PointMarkers.EllipsePointMarker)(target));
            return;
            case 43:
            this.LineAnnotion = ((SciChart.Charting.Visuals.Annotations.LineAnnotation)(target));
            return;
            case 44:
            this.DataGrid_Summary = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

