---
title: POST Agents/Project/GetProjectEventEntityFromProjectId
uid: v1ProjectAgent_GetProjectEventEntityFromProjectId
generated: true
content_type: reference
---

# POST Agents/Project/GetProjectEventEntityFromProjectId

```http
POST /api/v1/Agents/Project/GetProjectEventEntityFromProjectId
```

Get a ProjectEventEntity based on a projectId.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Project/GetProjectEventEntityFromProjectId?$select=name,department,category/id
```


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

## Request Body: request 

ProjectId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ProjectEventEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| SignOffConfirmationText | string | Text shown as confirmation text before accepting sign off. |
| SignOffText | string | Default text for the activity created when signing off. |
| SignOnConfirmationText | string | Text shown as confirmation text before accepting sign on. |
| SignOnText | string | Default text for the activity created when signing on. |
| EventDate | date-time | Dateof the event; publishing/visibility dates are in Publish, and restrictions are in AudienceVisibility |
| Enabled | bool | Is the event enabled |
| CreatedDate | date-time | Registered when  in UTC. |
| SignOff | bool | Is Sign Off functionality enabled? |
| SignOffTaskEnable | bool | If not 0, a task should be created when the external user Signs Off an event |
| SignOffTaskId | int32 | If not 0, sign off should cause an Activity of this type to be registered |
| SignOffTriggersAssign | bool | If 1, the SignOff task should be created as an Assigned task, triggering the invitation dialog |
| SignOn | bool | Is Sign On functionality enabled |
| SignOnTaskEnable | bool | If not 0, a task should be created when the external user Signs On to an event |
| SignOnTaskId | int32 | If not 0, sign on should cause an Activity of this type to be registered |
| SignOnTriggersAssign | bool | If 1, the SignOn task should be created as an Assigned task, triggering the invitation dialog |
| UpdatedDate | date-time | Last updated when  in UTC. |
| CreatedBy | Associate | The person that created the projectevent |
| UpdatedBy | Associate | The person that last updated the projectevent |
| ProjectId | int32 | The projectId for the project this projectEvent belongs to |
| Id | int32 | Id of the external event |
| PublishFrom | date-time | Publication valid from (inclusive) |
| PublishType | string | Type of publishing action, 0 = Unknown, 1 = to external persons |
| PublishTo | date-time | Publication valid to (inclusive) |
| VisibleForCategories | array | Array of categories that the event is visible for. MDO Table "category". |
| VisibleForPersonInterests | array | Array of person interests (MDO table "persint") that this event is visible for. |
| IsPublished | bool | Publish to external users? When true, the event/project information is visible to external users through the Audience portal. You can control the publish duration using the PublishFrom/PublishTo properties. |
| IsVisibleForMembers | bool |  |
| IsVisibleForCategories | bool |  |
| IsVisibleForPersonInterests | bool |  |
| ProjectEventId | int32 | Primary key |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Project/GetProjectEventEntityFromProjectId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 623
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "maxime",
  "SignOffText": "esse",
  "SignOnConfirmationText": "et",
  "SignOnText": "quos",
  "EventDate": "2016-04-20T11:24:48.4845166+02:00",
  "Enabled": false,
  "CreatedDate": "2025-09-14T11:24:48.4845166+02:00",
  "SignOff": false,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 73,
  "SignOffTriggersAssign": true,
  "SignOn": true,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 559,
  "SignOnTriggersAssign": true,
  "UpdatedDate": "2015-02-14T11:24:48.4845166+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 926,
  "Id": 859,
  "PublishFrom": "2019-10-16T11:24:48.4845166+02:00",
  "PublishType": "External",
  "PublishTo": "2006-01-04T11:24:48.4845166+01:00",
  "VisibleForCategories": [
    {
      "Id": 398,
      "Name": "Satterfield, Herzog and Dickens",
      "ToolTip": "Id eligendi voluptas sunt expedita quam.",
      "Deleted": false,
      "Rank": 970,
      "Type": "est",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "dolorum",
      "ColorBlock": 123,
      "ExtraInfo": "nesciunt",
      "StyleHint": "ex",
      "FullName": "Rupert Jenkins",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 752
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 593,
      "Name": "Kling-Schumm",
      "ToolTip": "Corrupti qui libero commodi dicta fugit voluptate.",
      "Deleted": false,
      "Rank": 170,
      "Type": "cupiditate",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "hic",
      "ColorBlock": 447,
      "ExtraInfo": "voluptatem",
      "StyleHint": "nisi",
      "FullName": "Angelica Rowe",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 325
        }
      }
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": true,
  "IsVisibleForCategories": false,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 229,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 98
    }
  }
}
```