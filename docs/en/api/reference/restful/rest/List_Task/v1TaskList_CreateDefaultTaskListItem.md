---
title: GET List/Task/Items/Default
uid: v1TaskList_CreateDefaultTaskListItem
---

# GET List/Task/Items/Default

```http
GET /api/v1/List/Task/Items/Default
```

Gets a default TaskListItem list item.








## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

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
GET /api/v1/List/Task/Items/Default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "TaskListItemId": 454,
  "Value": "omnis",
  "Direction": "Incoming",
  "Type": "Appointment",
  "Tooltip": "ratione",
  "Deleted": false,
  "IntentId": 109,
  "Rank": 945,
  "IsDefaultAlldayEvent": false,
  "IsDefaultFree": true,
  "IsDefaultPublished": true,
  "ColorIndex": "BlueAlt1",
  "DefaultVideomeetingStatus": "NoChange",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 936
    }
  }
}
```