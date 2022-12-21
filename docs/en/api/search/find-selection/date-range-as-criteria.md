---
title: Date range as criteria
uid: selection_dynamic_date_range_options
description: Details date criterion in find selections.
author: {AnthonyYates}
keywords: NewSelection, Selection, Find, Date
so.topic: article
# so.envir:
so.client: web
---

# Dynamic date range as criteria

This section introduces and explains the **new** date range operators. You might also be interested in [referencing all criteria operators][1] and [how to convert from legacy operators to new ones][2].

## Overview

* **This and next (n) (interval):** When a user select **This and next**, the selection returns all records with dates in the current period and the next periods the user has specified.

* **This and previous (n) (interval):** When a user select **This and previous**, the selection returns all records with dates in the current period as well as date in the previous periods the user has specified.

* **Previous period (n) (interval):** When a user selects **Previous period**, the selection returns all records from the previous periods the user has specified.

* **This period (list):** When a user selects **This period**, the selection returns all records with the current period specified.

* **Next period (n) (interval):** When a user selects **Next period**, the selection returns all records with the next periods the user has specified.

* **This, previous, and next (list):** When a user selects **This, previous and next**, the selection returns all records from the current period, the previous period and the next period, the user has specified.

## User input

The input is slightly different depending on whether the period is an interval or a list.

* For **lists**, the UI has a drop-down list where the user can select the type of period (also known as interval or unit): days, weeks, months, quarter, or years.

* For **intervals**, the UI has a number field in addition to the type drop-down list.

In the number field, the user is able to enter the number of days, weeks, months, and so on that they want the interval to run for. In the drop-down list, the user is able to select the interval.

The number field is unlimited, which means that the user is able to put any number in this field. The number represents the length of the interval.

When the user has selected the range they are looking for, a read-only text is shown next to the list with the dates the selected interval covers.

## This and next

The `thisAndNext` operator returns all records belonging to the current date's period and the next set of days, weeks, months, quarters, or years specified by the user.

When a user selects **This and next**, the right side of the line displays 2 fields: a number field and a drop-down list with the following options:

### Days

* The start date will be today (current day).
* The end date will be the last day of however many days the user has specified in the number field.

For example, if a user selects **This and next** 10 days and today is 15/10/2019, the date range will be 15/10/2019 – 25/10/2019. The selection includes all records that contains today's date or any date within the next 10 days.

### Weeks

* The start date will be the first day of current week
* The end date will be the last day of the last upcoming week specified by the user.

For example, if a user selects **This and next** 2 weeks and today is 15/10/2019, the date range will be 14/10/2019 – 03/11/2019. The selection includes all records that contains dates from the current week or any date within the next 2 weeks.

### Month

* The start date will be the first date of the current month
* The end date will be the last day of the last upcoming month the user has specified.

For example, Iif a user selects **This and next** 2 months and today is 15/10/2019, the date range will be 01/10/2019 – 31/12/2019. The selection includes all records that contain dates from the current month or any date within the next 2 months.

### Quarter

* The start date will be first day of the current quarter
* The end date will be the last day of the last upcoming quarter the user specified.

For example, if a user selects **This and next** 1 quarter and today is 15/10/2019, the date range will be 01/10/2019 – 31/03/2020. The selection includes records with dates from the current quarter or any date within the next quarter.

### Year

* The start date will be the first day of the current year
* The end date will be the last day of the last year the user has specified.

For example, if the user selects **This and next** 2 years and today is 15/10/2019, the date range will be 01/01/2019 – 31/12/2021. The selection includes all records with dates the current year or any date within the next 2 years.

## This and previous

The `thisAndPrevious` operator returns all items that are the previous set of days, weeks, months, quarter, or years specified by the user, **until and including the current period**.

When the user has selected **This and previous** as an operator, the right side of the line displays 2 fields: a number field and a drop-down list with the following options:

### Days

* The start date will be the first date when counting back the number of days from today the user has set as the number value
* The end date is today (current day).

For example, if the user selects **This and previous** 5 days, and today is 15/10/2019, the date range is 10/10/2019 – 15/10/2019. The selection includes all records with dates from the previous 5 days until and including today (15/10/2019).

### Weeks

* The start date will be the first date when counting back from the current week the number of weeks the user has set as the number field.
* The end date is the last day of the current week.

For example, if a user selects **This and previous** 3 weeks and today is 15/10/2019, the date range is 23/09/2019 – 20/10/2019. The selection includes all records with dates from the previous 3 weeks + the current week.

### Months

* The start date will be the first date of the month when counting back from current month the number of months specified in the number field.
* The end date is today (current day).

For example, if a user selects **This and previous** 4 months and today is 15/10/2019, the date range is 01/06/2019 – 31/10/2019. The selection includes all records with dates from the previous 4 months + the current month.

### Quarter

* The start date is the first date of the quarter when counting back from the first day of the current quarter the number of quarters set in the number field.
* The end date is end date of the current quarter.

For example, Iif a user selects **This and previous** 2 quarters and today is 15/10/2019, the date range is 01/04/2019 – 31/12/2019. The selection includes all record with dates from the previous 2 quarters + the current quarter.

### Years

* The start date is the first day of the previous year/years.
* The end date is the last day of the current year.

For example, if the user selects **This and Previous** 2 years and today is 15/10/2019, the date range is 01/01/2017 – 31/12/2019. The selection includes all records with dates from the 2 previous years, which is 2017 and 2018, it also includes all days of 2019.

## Previous period

The `previousPeriod` operator returns all items that are in the previous period set of days, weeks, months, quarter, or years specified by the user.

When the user has selected **Previous period**, the right side of the line displays 2 fields: a number field and a drop-down list with the following options:

### Days

* The start date will be the first date of the previous period specified by the user.
* The end date will be the last date of the set period.

For example, if a user selects **Previous period** 14 days and todays date is 15/10/2019, the date range will be 01/10/2019 – 14/10/2019. Meaning, the selection includes all records from the last 14 days, but not include the records from today

### Weeks

* The start date will be the first date of the previous week.
* The end date will be the last date of the previous week.

For example, if a user selects **Previous period** 2 weeks and todays date is 15/10/2019, the date range will be 30/09/2019 – 13/10/2019. Meaning, the selection includes all records from the last 2 weeks, but not include records from the current week.

### Months

* The start date will be the first date of the previous month.
* The end date will be the last date of the previous month.

For example, if a user selects **Previous period** 6 months and todays date is 15/10/2019, the date range is: 01/04/2019 – 30/09/2019. Meaning, the selection includes all records from the last six months, but not include records from the current month.

### Quarter

* The start date will be the first date of the previous quarter.
* The end date will be the last date of the previous quarter.

For example, if a user selects **Previous period** 1 quarter and todays date is 15/10/2019, the date range is 01/06/2019 – 30/09/2019. Meaning, the selection includes all records from the last quarter.

### Years

* The start date will be the first date of the previous year.
* The end date will be the last date of the previous year.

For example, if a user selects **Previous period** 2 years and todays date is 15/10/2019, the date range will be 01/01/2017 – 31/12/2018. Meaning, the selection includes all records from the previous 2 years, which is 2017 and 2018, it does not include the current year.

## This Period

The `thisPeriod` operator returns all items that are of this period, of the selected set of days, weeks, months, quarter, or years specified by the user.

When the user has selected **This period**, the right side of the line displays a drop-down list with the following options:

### This week

* The start date will be the first day of the week in the current week.
* The end date will be the last day of the week, which is normally a Sunday.

For example, if a user selects **This week** and todays date is 15/10/2019, the date range will be 14/10/2019 – 20/10/2019 (which is week 42). Meaning, the selection includes all records from the current week.

### This Month

* The start date will be the first date of the month, in the current month.
* The end date will be the last day of the month.

For example, if a user selects **This month** and todays date is 15/10/2019, the date range will be 01/10/2019 – 31/10/2019 (which is October). Meaning, the selection is only to include records from the current month.

### This quarter

* The start date will be the first day of the first month in the current quarter.
* The end date will be the last day of the last month, in the current quarter.

For example, if a user selects **This quarter** and todays date is 15/10/2019, the date range will be 01/10/2019 – 31/12/2019. Meaning, the selection is only to include records from the current quarter.

### This year

* The start date will be the first day of the current year.
* The end date will be the last date of the current year.

For example, if a user selects **This year** and todays date is 15/10/2019, the date range will be 01/01/2019 – 31/12/2019. Meaning, the selection is only to include records from the current year, which in this case is 2019.

## Next period

The `nextPeriod` operator returns all items that are of the next period, specified by the user.

When the user has selected **Next period**, the right side of the line displays 2 fields: a number field and a drop-down list with the following options:

### Days

* The start date will be the first day of the next period, which will be the day after the current day.
* The end date will be the last date in the next period specified by the user.

> [!NOTE]
> Days will always start running from tomorrow and run the number of days set in the number field, until and including the last day of the set range.

For example, if the user selects **Next period** 3 days and the current date is 15/10/2019, the date range will be the 16/10/2019 – 18/10/2019. Meaning, the selection is only to include records with dates in the next 3 days, and not include the current date.

### Weeks

* The start date will be the first day of the next week.
* The end date will be the last date of the last week of the specified range.

For example, if the user selects **Next period** 4 weeks and the current date is 15/10/2019 (week 42), the date range is 21/10/2019 – 17/11/2019. Meaning, the selection is only to include records with dates in the next 4 weeks (week 43, 44, 45 and 46), and not the current week.

> [!NOTE]
> If the user would have selected **Next period** 7 days this would have a given the user a different result than next 1 week.

### Months

* The start date will be the first day of the following month.
* The end date will be the last day of the last month in the specified range.

For example, if the user selects **Next period** 1 month and the current date is 15/10/2019, the date range is 01/11/2019 – 30/11/2019. Meaning, the selection will only include the next month and not the current month.

### Quarter

* The start date will be the first day of the following quarter.
* The end date will be the last day of the last quarter in the specified range.

For example, if the user selects the **Next period** 2 quarters and the current date is 15/10/2019, the date range is 01/01/2019 – 30/06/2019. Meaning, the selection includes the next 2 quarters (Q1 and Q2) and not the current quarter.

### Year

* The start date will be the first date of the next year.
* The end date will be the last date of the last year in the specified range.

For example, if a user selects **Next period** 3 years and the current date is 15/10/2019, the date range is 01/01/2020 – 31/12/2022. Meaning, the selection will include the next 3 years and not any dates of the current year.

## This, Previous, and Next

The `thisPreviousAndNext` operator returns all items that are of the selected unit in the list dropdown. It will give the user the records that are of dates in the previous period, this period and the next period.

When the user has selected **This, Previous, and Next**, the right side of the line displays a drop-down list with the following options:

### Day

* The start date will be the previous day (yesterday).
* The end date will be tomorrow.

For example, if a user selects **This, Previous and Next** days and todays date is 15/10/2019, the date range is 14/10/2019 – 16/10/2019. Meaning, the selection will include records from yesterday, today and tomorrow.

### Week

* The start date will be the first day of the previous week.
* The end date will be the last day of next week.

For example, if a user selects **This, Previous and Next** week and todays date is 15/10/2019, the date range is 07/10/2019 – 27/10/2019. Meaning, the result will include all records from the last week, the current week and the next week.

### Month

* The start date will be the first day of the previous month.
* The end date will be the last day of the next month.

For example, if a user selects **This, Previous and Next** and todays date is 15/10/2019, the date range is 01/09/2019 – 30/11/2019. Meaning, the selection will include all records from the last month, the current month and the following month.

### Quarter

* The start date will be the first day of the previous quarter.
* The end date will be the last day of the next quarter.

For example, if a user selects **This, Previous and Next** and todays date is 15/10/2019, the date range is 01/06/2019 – 30/09/2019. Meaning, the selection will include records from the last quarter, the current quarter and the next quarter.

### Year

* The start date will be the first day of the previous year.
* The end date will be the last date of the next year.

For example, if a user selects **This, Previous and Next** and todays date is 15/10/2019, the date range is 01/01/2018 – 31/12/2020. Meaning, the selection will include records from last year, the current year and the next year.

<!-- Referenced links -->
[1]: operators.md
[2]: convert-to-new-date-range-operators.md
