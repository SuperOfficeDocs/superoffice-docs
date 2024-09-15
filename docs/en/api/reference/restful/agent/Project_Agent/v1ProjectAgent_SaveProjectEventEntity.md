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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "perspiciatis",
  "SignOffText": "eligendi",
  "SignOnConfirmationText": "ea",
  "SignOnText": "autem",
  "EventDate": "2012-07-14T04:02:02.1440899+02:00",
  "Enabled": false,
  "CreatedDate": "2023-10-16T04:02:02.1440899+02:00",
  "SignOff": false,
  "SignOffTaskEnable": true,
  "SignOffTaskId": 677,
  "SignOffTriggersAssign": false,
  "SignOn": false,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 719,
  "SignOnTriggersAssign": false,
  "UpdatedDate": "2019-11-12T04:02:02.1440899+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 865,
  "Id": 234,
  "PublishFrom": "2009-10-31T04:02:02.1440899+01:00",
  "PublishType": "External",
  "PublishTo": "2012-01-15T04:02:02.1440899+01:00",
  "VisibleForCategories": [
    {
      "Id": 9,
      "Name": "Murray-Gibson",
      "ToolTip": "Consectetur aliquid ut sapiente et quibusdam dignissimos.",
      "Deleted": false,
      "Rank": 653,
      "Type": "nisi",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "ea",
      "ColorBlock": 250,
      "ExtraInfo": "vel",
      "StyleHint": "sed",
      "FullName": "Prof. Caleb Wellington Hyatt DVM"
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 753,
      "Name": "Watsica, Jakubowski and Turner",
      "ToolTip": "Totam et aut.",
      "Deleted": false,
      "Rank": 749,
      "Type": "perferendis",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "sapiente",
      "ColorBlock": 144,
      "ExtraInfo": "adipisci",
      "StyleHint": "suscipit",
      "FullName": "Sid Gutmann"
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": false,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 889
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "ut",
  "SignOffText": "consequatur",
  "SignOnConfirmationText": "qui",
  "SignOnText": "et",
  "EventDate": "2024-05-05T04:02:02.1440899+02:00",
  "Enabled": true,
  "CreatedDate": "1998-07-21T04:02:02.1440899+02:00",
  "SignOff": true,
  "SignOffTaskEnable": true,
  "SignOffTaskId": 914,
  "SignOffTriggersAssign": false,
  "SignOn": true,
  "SignOnTaskEnable": true,
  "SignOnTaskId": 764,
  "SignOnTriggersAssign": true,
  "UpdatedDate": "2010-01-21T04:02:02.1440899+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 864,
  "Id": 767,
  "PublishFrom": "1999-04-29T04:02:02.1440899+02:00",
  "PublishType": "External",
  "PublishTo": "2007-05-17T04:02:02.1440899+02:00",
  "VisibleForCategories": [
    {
      "Id": 476,
      "Name": "Tremblay Inc and Sons",
      "ToolTip": "Qui consequuntur harum quia reprehenderit voluptatem unde saepe.",
      "Deleted": false,
      "Rank": 136,
      "Type": "autem",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "pariatur",
      "ColorBlock": 845,
      "ExtraInfo": "consequatur",
      "StyleHint": "consectetur",
      "FullName": "Zachariah Kuvalis",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 436
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 942,
      "Name": "Roob-Anderson",
      "ToolTip": "Aut sequi tempora enim voluptatem repellendus sit quas.",
      "Deleted": false,
      "Rank": 594,
      "Type": "minima",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "ab",
      "ColorBlock": 618,
      "ExtraInfo": "nihil",
      "StyleHint": "enim",
      "FullName": "Stanley Morar",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 431
        }
      }
    }
  ],
  "IsPublished": true,
  "IsVisibleForMembers": true,
  "IsVisibleForCategories": true,
  "IsVisibleForPersonInterests": true,
  "ProjectEventId": 207,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 773
    }
  }
}
```