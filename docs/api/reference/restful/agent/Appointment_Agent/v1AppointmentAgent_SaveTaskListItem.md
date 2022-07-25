---
title: POST Agents/Appointment/SaveTaskListItem
id: v1AppointmentAgent_SaveTaskListItem
---

# POST Agents/Appointment/SaveTaskListItem

```http
POST /api/v1/Agents/Appointment/SaveTaskListItem
```

Updates the existing TaskListItem or creates a new TaskListItem if the id parameter is empty

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

The TaskListItem to be saved.

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

## Response: object

Carrier object for TaskListItem.
Services for the TaskListItem Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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

## Sample Request

```http!
POST /api/v1/Agents/Appointment/SaveTaskListItem
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "TaskListItemId": 103,
  "Value": "sint",
  "Direction": "Incoming",
  "Type": "Appointment",
  "Tooltip": "iste",
  "Deleted": true,
  "IntentId": 278,
  "Rank": 58,
  "IsDefaultAlldayEvent": true,
  "IsDefaultFree": true,
  "IsDefaultPublished": true,
  "ColorIndex": "BlueAlt1",
  "DefaultVideomeetingStatus": "NoChange"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TaskListItemId": 424,
  "Value": "quia",
  "Direction": "Incoming",
  "Type": "Appointment",
  "Tooltip": "aperiam",
  "Deleted": false,
  "IntentId": 211,
  "Rank": 115,
  "IsDefaultAlldayEvent": true,
  "IsDefaultFree": true,
  "IsDefaultPublished": true,
  "ColorIndex": "BlueAlt1",
  "DefaultVideomeetingStatus": "NoChange",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 722
    }
  }
}
```
