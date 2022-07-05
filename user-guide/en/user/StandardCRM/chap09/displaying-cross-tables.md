---
uid: help-en-displaying-cross-tables
title: Displaying cross tables
description: Displaying cross tables
author: SuperOffice RnD
so.date: 07.04.2022
keywords: CRM
so.topic: help
language: en
---

# Display cross tables

Cross tables can be displayed and printed in various ways. You can select which parts of the cross table to print, preview the cross table, or print it as an ordinary table or as a chart.

> [!TIP]
> If you are not sure if your report is a cross table, you can check the image between the report list and the report description. For more information about this, see **Report types** under [Show report properties](Showing-report-properties.md).

Do as follows:

1. Open the **Reports** screen.  
    <!-- Fix reuse ID=a2 -->
    [!include[How to-goto-reports](../../includes/goto-reports.md
)]

2. Select the required cross table report (see [Show report properties](Showing-report-properties.md)).

3. Click the **Preview** button under the criteria list. The cross table report is generated.

4. Click the report file (.Dcube) which is displayed in your browser. The file is opened in SuperOffice's cross table viewer application. The cross table report is shown as it will appear when filled with data from the SuperOffice database.

    <!-- Fix reuse ID=a3 -->

    To view a cross table report (.Dcube file), you need to install the **CrossTable viewer**.

    Do as follows:

    1. Click ![icon](../../../../media/icons/globalmenu-mainmenu-small.png) (main menu) and select **Download &gt; Download CrossTable viewer**.
    2. Click the downloaded file (**SoCrossTableInstaller.exe**) to run it.
    3. If a security warning is displayed, confirm that you want to run the file. The installation wizard then opens.
    4. Follow the instructions in the wizard to install the program.

    You only need to do this once per computer.

5. Edit the contents of the cross table by using these buttons:

    | Icon | Description |
    |---|---|
    |![icon](../media/Rep-krysstabell-listeboks.bmp) |Click this button to display a list box containing the different options for showing and hiding rows/columns. |
    | ![icon](../media/Rep-krysstabell-kryss.bmp) |Remove the check from this box if you don’t want rows and columns to be displayed in the cross table. |
    | ![icon](../media/RepWeb-preview-plus.bmp) |Click the plus sign to choose to display all the rows/columns in the list. |
    | ![icon](../media/RepWeb-preview-minus.bmp) |Click the minus sign to choose to hide all the rows/columns in the list. |
    | ![icon](../media/RepWeb-preview-asterisk.bmp) |Click the star to toggle between showing and hiding rows/columns. |
    | ![icon](../media/RepWeb-preview-checkmark.bmp) |Click the tick to confirm your choice. |
    | ![icon](../media/RepWeb-preview-cross.bmp) |Click the cross to cancel. |
    | ![icon](../media/Rep-krysstabell-pilkryss.bmp)<br />![icon](../media/Rep-krysstabell-pilkryss-groent.bmp) |You can also drag and drop individual components of the cross table. The mouse pointer turns into a four-headed arrow when you hold it over a moveable component. Fields where you can move components are displayed with a green line when you hold the mouse pointer over them. |

    > [!NOTE]
    > Fields, rows and columns which you choose to hide in the step described above will not be included in the print-out.

6. When you have finished editing the contents of the cross table, you can do one of the following:
    * Select **File** &gt; **Print Preview** to preview the report.
    * Select **File** &gt; **Print** to print the report. See [Print cross tables](Printing-cross-tables.md).
    * Click **Export** to save the report in Excel format. See [Save cross table reports as files](Saving-cross-table-reports-as-files.md).

7. Click **OK** to close the cross table viewer.
