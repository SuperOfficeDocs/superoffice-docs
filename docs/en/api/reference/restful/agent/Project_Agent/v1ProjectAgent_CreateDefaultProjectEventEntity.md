---
title: POST Agents/Project/CreateDefaultProjectEventEntity
uid: v1ProjectAgent_CreateDefaultProjectEventEntity
generated: true
---

# POST Agents/Project/CreateDefaultProjectEventEntity

```http
POST /api/v1/Agents/Project/CreateDefaultProjectEventEntity
```

Set default values into a new ProjectEventEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
  "SignOffConfirmationText": "commodi",
  "SignOffText": "beatae",
  "SignOnConfirmationText": "culpa",
  "SignOnText": "reiciendis",
  "EventDate": "2010-03-15T23:03:56.6351202+01:00",
  "Enabled": false,
  "CreatedDate": "2018-11-01T23:03:56.6351202+01:00",
  "SignOff": false,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 966,
  "SignOffTriggersAssign": false,
  "SignOn": true,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 896,
  "SignOnTriggersAssign": false,
  "UpdatedDate": "2011-09-24T23:03:56.6351202+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 973,
  "Id": 401,
  "PublishFrom": "2007-04-29T23:03:56.63562+02:00",
  "PublishType": "External",
  "PublishTo": "1996-09-17T23:03:56.63562+02:00",
  "VisibleForCategories": [
    {
      "Id": 255,
      "Name": "West, Ritchie and Oberbrunner",
      "ToolTip": "Ratione et aut quaerat est et.",
      "Deleted": true,
      "Rank": 767,
      "Type": "enim",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "inventore",
      "ColorBlock": 234,
      "ExtraInfo": "asperiores",
      "StyleHint": "quasi",
      "FullName": "Lane Fritsch",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 552
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 588,
      "Name": "Terry Group",
      "ToolTip": "Incidunt sed atque alias sint rerum unde nihil.",
      "Deleted": true,
      "Rank": 506,
      "Type": "ipsum",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "asperiores",
      "ColorBlock": 699,
      "ExtraInfo": "tempore",
      "StyleHint": "rerum",
      "FullName": "Oren Mayer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 773
        }
      }
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": true,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 675,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 606
    }
  }
}
```