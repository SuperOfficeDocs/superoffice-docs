---
uid: help-en-cross-table-reports
title: Displaying cross tables
description: Displaying cross tables
author: SuperOffice RnD
so.date: 07.04.2022
keywords: report
so.topic: concept
language: en
---

# Cross tables

Cross tables can be displayed and printed in various ways. You can select which parts of the cross table to print, preview the cross table, or print it as an ordinary table or as a chart.

> [!TIP]
> If you are not sure if your report is a cross table, you can check the image between the report list and the report description. [How][1].

## <a id="install" />Install the CrossTable viewer

To view a cross table report (.Dcube file), you must install the **CrossTable viewer** (once per computer).

1. Click ![icon][img1] **Main menu** and select **Download** > **Download CrossTable viewer**.
1. Click the downloaded file (**SoCrossTableInstaller.exe**) to run it.
1. If a security warning is displayed, confirm that you want to run the file.
1. Follow the instructions in the wizard to install the program.

## View a cross table

1. [!include[How to-goto-reports](includes/goto-reports.md)]

1. [Select the required cross table report][1].

1. Click the **Preview** button under the criteria list. The cross table report is generated.

1. Click the report file (.Dcube) which is displayed in your browser. The file is opened in SuperOffice's cross table viewer application. The cross table report is shown as it will appear when filled with data from the SuperOffice database.

    > [!NOTE]
    > If you cannot see the cross table report in your browser (.Dcube), you must [install the CrossTable viewer](#install).

1. Edit the contents of the cross table by using the buttons (see below).

    > [!NOTE]
    > Fields, rows and columns which you choose to hide in the step described above will not be included in the print-out.

1. After editing the contents of the cross table, you can do one of the following:

    * Select **File** > **Print Preview** to preview the report.
    * Select **File** > **Print** to print the report.
    * Click **Export** to save the report in Excel format.

1. Click **OK** to close the cross table viewer.

## <a id="print" />Print cross tables

There are several print options for cross tables. You can select which parts of the cross table to print, preview the cross table, or print it as an ordinary table or as a chart.

## <a id="export" />Save cross table reports as files

Saving reports as files works slightly differently for cross table reports than for other types of report. To save a cross table report as a file, click **Export** when viewing the report in the CrossTable viewer.

## Buttons

| Icon | Description |
|---|---|
| ![icon][img2] | Click this button to display a list box containing the different options for showing and hiding rows/columns. |
| ![icon][img3] | Remove the check from this box if you do not want rows and columns to be displayed in the cross table. |
| ![icon][img4] | Click the plus sign to choose to display all the rows/columns in the list. |
| ![icon][img5] | Click the minus sign to choose to hide all the rows/columns in the list. |
| ![icon][img6] | Click the star to toggle between showing and hiding rows/columns. |
| ![icon][img7] | Click the tick to confirm your choice. |
| ![icon][img8] | Click the cross to cancel. |
| ![icon][img9], ![icon][img10] | You can also drag and drop individual components of the cross table. The mouse pointer turns into a four-headed arrow when you hold it over a moveable component. Fields where you can move components are displayed with a green line when you hold the mouse pointer over them. |

<!-- Referenced links -->
[1]: properties.md

<!-- Referenced images -->
[img1]: ../../../media/icons/main-menu.png
[img2]: ../../../media/icons/reports/list-box.bmp
[img3]: ../../../media/icons/reports/black-x-2.bmp
[img4]: ../../../media/icons/reports/plus.bmp
[img5]: ../../../media/icons/reports/minus.bmp
[img6]: ../../../media/icons/reports/asterisk.bmp
[img7]: ../../../media/icons/reports/check.bmp
[img8]: ../../../media/icons/reports/black-x.bmp
[img9]: ../../../media/icons/reports/arrows-plus.bmp
[img10]: ../../../media/icons/reports/arrows-split-green.bmp
