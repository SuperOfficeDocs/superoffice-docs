---
title: PUT List/Task/Items/{id}
uid: v1TaskList_PutTaskListItem
---

# PUT List/Task/Items/{id}

```http
PUT /api/v1/List/Task/Items/{id}
```

Updates the existing TaskListItem

Calls the Appointment agent service SaveTaskListItem.

| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of TaskListItem to be saved. **Required** |

## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: entity

The details of TaskListItem to be saved.

| Property Name | Type |  Description |
|----------------|------|--------------|
| TaskListItemId | int32 | Primary key |
| Value | string | The list item |
| Direction | string | 1 = incoming, 2 = outgoing, see EAppntDirection |
| Type | string | 1 = app, 2 = doc, 3 = email, 4 = fax, 5 = phone, 6 = todo - see EAppntRecordTypes |
| Tooltip | string | Tooltip or other description |
| Deleted | bool | If true, the Task list item is deleted |
| IntentId | int32 | Link to the intention of this kind of task (used by SAINT) |
| Rank | int32 | Rank order |
| IsDefaultAlldayEvent | bool | True if all day event |
| IsDefaultFree | bool | True if free, false if busy |
| IsDefaultPublished | bool | Published to external persons |
| ColorIndex | string | JAP |
| DefaultVideomeetingStatus | string | Default video-meeting status for meetings created in SuperOffice CRM. |

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 400 | Bad request. Entity to save is not in request body. |

Response body:

| Property Name | Type |  Description |
|----------------|------|--------------|
| TaskListItemId | int32 | Primary key |
| Value | string | The list item |
| Direction | string | 1 = incoming, 2 = outgoing, see EAppntDirection |
| Type | string | 1 = app, 2 = doc, 3 = email, 4 = fax, 5 = phone, 6 = todo - see EAppntRecordTypes |
| Tooltip | string | Tooltip or other description |
| Deleted | bool | If true, the Task list item is deleted |
| IntentId | int32 | Link to the intention of this kind of task (used by SAINT) |
| Rank | int32 | Rank order |
| IsDefaultAlldayEvent | bool | True if all day event |
| IsDefaultFree | bool | True if free, false if busy |
| IsDefaultPublished | bool | Published to external persons |
| ColorIndex | string | JAP |
| DefaultVideomeetingStatus | string | Default video-meeting status for meetings created in SuperOffice CRM. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/Task/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TaskListItemId": 138,
  "Value": "id",
  "Direction": "Incoming",
  "Type": "Appointment",
  "Tooltip": "nemo",
  "Deleted": false,
  "IntentId": 497,
  "Rank": 447,
  "IsDefaultAlldayEvent": false,
  "IsDefaultFree": true,
  "IsDefaultPublished": false,
  "ColorIndex": "BlueAlt1",
  "DefaultVideomeetingStatus": "NoChange"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TaskListItemId": 285,
  "Value": "error",
  "Direction": "Incoming",
  "Type": "Appointment",
  "Tooltip": "corrupti",
  "Deleted": false,
  "IntentId": 73,
  "Rank": 862,
  "IsDefaultAlldayEvent": false,
  "IsDefaultFree": false,
  "IsDefaultPublished": false,
  "ColorIndex": "BlueAlt1",
  "DefaultVideomeetingStatus": "NoChange",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 135
    }
  }
}
```
