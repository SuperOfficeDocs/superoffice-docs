---
uid: help-en-example-change-search-criteria
title: Example change search criteria
description: Example change search criteria
author: SuperOffice RnD
so.date: 07.04.2022
keywords: CRM
so.topic: help
language: en
---

# Edit search criteria - an example

We are now going to see how you adjust the criteria in a sales report:

1. Click the **Sale** tab. In the report list, a list of standard reports for the tab you have chosen is displayed.
2. Select the **Sale report – Actual sales** standard report. The text field displays a description of the report, and the criteria list below that shows the criteria for the standard report you have selected.

Now we are going to amend slightly the standard report criteria, so that you can see how to change them to match your needs. We are going to change the standard report so that it shows all actual sales from the previous month which do *not* have the status **Open**.

1. Double-click the **Sale: Date** criterion in the criteria list. The **Add/edit search criteria** dialog appears.

    ![icon](../media/Chap10-reports/121-chap10-edit-criteria.bmp)

2. Click the arrow next to the **This month** field, change the period to **Last month** and click **OK**. Your report will now only contain sales from the previous month.

3. Select the **Sale: Owner** criterion in the criteria list and click the **Delete** button at the bottom. Your report will now include all sales, and not just sales where the user in question (i.e. you) is recorded as the owner.

4. Double-click the **Sale: Status** criterion in the criteria list. The **Add/edit search criteria** dialog appears. Now we are going to change the **Sale: Status** criterion so that the report only contains sales which do *not* have the status **Open**.

    ![icon](../media/Chap10-reports/122-chap10-edit-criteria-2.bmp)

5. Click the arrow next to the **Is one of** field and change the value to **Is not one of**.

6. Select the **Sold** criterion in the **Selected values** column and click the left-pointing arrow (![icon][img2]) between the columns. The criterion is moved over to the left-hand column.

7. Select the **Open** criterion in the left-hand column and click the right-pointing arrow (![icon][img1]) between the columns. The criterion is moved over to the **Selected values** column. The report will now contain sales which do *not* have the status **Open**.

8. Click **OK**.

For more information about search criteria and field types, see [Use search criteria](../key-functions/Using-search-criteria.md).

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: ../../../../media/icons/pil-hoeyre.bmp
[img2]: ../../../../media/icons/pil-venstre.bmp