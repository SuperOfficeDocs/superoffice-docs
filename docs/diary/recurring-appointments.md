---
title: Recurring appointments
uid: recurring_appointment
description: Recurring appointment
author: Bergfrid Skaara Dias
so.date: 03.18.2022
keywords: diary, calendar, appointment, recurrence, recurrencerule, frequency, pattern
so.topic: concept
---

# Recurring appointments

A repeating follow-up is a series of appointments, tasks, or calls scheduled to occur at regular intervals. For example, a weekly status meeting. A recurring appointment is stored in two parts:

* A recurrence rule, which defines the pattern of the recurrence
* All the appointments created by the recurrence are created in the [appointment table][3], and each one points to the recurrence rule that defines it.

> [!CAUTION]
> Modifying the start or end date on a recurring appointment after it has been saved is a bad idea. Changing the time on a recurring appointment will work fine, but changing the date will only lead to confusion. **Changing the start time on an appointment will trigger an update on all subsequence recurrences** if you have set the update mode to this-and-forward.

## Frequency

| Value   | Description | Comment | Example |
|:--------|:---|:---|:---|
| daily   | every working day<br>every day of the week | or custom | every other day |
| weekly  | every week on given day  | must set weekday       | every 3 weeks on Tuesday |
| monthly | every month on given day | must set day of month  | on the 5th of the month, every 4th month |
| yearly  | every year on given date | must set day and month | every 23rd of September |

A **cycle** is the number of days between each recurrence.

The enum values correspond to what you see in the **Pattern** dialog.

![Recurring follow-up dialog -screenshot][img1]

### Enum RecurrencePattern

| Value | Description |
|:-:|:---|
| 0 | unknown |
| 1 | daily |
| 2 | weekly |
| 3 | monthly |
| 4 | yearly |
| 5 | custom |

### Enum RecurrenceSubPattern

| Value | Name | Type | Description |
|:--:|:---|---|---|
| 0 | Unknown        |        | |
| 1 | EveryWorkday   | daily  | Mon-Fri |
| 2 | EveryWeekday   | daily  | Mon-Sun |
| 3 | EveryCyclicDay | daily  | cyclic interval of days |
| 4 | DayOfMonth     | weekly | repeat on day n of the month<br>ex: the 17th day of every 2 months |
| 5 | WeekdayOfMonth | weekly | repeat on given weekday <br>ex: the 3rd Thursday of every 3 months |
| 6 | DayOfMonth     | yearly | repeat on given date every year |
| 7 | WeekdayOfMonth | yearly | repeat on given weekdays of month<br>ex: the 3rd Thursday of every August |

> [!CAUTION]
> The **sub-pattern should match the pattern**. There is little error-checking if you mix the wrong set. You can set pattern = yearly and sub-pattern = dailyEveryDay and something strange will probably happen.

#### Weekdays

| Value | Weekday |
|:---:|:--|
| 0  | Unknown |
| 1  | Monday |
| 2  | Tuesday |
| 4  | Wednesday |
| 8  | Thursday |
| 16 | Friday |
| 32 | Saturday |
| 64 | Sunday |

> [!TIP]
> Enumeration flag values can be combined.

#### Week of month

| Value | Description |
|:-:|:---|
| 0 | Unknown |
| 1 | The 1st week of the month |
| 2 | The 2nd week of the month |
| 3 | The 3rd week of the month |
| 4 | The 4th week of the month |
| 5 | The last week of the month |

## Example (SQL)

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

Let's look at the rule:

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

## How-tos

* [Create recurring appointment - web services][4]
* [Create recurring appointment - entity layer][2]

## See also

* [recurrencerule table][1]
* [RecurrencePattern enum][5]

<!-- Referenced links -->
[1]: ../database/tables/recurrencerule.md
[2]: howto/entity/create-recurring-appointment-entity.md
[3]: ../database/tables/appointment.md
[4]: howto/services/create-recurring-appointment-services.md
[5]: ../database/enums/recurrencepattern.md

<!-- Referenced images -->
[img1]: media/recurrence-dialog.png
