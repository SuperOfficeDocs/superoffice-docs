---
title: POST Agents/Project/SaveProjectEventEntity
uid: v1ProjectAgent_SaveProjectEventEntity
generated: true
---

# POST Agents/Project/SaveProjectEventEntity

```http
POST /api/v1/Agents/Project/SaveProjectEventEntity
```

Updates the existing ProjectEventEntity or creates a new ProjectEventEntity if the id parameter is empty








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

The ProjectEventEntity to be saved. 

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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "iste",
  "SignOffText": "dicta",
  "SignOnConfirmationText": "nostrum",
  "SignOnText": "nihil",
  "EventDate": "2008-11-27T23:03:56.6366214+01:00",
  "Enabled": false,
  "CreatedDate": "2013-12-07T23:03:56.6366214+01:00",
  "SignOff": true,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 341,
  "SignOffTriggersAssign": false,
  "SignOn": true,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 798,
  "SignOnTriggersAssign": false,
  "UpdatedDate": "2021-08-18T23:03:56.6366214+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 732,
  "Id": 50,
  "PublishFrom": "1998-06-05T23:03:56.6371199+02:00",
  "PublishType": "External",
  "PublishTo": "2001-11-29T23:03:56.6371199+01:00",
  "VisibleForCategories": [
    {
      "Id": 912,
      "Name": "Hackett Inc and Sons",
      "ToolTip": "Voluptates optio provident voluptas.",
      "Deleted": false,
      "Rank": 105,
      "Type": "distinctio",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "quia",
      "ColorBlock": 21,
      "ExtraInfo": "ipsum",
      "StyleHint": "porro",
      "FullName": "Pauline O'Keefe"
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 397,
      "Name": "Dickens LLC",
      "ToolTip": "Suscipit officia ut et.",
      "Deleted": true,
      "Rank": 361,
      "Type": "aliquid",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "minima",
      "ColorBlock": 552,
      "ExtraInfo": "voluptatem",
      "StyleHint": "corrupti",
      "FullName": "Tremaine Rath IV"
    }
  ],
  "IsPublished": true,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": true,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 455
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "temporibus",
  "SignOffText": "libero",
  "SignOnConfirmationText": "architecto",
  "SignOnText": "rerum",
  "EventDate": "2011-06-04T23:03:56.6401225+02:00",
  "Enabled": false,
  "CreatedDate": "2021-08-27T23:03:56.6401225+02:00",
  "SignOff": false,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 527,
  "SignOffTriggersAssign": true,
  "SignOn": false,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 228,
  "SignOnTriggersAssign": true,
  "UpdatedDate": "2013-06-16T23:03:56.6401225+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 243,
  "Id": 18,
  "PublishFrom": "2008-11-23T23:03:56.64112+01:00",
  "PublishType": "External",
  "PublishTo": "2007-02-17T23:03:56.64112+01:00",
  "VisibleForCategories": [
    {
      "Id": 573,
      "Name": "Schinner, Cruickshank and Grady",
      "ToolTip": "Quis sapiente quis minus voluptate minima mollitia.",
      "Deleted": true,
      "Rank": 45,
      "Type": "ad",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "modi",
      "ColorBlock": 499,
      "ExtraInfo": "inventore",
      "StyleHint": "enim",
      "FullName": "Dr. Brooks Hegmann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 702
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 125,
      "Name": "Homenick-Wisoky",
      "ToolTip": "Et molestiae non sit vitae quo.",
      "Deleted": false,
      "Rank": 445,
      "Type": "architecto",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "non",
      "ColorBlock": 600,
      "ExtraInfo": "voluptatem",
      "StyleHint": "vel",
      "FullName": "Brennon Billy Herman V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 432
        }
      }
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": true,
  "IsVisibleForCategories": false,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 825,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 859
    }
  }
}
```