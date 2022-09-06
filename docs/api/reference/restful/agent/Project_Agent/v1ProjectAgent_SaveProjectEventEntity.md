---
title: POST Agents/Project/SaveProjectEventEntity
uid: v1ProjectAgent_SaveProjectEventEntity
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
| CreatedBy |  | The person that created the projectevent |
| UpdatedBy |  | The person that last updated the projectevent |
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

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

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
| CreatedBy |  | The person that created the projectevent |
| UpdatedBy |  | The person that last updated the projectevent |
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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Project/SaveProjectEventEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "ad",
  "SignOffText": "explicabo",
  "SignOnConfirmationText": "dicta",
  "SignOnText": "recusandae",
  "EventDate": "2001-12-11T11:10:27.5774536+01:00",
  "Enabled": true,
  "CreatedDate": "2004-03-29T11:10:27.5774536+02:00",
  "SignOff": false,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 802,
  "SignOffTriggersAssign": false,
  "SignOn": false,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 810,
  "SignOnTriggersAssign": true,
  "UpdatedDate": "2012-07-17T11:10:27.5774536+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 997,
  "Id": 803,
  "PublishFrom": "2016-07-16T11:10:27.579453+02:00",
  "PublishType": "External",
  "PublishTo": "2010-11-27T11:10:27.579453+01:00",
  "VisibleForCategories": [
    {
      "Id": 225,
      "Name": "Sawayn-Hilpert",
      "ToolTip": "Consequatur voluptatem quam in nihil minus tenetur.",
      "Deleted": true,
      "Rank": 21,
      "Type": "totam",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "dolores",
      "ColorBlock": 620,
      "ExtraInfo": "et",
      "StyleHint": "perferendis",
      "FullName": "Prof. Xavier Weber"
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 724,
      "Name": "Torphy, Langworth and Sipes",
      "ToolTip": "Libero mollitia rem placeat.",
      "Deleted": true,
      "Rank": 86,
      "Type": "fuga",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "ullam",
      "ColorBlock": 419,
      "ExtraInfo": "aut",
      "StyleHint": "doloribus",
      "FullName": "Caesar Roberts Jr."
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": false,
  "IsVisibleForPersonInterests": true,
  "ProjectEventId": 72
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "optio",
  "SignOffText": "reprehenderit",
  "SignOnConfirmationText": "natus",
  "SignOnText": "in",
  "EventDate": "2008-10-21T11:10:27.582453+02:00",
  "Enabled": false,
  "CreatedDate": "2006-09-30T11:10:27.582453+02:00",
  "SignOff": false,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 593,
  "SignOffTriggersAssign": false,
  "SignOn": true,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 457,
  "SignOnTriggersAssign": true,
  "UpdatedDate": "2000-02-08T11:10:27.582453+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 206,
  "Id": 29,
  "PublishFrom": "2017-07-11T11:10:27.582453+02:00",
  "PublishType": "External",
  "PublishTo": "2005-01-05T11:10:27.582453+01:00",
  "VisibleForCategories": [
    {
      "Id": 320,
      "Name": "Boehm, Schoen and Cremin",
      "ToolTip": "Assumenda similique.",
      "Deleted": false,
      "Rank": 663,
      "Type": "sint",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "perspiciatis",
      "ColorBlock": 911,
      "ExtraInfo": "dolorum",
      "StyleHint": "aut",
      "FullName": "Dr. Lia Murphy II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 831
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 774,
      "Name": "Yost, Smith and Rowe",
      "ToolTip": "Hic libero culpa maiores.",
      "Deleted": false,
      "Rank": 438,
      "Type": "nesciunt",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "ut",
      "ColorBlock": 504,
      "ExtraInfo": "odit",
      "StyleHint": "placeat",
      "FullName": "Prof. Bradley Kariane Fay V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 645
        }
      }
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": false,
  "IsVisibleForPersonInterests": true,
  "ProjectEventId": 905,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 509
    }
  }
}
```
