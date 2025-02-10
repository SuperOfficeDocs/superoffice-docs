---
title: POST Agents/Project/GetProjectEventEntity
uid: v1ProjectAgent_GetProjectEventEntity
generated: true
---

# POST Agents/Project/GetProjectEventEntity

```http
POST /api/v1/Agents/Project/GetProjectEventEntity
```

Gets a ProjectEventEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| projectEventEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Project/GetProjectEventEntity?projectEventEntityId=526
POST /api/v1/Agents/Project/GetProjectEventEntity?$select=name,department,category/id
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
POST /api/v1/Agents/Project/GetProjectEventEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "odio",
  "SignOffText": "quis",
  "SignOnConfirmationText": "consequatur",
  "SignOnText": "dolorum",
  "EventDate": "2019-07-20T12:01:28.1503067+02:00",
  "Enabled": false,
  "CreatedDate": "2004-08-25T12:01:28.1503067+02:00",
  "SignOff": true,
  "SignOffTaskEnable": true,
  "SignOffTaskId": 115,
  "SignOffTriggersAssign": true,
  "SignOn": true,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 309,
  "SignOnTriggersAssign": true,
  "UpdatedDate": "2018-04-11T12:01:28.1503067+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 918,
  "Id": 72,
  "PublishFrom": "2012-03-03T12:01:28.1503067+01:00",
  "PublishType": "External",
  "PublishTo": "2008-06-21T12:01:28.1503067+02:00",
  "VisibleForCategories": [
    {
      "Id": 908,
      "Name": "Halvorson-Quigley",
      "ToolTip": "Quod harum et repudiandae facere officiis repudiandae quo.",
      "Deleted": false,
      "Rank": 686,
      "Type": "hic",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "nobis",
      "ColorBlock": 27,
      "ExtraInfo": "excepturi",
      "StyleHint": "cum",
      "FullName": "Unique O'Keefe",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 326
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 652,
      "Name": "Stanton-Runolfsson",
      "ToolTip": "Est porro ea provident nisi.",
      "Deleted": false,
      "Rank": 448,
      "Type": "praesentium",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "enim",
      "ColorBlock": 912,
      "ExtraInfo": "qui",
      "StyleHint": "placeat",
      "FullName": "Maudie Wolf",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 866
        }
      }
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": false,
  "IsVisibleForPersonInterests": true,
  "ProjectEventId": 140,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 66
    }
  }
}
```