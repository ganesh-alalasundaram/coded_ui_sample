﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace Sample_CodedUi
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        #region Properties
        public UINationalandLocalWeatWindow UINationalandLocalWeatWindow
        {
            get
            {
                if ((this.mUINationalandLocalWeatWindow == null))
                {
                    this.mUINationalandLocalWeatWindow = new UINationalandLocalWeatWindow();
                }
                return this.mUINationalandLocalWeatWindow;
            }
        }
        #endregion
        
        #region Fields
        private UINationalandLocalWeatWindow mUINationalandLocalWeatWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UINationalandLocalWeatWindow : BrowserWindow
    {
        
        public UINationalandLocalWeatWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "National and Local Weather Forecast, Hurricane, Radar and Report";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("National and Local Weather Forecast, Hurricane, Radar and Report");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UINationalandLocalWeatDocument UINationalandLocalWeatDocument
        {
            get
            {
                if ((this.mUINationalandLocalWeatDocument == null))
                {
                    this.mUINationalandLocalWeatDocument = new UINationalandLocalWeatDocument(this);
                }
                return this.mUINationalandLocalWeatDocument;
            }
        }
        #endregion
        
        #region Fields
        private UINationalandLocalWeatDocument mUINationalandLocalWeatDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UINationalandLocalWeatDocument : HtmlDocument
    {
        
        public UINationalandLocalWeatDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "National and Local Weather Forecast, Hurricane, Radar and Report";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "https://weather.com/";
            this.WindowTitles.Add("National and Local Weather Forecast, Hurricane, Radar and Report");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIWindowesidatawindowePane
        {
            get
            {
                if ((this.mUIWindowesidatawindowePane == null))
                {
                    this.mUIWindowesidatawindowePane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIWindowesidatawindowePane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIWindowesidatawindowePane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIWindowesidatawindowePane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "window.esidata = window.esidata || {}; w";
                    this.mUIWindowesidatawindowePane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIWindowesidatawindowePane.FilterProperties[HtmlDiv.PropertyNames.Class] = "berlin clearfix";
                    this.mUIWindowesidatawindowePane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"berlin clearfix\"";
                    this.mUIWindowesidatawindowePane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "1";
                    this.mUIWindowesidatawindowePane.WindowTitles.Add("National and Local Weather Forecast, Hurricane, Radar and Report");
                    #endregion
                }
                return this.mUIWindowesidatawindowePane;
            }
        }
        
        public HtmlEdit UISearchcityziporplaceEdit
        {
            get
            {
                if ((this.mUISearchcityziporplaceEdit == null))
                {
                    this.mUISearchcityziporplaceEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUISearchcityziporplaceEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = null;
                    this.mUISearchcityziporplaceEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "search";
                    this.mUISearchcityziporplaceEdit.SearchProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                    this.mUISearchcityziporplaceEdit.SearchProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUISearchcityziporplaceEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = "Search city, zip or place";
                    this.mUISearchcityziporplaceEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "input--search ng-touched";
                    this.mUISearchcityziporplaceEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"search\" title=\"Search city, zip or";
                    this.mUISearchcityziporplaceEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "1";
                    this.mUISearchcityziporplaceEdit.WindowTitles.Add("National and Local Weather Forecast, Hurricane, Radar and Report");
                    #endregion
                }
                return this.mUISearchcityziporplaceEdit;
            }
        }
        
        public UIWxheaderwrapCustom UIWxheaderwrapCustom
        {
            get
            {
                if ((this.mUIWxheaderwrapCustom == null))
                {
                    this.mUIWxheaderwrapCustom = new UIWxheaderwrapCustom(this);
                }
                return this.mUIWxheaderwrapCustom;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIWindowesidatawindowePane;
        
        private HtmlEdit mUISearchcityziporplaceEdit;
        
        private UIWxheaderwrapCustom mUIWxheaderwrapCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIWxheaderwrapCustom : HtmlCustom
    {
        
        public UIWxheaderwrapCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "HEADER";
            this.SearchProperties["Id"] = "wx-header-wrap";
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.FilterProperties["Class"] = "region navigation";
            this.FilterProperties["ControlDefinition"] = "class=\"region navigation\" id=\"wx-header-";
            this.FilterProperties["TagInstance"] = "1";
            this.WindowTitles.Add("National and Local Weather Forecast, Hurricane, Radar and Report");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIItemPane
        {
            get
            {
                if ((this.mUIItemPane == null))
                {
                    this.mUIItemPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIItemPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIItemPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = null;
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "wx-iconfont-global wx-icon-search icon--search ";
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"wx-iconfont-global wx-icon-search icon--search \" aria-hidden=\"true\" data-n" +
                        "g-if=\"!hideSearchIcon\" data-ng-class=\"{inputActive: term.length > 0}\"";
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "52";
                    this.mUIItemPane.WindowTitles.Add("National and Local Weather Forecast, Hurricane, Radar and Report");
                    #endregion
                }
                return this.mUIItemPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIItemPane;
        #endregion
    }
}
