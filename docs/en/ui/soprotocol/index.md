---
title: SoProtocol
uid: soprotocol
description: SoProtocol
author: Tony Yates
date: 09.24.2024
version: 10.3
keywords: soprotocol, deeplinking
topic: concept
---

# SoProtocol

**SOProtocol** is a standard for defining URL short-cuts to SuperOffice entities. It lets you control the user interface without scripting and send users directly to the desired screen.

## Why use SoProtocol

* No Scripting is needed, although scripts can [invoke an soprotocol URL][4].
* Works with the integrated web browser (webpages can control the CRM client user interface).
* Works with both web and Windows (legacy) clients.
* Security, it's primarily for navigation and cannot write data into the database.

## How is an SoProtocol URL defined

SOProtocol URLs have multiple parts, and can be either opened directly in the browser:
`https://{{environment}}.superoffice.com/{{tenant}}/default.aspx?{{WHERE}}?{{WHAT}}`

Or be [invoker through a script][4]:
`soprotocol:{{WHERE}}?{{WHAT}}`

The {{WHERE}} tells SuperOffice which page to display, and what tabs to select. See the [SoProtocol targets reference][2] for a list of soprotocol targets.

The {{WHAT}} tells SuperOffice what data to display on the page, such as a specific contact or project by id.

Example:
`https://{{environment}}.superoffice.com/{{tenant}}/default.aspx?target-screen.upper-tab.lower-tab.mini-card?[entity]_id=id`

or

`soprotocol:target-screen.upper-tab.lower-tab.mini-card?[entity]_id=id`

## Practical examples

### 1

On the company page, showing the main tab above and the contacts grid below, with the company details on the right, where the contact_id equals 2, use the following SoProtocol URL:

`soprotocol:contact.main.personarchive.minicontact?contact_id=2`

![08][img4]

### 2

This URL opens the project page displaying the **More** (udef) tab:

`http://localhost/SuperOfficeWeb/default.aspx?project.udef`

Here, *project* is the target panel, and *udef* is the target upper tab view.

![01][img1]

### 3

This link opens the project page displaying the links tab above and the project members grid tab below:

`http://localhost/SuperOfficeWeb/default.aspx?project.links.projectmemberarchive`

![02][img2]

## SoProtocol and SuperState

SoProtocol drives the [SuperState][1], meaning when you set an [entity]_id equal to a value, the current representation of that entity is set by the id. The SuperState is defined by the SoProtocol URL together with the values of SuperState history. If no SoProtocol is given, the last valid SuperState history will be used.

## Find current state

To get the SOProtocol link that reflects the current state of the application, use the browser address bar to view the current page information and copy the address.
Alternatively, use the **Copy Shortcut** option in the task button when available to get the current SoProtocol.

![03][img3]

> [!TIP]
> It is possible to test an SoProtocol by running PageUpdate in the console/browser's DevTools. For instance, opening a [CustomObject][3] can be achieved by running the command 'PageUpdate("soprotocol:customobject?customobject_name=y_car&customobject_id=1");'.

## SCIL

SuperOffice has an ongoing project to port existing pages from `pagebuilder` to `SCIL`.
Working with `soprotocol` in SCIL-pages are similar to the old pagebuilder, so existing soprotocol-requests should still work. The only exception is `[dialog=...]` which is deprecated and will no longer have any effect.

### Document

The soprotocol should be on the format: `soprotocol:document.main[new=true]?appointment_id=0&...other args...`

The property `[new=true]` is mandatory if opening a new document, and can be escaped if opening an existing one.

The following parameters are supported:

| Property                     | Description                                                                                     |
|------------------------------|-------------------------------------------------------------------------------------------------|
| `document_id`                | Document id, if 0, a new document is created.                                                  |
| `contact_id`                 | Set the current contact.                                                                       |
| `person_id`                  | Set the current person.                                                                        |
| `sale_id`                    | Set the current sale.                                                                          |
| `project_id`                 | Set the current project.                                                                       |
| `logicmode`                  | "default" or "sendandarchive"                                                                                    |
| `setvisiblefor`              | If true, use the same logic as if the preference "remember visible for" is enabled.            |
| `suggesteddocument_id`       | Suggested document id.                                                                         |
| `email_item_id`              | If set, the document is created from this e-mail                                                                                |
| `email_attachment_id`        | Email attachment id.                                                                           |
| `savedreport`                | If true, create the document from a saved report.                                              |
| `reportid`                   | Report id.                                                                                     |
| `documenttemplate_id`        | The template to use for the document.                                                          |
| `documentdate_name`          | The date of the document in C# "ticks".                                                        |
| `documentheading_name`       | The heading of the document.                                                                   |
| `documentfile_name`          | Filename to use.                                                                               |
| `documentforeignkey_name`    | Set a custom field in the document entity.                                                     |
| `documentforeignkey_type`    | The value of the custom field defined above.                                                   |

#### Examples

##### Open an existing document

`soprotocol:document.main?document_id=1000`

##### Create a new document with pre-selected document template

`soprotocol:document.main[new=true]?document_id=0&documenttemplate_id=10`

### Appointment

The soprotocol should be on the format: `soprotocol:appointment.main[new=true]?appointment_id=0&...other args...`

The property `[new=true]` is mandatory if opening a new appointment, and can be escaped if opening an existing one.

The following parameters are supported:

| Property                     | Description                                                                                     |
|------------------------------|-------------------------------------------------------------------------------------------------|
| `appointment_id`             | ID of the appointment to open. If set, the appointment will be opened. For new appointments, this should be set to 0. |
| `appointment_type`           | Type of the appointment. 5 = Todo, 6 = Phone. Anything else is considered a meeting. This will be used to select the task type. |
| `appointmenttask_name`       | ID of the task to create when creating a new appointment. This lets you set an actual task instead of the default meeting, phone, etc. |
| `appointmenttitle_name`      | Title of the new appointment.                                                                  |
| `appointmentagenda_name`     | Agenda of the new appointment (HTML).                                                          |
| `appointmentdescription_name`| Description of the new appointment (plain text).                                               |
| `doby`                       | Start date when creating new appointment. Format: YYYY.MM.DD HH:mm. Can be without time information. |
| `enddate`                    | End date when creating new appointment. Format: YYYY.MM.DD HH:mm.                              |
| `length`                     | Duration when creating new appointment – set instead of enddate. If both are set, length wins. |
| `usedefaulttime`             | Indicates that the `doby`/`enddate` parameters above are missing the time component, and the default time should be used. |
| `calendarassociate_id`       | The owner when creating a new appointment.                                                     |
| `useprojectcurrent`          | If true, sets “current” project on the new appointment. For example, when creating an appointment from the project activity archive. |
| `usesalecurrent`             | If true, sets “current” sale on the new appointment. For example, when creating an appointment from the sale activity archive. |
| `reopen`                     | If true, uses the current sale and `CreateDefaultReopenAppointment()` to create the new appointment. Set when stalling a sale. |
| `groupview`                  | If present, the appointment is created from the group view (Diary -> View). Any text value will enable this. |
| `addparticipants`            | If present and `groupview` is set, adds participants from the current group view automatically. If not set, checks preferences for invite behavior. |
| `basedon`                    | Appointment ID to use as the base of the new appointment. Conflicts with `reopen`. If both are set, `reopen` wins. |
| `suggestedappointment_id`    | Appointment ID to use as the base of the new appointment. Conflicts with similar parameters, and the other parameters will win. |
| `entity`                     | Entity to use with `suggestedappointment_id`. Can be "project" or "sale". Defaults to "sale" if unset but `suggestedappointment_id` is provided. |
| `assignto`                   | If set to any string value, the appointment will be assigned to the requested owner.            |
| `create`                     | Parameter passed to `CreateDefaultAppointmentEntityFromSaleSuggestion()`. Should be "true" or "false". |
| `pids`                       | Comma-separated list of person IDs to invite.                                                  |

#### Examples

##### Open an existing appointment

`soprotocol:appointment.main?appointment_id=1000`

##### Create a new appointment based on another appointment

`soprotocol:appointment.main[new=true]?appointment_id=0&basedon=1000`

##### Create a follow-up on 2020-12-15 using default time (next 15-minute slot)

`soprotocol:appointment.main[new=true]?appointment_id=0&doby=2020.12.15 10:30&usedefaulttime=true`

##### Create a follow-up with a specified title and agenda

`appointment.main[new=true]?appointment_id=0&appointmenttask_name=6&appointmenttitle_name=Meeting Title&appointmentagenda_name=Agenda`

<!-- Referenced links -->
[1]: ../web-app/pagebuilder/superstate/index.md
[2]: navigation-points.md
[3]: custom-object.md
[4]: ./in-crmscript.md

<!-- Referenced images -->
[img1]: media/project-udef.png
[img2]: media/project-note-projectmembersarchive.png
[img3]: media/copy-shortcut.png
[img4]: media/contact-contact_id.png
