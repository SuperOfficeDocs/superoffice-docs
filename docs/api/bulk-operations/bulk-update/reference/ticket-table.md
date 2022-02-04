---
title: Ticket table
uid: bulkupdate_ticket_table
description: Bulk update ticket table
author: Bergfrid Skaara Dias
so.date: 01.27.2022
keywords: bulk update, ticket
so.topic: reference
so.envir: cloud
so.client: online
---


# Ticket table

Ticket fields. Key constants are in `BulkUpdateSystem.TicketFieldValueKeys`.

<table>
    <title>Ticket</title>
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
                <p>Author</p>
            </td>
            <td rowspan="2">
                <p>Set, Clear, SearchAndReplace, RegEx</p>
                <p></p>
                <p></p>
                <p></p>
            </td>
            <td rowspan="2">
                <p>Values Count = 0 to 7</p>
                <p>Set: Values[0] = (string)</p>
                <p>Clear: <br>Clears value</p>
                <p>SearchAndReplace:<br>Values[1] = searchString<br>Values[2] = replaceString<br>Values[3] = options</p>
                <p>RegEx:<br>Values[4] = expression<br>Values[5] = replace with<br>Values[6] = options</p>
            </td>
            <td>
                <p>Author</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Title</p>
            </td>
            <td>
                <p>Title</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>ActivateDate</p>
            </td>
            <td>
                <p>Set</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (datetime)</p>
            </td>
            <td>
                <p>Activate</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Deadline</p>
            </td>
            <td>
                <p>Set</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (datetime)</p>
            </td>
            <td>
                <p>Deadline</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>ReadByOwner</p>
            </td>
            <td>
                <p>Set</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (datetime)</p>
            </td>
            <td>
                <p>ReadByOwner</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Category</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) Category</p>
            </td>
            <td>
                <p>Category</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>OriginalCategory</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) OrigCategory</p>
            </td>
            <td>
                <p>OrigCategory</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>InternalStatus</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) Status</p>
            </td>
            <td>
                <p>Status</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>UserStatus</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) TicketStatus</p>
            </td>
            <td>
                <p>TicketStatus</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>ReadStatus</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) ReadStatus</p>
            </td>
            <td>
                <p>ReadStatus</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Origin</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) Origin</p>
            </td>
            <td>
                <p>Origin</p>
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
                <p>Values[0] = (int) Priority</p>
            </td>
            <td>
                <p>Priority</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>OriginalPriority</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) OrigPriority</p>
            </td>
            <td>
                <p>OrigPriority</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>OwnedBy</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) OwnedBy</p>
            </td>
            <td>
                <p>OwnedBy</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>SecurityLevel</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) Slevel</p>
            </td>
            <td>
                <p>Slevel</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Tags</p>
            </td>
            <td>
                <p>addItems, removeItems, Clear</p>
            </td>
            <td>
                <p>addItems: <br />
                Values Count = 0&hellip;n<br />
                Values[n] = (int)</p>
                <p>removeItems: <br />
                Values Count = 1&hellip;n<br />
                Values[n] = (int)</p>
                <p>Clear: <br>Clears all existing rows</p>
            </td>
            <td>
                <p>Tags</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>MdoTag</p>
            </td>
            <td>
                <p>Add, Remove, Clear</p>
            </td>
            <td>
                <p>Values Count = 0&hellip;2<br /></p>
                <p>Add: if value doesn’t already exist<br />
                Values[0] = (string) value<br/>
                Values[1] = (string) description</p>
                <p>Remove: <br/>
                Values[0] = (string) value</p>
                <p>Clear: <br>Clears all existing rows</p>
            </td>
            <td>
                <p>Tags</p>
            </td>
        </tr>
    </tbody>
</table>
