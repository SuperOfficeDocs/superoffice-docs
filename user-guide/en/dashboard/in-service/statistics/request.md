---
uid: help-en-service-statistics-request
title: Request statistics
description: Request statistics
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Request statistics

This screen is used to create statistics based on the requests stored in the system. By adjusting the various parameters, you can specify which information you would like statistics for.

In the **Settings** tab, set the following parameters:

1. Set the date interval:
    * **From date** and **To date**: In these fields, you must enter the date interval you want statistics for. Set a date by clicking the calendar icon (![icon][img1]) or by typing the date into the field. To select today's date, click ![icon][img2].

2. **Choose statistics**: In the first column you choose which value(s) you would like to measure. You can measure more than one value by holding down the **CTRL** key while you click the required type. Statistics are based on different measurable values, listed in the left column, and different summing options, listed in the right column. By making multiple selections, you can achieve all possible combinations of selected elements in the left and right columns. Among the different measurable values are the following:

    * **Number of requests registered**: Specifies the number of requests registered, based on their original status.

    * **Number of requests closed**: The same as Total number of requests, but includes only those requests with the status **Closed**.

    * **Average time-to-close**: Specifies the average time to close a case. There is information below on how this time is calculated.

    * **Average time-to-reply**: Specifies the average time taken to answer a request, calculated from when the second message is added to a request. There is information below on how this time is calculated. Requests with just a single message are ignored.

3. In the second column, select **summing options**, since you are likely to want statistics.

    * **Time of day**: The measurable values are summed for each of the 24 hours in a day. These values are inclusive, for example, from 09:00:00 to 10:59:59. Note that for all measurable values, except **Number of requests closed**, this field refers to when the request was registered, not when it was closed or answered. For example: a request registered at 15:00 and answered at 16:10 will have a reply time of one hour, summed for the reply times from 15:00:00 to 15:59:59. The result is thus the average reply time for requests registered within a given time period.
    * **Day of week**: This summing option works exactly like **Hour**, but applies to the seven days of the week.
    * **Category**: Sums measurable values by category.
    * **User**: Sums measurable values by user.
    * **Priority**: Sums measurable values by priority.
    * **Mailbox**: Sums measurable values by mailbox. Requests not generated from emails are ignored.

4. Set these options as necessary:

    * **Calculate reply time and time-to-close based on the priority's time frame**: If enabled, the values for average reply time and time-to-close will be based on the priority's time frame for the request. For example, a request has priority **Medium**, and the time frame for this priority is Monday-Friday from 9am to 5pm. A request was created on Friday at 4pm and closed on Monday at 10am. The raw time-to-close for this request is then 64 hours, but the real time-to-close is only 2 hours. With this option enabled, 2 hours is the value used for the calculations.

    * **Show time interval in minutes**: If enabled, the calculated time intervals are displayed as number of minutes. Convenient if you would like to export the data and use them to display a graph.

    * **Display dates as YYYY-MM-DD**: If enabled, dates are written in this format. Useful if you want to export the data to another program.

    * **Hide empty rows**: If enabled, rows in the calculated dataset containing only nulls/zeros are ignored.

    * **Hide empty columns**: If enabled, columns in the calculated dataset containing only nulls/zeros are ignored. Applies to the entire spreadsheet.

    * **Hide empty bars**: If enabled, empty bars are hidden in the resulting graph. Applies to charts.

    * **Show sum per week**: If enabled, a calculated sum per week, calculated as 7 days from the start date, is displayed.

    * **Show sum per month**: If enabled, a calculated sum per month is displayed. This statistic applies to full calendar months and not the number of days, which can vary.

5. **Display format**: Here you select how you want to display the data. The different formats are:

    * **On screen as a graph**. The data are displayed on screen as flat bar charts. Note that each chart contains only one dataset and each will have its own scale. Charts will therefore not be visually comparable.

    * **On screen as table**. The data are displayed on screen as a spreadsheet.

    * **As an HTML table file**. The data are displayed in a table in a pure HTML file, which can be saved locally and then imported into a spreadsheet.

    * **As a CSV (comma-separated value) file**: The data are displayed in a comma-separated file, which can be saved locally and then imported into a spreadsheet.

6. Click **OK** to open the statistics.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../../common/icons/diaryblack.png
[img2]: ../../../../../common/icons/now.png
