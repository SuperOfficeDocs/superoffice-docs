# What to do when SuperOffice archiving button has disappeared from Outlook?

SuperOffice archiving button disappeared from Outlook. Just before that, I have received a notification, telling me that SuperOffice Ribbon has been deactivated. Why does it happen and how do I fix it?

There are 4 common causes of this situation:

* You have recently updated Windows or Microsoft Office on your computer.
 
* Outlook believes that SuperOffice Ribbon is running too slow, affecting the overall Outlook performance. 
 
* Your computer, the Microsoft Office package, or the Outlook application crashed just before SuperOffice Ribbon disappeared.
 
* Mail Link has been installed by another Windows user than the one which is using Outlook.

To get your SuperOffice Ribbon back follow the steps below:

  1. Right-click on the Outlook Ribbon and click on the Customize the Ribbon item on the menu.
    
      ![Customize the Ribbon][img1]

  1. Click on the **Add-ins** button on the left-hand side to open the Add-in screen and look for SuperOffice Ribbon there.
    
      If you found SuperOffice Ribbon in the **Active (1)** section, [check this section.](https://community.superoffice.com/no/support-faqs/faq/what-to-do-when-superoffice-archiving-button-has-disappeared-from-outlook/#1).
 
      If SuperOffice Ribbon is in the **Inactive (2)** section, [check this section.](https://community.superoffice.com/no/support-faqs/faq/what-to-do-when-superoffice-archiving-button-has-disappeared-from-outlook/#2).
 
      If SuperOffice Ribbon is in the **Disabled (3)** section, [check this section.](https://community.superoffice.com/no/support-faqs/faq/what-to-do-when-superoffice-archiving-button-has-disappeared-from-outlook/#3).
 
      If you cannot find SuperOffice Ribbon on the list, [check this section.](https://community.superoffice.com/no/support-faqs/faq/what-to-do-when-superoffice-archiving-button-has-disappeared-from-outlook/#4).

      ![Outlook options][img2]

### SuperOffice Ribbon is in the Active section

If you find SuperOffice Ribbon in the Active section, but it is still not visible in the Outlook Ribbon, it could be that:

* Visual Studio 2010 Tools for Office Runtime (VSTO), which is a prerequisite for SuperOffice Ribbon to work is not installed on the computer. Please download it from [here](https://www.microsoft.com/en-us/download/details.aspx?id=48217).

* The issue is caused by a [known bug](https://community.superoffice.com/no/product-releases/bugs-wishes/product-issue/?bid=22220&azure=1), please check it for more information.

### SuperOffice Ribbon is in the Inactive section

If you find SuperOffice Ribbon in the Inactive section, you should do the following:

  1. At the bottom of the screen, select **COM Add-ins (1)** from the **Manage field** menu and click **Go (2)**.

      ![COM Add-ins][img3]

  1. Tick the box next to **SuperOffice Ribbon (1)** and close the dialog by clicking **OK (2)**.

      ![SuperOffice Ribbon][img4]
  
  1. SuperOffice Ribbon should be visible now. In some cases, you might need to restart your Outlook before the ribbon reappears.

  **Note!** If next to **Load Behavior** you see status **Deleted** or **Not loaded**, SuperOffice Ribbon Load Behavior Windows Registry needs to be adjusted, check [this FAQ](https://online2.superoffice.com/Cust1990/CS/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&&noCookies=true&action=viewKbEntry&id=113536) telling how to do it.

  ![Load at Startup][img5]

### SuperOffice Ribbon in the Disabled section

If you find SuperOffice Ribbon in the **Disabled** section, you should do the following:

  1. At the bottom of the screen, select **Disabled Items** from the **Manage field** menu, and click **Go**.

      ![Disabled Items][img6]

  1. Select **SuperOffice Ribbon (1)**, click **Enable (2)**, and **Close (3)** the dialog box.

      ![Dialog Box][img7]
  
  1. Then, in the same place select **COM Add-ins (1)** and again click **Go (2)**.

      ![COM Add-ins][img8]
  
  1. Tick the box next to **SuperOffice Ribbon (1)** and close the dialog by clicking **OK (2)**. SuperOffice Ribbon should be visible now. In some cases, you might need to restart your Outlook before the ribbon reappears.

      ![Superoffice Ribbon][img4]

      **Note!** If next to **Load Behavior** you see status **Deleted** or **Not loaded**, SuperOffice Ribbon Load Behavior Windows Registry needs to be adjusted, check [this FAQ](https://cs.superoffice.com/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=113536) telling how to do it.

### SuperOffice Ribbon cannot be found in the list

If you are sure that SuperOffice Mail Link is installed on your computer, but the SuperOffice Ribbon does not appear in the Outlook Add-in list at all, try to [reinstall Mail Link, check this FAQ how to do it.](http://cs.superoffice.com/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=112945)

If after reinstalling Mail Link SuperOffice Ribbon is still invisible then check if the SuperOffice registry key has been created in your Windows profile. To do so in *regedit.exe* navigate to *HKEY\Current User\Software\Microsoft\Office\Outlook\Addins* where you could see a key called *SuperOfficeRibbon-Outlook*.

![SuperOfficeRibbon-Outlook][img9]

If it is not created automatically, most of the time that is due to missing rights on the Windows profile. In this situation, we suggest either give the user local administrator rights on the computer and try to install Mail link with the .msi file or import/copy missing registry keys from the computer where SuperOffice Ribbon is visible, [check this FAQ how to do it.](https://cs.superoffice.com/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=113466)

**Note!** Incorrectly editing a registry can permanently damage your computer or server (if you work on Citrix/Terminal Server), so do not delete or adjust any key if you don't know specifically why you do it. We recommend to back up the Windows registry before making any change. You can find instructions on how to do it in [this article.](https://neosmart.net/wiki/backup-restore-registry/)

### More information:

FAQ: [What to do if SuperOffice Ribbon gets disabled every time we start Outlook?](http://cs.superoffice.com/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=113156)

FAQ: [What can I do when I run into the problems with archiving e-mails from Outlook to SuperOffice CRM?](https://online2.superoffice.com/Cust1990/CS/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=113567)


[img1]:media/customize-ribbon.png
[img2]:media/outlook-options.png
[img3]:media/com-add-ins.png
[img4]:media/so-ribbon.png
[img5]:media/load-startup.png
[img6]:media/disabled-items.png
[img7]:media/dialog-box.png
[img8]:media/com-add-ins-2.png
[img9]:media/ribbon-outlook.png