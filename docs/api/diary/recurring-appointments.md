---
title: Recurring appointments
uid: recurring_appointment
description: Recurring appointment
author: Bergfrid Skaara Dias
so.date: 11.04.2021
keywords: diary, calendar, appointment, API, associate, recurrence, recurrencerule
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

![Recurring follow-up dialog -screenshot][img1]

> [!CAUTION]
> The sub-pattern should match the pattern. There is little error-checking if you mix the wrong set. You can set pattern = yearly and sub-pattern = dailyEveryDay and something strange will probably happen.

The system generates appointment records for all the recurrence instances:

```SQL
SELECT appointment_id, associate_id, activeDate, type, status, recurrenceRuleId 
FROM appointment WHERE recurrenceRuleId = 1
```

| appointment_id | associate_id | activeDate | type | status | recurrenceRuleId |
|---|---|---|---|---|---|
| 264 | 15 | 2021-11-04 11:30:00 | 1 | 1 | 1 |
| 267 | 15 | 2021-11-09 11:30:00 | 1 | 1 | 1 |
| 268 | 15 | 2021-11-11 11:30:00 | 1 | 1 | 1 |
| 269 | 15 | 2021-11-16 11:30:00 | 1 | 1 | 1 |
| 270 | 15 | 2021-11-18 11:30:00 | 1 | 1 | 1 |
| 271 | 15 | 2021-11-23 11:30:00 | 1 | 1 | 1 |

Taking a look at the rule itself:

```SQL
SELECT * FROM recurrencerule WHERE recurrencerule_id = 1
```

| RecurrenceRule_id | pattern | subPattern | startDate | endDate | cyclicDay | cyclicWeek | cyclicMonth|
|---|---|---|---|---|---|---|---|
| 1 | 2 | 0 | 2021-11-04 11:30:00 | 2022-01-27 12:00:00 | 0 | 1 | 0 |

This recurrence rule has:

* pattern = 2 (weekly) (corresponds to the radio-button choice in the dialog).
* subPattern = 0 (none)
* cyclicWeek = 1  = "every 1 week(s)"

## Editing

If you decide to change the rule pattern in the middle of a series of appointments, then a new rule is created, and the old rule is stopped at the point where the break occurs.

If you change the start time for a single appointment, the rule is not affected. The appointment is treated as an exception to the rule. The exception can be made un-exceptional by moving it back into line with the other appointments.

## See also

* [recurrencerule table][1]

<!-- Referenced links -->
[1]: ../../../database/docs/tables/recurrencerule.md

<!-- Referenced images -->
[img1]: media/recurrence-dialog.png
