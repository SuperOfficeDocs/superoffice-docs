---
title: POST Agents/Project/CreateDefaultProjectEventEntity
uid: v1ProjectAgent_CreateDefaultProjectEventEntity
generated: true
content_type: reference
---

# POST Agents/Project/CreateDefaultProjectEventEntity

```http
POST /api/v1/Agents/Project/CreateDefaultProjectEventEntity
```

Loading default values into a new ProjectEventEntity.








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
POST /api/v1/Agents/Project/CreateDefaultProjectEventEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "autem",
  "SignOffText": "omnis",
  "SignOnConfirmationText": "enim",
  "SignOnText": "mollitia",
  "EventDate": "2000-10-18T03:41:53.9025923+02:00",
  "Enabled": true,
  "CreatedDate": "2001-09-15T03:41:53.9025923+02:00",
  "SignOff": false,
  "SignOffTaskEnable": true,
  "SignOffTaskId": 836,
  "SignOffTriggersAssign": true,
  "SignOn": false,
  "SignOnTaskEnable": true,
  "SignOnTaskId": 232,
  "SignOnTriggersAssign": false,
  "UpdatedDate": "2010-11-17T03:41:53.9025923+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 367,
  "Id": 881,
  "PublishFrom": "2000-05-31T03:41:53.9025923+02:00",
  "PublishType": "External",
  "PublishTo": "2021-11-28T03:41:53.9025923+01:00",
  "VisibleForCategories": [
    {
      "Id": 144,
      "Name": "Kulas-Cruickshank",
      "ToolTip": "Dolor laborum asperiores in est enim.",
      "Deleted": false,
      "Rank": 917,
      "Type": "quia",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "voluptates",
      "ColorBlock": 288,
      "ExtraInfo": "perspiciatis",
      "StyleHint": "commodi",
      "FullName": "Alexanne Doyle",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 745
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 542,
      "Name": "Skiles Inc and Sons",
      "ToolTip": "Aut laboriosam odit quas aspernatur rerum.",
      "Deleted": false,
      "Rank": 919,
      "Type": "totam",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "blanditiis",
      "ColorBlock": 198,
      "ExtraInfo": "voluptatum",
      "StyleHint": "ut",
      "FullName": "Cooper Morar",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 661
        }
      }
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": true,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 188,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 973
    }
  }
}
```