---
title: Document Table
uid: bulkupdate_document_table
description: Bulk update Document table
author: Tony Yates
so.date: 06.23.2017
keywords:
so.topic: reference
so.envir: cloud
so.client: online
---

# Document Table

Document fields. Key constants are in `BulkUpdateSystem.DocumentFieldValueKeys`.

<table>
    <title>Document</title>
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
                <p>Done</p>
            </td>
            <td>
                <p>Check, Toggle</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Check:<br>Values[0] = (int)<br>0 = Status.NotStarted<br>1 = Status.Completed</p>
                <p>Toggle: invert current</p>
            </td>
            <td>
                <p>DocumentAppointment.Status</p>
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
                <p>DocumentAppointment.AssociateId DocumentAppointment.GroupIdx</p>
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
                <p>DocumentAppointment .ProjectId</p>
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
                <p>DocumentAppointment.SaleId</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Date</p>
            </td>
            <td>
                <p>Set, Clear</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Set:<br>Values[0] = (Date)<br>Format: InvariantInfo</p>
                <p>Clear = 1/1/0001 12:00:00 AM</p>
            </td>
            <td>
                <p>DocumentAppointment.ActiveDate<br>DocumentAppointment.EndDate<br>DocumentAppointment.DoBy<br>DocumentAppointment.Done
                </p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Subject</p>
            </td>
            <td rowspan="4">
                <p>Set, Clear, SearchAndReplace, RegEx</p>
            </td>
            <td rowspan="4">
                <p>Values Count = 0 to 7</p>
                <p>Set: Values[0] = (string)</p>
                <p>Clear: Clears value</p>
                <p>SearchAndReplace:<br>Values[1] = searchString<br>Values[2] = replaceString<br>Values[3] = options</p>
                <p>RegEx:<br>Values[4] = expression<br>Values[5] = replace with<br>Values[6] = options</p>
            </td>
            <td>
                <p>Header</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Description</p>
            </td>
            <td>
                <p>DocumentText</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>OurRef</p>
            </td>
            <td>
                <p>OurRef</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>YourRef</p>
            </td>
            <td>
                <p>YourRef</p>
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
                <p>DocumentAppointment.TaskIdx</p>
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
                <p>Values[0] = (int)</p>
                <p>Int.MinValue = All<br>Neg: -10 = GroupId (10)<br>Pos: 10 = AssociateId (10)</p>
            </td>
            <td>
                <p>DocumentAppointment.VisibleFor</p>
            </td>
        </tr>
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
                <p>&ldquo;sale=78&rdquo; <br>or<br>&ldquo;sale=78&amp;comment=Some link comment&rdquo;</p>
                <p>Allowed table names:<br>(case-sensitive)<br>appointment, document, project, sale or URL</p>
                <p>add:<br>Creates and adds all values as RelationRows.</p>
                <p>remove:<br>Deletes all similar relations.</p>
                <p>ReplaceWith:<br>Deletes all similar relations, then adds back new ones.</p>
                <p>Clear: <br>Deletes all existing relations.</p>
            </td>
            <td>
                <p>LinksHelper</p>
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
                <p>Values[0] = (int) IsPublished</p>
                <p>0 = Not published<br>1 = Published</p>
            </td>
            <td>
                <p>PublishHelper</p>
            </td>
        </tr>
    </tbody>
</table>

See [User-Defined Fields][1].

<!-- Referenced links -->
[1]: user-defined-fields.md
