---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: Date range as criteria      # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Details date criterion in find selections.  # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {AnthonyYates}             # Your GitHub alias.
keywords: NewSelection, Selection, Find, Date
so.topic: article                      # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
so.client: web                   # online, web, or win
---

# Date range as criteria

The current dynamic date ranges for selections in SuperOffice CRM does not cover all the ranges that are necessary for keeping selections up to date and providing good data quality. The date ranges already in SuperOffice has been few and not very conclusive of the function they served. We have therefore decided to remove some of them and to add a few that will cover a bigger range of dates, for the past, the current and the future.  

## Dynamic data ranges

The old set of date operators in selections was as follows:

1. Before
2. Equals
3. After
4. Between
5. To
6. From
7. Beforetoday
8. Today
9. Aftertoday
10. Lastweek
11. Thisweek
12. Nextweek
13. Lastmonth
14. Thismonth
15. Nextmonth
16. LastQuarter
17. ThisQuarter
18. NextQuarter
19. Thishalf
20. Nextyear

The operators that has a line through is the ones that will be removed. Overall 11 of the old date operators will be removed and 6 new will be added to cover for the ones removed.

New dynamic date ranges

The new list of operators:

1. Before
2. Equals
3. After
4. Between
5. To
6. From
7. Before today
8. Today
9. After today
10. This and Next (n) (interval)
11. This and previous (n) (interval)
12. Previous period (n) (interval)
13. This Period (list)
14. Next period (n) (interval)
15. This, previous and next (list)

The operators with an underline are new.

The new date range operators are as follows:

This and Next (n) (interval): When a user select this and next, the selection should return all records with dates in the current period and the next periods the user has specified with a number field and interval dropdown.

This and previous (n) (interval): When a user select this and previous, the selection should return all records with dates in the current period as well as date in the previous periods the user has specified with a number field and interval dropdown.

Previous period (n) (interval): When a user selects previous period, the selection should return all records from the previous periods the user has specified with a number field and interval dropdown.

This Period (list): When a user selects this period, the selection should return all records with the current period specified from the list dropdown.

Next period (n) (interval): When a user selects next period, the selection should return all records with the next periods the user has specified with a number field and an interval dropdown.

This, previous and next (list): When a user selects this, previous and next, the selection should return all records from the current period, the previous period and the next period, the user has specified in the list dropdown.


This and next 

The "This and next" operator should return all records that are of the current dates period and the next set of days, weeks, months, quarters or years specified by the user.  

 

When a user selects "This and next", the right side of the line should display two fields. The two fields are a number field and a list dropdown. In the number field the user should be able to enter the number of days, weeks, months, etc. they want the interval to run for. In the list dropdown the user should be able to select the interval. 

The number field should be unlimited, which means that the user should be able to put any number in this field. The number should represent the length of the interval. 

The unit/interval dropdown for the "This and next" operator should only contain the following intervals: 

Days: The start date will be today (current day), the end date will be the last day of however many days the user has specified in the number field. If a user selects "This and next" 10 days and today is 15/10/2019, the date range will be 15/10/2019 – 25/10/2019. The selection should then include all records that contains today's date or any date within the next 10 days. 

Weeks: The start date will be the first day of current week, the end date will be the last day of the last upcoming week specified by the user. If a user selects "This and next" 2 weeks and today is 15/10/2019, the date range will be 14/10/2019 – 03/11/2019. The selection should then include all records that contains dates from the current week or any date within the next 2 weeks. 

Month: The start date will be the first date of the current month; the end date will be the last day of the last upcoming month the user has specified. If a user selects "This and next" 2 months and today is 15/10/2019, the date range will be 01/10/2019 – 31/12/2019. The selection should then include all records that contain dates from the current month or any date within the next 2 months. 

Quarter: The start date will be first day of the current quarter; the end date will be the last day of the last upcoming quarter the user specified. If a user selects "This and next" 1 quarter and today is 15/10/2019, the date range will be 01/10/2019 – 31/03/2020. The selection should then include records with dates from the current quarter or any date within the next quarter. 

Year: The start date will be the first day of the current year, the end date will be the last day of the last year the user has specified. If the user selects "This and next" 2 years and today is 15/10/2019, the date range will be 01/01/2019 – 31/12/2021. The selection should then include all records with dates the current year or any date within the next 2 years. 

 

When the user has selected the range they are looking for, a read-only text should be shown next to the list dropdown displaying the dates the selected interval covers. 

 
This and previous 

The "This and previous" operator should return all items that are the previous set of days, weeks, months, quarter or years specified in the number and list dropdown, until and including the current period. 

 

 

When the user has selected "This and previous" as an operator the right side of the line should display 2 fields, a number field and a list dropdown. In the number field the user should enter the number of days, weeks, months, etc. they want the interval to run for. In the list dropdown the user should be able to select the interval.  

The number field should be unlimited, meaning that the user should be able to put any number in this field. This number should represent the length of the interval. 

The unit dropdown should only contain the following units/intervals: 

Days: The start date will be the first date when counting back the number of days from today the user has set as the number value. The end date should be today (current day). If the user selects this and previous 5 days, and today is 15/10/2019, the date range should be 10/10/2019 – 15/10/2019. The selection should then include all records with dates from the previous 5 days until and including today (15/10/2019). 

Weeks: The start date will be the first date when counting back from the current week the number of weeks the user has set as the number field. The end date should be the last day of the current week. If a user selects "This and previous" 3 weeks and today is 15/10/2019, the date range should be 23/09/2019 – 20/10/2019. The selection should then include all records with dates from the previous 3 weeks + the current week. 

Months: The start date will be the first date of the month when counting back from current month the number of months specified in the number field. End date should be today (current day). If a user selects "This and previous" 4 months and today is 15/10/2019, the date range should be 01/06/2019 – 31/10/2019. The selection should include all records with dates from the previous 4 months + the current month. 

Quarter: The start date should be the first date of the quarter when counting back from the first day of the current quarter the number of quarters set in the number field. The end date should be end date of the current quarter. If a user selects "This and previous" 2 quarters and today is 15/10/2019, the date range should be 01/04/2019 – 31/12/2019. The selection should include all record with dates from the previous 2 quarters + the current quarter. 

Years: The start date should be the first day of the previous year/years. The end date should be the last day of the current year. If the user selects "This and Previous" 2 years and today is 15/10/2019, the date range should be 01/01/2017 – 31/12/2019. The selection should include all records with dates from the 2 previous years, which is 2017 and 2018, it should also include all days of 2019. 

 

When the user has selected the range they are looking for, a read-only text should be shown next to the list dropdown displaying the dates the selected interval covers. 

Previous period 

The "Previous period" operator should return all items that are in the previous period set of days, weeks, months, quarter or years specified in the number field and the list dropdown.  

 
 

When the user has selected Previous period, the right side of the line should display 2 fields, a number field and a list dropdown. In the number field the user should enter the number of days, weeks, months, etc. they want the interval to run for. In the list dropdown the user should be able to select the interval.  

The number field should be unlimited, meaning that the user should be able to put any number in this field. This number should represent the length of the interval. 

The unit dropdown should only contain the following units/intervals: 

Days: Start date will be the first date of the previous period specified by the user. The end date will be the last date of the set period. If a user selects "Previous period" 14 days and todays date is 15/10/2019, the date range will be 01/10/2019 – 14/10/2019. Meaning, the selection should include all records from the last 14 days, but not include the records from today. 

Weeks: Start date will be the first date of the previous week. The end date will be the last date of the previous week. If a user selects "Previous period" 2 weeks and todays date is 15/10/2019, the date range will be 30/09/2019 – 13/10/2019. Meaning, the selection should include all records from the last 2 weeks, but not include records from the current week. 

Months: Start date will be the first date of the previous month. The end date will be the last date of the previous month. If a user selects "Previous period" 6 months and todays date is 15/10/2019, the date range should be: 01/04/2019 – 30/09/2019. Meaning, the selection should include all records from the last six months, but not include records from the current month. 

Quarter: The start date will be the first date of the previous quarter. The end date will be the last date of the previous quarter. If a user selects "Previous period" 1 quarter and todays date is 15/10/2019, the date range should be 01/06/2019 – 30/09/2019. Meaning, the selection should include all records from the last quarter. 

Years: Start date will be the first date of the previous year. The end date will be the last date of the previous year. If a user selects "Previous period" 2 years and todays date is 15/10/2019, the date range will be 01/01/2017 – 31/12/2018. Meaning, the selection should include all records from the previous 2 years, which is 2017 and 2018, it should not include the current year.  

 

When the user has selected the range they are looking for, a read-only text should be shown next to the list dropdown displaying the dates the selected interval covers. 

 

 

 

 

 

 

 

 

 

 

This Period 

The "This Period" operator should return all items that are of this period, of the selected set of days, weeks, months, quarter or years specified in the list dropdown. 

 

When the user has selected "This period" operator, the right side of the line should display a list dropdown. In the list dropdown the user should be able to select among the following: 

This week: The start date will be the first day of the week in the current week. End date will be the last day of the week, which is normally a Sunday. If a user selects "This week" and todays date is 15/10/2019, the date range will be 14/10/2019 – 20/10/2019 (which is week 42). Meaning, the selection should include all records from the current week. 

This Month: The start date will be the first date of the month, in the current month. The end date will be the last day of the month. If a user selects "This month" and todays date is 15/10/2019, the date range will be 01/10/2019 – 31/10/2019 (which is October). Meaning, the selection is only to include records from the current month. 

This quarter: The start date will be the first day of the first month in the current quarter. The end date will be the last day of the last month, in the current quarter. If a user selects "This quarter" and todays date is 15/10/2019, the date range will be 01/10/2019 – 31/12/2019. Meaning, the selection is only to include records from the current quarter. 

This year: The start date will be the first day of the current year. The end date will be the last date of the current year. If a user selects this year and todays date is 15/10/2019, the date range will be 01/01/2019 – 31/12/2019. Meaning, the selection is only to include records from the current year, which in this case is 2019. 

 

When the user has selected the range they are looking for, a read-only text should be shown next to the list dropdown displaying the dates the selected interval covers. 

 
Next period  

The "Next period" operator should return all items that are of the next period, specified by the user in the number and list dropdown.  

 
 

When the user has selected the next period operator, the right side of the line should display 2 fields, a number field and a list dropdown. In the number field the user should enter the number of days, weeks, months, etc. they want the interval to run for. In the list dropdown the user should be able to select the interval.  

The number field should be unlimited, meaning that the user should be able to put any number in this field. This number should represent the length of the interval. 

The unit dropdown should only contain the following units/intervals: 

Days: The start date will be the first day of the next period, which will be the day after the current day. The end date will be the last date in the next period specified by the user. Days will always start running from tomorrow and run the number of days set in the number field, until and including the last day of the set range. If the user selects "Next period" 3 days and the current date is 15/10/2019, the date range will be the 16/10/2019 – 18/10/2019. Meaning, the selection is only to include records with dates in the next 3 days, and not include the current date. 

Weeks: The start date will be the first day of the next week. The end date will be the last date of the last week of the specified range. If the user selects "Next period" 4 weeks and the current date is 15/10/2019 (week 42), the date range should be 21/10/2019 – 17/11/2019. Meaning, the selection is only to include records with dates in the next 4 weeks (week 43, 44, 45 and 46), and not the current week. If the user would have selected next period 7 days this would have a given the user a different result than next 1 week. 

Months: The start date will be the first day of the following month. Then end date will be the last day of the last month in the specified range. If the user selects "Next period" 1 month and the current date is 15/10/2019, the date range should be 01/11/2019 – 30/11/2019. Meaning, the selection will only include the next month and not the current month. 

Quarter: The start date will be the first day of the following quarter. The end date will be the last day of the last quarter in the specified range. If the user selects the "Next period" 2 quarters and the current date is 15/10/2019, the date range should be 01/01/2019 – 30/06/2019. Meaning, the selection should include the next 2 quarters (Q1 and Q2) and not the current quarter. 

Year: The start date will be the first date of the next year. The end date will be the last date of the last year in the specified range. If a user selects "Next period" 3 years and the current date is 15/10/2019, the date range should be 01/01/2020 – 31/12/2022. Meaning, the selection will include the next 3 years and not any dates of the current year. 

 

When the user has selected the range they are looking for, a read-only text should be shown next to the list dropdown displaying the dates the selected interval covers. 

This, Previous and Next 

The "This, Previous and Next" operator should return all items that are of the selected unit in the list dropdown. The "This, Previous and Next" will give the user the records that are of dates in the previous period, this period and the next period. 

 

When the user has selected the "This, Previous and Next" operator, the right side of the line should display a list dropdown. In the list dropdown the user should be able to select among the following: 

Day: The start date will be the previous day (yesterday), the end date will be tomorrow. If a user selects "This, Previous and Next" days and todays date is 15/10/2019, the date range should be 14/10/2019 – 16/10/2019. Meaning, the selection will include records from yesterday, today and tomorrow. 

Week: The start date will be the first day of the previous week, the end date will be the last day of next week. If a user selects "This, Previous and Next" week and todays date is 15/10/2019, the date range should be 07/10/2019 – 27/10/2019. Meaning, the result will include all records from the last week, the current week and the next week. 

Month: The start date will be the first day of the previous month, the end date will be the last day of the next month. If a user selects "This, Previous and Next" and todays date is 15/10/2019, the date range should be 01/09/2019 – 30/11/2019. Meaning, the selection will include all records from the last month, the current month and the following month. 

Quarter: The start date will be the first day of the previous quarter, the end date will be the last day of the next quarter. If a user selects "This, Previous and Next" and todays date is 15/10/2019, the date range should be 01/06/2019 – 30/09/2019. Meaning, the selection will include records from the last quarter, the current quarter and the next quarter. 

Year: The start date will be the first day of the previous year, the end date will be the last date of the next year. If a user selects "This, Previous and Next" and todays date is 15/10/2019, the date range should be 01/01/2018 – 31/12/2020. Meaning, the selection will include records from last year, the current year and the next year. 

 

When the user has selected the range they are looking for, a read-only text should be shown next to the list dropdown displaying the dates the selected interval covers. 

 

Converting to new dynamic date ranges 

When removing old date operators and replacing them with new, users are already having existing selections based on old operators.  These selections should continue to give users the same result, which means existing criteria needs to be replaced by the equivalent new criteria. 

Old criteria 

Date examples if today is 18.03.2020 

New criteria 

10. Last week  

Monday 09.03.2020 - Sunday 15.03.2020 

Previous period 1 week 

11. This week  

Monday 16.03.2020 - Sunday 22.03.2020 

This period week 

12. Next week  

Monday 23.03.2020 - Sunday 29.03.2020 

Next period 1 week 

13. Last month  

01.02.2020 - 29.02.2020 

Previous period 1 month 

14. This month  

01.03.2020 - 31.03.2020 

This period month 

15. Next month  

01.04.2020 - 30.04.2020 

Next period 1 month 

16. Last Quarter  

01.10.2019 - 31.12.2019 

Previous period 1 quarter 

17. This Quarter  

01.01.2020 - 31.03.2020 

This period quarter 

18. Next Quarter  

01.04.2020 - 30.06.2020 

Next period 1 quarter 

19. This half 

01.01.2020 - 30.06.2020 

This period 6 months 

20. This year  

01.01.2020 - 31.12.2020 

This period year 

 

Additional requirements: 

The new dynamic date criteria are going to be released as a part of New Selection. As this functionality is going to be deployed to customers by enabling a feature toggle, a convert during db upgrade is not a possible solution. 

Users reading old selections requires convert of dynamic date range on the fly when NewSelection = true.  

When feature toggle for New Selection is removed, a db step can convert remaining selections automatically. 