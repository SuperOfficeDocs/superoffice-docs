---
uid: help-en-screen-designer-field-reference
title: Reference
description: Reference of elements available in the Screen Designer in Settings and maintenance.
keywords: Screen designer, layout, field, standard field, tab, standard tab
author: Bergfrid Dias
date: 10.07.2024
version: 10.3.6
topic: reference
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Reference

## Company

**Standard fields:**

| Field | Type | Comment |
|---|---|---|
| [Address][20] | Address | Show in expanded mode |
| Business | Text | |
| [Category][18] | Text | |
| Code | Text | |
| Company name | Text | |
| Country | Text | |
| Department | Text | |
| Email | Text | |
| ERP | ERP | Has no options. Configured in **Settings and maintenance** > **ERP**. |
| Fax | Text | |
| [Interests][17] | Interests | Has no options |
| Last modified | Date | |
| Main contact | Text | |
| No mailings | Checkbox | |
| Note | Text box | |
| Number | Text | |
| Our contact | Text | |
| Our service contact | Text | |
| Phone | Text | |
| Priority | Text | |
| Registered date | Date | |
| Single interest | Checkbox | Select interest from list |
| Stop | Checkbox | |
| VAT No | Text | |
| Website | Text | |
| Custom fields | | Both user-defined and extra |

For details about the value of each field, see the [Contact database table][2].

**Default tabs:**

* Company
* More
* Interests
* Note

## Contact

**Standard fields:**

| Field | Type | Comment |
|---|---|---|
| Academic title | Text | |
| [Address][20] | Address | Show in expanded mode |
| Birthdate | Text | |
| Business | Text | |
| Category | Text | |
| Chat | Text | |
| Company | Text | |
| Country | Text | |
| Direct phone | Text | |
| Email | Text | |
| ERP | ERP | Has no options. Configured in **Settings and maintenance** > **ERP**. |
| Fax | Text | |
| First name | Text | |
| Former employee | Checkbox | |
| [Interests][17] | Interests | Has no options |
| Internet phone | Text | |
| Last modified | Date | |
| Last name | Text | |
| Middle name | Text | |
| Mobile | Text | |
| Mr/Ms | Text | |
| Note | Text box | |
| Number | Text | |
| Our contact | Text | |
| Our service contact | Text | |
| Position | Text | |
| Preferred language | Selection | |
| Private | Text | |
| Registered date | Date | |
| Service priority | Text | |
| Single interest | Checkbox | Select interest from list |
| Subscription | | |
| Title | Text | |
| Use as postal address | Checkbox | |
| Website | Text | |
| Custom fields | | Both user-defined and extra |

For details about the value of each field, see the [Person database table][3].

**Default tabs:**

* Contact
* Details
* More
* Interests
* Note

## Sale

**Standard fields:**

| Field | Type | Comment |
|---|---|---|
| Company | Dropdown | |
| Competitor | Dropdown | |
| Contact | Dropdown | |
| Credited | Dropdown | |
| Description | Text box | Select number of rows. Has no label |
| Last modified | Date | |
| Links | Links | Has no options |
| Number | Text | |
| Owner | Drop-down | |
| Probability | Text | Right-aligned percent |
| Profit | Number | Percent and amount |
| Project | Dropdown  | |
| Registered date | Date | |
| Sale date | Date picker | |
| Sale type | Drop-down | |
| Sales | Text | |
| Source | Dropdown | |
| Stage | Drop-down | |
| Stage - workflow | Multiline text | Has no options |
| Total cost | Number | Right-aligned amount |
| Visible for | Text | |
| Custom fields | | Both user-defined and extra |

For details about the value of each field, see the [Sale database table][4].

**Default tabs:**

* Sale
* Details
* More
* Links
* Note

## Project

**Standard fields:**

| Field | Type | Comment |
|---|---|---|
| Description | Text box | Select number of rows. Has no label |
| End date | Date picker | |
| ERP | ERP | Has no options. Configured in **Settings and maintenance** > **ERP**. |
| Last modified | Date | |
| Next milestone | | |
| Number | Text | |
| Project | Text | |
| Published | Checkbox | |
| Registered date | Date | |
| Responsible | Drop-down | |
| Status | Drop-down | |
| Type | Drop-down | |
| Website | Text | |
| Custom fields | | Both user-defined and extra |

For details about the value of each field, see the [Project database table][5].

**Default tabs:**

* Project
* More
* Note
* Image
* Links

## Request

**Standard fields:**

| Field | Type | Comment |
|---|---|---|
| Access level | Drop-down | |
| Alert timeout | Text | |
| Author | Text | |
| Category | Drop-down | |
| Closed at | Date | |
| Company | Text | |
| Contact | Text | |
| Created |  Date | |
| Created by | Text | |
| Deadline | Date | |
| First read by owner | Date | |
| First read by user | Date | |
| Has attachment | Checkbox | |
| ID | Text | |
| Internal status | Text | |
| Language | Text | |
| Last changed | Date | |
| Level | Text | |
| Number of messages | Time | |
| Number of replies | Time | |
| Origin | Text | |
| Owner | Drop-down | |
| Postponed to | Text | |
| Priority | Drop-down | |
| Project | Drop-down | |
| Read | Text | |
| Read by owner | Date | |
| Real time externally | Time | |
| Real time internally | Time | |
| Real time in queue | Time | |
| Real time to close | Time | |
| Real time to reply | Time | |
| Replied at | Date | |
| [Request type][13] | Drop-down | |
| Sale | Drop-down | |
| Sentiment | Text | |
| Sentiment confidence | Text | |
| Status | Drop-down | |
| Tags | Drop-down | Has no options |
| Time spent | Time | |
| Time spent externally | Time | |
| Time spent in queue | Time | |
| Time to close | Time | |
| Time to reply | Time | |
| Title | Text | |
| Custom fields | | Both user-defined and extra |

For details about the value of each field, see the [Ticket database table][6].

**Default tabs:**

* Messages
* Details
* Change log

## Follow-up

**Standard fields:**

| Field | Type | Comment |
|---|---|---|
| Alarm | Drop-down | |
| [Check availability][15] | Scheduling assistant | |
| Completed | Checkbox | |
| Links | Multiline text | Select number of rows. Has no label |
| Owner | Drop-down | |
| Priority | Drop-down | |
| Project Drop-down | | |
| Sale | Drop-down | |
| [Suggested time slots][15] | | Has no options |
| Title | Text | Placement locked. |
| Type | Drop-down | Placement locked |
| Video link | Text | Has no options |
| Visible for | Drop-down | Has no options |
| Custom fields | | Both user-defined and extra |

* Mandatory fields cannot be moved or removed. This applies to: title, type, time, company/contact, attendees, locations, and resources.

* The right column is hidden if no attendees.

For details about the value of each field, see the [Appointment database table][7].

**Default tabs:**

* Agenda
* Internal notes
* Links

## Related content

* [Working with fields][1]
* [Address formats][20]
* [Learn more about sales][11]
* [Learn more about projects][10]
* [Learn more about requests][14]
* [Learn more about follow-ups][16]

<!-- Referenced links -->
[1]: working-with-fields.md
[2]: ../../../../en/database/tables/contact.md
[3]: ../../../../en/database/tables/person.md
[4]: ../../../../en/database/tables/sale.md
[5]: ../../../../en/database/tables/project.md
[6]: ../../../../en/database/tables/ticket.md
[7]: ../../../../en/database/tables/appointment.md
[11]: ../../../../en/sale/overview.md
[10]: ../../../../en/project/overview.md
[13]: ../../../request/learn/type/index.md
[14]: ../../../../en/request/overview.md
[15]: ../../../diary/learn/invitation/add-attendee.md#availability
[16]: ../../../diary/learn/follow-ups.md
[17]: ../../../../en/company/interests.md
[18]: ../../../../en/company/category-list.md
[20]: ../../../../en/globalization-and-localization/address/index.md
