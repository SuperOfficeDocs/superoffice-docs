---
uid: help-en-recurrence-set
title: Schedule repeating follow-up
description: Instead of recording these meetings one at a time, you can schedule repeating follow-ups
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: diary, follow-up, repeat, recur, frequency, schedule, pattern
so.topic: howto
language: en
---

# Schedule repeating follow-up

To set up recurrence means to schedule the *start date* of follow-ups in a series. At the upper left of the dialog, the start date and time for the follow-up as well as the end time are displayed.

[!include[Caution](../includes/caution-do-not-change-recurring-date.md)]

## Steps

<!-- markdownlint-disable MD051 -->
### [Classic](#tab/fields-old)

1. [Open or create a follow-up][2].

2. Select the **Details** tab and click the word **Never** next to the **Recurrence** field.

    If you are updating a repeating follow-up, click the previously set pattern, for example, **Monthly (23.09.2023 - 23.09.2024)**.

3. Choose **frequency:** should the follow-up be repeated daily, weekly, monthly, yearly, or at a user-defined interval?

4. Select further details for the [frequency pattern][4]. The options in the box depend on what you select in step 3.
    If none of the patterns work for you, you can manually enter the dates you require.
    Select **Custom**. Then select a date in the calendar and click the arrow ![icon][img2] to add it to the list of selected dates. Repeat to add more dates. To remove a date, select the date in the list and click **Delete**.

5. In the **Repeating follow-ups ends** field, choose if the follow-up should stop after a specific number of times or after a specific date.

6. Optionally, change one or more dates manually in the list of selected dates, for example, if there is a conflict.

    * **To move a date**, select the date you want to move, and click **Later** to defer the follow-up by one day, or **Earlier** to bring the follow-up one day forwards.

    * **To add a date**, click the **Add** button below the list. Select the required date and click the arrow button ![icon][img2] to the right of the calendar to add the date to the list. Use the arrow buttons on either side of the month name in the calendar to display other months.

    * **To remove a date**, select the date you want to remove, and click the **Delete** button below the list. The date will then be removed from the list of dates.

7. Click **OK** to save the dates and close the dialog, or click **Cancel** to close the dialog without saving the dates.

    In the dialog, the text next to the **Recurrence** field will show what sort of repetition you specified for the follow-up, for example, **Monthly (23.09.2023 - 23.09.2024)**.

8. Click **Save** in the **Follow-up** dialog to save all changes.

![Repeating follow-ups dialog -screenshot][img6]

### [New (from version 10.2.11 pilot)](#tab/fields-new)

1. [Open or create a follow-up][2].

1. Click the repeat icon ![icon][img1] and select one of the suggested frequencies. If none of the patterns work for you, select **Custom**.

    ![Follow-up dialog, suggested recurrence -screenshot][img8]

    If you do not see the icon, click **Show more**.

1. Update the start date if necessary.

1. Select a frequency, for example, repeat every 2 weeks. Additional options appear if you select *Week(s)*, *Month(s)*, or *Year(s)*.

    ![Follow-up dialog, recurrence -screenshot][img7]

1. Choose if the follow-up should stop after a specific number of times or after a specific date.

1. Optionally, fine-tune the list of selected dates, for example, if there is a conflict. Click a date, then use the buttons below the list to either remove or move that date.

1. Click **OK** to save the dates and return to the follow-up details.

1. Click **Save** in the **Follow-up** dialog to save all changes.

***
<!-- markdownlint-restore -->

## What would you like to find out more about?

* [Edit repeating follow-up][1]
* [Stop repeating follow-up][3]

<!-- Referenced links -->
[1]: ../edit-follow-up.md#repeat
[2]: ../create-follow-up.md
[3]: stop.md
[4]: index.md#frequency

<!-- Referenced images -->
[img1]: ../../../../../common/icons/refresh-icon.png
[img2]: ../../../../media/icons/arrow-right.png
[img6]: ../../../../media/loc/en/diary/recurrence-dialog.png
[img7]: ../../../../media/loc/en/diary/recurrence-selected-dates.png
[img8]: ../../../../media/loc/en/diary/suggested-pattern.png
