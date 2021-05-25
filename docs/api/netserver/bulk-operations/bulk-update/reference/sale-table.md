---
title: Sale Table
uid: bulkupdate_sale_table
description: Bulk update Sale table
author: Tony Yates
so.date: 06.23.2017
keywords:
so.topic: reference
so.envir: cloud
so.client: online
---

# Sale Table

Sale fields. Key constants are in `BulkUpdateSystem.SaleFieldValueKeys`.

<table>
    <title>Sale</title>
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
                <p>Associate</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>TypeAndStage</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 2</p>
                <p>Values[0] = (int) SaleTypeId <br>Values[1] = (int) ProbabilityId</p>
            </td>
            <td>
                <p>SaleType</p>
                <p>Probability</p>
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
                <p>Check:<br>Values[0] = (int)<br>0 = Do Not Know<br>1 = No<br>2 = Yes</p>
                <p>Toggle:<br>invert current value</p>
            </td>
            <td>
                <p>Done</p>
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
                <p>Values[0] = (Date) <br>Format: InvariantInfo</p>
                <p>Clear: 1/1/0001 12:00:00 AM</p>
            </td>
            <td>
                <p>Saledate</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Heading</p>
            </td>
            <td rowspan="3">
                <p>Set, Clear, SearchAndReplace, RegEx</p>
            </td>
            <td rowspan="3">
                <p>Values Count = 0 to 7</p>
                <p>Set: Values[0] = (string)</p>
                <p>Clear: <br>Clears value</p>
                <p>SearchAndReplace:<br>Values[1] = searchString<br>Values[2] = replaceString<br>Values[3] = options</p>
                <p>RegEx:<br>Values[4] = expression<br>Values[5] = replace with<br>Values[6] = options</p>
            </td>
            <td>
                <p>Heading</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Description</p>
            </td>
            <td>
                <p>SaleText</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Number1</p>
            </td>
            <td>
                <p>Number1</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>EarningAmount</p>
            </td>
            <td>
                <p>Set</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (double) earning</p>
            </td>
            <td>
                <p>Earning<br>EarningPercent<br>Amount</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>EarningPercent</p>
            </td>
            <td>
                <p>Set</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (double) percent</p>
            </td>
            <td>
                <p>EarningPercent<br>Earning</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Amount</p>
            </td>
            <td>
                <p>Set</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (double) amount</p>
            </td>
            <td>
                <p>Amount<br>Earning<br>EarningPercent</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Probability&nbsp;</p>
            </td>
            <td>
                <p>Set</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (short) probability</p>
            </td>
            <td>
                <p>Probability</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Source</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) SourceId</p>
            </td>
            <td>
                <p>Source</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Competitor</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) ComptrId</p>
            </td>
            <td>
                <p>ComptrId</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Credited</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) CreditedId</p>
            </td>
            <td>
                <p>Credited</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Currency</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) CurrencyId</p>
            </td>
            <td>
                <p>Currency</p>
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
        <tr>
            <td>
                <p>Activitylink</p>
            </td>
            <td>
                <p>Add, Remove, ReplaceWith, Clear</p>
            </td>
            <td>
                <p>Values are encoded as tableName=recordId values with an optional comment:</p>
                <p>&ldquo;appointment=78&rdquo; <br>or<br>&ldquo;appointment=78&amp;comment=Some link comment&rdquo;</p>
                <p>Allowed table names:<br>(case-sensitive)<br>appointment, document, project, sale or URL</p>
                <p>Add:<br>Creates and adds all values as RelationRows.</p>
                <p>Remove:<br>Deletes all similar relations.</p>
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
                <p>Values[0] = (int) IsPublished<br>0 = Not published<br>1 = Published</p>
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
