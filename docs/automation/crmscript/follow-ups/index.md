---
uid: crmscript_followups
title: Calendar and todo list
author:
so.date:
keywords:
so.topic:
---

# Calendar and todo list

The diary in SuperOffice CRM is fundamentally a personal diary. It consists of a calendar and a todo list and is used similar to a Filofax with separate pages for every day, week, and month.

* **calendar**: shows entries allocated to a particular time or date
* **todo list**: shows stuff that you have not yet completed, mostly calls and tasks without time or date

In the UI, both are closely linked to the **Diary** screen.

## Three types of follow-ups

In SuperOffice CRM, *follow-up* is a collective term for **appointments**, **phone calls**, and **tasks** . These entities are always tied to an [associate][1] and have some form of [time][2] reference.

| type        | start time | end time | duration   | deadline | displayed | description | example |
|-------------|:----------:|:--------:|:----------:|:--------:|-----------|-------------|---------|
| appointment | x          | x        | calculated |          | calendar  | activity w/ defined start and end time | meetings |
| task/todo   |            |          |            | x        | todo list | follow-up w/ no start time | reminder for stuff due by a specific time |
| call        | x          |          | x          |          | todo list | phone call  |         |

> [!NOTE]
> Overdue appointments will by default also appear in the todo list!<br>Logged phone calls will also appear in the calendar.

## Follow-ups vs. activities

Follow-ups are part of a broader group of entities labeled **activities**:

* follow-ups
  * [appointment][3]
  * [task][4]
  * [call][5]
* documents
  * document
  * email
* mailings and form submissions
* chat sessions

> [!NOTE]
> It is important to understand the distinction between activities and follow-ups. When you get data from the [appointment table][6] or use the CRMScript [NSAppointment class][7], it is crucial that you pay attention to the **type** field.

## Follow-ups vs. other entities

When working with follow-ups, data will often intersect with the following entities:

* [company][8] (contact table)
* [contact][9] (person table)
* [project][11]
* [sale][10]

## In this section

1. autolist

<!-- Referenced links -->
[1]: ../persons-and-organizations/employees.md
[2]: ../datatypes/datetime-type.md
[3]: appointment.md
[4]: task.md
[5]: call.md
[6]: https://community.superoffice.com/documentation/SDK/SO.Database/html/Tables-appointment.htm
[7]: https://community.superoffice.com/documentation/SDK/SO.Customer.Service.Support/html/EJScript-Classes-NSAppointment-NSAppointment.htm
[8]: ../persons-and-organizations/company.md
[9]: ../persons-and-organizations/customer.md
[10]: ../sales/leads.md
[11]: ../projects/index.md
