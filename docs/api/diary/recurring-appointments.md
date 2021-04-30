---
title: recurring_appointment
description: Recurring appointment
author:
so.date:
keywords:
so.topic: concept
---

# Recurring appointments

A recurring appointment is stored in 2 parts:

* A recurrence rule is stored which defines the pattern of the recurrence
* All the appointments created by the recurrence are created in the `appointment` table, and each one points to the recurrence rule that defines it.

> [!CAUTION]
> Modifying the start or end date on a recurring appointment after it has been saved is a bad idea. Changing the time on a recurring appointment will work fine, but changing the date will only lead to confusion. **Changing the start time on an appointment will trigger an update on all subsequence recurrences** if you have set the update mode to this-and-forward.

## Recurrence pattern

**enum `Pattern`:**

* enPatternDaily
* enPatternWeekly
* enPatternMonthly
* enPatternYearly
* enPatternCustom

**enum `Subpattern`:**

* enSubPatternNone
* enDailyWorkday
* enDailyEveryDay
* enDailyCycle
* enMonthlyDate
* ...

The enum values correspond to what you see in the **Pattern** dialog.

![Recurring appointment dialog][img1]

> [!CAUTION]
> The sub-pattern should match the pattern. There is little error-checking if you mix the wrong set. You can set pattern = yearly and sub-pattern = dailyEveryDay and something strange will probably happen.

The system generates appointment records for all the recurrence instances:

```SQL
SELECT appointment_id, associate_id, activeDate, type, status, recurrenceRuleId 
FROM appointment WHERE recurrenceRuleId = 5
```

![x][igm2]

Taking a look at the rule itself:

```SQL
SELECT * FROM recurrencerule WHERE recurrencerule_id = 5
```

![x][img3]

This recurrence rule has:

* pattern = 2 (weekly) (corresponds to the radio-button choice in the dialog).
* subPattern = 0 (none)
* weekdays = 3 ( = 1+3 = monday + tuesday) (corresponds to the checkboxes marked in the dialog)
* cyclicWeek = 1  = "every 1 week(s)"

## Editing

If you decide to change the rule pattern in the middle of a series of appointments, then a new rule is created, and the old rule is stopped at the point where the break occurs.

If you change the start-time for a single appointment, the rule is not affected. The appointment is treated as an exception to the rule. The exception can be made un-exceptional by moving it back into line with the other appointments.

## See also

* [recurrencerule table][1]

<!-- Referenced links -->
[1]: ../../../database/docs/tables/recurrencerule.md

<!-- Referenced images -->
[img1]: media/repeat-dialog.gif
[img2]: media/recurrence-rule-table.png
[img3]: media/recurrence-rule-5.png
