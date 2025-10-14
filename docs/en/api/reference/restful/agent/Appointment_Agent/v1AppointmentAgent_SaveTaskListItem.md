---
title: POST Agents/Appointment/SaveTaskListItem
uid: v1AppointmentAgent_SaveTaskListItem
generated: true
content_type: reference
---

# POST Agents/Appointment/SaveTaskListItem

```http
POST /api/v1/Agents/Appointment/SaveTaskListItem
```

Updates the existing TaskListItem or creates a new TaskListItem if the id parameter is 0.


NsApiSlow threshold: 1000 ms.







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

## Request Body: taskListItem 

The TaskListItem that is saved 

| Property Name | Type |  Description |
|----------------|------|--------------|
| TaskListItemId | Integer | Primary key |
| Value | String | The list item |
| Direction | String | 1 = incoming, 2 = outgoing, see EAppntDirection |
| Type | String | 1 = app, 2 = doc, 3 = email, 4 = fax, 5 = phone, 6 = todo - see EAppntRecordTypes |
| Tooltip | String | Tooltip or other description |
| Deleted | Boolean | If true, the Task list item is deleted |
| IntentId | Integer | Link to the intention of this kind of task (used by SAINT) |
| Rank | Integer | Rank order |
| IsDefaultAlldayEvent | Boolean | True if all day event |
| IsDefaultFree | Boolean | True if free, false if busy |
| IsDefaultPublished | Boolean | Published to external persons |
| ColorIndex | String | JAP |
| DefaultVideomeetingStatus | String | Default video-meeting status for meetings created in SuperOffice CRM. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TaskListItem

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Appointment/SaveTaskListItem
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "TaskListItemId": 516,
  "Value": "ut",
  "Direction": "Incoming",
  "Type": "Appointment",
  "Tooltip": "qui",
  "Deleted": false,
  "IntentId": 53,
  "Rank": 56,
  "IsDefaultAlldayEvent": true,
  "IsDefaultFree": false,
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
  "TaskListItemId": 398,
  "Value": "quasi",
  "Direction": "Incoming",
  "Type": "Appointment",
  "Tooltip": "reprehenderit",
  "Deleted": false,
  "IntentId": 646,
  "Rank": 198,
  "IsDefaultAlldayEvent": false,
  "IsDefaultFree": false,
  "IsDefaultPublished": false,
  "ColorIndex": "BlueAlt1",
  "DefaultVideomeetingStatus": "NoChange",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 149
    }
  }
}
```