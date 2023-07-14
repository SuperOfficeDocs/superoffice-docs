---
uid: help-en-report-search-criteria-edit
title: Edit search criteria in reports
description: Edit search criteria in reports
author: SuperOffice RnD
so.date: 07.04.2022
keywords: report
so.topic: howto
language: en
---

# Edit search criteria in reports

You can edit search criteria in favorite reports. Standard reports cannot actually be edited, but you can customize the search criteria in them and save them as your own [favorite reports][1].

1. [!include[How to-goto-reports](../includes/goto-reports.md)]

1. Select a tab. The reports are displayed in the report list.

    > [!NOTE]
    > It is not recommended that you run reports without specifying search criteria, as this may generate extremely large reports and result in time-consuming processing.

1. Select the required report from the list.

1. In the criteria list, double-click the criterion you want to edit.

1. The **Add/edit search criteria** dialog appears.

1. [Edit the required information][2].

    > [!NOTE]
    > The criteria you can choose from vary according to the tab and report you selected.

1. Click **OK** at the bottom of the **Add/edit search criteria** dialog when you are done.

## Example

We are now going to see how you adjust the criteria in a sales report:

1. Click the **Sale** tab. In the report list, a list of standard reports for the tab you chose is displayed.
1. Select the **Sale report – Actual sales** standard report. The text field displays a description of the report, and the criteria list below that shows the criteria for the standard report you selected.

Now we are going to amend slightly the standard report criteria, so that you can see how to change them to match your needs. We are going to change the standard report so that it shows all actual sales from the previous month which do *not* have the status **Open**.

1. Double-click the **Sale: Date** criterion in the criteria list. The **Add/edit search criteria** dialog appears.

    ![Add/edit search criteria -screenshot][img3]

1. Click the arrow next to the **This month** field, change the period to **Last month** and click **OK**. Your report will now only contain sales from the previous month.

1. Select the **Sale: Owner** criterion in the criteria list and click the **Delete** button at the bottom. Your report will now include all sales, and not just sales where the user in question (you) is recorded as the owner.

1. Double-click **Sale: Status** in the criteria list. The **Add/edit search criteria** dialog appears. Now we are going to change the **Sale: Status** criterion so that the report only contains sales that do not have the status **Open**.

    ![Add/edit search criteria -screenshot][img4]

1. Click the arrow next to the **Is one of** field and change the value to **Is not one of**.

1. In the **Selected values** column, select **Sold** and click ![icon][img2]. The criterion is moved to the leftmost column.

1. In the leftmost column select **Open** and click ![icon][img1]. The criterion is moved to the **Selected values** column. The report will now contain sales that do not have the status **Open**.

1. Click **OK**.

<!-- Referenced links -->
[1]: ../favorites/add.md
[2]: ../../../search-options/learn/search-criteria.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/arrow-right.png
[img2]: ../../../../media/icons/arrow-left.png
[img3]: ../../../../media/loc/en/reports/edit-criteria.bmp
[img4]: ../../../../media/loc/en/reports/edit-criteria-2.bmp
