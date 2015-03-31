/*
 * Created by Ranorex
 * User: nformtest
 * Date: 2015/1/8
 * Time: 9:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace NformTester.lib
{
    /// <summary>
    /// Description of VersionCheck.
    /// </summary>
    [TestModule("9D35246A-7256-472B-A607-26156106CA09", ModuleType.UserCode, 1)]
    public class VersionCheck : ITestModule
    {
        NformRepository repo = NformRepository.Instance;
        private int totalCount = 0;
        private int containerCount = 0;
        private int textCount = 0;
        private int checkBoxCount = 0;
        private int buttonCount = 0;
        private int ComboBoxCount = 0;
        private int TabPageCount = 0;
        private int MenuBarCount = 0;
        private int TitleBarCount = 0;
        private int PictureCount = 0;
        private int SeparatorCount = 0;
        private int MenuItemCount = 0;
        private int CellCount = 0;
        private int IndicatorCount = 0;
        private int LinkCount = 0;
        private int TreeCount = 0;
        private int TreeItemCount = 0;
        private int RadioButtonCount = 0;
        private int ListCount = 0;
        private int ListItemCount = 0;
        private int GripCount = 0;
        
    	/// <summary>
        /// Constructs a new instance.
        /// </summary> 
        public VersionCheck()
        {
            // Do not delete - a parameterless constructor is required!
        }
		
        /// <summary>
        /// Get the Total Count element.
        /// </summary> 
        public String GetTotalCount()
        {
        	return totalCount.ToString();
        }
         /// <summary>
        /// Get the container Count element.
        /// </summary> 
        public String GetContainerCount()
        {
        	return containerCount.ToString();
        }
         /// <summary>
        /// Get the Text Count element.
        /// </summary> 
        public String GetTextCount()
        {
        	return textCount.ToString();
        }
        
        public String GetCheckBoxCount()
        {
        	return checkBoxCount.ToString();
        }
         /// <summary>
        /// Get the Button Count element.
        /// </summary> 
        public String GetButtonCount()
        {
        	return buttonCount.ToString();
        }
         /// <summary>
        /// Get the ComboBox Count element.
        /// </summary> 
        public String GetComboBoxCount()
        {
        	return ComboBoxCount.ToString();
        }
        /// <summary>
        /// Get the TabPage element.
        /// </summary> 
        public String GetTabPageCount()
        {
        	return TabPageCount.ToString();
        }
        /// <summary>
        /// Get the MenuBar Count element.
        /// </summary> 
        public String GetMenuBarCount()
        {
        	return MenuBarCount.ToString();
        }
        /// <summary>
        /// Get the TitleBar Count element.
        /// </summary> 
        public String GetTitleBarCount()
        {
        	return TitleBarCount.ToString();
        }
        /// <summary>
        /// Get the Picture Count element.
        /// </summary> 
        public String GetPictureCount()
        {
        	return PictureCount.ToString();
        }
        /// <summary>
        /// Get the Separator Count element.
        /// </summary> 
        public String GetSeparatorCount()
        {
        	return SeparatorCount.ToString();
        }
        /// <summary>
        /// Get the MenuItem Count element.
        /// </summary> 
        public String GetMenuItemCount()
        {
        	return MenuItemCount.ToString();
        }
        /// <summary>
        /// Get the Cell Count element.
        /// </summary> 
        public String GetCellCount()
        {
        	return CellCount.ToString();
        }
        /// <summary>
        /// Get the Indicator Count element.
        /// </summary> 
        public String GetIndicatorCount()
        {
        	return IndicatorCount.ToString();
        }
        /// <summary>
        /// Get the Link Count element.
        /// </summary> 
        public String GetLinkCount()
        {
        	return LinkCount.ToString();
        }
        /// <summary>
        /// Get the Tree Count element.
        /// </summary> 
        public String GetTreeCount()
        {
        	return TreeCount.ToString();
        }
        /// <summary>
        /// Get the TreeItem Count element.
        /// </summary> 
        public String GetTreeItemCount()
        {
        	return TreeItemCount.ToString();
        }
        /// <summary>
        /// Get the RadioButton Count element.
        /// </summary> 
        public String GetRadioButtonCount()
        {
        	return RadioButtonCount.ToString();
        }
        /// <summary>
        /// Get the List Count element.
        /// </summary> 
        public String GetListCount()
        {
        	return ListCount.ToString();
        }
        /// <summary>
        /// Get the ListItem Count element.
        /// </summary> 
        public String GetListItemCount()
        {
        	return ListItemCount.ToString();
        }
        /// <summary>
        /// Get the Grip Count element.
        /// </summary> 
        public String GetGripCount()
        {
        	return GripCount.ToString();
        }
        public void PopElementCount(IList<Unknown> elementList)
        {
        	foreach(Unknown element in elementList)
        	{
	        	if ( element.Children.Count == 0 )
	        	{
	        		//Report.Info("Form", element.ToString());
	        		totalCount += 1;
	        		string [] split = element.ToString().Split(new Char [] {'{', ':' , '}'});
	        		if (split[1] == "Container")
	        		{
	        			containerCount += 1;
	        		}
	        		else if(split[1] == "Text")
	        		{
	        			textCount += 1;
	        		}
	        		else if(split[1] == "CheckBox")
	        		{
	        			checkBoxCount += 1;
	        		}
	        		else if(split[1] == "Button")
	        		{
	        			buttonCount += 1;
	        		}
	        		else if(split[1] == "ComboBox")
	        		{
	        			ComboBoxCount += 1;
	        		}
	        		else if(split[1] == "TabPage")
	        		{
	        			TabPageCount += 1;
	        		}
	        		else if(split[1] == "MenuBar")
	        		{
	        			MenuBarCount += 1;
	        		}
	        		else if(split[1] == "TitleBar")
	        		{
	        			TitleBarCount += 1;
	        		}
	        		else if(split[1] == "Picture")
	        		{
	        			PictureCount += 1;
	        		}
	        		else if(split[1] == "Separator")
	        		{
	        			SeparatorCount += 1;
	        		}
	        		else if(split[1] == "MenuItem")
	        		{
	        			MenuItemCount += 1;
	        		}
	        		else if(split[1] == "Cell")
	        		{
	        			CellCount += 1;
	        		}
	        		else if(split[1] == "Indicator")
	        		{
	        			IndicatorCount += 1;
	        		}
	        		else if(split[1] == "Link")
	        		{
	        			LinkCount += 1;
	        		}
	        		else if(split[1] == "Tree")
	        		{
	        			TreeCount += 1;
	        		}
	        		else if(split[1] == "TreeItem")
	        		{
	        			TreeItemCount += 1;
	        		}
	        		else if(split[1] == "RadioButton")
	        		{
	        			RadioButtonCount += 1;
	        		}
	        		else if(split[1] == "List")
	        		{
	        			ListCount += 1;
	        		}
	        		else if(split[1] == "ListItem")
	        		{
	        			ListItemCount += 1;
	        		}
	        		else if(split[1] == "Grip")
	        		{
	        			GripCount += 1;
	        		}
	        		
	        		continue;
	        	}
	        	else
	        	{	
	        		PopElementCount(element.Children);
	        		continue;
	        	}
        	}
        	
        }
        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            
           // int expectedItems = 11;
            Form MgdDevice = "/form[@controlname='LxMgdDeviceEditDlg']";
            IList<Unknown> elementsOfForm = MgdDevice.Children;
           
            PopElementCount(elementsOfForm);
            Report.Info("total Count is", totalCount.ToString());
            Report.Info("textCount is", textCount.ToString());
            Report.Info("container Count is", containerCount.ToString());
            Report.Info("checkBoxCount is", checkBoxCount.ToString());
            Report.Info("buttonCount is", buttonCount.ToString());
            Report.Info("ComboBoxCount is", ComboBoxCount.ToString());
            Report.Info("TabPageCount is", TabPageCount.ToString());
            Report.Info("MenuBarCount is", MenuBarCount.ToString());
            Report.Info("TitleBarCount is", TitleBarCount.ToString());
           
			/*
            IList<Unknown> elementsOfContainer = container.Children;
			if(elementsOfContainer.Count != expectedItems)
			{
				throw new RanorexException("The container doesn't contain the expected number of items");
			}
			else
			{
			    Report.Info("The container contains the expected number of items");
			}
			*/
            	
        }
    }
}
