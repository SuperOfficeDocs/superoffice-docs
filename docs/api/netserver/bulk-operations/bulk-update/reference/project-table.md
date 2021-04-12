---
# Mandatory fields.
title: bulkupdate_project_table # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Bulk update Project table # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Tony Yates
so.date: 06.23.2017
keywords:
so.topic: reference # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud # cloud or onsite
so.client: online # online, web, win, pocket, or mobile
---

# Project Table

Project fields. Key constants are in `BulkUpdateSystem.ProjectFieldValueKeys`.

<table>
    <title>Project</title>
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
                <p>Responsible</p>
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
                <p>TypeAndStatus</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 2</p>
                <p>Values[0] = (int) TypeIdx <br>Values[1] = (int) StatusIdx</p>
            </td>
            <td>
                <p>Type</p>
                <p>Status</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Done&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
            </td>
            <td>
                <p>Check, Toggle</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Check:<br>Values[0] = (int)<br>0 = Not Done<br>1 = Done</p>
                <p>Toggle: invert current</p>
            </td>
            <td>
                <p>Done</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Number</p>
            </td>
            <td rowspan="3">
                <p>Set, Clear, SearchAndReplace, RegEx</p>
            </td>
            <td rowspan="3">
                <p>Values Count = 0 to 7</p>
                <p>Set: Values[0] = (string)</p>
                <p>Clear: Clears value</p>
                <p>SearchAndReplace:<br>Values[1] = searchString<br>Values[2] = replaceString<br>Values[3] = options</p>
                <p>RegEx:<br>Values[4] = expression<br>Values[5] = replace with<br>Values[6] = options</p>
            </td>
            <td>
                <p>ProjectNumber</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Name</p>
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
                <p>ProjectText</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>EndDate</p>
            </td>
            <td>
                <p>Set, Clear</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Set:<br>Values[0] = (Date) <br>Format: InvariantInfo</p>
                <p>Clear: 1/1/0001 12:00:00 AM</p>
            </td>
            <td>
                <p>EndDate</p>
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
                <p>Values are encoded as tableName=recordId with an optional comment.
                    Example:<br>&ldquo;appointment=78&rdquo; <br>or<br>&ldquo;appointment=78&amp;comment=Some link
                    comment&rdquo;</p>
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
                <p>Published&nbsp;&nbsp;</p>
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
        <tr>
            <td>
                <p>EventFromDate</p>
            </td>
            <td rowspan="2">
                <p>Set, Clear</p>
            </td>
            <td rowspan="2">
                <p>Values Count = 1</p>
                <p>Set: Values[0] = (Date)<br>Format: InvariantInfo</p>
                <p>Clear: 1/1/0001 12:00:00 AM</p>
            </td>
            <td>
                <p>PublishHelper.PublishStart</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>EventToDate</p>
            </td>
            <td>
                <p>PublishHelper.PublishEnd</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Url</p>
            </td>
            <td>
                <p>Add, Remove, ReplaceWith, Clear, SearchAndReplace, RegEx</p>
            </td>
            <td>
                <p>Values Count = 0 to 8</p>
                <p>Add: if value doesn&rsquo;t already exist<br>Values[0] = (string) value<br>Values[1] = (string)
                    description</p>
                <p>Remove: <br>Only one needs to match<br>Values[0] = (string) value<br>or...<br>Values[1] = (string)
                    description</p>
                <p>ReplaceWith:<br>Locates row with Rank =1 and updates it, removes all others. Updates
                    using:<br>Values[0] = (string) value<br>Values[1] = (string) description</p>
                <p>Clear: <br>Clears all existing rows</p>
                <p>SearchAndReplace:<br>Works on value only, not description.<br>Values[2] = searchString<br>Values[3] =
                    replaceString<br>Values[4] = Search Options</p>
                <p>RegEx:<br>Works on value only, not description.<br>Values[5] = expression<br>Values[6] = replace
                    with<br>Values[7] = Search Options</p>
            </td>
            <td>
                <p>Urls</p>
            </td>
        </tr>
    </tbody>
</table>

See [User-Defined Fields][1].

<!-- Referenced links -->
[1]: user-defined-fields.md
