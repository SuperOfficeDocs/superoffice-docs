---
# Mandatory fields.
title: bulkupdate_extra_fields # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Bulk update extra-fields # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates
so.date: 06.23.2017
keywords:
so.topic: reference # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud # cloud or onsite
so.client: online # online, web, win, pocket, or mobile
---

<table>
    <title>Extra Fields</title>
    <thead>
        <tr>
            <th>
                <p>Field Type</p>
            </th>
            <th>
                <p>OperationTypes</p>
            </th>
            <th>
                <p>Expected Field Values</p>
            </th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>Integer</td>
            <td>
                <p>Set</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int)</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Clob and Varchar</p>
            </td>
            <td>
                <p>SelectOne, Clear, SearchAndReplace, RegEx</p>
            </td>
            <td>
                <p>Values Count = 0 to 7</p>
                <p>SelectOne: Values[0] = (string)</p>
                <p>Clear: Clears value</p>
                <p>SearchAndReplace:<br>Values[1] = searchString<br>Values[2] = replaceString<br>Values[3] = options</p>
                <p>RegEx:<br>Values[4] = expression<br>Values[5] = replace with<br>Values[6] = options</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Date and DateTime</p>
            </td>
            <td>
                <p>Set, Clear</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Set:<br>Values[0] = (Date)<br>or<br>Values[0] = (DateTime)</p>
                <p>Clear: <br>Sets date to min date: 1/1/0001 12:00:00 AM</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Time</p>
            </td>
            <td>
                <p>Set</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Check:<br>Values[0] = (int)</p>
                <p>Value:<br>Number of minutes since midnight.</p>
            </td>
        </tr>
        <tr>
            <td>TimeSpan</td>
            <td>Set, Clear</td>
            <td>
                <p>Values Count = 1</p>
                <p>Set:<br>Values[0] = (int, day)<br>Values[1] = (int, hour)<br>Values[2] = (int, minute)</p>
                <p>Clear: <br>Sets TimeSpan to 0</p>
            </td>
        </tr>
        <tr>
            <td>Bool</td>
            <td>Set</td>
            <td>
                <p>Values Count = 1</p>
                <p>Check:</p>
                <p>Values[0] = (int) 0 or 1<br>0 = False<br>1 = True</p>
            </td>
        </tr>
        <tr>
            <td>Float</td>
            <td>Set</td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (float)</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>CustomerId,<br>TicketId,<br>UserId,<br>AttachmentId,<br>CategoryId,<br>PriorityId,<br>FaqEntryId,<br>SaleId,<br>ProjectId,<br>AppointmentId,<br>ContactCategoryId,<br>BusinessId,<br>ExtraTableId
                </p>
            </td>
            <td>SelectOne, Clear</td>
            <td>
                <p>Values Count = 1</p>
                <p>Set:<br>Values[0] = (int)</p>
                <p>Clear: <br>Sets value to 0</p>
            </td>
        </tr>
        <tr>
            <td>Link: Not Supported</td>
            <td><p></p></td>
            <td>
                <p></p>
            </td>
        </tr>
    </tbody>
</table>
