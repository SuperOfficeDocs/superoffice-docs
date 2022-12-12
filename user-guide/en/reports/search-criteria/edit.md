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

You can edit search criteria in favorite reports. Standard reports cannot actually be edited, but you can customize the search criteria in them and save them as your own [favorite reports][1]).

1. [!include[How to-goto-reports](../includes/goto-reports.md)]

2. Select a tab. The reports are displayed in the report list.

    > [!NOTE]
    > It is not recommended that you run reports without specifying search criteria, as this may generate extremely large reports and result in time-consuming processing.

3. Select the required report from the list.

4. In the criteria list, double-click the criterion you want to edit.

5. The **Add/edit search criteria** dialog appears.

6. [Edit the required information][2].

    > [!NOTE]
    > The criteria you can choose from vary according to the tab and report you selected.

7. Click **OK** at the bottom of the **Add/edit search criteria** dialog when you are done.

## Example

We are now going to see how you adjust the criteria in a sales report:

1. Click the **Sale** tab. In the report list, a list of standard reports for the tab you chose is displayed.
2. Select the **Sale report – Actual sales** standard report. The text field displays a description of the report, and the criteria list below that shows the criteria for the standard report you selected.

Now we are going to amend slightly the standard report criteria, so that you can see how to change them to match your needs. We are going to change the standard report so that it shows all actual sales from the previous month which do *not* have the status **Open**.

1. Double-click the **Sale: Date** criterion in the criteria list. The **Add/edit search criteria** dialog appears.

    ![Add/edit search criteria -screenshot][img3]

2. Click the arrow next to the **This month** field, change the period to **Last month** and click **OK**. Your report will now only contain sales from the previous month.

3. Select the **Sale: Owner** criterion in the criteria list and click the **Delete** button at the bottom. Your report will now include all sales, and not just sales where the user in question (you) is recorded as the owner.

4. Double-click the **Sale: Status** criterion in the criteria list. The **Add/edit search criteria** dialog appears. Now we are going to change the **Sale: Status** criterion so that the report only contains sales which do *not* have the status **Open**.

    ![Add/edit search criteria -screenshot][img4]

5. Click the arrow next to the **Is one of** field and change the value to **Is not one of**.

6. Select the **Sold** criterion in the **Selected values** column and click the left-pointing arrow (![icon][img2]) between the columns. The criterion is moved over to the left-hand column.

7. Select the **Open** criterion in the left-hand column and click the right-pointing arrow (![icon][img1]) between the columns. The criterion is moved over to the **Selected values** column. The report will now contain sales which do *not* have the status **Open**.

8. Click **OK**.

<!-- Referenced links -->
[1]: ../labels/add-format.md
[2]: ../../search-options/using-search-criteria.md

<!-- Referenced images -->
[img1]: ../../../media/icons/arrow-right.png
[img2]: ../../../media/icons/arrow-left.png
[img3]: ../media/edit-criteria.bmp
[img4]: ../media/edit-criteria-2.bmp
