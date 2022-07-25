---
title: POST Agents/Project/GetMyProjectEvents
id: v1ProjectAgent_GetMyProjectEvents
---

# POST Agents/Project/GetMyProjectEvents

```http
POST /api/v1/Agents/Project/GetMyProjectEvents
```

Gets all project events that belongs to the currently logged on user.

The list of events are filtered by the Audience Visibility restrictions set when the project event is created.

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Project/GetMyProjectEvents?$select=name,department,category/id
```

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

## Response: array

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateFullName | string | Name of the person that ows the event (i.e. project) |
| Description | string | The event description (i.e. the project text) |
| ProjectId | int32 | Id of the project that represents the event |
| EventName | string | The name of the event (i.e. the project name) |
| AssociateId | int32 | Id of the person that ows the event (i.e. project) |
| IsSignedOn | bool | True if the current user is signed on to the event (i.e. is project member) |
| SignOffConfirmationText | string | Text shown as confirmation text before accepting sign off. |
| SignOffText | string | Default text for the activity created when signing off. |
| SignOnConfirmationText | string | Text shown as confirmation text before accepting sign on. |
| SignOnText | string | Default text for the activity created when signing on. |
| EventDate | date-time | Date of the event. Event is not visible after this date. |
| Enabled | bool | If true the event is enabled (visible) |
| SignOff | bool | If true, it is possible to sign off the event. |
| SignOffTaskEnable | bool | If true, a task should be created when the external user signs off an event |
| SignOnTaskEnable | bool | If true, a task should be created when the external user signs on an event |
| SignOn | bool | If true, it is possible to sign on the event. |
| SignOffTaskId | int32 | If not 0, sign off should cause an Activity of this type to be registered |
| SignOnTaskId | int32 | If not 0, sign on should cause an Activity of this type to be registered |
| SignOffTriggersAssign | bool | If true, the sign off task should be created as an Assigned task, triggering the invitation dialog |
| SignOnTriggersAssign | bool | If true, the sign on task should be created as an Assigned task, triggering the invitation dialog |
| SignOnPersonId | int32 | If 0, the signOn Activity should go into the persons Our Contact; if not 0, this is the Person whose diary should get the activity |
| SignOffPersonId | int32 | If 0, the signOn Activity should go into the persons Our Contact; if not 0, this is the Person whose diary should get the activity |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Project/GetMyProjectEvents
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AssociateFullName": "Haskell Crooks",
    "Description": "Sharable modular conglomeration",
    "ProjectId": 302,
    "EventName": "Kihn Inc and Sons",
    "AssociateId": 160,
    "IsSignedOn": true,
    "SignOffConfirmationText": "soluta",
    "SignOffText": "placeat",
    "SignOnConfirmationText": "numquam",
    "SignOnText": "perferendis",
    "EventDate": "2006-06-16T18:28:49.777144+02:00",
    "Enabled": true,
    "SignOff": true,
    "SignOffTaskEnable": false,
    "SignOnTaskEnable": false,
    "SignOn": true,
    "SignOffTaskId": 568,
    "SignOnTaskId": 102,
    "SignOffTriggersAssign": false,
    "SignOnTriggersAssign": true,
    "SignOnPersonId": 560,
    "SignOffPersonId": 965,
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
        "FieldType": "System.Int32",
        "FieldLength": 122
      }
    }
  }
]
```
