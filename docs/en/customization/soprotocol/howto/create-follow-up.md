---
uid: sop-create-follow-up
title: Create Follow-up
description: How to create a Follow-up using the soprotocol
keywords: soprotocol, follow-up, create
author: Eivind Fasting
date: 11.26.2024
content_type: howto
category: customization
topic: soprotocol
redirect_from:
  - /en/ui/soprotocol/create-appointment
  - /en/ui/soprotocol/howto/create-follow-up
language: en
---

# Create follow-up

The soprotocol should be on the format: ```soprotocol:appointment.main[new=true]?appointment_id=0&...other args...```

Refer to the [follow-up arguments](#follow-up-arguments) for full list of available properties/args.

## Create a new follow-up with specified sale_id

To set sale when creating a new follow-up the property `usesalecurrent` needs to be set, in addition to the specific `sale_id`.

```soprotocol:appointment.main[new=true]?appointment_id=0&usesalecurrent=true&sale_id=1000```

## Create a new follow-up with specified project_id

To set project when creating a new follow-up the property `useprojectcurrent` needs to be set, in addition to the specific `project_id`.

```soprotocol:appointment.main[new=true]?appointment_id=0&useprojectcurrent=true&project_id=1000```

## Create a new follow-up based on another follow-up

```soprotocol:appointment.main[new=true]?appointment_id=0&basedon=1000```

## Create a follow-up on 2020-12-15 using default time (next 15-minute slot)

```soprotocol:appointment.main[new=true]?appointment_id=0&doby=2020.12.15 10:30&usedefaulttime=true```

## Create a follow-up with a specified title and agenda

```appointment.main[new=true]?appointment_id=0&appointmenttask_name=6&appointmenttitle_name=Meeting Title&appointmentagenda_name=Agenda```

## Follow-up arguments

The following arguments are supported when creating a new follow-up

| Property                     | Description                                                                                     |
|------------------------------|-------------------------------------------------------------------------------------------------|
| `appointment_id`             | ID of the appointment to open. If set, the appointment will be opened. For new appointments, this should be set to 0. |
| `appointment_type`           | Type of the appointment. 5 = Todo, 6 = Phone. Anything else is considered a meeting. This will be used to select the task type. |
| `tasktype`                   | ID of the task type to use for the new appointment. This lets you set an actual task instead of the default meeting, default phone and so on from appointment_type                                            |
| `appointmenttitle_name`      | Title of the new appointment.                                                                  |
| `appointmentagenda_name`     | Agenda of the new appointment (HTML).                                                          |
| `appointmentdescription_name`| Description of the new appointment (plain text).                                               |
| `doby`                       | Start date when creating new appointment. Format: YYYY.MM.DD HH:mm. Can be without time information. |
| `enddate`                    | End date when creating new appointment. Format: YYYY.MM.DD HH:mm.                              |
| `length`                     | Duration when creating new appointment – set instead of enddate. If both are set, length wins. |
| `usedefaulttime`             | Indicates that the `doby`/`enddate` parameters above are missing the time component, and the default time should be used. |
| `calendarassociate_id`       | The owner when creating a new appointment.                                                     |
| `useprojectcurrent`          | If true, sets ''current'' project on the new appointment. For example, when creating an appointment from the project activity archive. |
| `usesalecurrent`             | If true, sets ''current'' sale on the new appointment. For example, when creating an appointment from the sale activity archive. |
| `reopen`                     | If true, uses the current sale and `CreateDefaultReopenAppointment()` to create the new appointment. Set when stalling a sale. |
| `groupview`                  | If present, the appointment is created from the group view (Diary > View). Any text value will enable this. |
| `addparticipants`            | If present and `groupview` is set, adds participants from the current group view automatically. If not set, checks preferences for invite behavior. |
| `basedon`                    | Appointment ID to use as the base of the new appointment. Conflicts with `reopen`. If both are set, `reopen` wins. |
| `suggestedappointment_id`    | Appointment ID to use as the base of the new appointment. Conflicts with similar parameters, and the other parameters will win. |
| `entity`                     | Entity to use with `suggestedappointment_id`. Can be "project" or "sale". Defaults to "sale" if unset but `suggestedappointment_id` is provided. |
| `assignto`                   | If set to any string value, the appointment will be assigned to the requested owner.            |
| `create`                     | Parameter passed to `CreateDefaultAppointmentEntityFromSaleSuggestion()`. Should be "true" or "false". |
| `pids`                       | Comma-separated list of person IDs to invite.                                                  |
