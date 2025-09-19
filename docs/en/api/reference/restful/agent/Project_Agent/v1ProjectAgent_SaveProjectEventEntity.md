---
title: POST Agents/Project/SaveProjectEventEntity
uid: v1ProjectAgent_SaveProjectEventEntity
generated: true
content_type: reference
---

# POST Agents/Project/SaveProjectEventEntity

```http
POST /api/v1/Agents/Project/SaveProjectEventEntity
```

Updates the existing ProjectEventEntity or creates a new ProjectEventEntity if the id parameter is 0.








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

## Request Body: projectEventEntity 

The ProjectEventEntity that is saved 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SignOffConfirmationText | String | Text shown as confirmation text before accepting sign off. |
| SignOffText | String | Default text for the activity created when signing off. |
| SignOnConfirmationText | String | Text shown as confirmation text before accepting sign on. |
| SignOnText | String | Default text for the activity created when signing on. |
| EventDate | String | Dateof the event; publishing/visibility dates are in Publish, and restrictions are in AudienceVisibility |
| Enabled | Boolean | Is the event enabled |
| CreatedDate | String | Registered when  in UTC. |
| SignOff | Boolean | Is Sign Off functionality enabled? |
| SignOffTaskEnable | Boolean | If not 0, a task should be created when the external user Signs Off an event |
| SignOffTaskId | Integer | If not 0, sign off should cause an Activity of this type to be registered |
| SignOffTriggersAssign | Boolean | If 1, the SignOff task should be created as an Assigned task, triggering the invitation dialog |
| SignOn | Boolean | Is Sign On functionality enabled |
| SignOnTaskEnable | Boolean | If not 0, a task should be created when the external user Signs On to an event |
| SignOnTaskId | Integer | If not 0, sign on should cause an Activity of this type to be registered |
| SignOnTriggersAssign | Boolean | If 1, the SignOn task should be created as an Assigned task, triggering the invitation dialog |
| UpdatedDate | String | Last updated when  in UTC. |
| CreatedBy | Associate | The person that created the projectevent |
| UpdatedBy | Associate | The person that last updated the projectevent |
| ProjectId | Integer | The projectId for the project this projectEvent belongs to |
| Id | Integer | Id of the external event |
| PublishFrom | String | Publication valid from (inclusive) |
| PublishType | String | Type of publishing action, 0 = Unknown, 1 = to external persons |
| PublishTo | String | Publication valid to (inclusive) |
| VisibleForCategories | Array | Array of categories that the event is visible for. MDO Table "category". |
| VisibleForPersonInterests | Array | Array of person interests (MDO table "persint") that this event is visible for. |
| IsPublished | Boolean | Publish to external users? When true, the event/project information is visible to external users through the Audience portal. You can control the publish duration using the PublishFrom/PublishTo properties. |
| IsVisibleForMembers | Boolean |  |
| IsVisibleForCategories | Boolean |  |
| IsVisibleForPersonInterests | Boolean |  |
| ProjectEventId | Integer | Primary key |

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
POST /api/v1/Agents/Project/SaveProjectEventEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "ducimus",
  "SignOffText": "et",
  "SignOnConfirmationText": "sed",
  "SignOnText": "adipisci",
  "EventDate": "2012-04-06T03:41:53.9025923+02:00",
  "Enabled": false,
  "CreatedDate": "1999-08-02T03:41:53.9025923+02:00",
  "SignOff": true,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 980,
  "SignOffTriggersAssign": true,
  "SignOn": true,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 410,
  "SignOnTriggersAssign": false,
  "UpdatedDate": "2009-11-01T03:41:53.9025923+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 178,
  "Id": 412,
  "PublishFrom": "2022-03-09T03:41:53.9025923+01:00",
  "PublishType": "External",
  "PublishTo": "2016-09-19T03:41:53.9025923+02:00",
  "VisibleForCategories": [
    {
      "Id": 597,
      "Name": "Kihn Inc and Sons",
      "ToolTip": "Dolorum omnis sunt nisi quia quae exercitationem vel.",
      "Deleted": true,
      "Rank": 222,
      "Type": "blanditiis",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "maxime",
      "ColorBlock": 327,
      "ExtraInfo": "maxime",
      "StyleHint": "saepe",
      "FullName": "Gustave Eichmann"
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 934,
      "Name": "Corkery-D'Amore",
      "ToolTip": "Nihil soluta ab.",
      "Deleted": false,
      "Rank": 217,
      "Type": "corrupti",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "vel",
      "ColorBlock": 51,
      "ExtraInfo": "totam",
      "StyleHint": "quis",
      "FullName": "Pat Keeling"
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": false,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 801
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "ducimus",
  "SignOffText": "totam",
  "SignOnConfirmationText": "quam",
  "SignOnText": "officiis",
  "EventDate": "2014-12-02T03:41:53.9025923+01:00",
  "Enabled": false,
  "CreatedDate": "2011-10-23T03:41:53.9025923+02:00",
  "SignOff": false,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 640,
  "SignOffTriggersAssign": false,
  "SignOn": false,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 929,
  "SignOnTriggersAssign": false,
  "UpdatedDate": "2007-04-30T03:41:53.9025923+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 594,
  "Id": 508,
  "PublishFrom": "2018-06-18T03:41:53.9025923+02:00",
  "PublishType": "External",
  "PublishTo": "2020-01-20T03:41:53.9025923+01:00",
  "VisibleForCategories": [
    {
      "Id": 793,
      "Name": "Block, Corwin and Ondricka",
      "ToolTip": "Repellat et est.",
      "Deleted": true,
      "Rank": 771,
      "Type": "voluptas",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "voluptas",
      "ColorBlock": 508,
      "ExtraInfo": "temporibus",
      "StyleHint": "corporis",
      "FullName": "Ms. Lexus Huel I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 445
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 974,
      "Name": "Predovic, Quigley and Denesik",
      "ToolTip": "Nisi et dolorum ea quia unde.",
      "Deleted": false,
      "Rank": 864,
      "Type": "voluptatem",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "architecto",
      "ColorBlock": 250,
      "ExtraInfo": "ea",
      "StyleHint": "eaque",
      "FullName": "Prof. Lemuel Crona I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 166
        }
      }
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": false,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 226,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 788
    }
  }
}
```