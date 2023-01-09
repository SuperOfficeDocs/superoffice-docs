---
title: POST Agents/Project/CreateDefaultProjectEventEntity
uid: v1ProjectAgent_CreateDefaultProjectEventEntity
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Project/CreateDefaultProjectEventEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "voluptatum",
  "SignOffText": "et",
  "SignOnConfirmationText": "neque",
  "SignOnText": "sed",
  "EventDate": "2009-12-25T17:37:18.6152415+01:00",
  "Enabled": true,
  "CreatedDate": "2012-01-02T17:37:18.6152415+01:00",
  "SignOff": true,
  "SignOffTaskEnable": true,
  "SignOffTaskId": 545,
  "SignOffTriggersAssign": true,
  "SignOn": true,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 989,
  "SignOnTriggersAssign": true,
  "UpdatedDate": "1998-07-08T17:37:18.6152415+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 375,
  "Id": 997,
  "PublishFrom": "1998-07-03T17:37:18.6162445+02:00",
  "PublishType": "External",
  "PublishTo": "1995-11-24T17:37:18.6162445+01:00",
  "VisibleForCategories": [
    {
      "Id": 337,
      "Name": "Stark-Towne",
      "ToolTip": "Nulla at delectus earum dicta qui.",
      "Deleted": false,
      "Rank": 331,
      "Type": "corrupti",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "quis",
      "ColorBlock": 457,
      "ExtraInfo": "earum",
      "StyleHint": "et",
      "FullName": "Prof. Maddison Lindgren",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 806
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 156,
      "Name": "Kiehn Group",
      "ToolTip": "Provident esse quasi quod asperiores dignissimos quod earum.",
      "Deleted": false,
      "Rank": 645,
      "Type": "dignissimos",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "vitae",
      "ColorBlock": 504,
      "ExtraInfo": "ipsam",
      "StyleHint": "odio",
      "FullName": "Rashawn Hegmann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 275
        }
      }
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": false,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 172,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 140
    }
  }
}
```