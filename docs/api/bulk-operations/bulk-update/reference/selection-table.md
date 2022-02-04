---
title: Selection table
uid: bulkupdate_selection_table
description: Bulk update selection table
author: Tony Yates
so.date: 06.23.2017
keywords: bulk update, selection
so.topic: reference
so.envir: cloud
so.client: online
---

# Selection table

Selection fields. Key constants are in `BulkUpdateSystem.SelectionFieldValueKeys`.

<table>
<title>Selection</title>
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
                <p>Check:<br>Values[0] = (int)<br>0 = false<br>1 = True</p>
                <p>Toggle:<br>invert current value</p>
            </td>
            <td>
                <p>Row.Done</p>
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
                <p>Values[0] = (int) SearchCatId</p>
            </td>
            <td>
                <p>Row.SearchCatId</p>
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
                <p>Row.AssociateId<br>Row.GroupId</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Name</p>
            </td>
            <td rowspan="2">
                <p>Set, Clear, SearchAndReplace, RegEx</p>
            </td>
            <td rowspan="2">
                <p>Values Count = 0 to 7</p>
                <p>Set: Values[0] = (string)</p>
                <p>Clear: Clears value</p>
                <p>SearchAndReplace:<br>Values[1] = searchString<br>Values[2] = replaceString<br>Values[3] = options</p>
                <p>RegEx:<br>Values[4] = expression<br>Values[5] = replace with<br>Values[6] = options</p>
            </td>
            <td>
                <p>Name</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Description</p>
            </td>
            <td>
                <p>SelectionText</p>
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
                <p>Values[0] = (int)<br>Int.MinValue = All<br>Neg: -10 = GroupId (10)<br>Pos: 10 = AssociateId (10)</p>
            </td>
            <td>
                <p>VisibleFor</p>
            </td>
        </tr>
    </tbody>
</table>
