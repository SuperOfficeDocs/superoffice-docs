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
> If you are not sure if your report is a cross table, you can check the image between the report list and the report description. For more information about this, see **Report types** under [Show report properties][1].

Do as follows:

1. Open the **Reports** screen.
    <!-- Fix reuse ID=a2 -->
    [!include[How to-goto-reports](../includes/goto-reports.md
)]

2. Select the required cross table report (see [Show report properties][1]).

3. Click the **Preview** button under the criteria list. The cross table report is generated.

4. Click the report file (.Dcube) which is displayed in your browser. The file is opened in SuperOffice's cross table viewer application. The cross table report is shown as it will appear when filled with data from the SuperOffice database.

    <!-- Fix reuse ID=a3 -->

    To view a cross table report (.Dcube file), you need to install the **CrossTable viewer**.

    Do as follows:

    1. Click ![icon][img1] (main menu) and select **Download &gt; Download CrossTable viewer**.
    2. Click the downloaded file (**SoCrossTableInstaller.exe**) to run it.
    3. If a security warning is displayed, confirm that you want to run the file. The installation wizard then opens.
    4. Follow the instructions in the wizard to install the program.

    You only need to do this once per computer.

5. Edit the contents of the cross table by using these buttons:

    | Icon | Description |
    |---|---|
    | ![icon][img2] |Click this button to display a list box containing the different options for showing and hiding rows/columns. |
    | ![icon][img3] |Remove the check from this box if you don’t want rows and columns to be displayed in the cross table. |
    | ![icon][img4] |Click the plus sign to choose to display all the rows/columns in the list. |
    | ![icon][img5] |Click the minus sign to choose to hide all the rows/columns in the list. |
    | ![icon][img6] |Click the star to toggle between showing and hiding rows/columns. |
    | ![icon][img7] |Click the tick to confirm your choice. |
    | ![icon][img8] |Click the cross to cancel. |
    | ![icon][img9], ![icon][img10] |You can also drag and drop individual components of the cross table. The mouse pointer turns into a four-headed arrow when you hold it over a moveable component. Fields where you can move components are displayed with a green line when you hold the mouse pointer over them. |

    > [!NOTE]
    > Fields, rows and columns which you choose to hide in the step described above will not be included in the print-out.

6. When you have finished editing the contents of the cross table, you can do one of the following:
    * Select **File** &gt; **Print Preview** to preview the report.
    * Select **File** &gt; **Print** to print the report. See [Print cross tables][2].
    * Click **Export** to save the report in Excel format. See [Save cross table reports as files][3].

7. Click **OK** to close the cross table viewer.

<!-- Referenced links -->
[1]: showing-report-properties.md
[2]: printing-cross-tables.md
[3]: saving-cross-table-reports-as-files.md

<!-- Referenced images -->
[img1]: ../../../media/icons/globalmenu-mainmenu-small.png
[img2]: ../../../media/icons/reports/rep-krysstabell-listeboks.bmp
[img3]: ../../../media/icons/reports/rep-krysstabell-kryss.bmp
[img4]: ../../../media/icons/reports/repweb-preview-plus.bmp
[img5]: ../../../media/icons/reports/repweb-preview-minus.bmp
[img6]: ../../../media/icons/reports/repweb-preview-asterisk.bmp
[img7]: ../../../media/icons/reports/repweb-preview-checkmark.bmp
[img8]: ../../../media/icons/reports/repweb-preview-cross.bmp
[img9]: ../../../media/icons/reports/rep-krysstabell-pilkryss.bmp
[img10]: ../../../media/icons/reports/rep-krysstabell-pilkryss-groent.bmp
