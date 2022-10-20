---
uid: screen-element-reference
title: Working with fields
description: Reference of elements available in the Screen Designer in Settings and maintenance.
author: Bergfrid Dias
so.date: 10.14.2022
keywords: ui, screen, customization
so.topic: reference
so.version: 10
---

# Reference

## Company

**Standard fields:**

| Field | Type | Can hide label | Comment |
|---|---|:-:|---|
| [Address][6] | Address | x | Show in expanded mode |
| Business | Text | x | |
| [Category][8] | Text | x | |
| Code | Text | x | |
| Company name | Text | x | |
| Country | Text | x | |
| Department | Text | x | |
| Email | Text | x | |
| ERP | ERP | x | Has no options. Configured in **Settings and maintenance** > **ERP**. |
| Fax | Text | x | |
| [Interests][7] | Interests | x | Has no options |
| Last modified | Date | x | |
| Main contact | Text | x | |
| No mailings | Checkbox | x | |
| Note | Text box | x | |
| Number | Text | x | |
| Our contact | Text | x | |
| Our service contact | Text | x | |
| Phone | Text | x | |
| Priority | Text | x | |
| Registered date | Date | x | |
| Single interest | Checkbox | x | Select interest from list |
| Stop | Checkbox | x | |
| VAT No | Text | x | |
| Website | Text | x | |
| Custom fields | | x | Both user-defined and extra |

For details about the value of each field, see the [Contact database table][2].

**Default tabs:**

* Company
* More
* Interests
* Note

## Contact

**Standard fields:**

| Field | Type | Can hide label | Comment |
|---|---|:-:|---|
| Academic title | Text | x | |
| [Address][6] | Address | x | Show in expanded mode |
| Birthdate | Text | x | |
| Business | Text | x | |
| Category | Text | x | |
| Chat | Text | x | |
| Company | Text | x | |
| Country | Text | x | |
| Direct phone | Text | x | |
| Email | Text | x | |
| ERP | ERP | x | Has no options. Configured in **Settings and maintenance** > **ERP**. |
| Fax | Text | x | |
| First name | Text | x | |
| Former employee | Checkbox | x | |
| [Interests][7] | Interests | x | Has no options |
| Internet phone | Text | x | |
| Last modified | Date | x | |
| Last name | Text | x | |
| Middle name | Text | x | |
| Mobile | Text | x | |
| Mr/Ms | Text | x | |
| Note | Text box | x | |
| Number | Text | x | |
| Our contact | Text | x | |
| Our service contact | Text | x | |
| Position | Text | x | |
| Preferred language | Selection | x | |
| Private | Text | x | |
| Registered date | Date | x | |
| Service priority | Text | x | |
| Single interest | Checkbox | x | Select interest from list |
| Subscription | | x | |
| Title | Text | x | |
| Use as postal address | Checkbox | x | |
| Website | Text | x | |
| Custom fields | | x | Both user-defined and extra |

For details about the value of each field, see the [Person database table][3].

**Default tabs:**

* Contact
* Details
* More
* Interests
* Note

## Sale

**Standard fields:**

| Field | Type | Can hide label | Comment |
|---|---|:-:|---|
| Company | Dropdown | x | |
| Competitor | Dropdown | x | |
| Contact | Dropdown | x | |
| Credited | Dropdown | x | |
| Description | Text box | | Select number of rows. Has no label |
| Last modified | Date | x | |
| Links | Links | | Has no options |
| Number | Text | x | |
| Owner | Drop-down | x | |
| Probability | Text | x | Right-aligned percent |
| Profit | Number | x | Percent and amount |
| Project | Dropdown  | x | |
| Registered date | Date | x | |
| Sale date | Date picker | x | |
| Sale type | Drop-down | x | |
| Sales | Text | x | |
| Source | Dropdown | x | |
| Stage | Drop-down | x | |
| Stage - workflow | Multiline text | | Has no options |
| Total cost | Number | x | Right-aligned amount |
| Visible for | Text | x | |
| Custom fields | | x | Both user-defined and extra |

For details about the value of each field, see the [Sale database table][4].

**Default tabs:**

* Sale
* Details
* More
* Links
* Note

## Project

**Standard fields:**

| Field | Type | Can hide label | Comment |
|---|---|:-:|---|
| Description | Text box | | Select number of rows. Has no label |
| End date | Date picker | x | |
| ERP | ERP | x | Has no options. Configured in **Settings and maintenance** > **ERP**. |
| Last modified | Date | x | |
| Next milestone | | x | |
| Number | Text | x | |
| Project | Text | x | |
| Published | Checkbox | x | |
| Registered date | Date | x | |
| Responsible | Drop-down | x | |
| Status | Drop-down | x | |
| Type | Drop-down | x | |
| Website | Text | x | |
| Custom fields | | x | Both user-defined and extra  |

For details about the value of each field, see the [Project database table][5].

**Default tabs:**

* Project
* More
* Note
* Image
* Links

## Related content

* [Working with fields][1]
* [Address formats][6]
* [Learn more about sales][9]
* [Learn more about projects][10]

<!-- Referenced links -->
[1]: configurable-screens/working-with-fields.md
[2]: ../../database/tables/contact.md
[3]: ../../database/tables/person.md
[4]: ../../database/tables/sale.md
[5]: ../../database/tables/project.md
[6]: ../../globalization-and-localization/address/index.md
[7]: ../../company/interests.md
[8]: ../../company/category-list.md
[9]: ../../sale/overview.md
[10]: ../../project/overview.md

<!-- Referenced images -->
