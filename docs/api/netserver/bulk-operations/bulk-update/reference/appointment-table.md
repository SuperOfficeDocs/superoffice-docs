---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: bulkupdate_appointment_table # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Bulk update Appointment table # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates
so.date: 06.23.2017
keywords:
so.topic: reference # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud # cloud or onsite
so.client: online # online, web, win, pocket, or mobile
---


# Appointment Table

Appointment fields. Key constants are in `BulkUpdateSystem.AppointmentFieldValueKeys`.

<table>
    <title>Appointment</title>
    <thead>
        <tr>
            <th>
                <p>FieldValueKeys</p>
            </th>
            <th>
                <p>OperationTypes</p>
            </th>
            <th>
                <p>Expected Field Values</p>
            </th>
            <th>
                <p>Affected Properties</p>
            </th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                <p>Activitylink</p>
            </td>
            <td>
                <p>Add, Remove, ReplaceWith, Clear</p>
            </td>
            <td>
                <p>Values Count = 1&hellip;n</p>
                <p>Values are encoded as tableName=recordId values with an optional comment:</p>
                <p>&ldquo;appointment=78&rdquo; or<br>&ldquo;appointment=78&amp;comment=Some link comment&rdquo;</p>
                <p>Allowed table names:<br>(case-sensitive)<br>appointment, document, project, sale or URL</p>
                <p>add:<br>Creates and adds all values as RelationRows.</p>
                <p>remove:<br>Deletes all similar relations.</p>
                <p>ReplaceWith:<br>Deletes all similar relations, then adds back new ones.</p>
                <p>Clear: deletes all existing relations.</p>
            </td>
            <td>
                <p>LinksHelper</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>AlarmOffSet</p>
            </td>
            <td>
                <p>Set</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) Alarm</p>
            </td>
            <td>
                <p>Alarm</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Description</p>
            </td>
            <td>
                <p>Set, Clear, SearchAndReplace, RegEx</p>
            </td>
            <td>
                <p>Values Count = 0 to 7</p>
                <p>Set: Values[0] = (string)</p>
                <p>Clear: Clears value</p>
                <p>SearchAndReplace:<br>Values[1] = searchString<br>Values[2] = replaceString<br>Values[3] = options</p>
                <p>RegEx:<br>Values[4] = expression<br>Values[5] = replace with<br>Values[6] = options</p>
            </td>
            <td>
                <p>AppointmentText</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Done</p>
            </td>
            <td>
                <p>Check, Toggle</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Check:<br>Values[0] = (int) 0 or 1<br>0 = Status.NotStarted<br>1 = Status.Completed</p>
                <p>Toggle: invert current</p>
            </td>
            <td>
                <p>Appointment.Status, Appointment.AssociateId, Appointment.GroupIdx</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>FreeBusy</p>
            </td>
            <td>
                <p>Set</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int)<br>0 = FreeBusy.Free<br>1 = FreeBusy.Busy</p>
            </td>
            <td>
                <p>FreeBusy</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>HasAlarm</p>
            </td>
            <td>
                <p>Check</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) HasAlarm<br>0 = No, 1&nbsp;= Yes</p>
            </td>
            <td>
                <p>HasAlarm</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Owner</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) AssociateId</p>
            </td>
            <td>
                <p>Owner</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>ProjectId</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) ProjectId</p>
            </td>
            <td>
                <p>ProjectId</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Priority</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) PriorityIdx</p>
            </td>
            <td>
                <p>Priority</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Published</p>
            </td>
            <td>
                <p>Check</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) IsPublished<br>0 = No,&nbsp;1 = Yes</p>
            </td>
            <td>
                <p>PublishHelper</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>SaleId</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) SaleId</p>
            </td>
            <td>
                <p>SaleId</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Type</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) TaskIdx</p>
            </td>
            <td>
                <p>Task</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>StartDate</p>
            </td>
            <td>
                <p>Set</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (datetime) <br>Only changes Date. Times are changed via StartTime field.</p>
            </td>
            <td>DoBy (Date Only)<br>EndDate (Date Only)</td>
        </tr>
        <tr>
            <td>
                <p>StartTime</p>
            </td>
            <td>
                <p>Set</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) <br>minutes since midnight relative to current datetime</p>
            </td>
            <td>
                <p>DoBy<br>EndDate</p>
                <p></p>
            </td>
        </tr>
        <tr>
            <td>
                <p>EndTime</p>
            </td>
            <td>
                <p>Set</p>
            </td>
            <td>
                <p></p>
            </td>
            <td>
                <p></p>
            </td>
        </tr>
        <tr>
            <td>
                <p>StartTimeAndEndTime</p>
            </td>
            <td>
                <p>Set</p>
            </td>
            <td>
                <p>Values Count = 2</p>
                <p>Values[0] = (int) DoBy<br>Values[1] = (int) EndDate</p>
                <p>minutes since midnight relative to current datetime</p>
            </td>
            <td>
                <p>DoBy<br>EndTime</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>VisibleFor</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) <br>Int.MinValue = All<br>Neg: -10 = GroupId (10)<br>Pos: 10 = AssociateId (10)</p>
            </td>
            <td>
                <p>VisibleFor</p>
            </td>
        </tr>
    </tbody>
</table>

See [User-Defined Fields][1].

<!-- Referenced links -->
[1]: user-defined-fields.md
