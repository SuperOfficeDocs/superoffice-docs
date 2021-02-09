---
# Mandatory fields.
title: bulkupdate_user_defined_fields # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Bulk update user-defined fields # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates
so.date: 06.23.2017
keywords:
so.topic: reference # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud # cloud or onsite
so.client: online # online, web, win, pocket, or mobile
---

# User-Defined Tables

User-Defined fields. Key constants are the user-defined field `progId`.

<table>
    <title>User-Defined Fields</title>
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
            <td>
                <p>Number and</p>
                <p>Decimal</p>
            </td>
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
                <p>ShortText and LongText</p>
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
        </tr>
        <tr>
            <td>
                <p>Date and UnlimitedDate</p>
            </td>
            <td>
                <p>Set, Clear</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Set:<br>Values[0] = (Date)<br>or<br>Values[0] = (DateTime)</p>
                <p>Format: InvariantInfo</p>
                <p>Clear: <br>Sets date to min date: 1/1/0001 12:00:00 AM</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Checkbox</p>
            </td>
            <td>
                <p>Check and Toggle</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Check:<br>Values[0] = (int) or (bool)</p>
                <p>Toggle:<br>invert current value</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>List</p>
            </td>
            <td>
                <p>SelectOne, Clear (?)</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>SelectOne:<br>Values[0] = (int)</p>
                <p>Clear:<br>Only on certain UDF&rsquo;s.</p>
            </td>
        </tr>
    </tbody>
</table>
