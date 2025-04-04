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
  "SignOffConfirmationText": "fuga",
  "SignOffText": "hic",
  "SignOnConfirmationText": "ad",
  "SignOnText": "reiciendis",
  "EventDate": "2013-06-19T13:14:00.9089029+02:00",
  "Enabled": false,
  "CreatedDate": "2012-09-11T13:14:00.9089029+02:00",
  "SignOff": false,
  "SignOffTaskEnable": true,
  "SignOffTaskId": 110,
  "SignOffTriggersAssign": true,
  "SignOn": true,
  "SignOnTaskEnable": true,
  "SignOnTaskId": 950,
  "SignOnTriggersAssign": false,
  "UpdatedDate": "2018-12-22T13:14:00.9089029+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 532,
  "Id": 314,
  "PublishFrom": "2012-12-26T13:14:00.9089029+01:00",
  "PublishType": "External",
  "PublishTo": "2016-04-23T13:14:00.9089029+02:00",
  "VisibleForCategories": [
    {
      "Id": 999,
      "Name": "Wilkinson Group",
      "ToolTip": "Minus pariatur officia.",
      "Deleted": true,
      "Rank": 448,
      "Type": "perspiciatis",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "consequatur",
      "ColorBlock": 130,
      "ExtraInfo": "quam",
      "StyleHint": "doloremque",
      "FullName": "Miss Cecil Adaline Lindgren MD"
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 98,
      "Name": "Hettinger-Weimann",
      "ToolTip": "Rerum omnis expedita ab ipsum magnam deserunt.",
      "Deleted": false,
      "Rank": 953,
      "Type": "sunt",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "quis",
      "ColorBlock": 494,
      "ExtraInfo": "laboriosam",
      "StyleHint": "ratione",
      "FullName": "Icie McCullough"
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": false,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 109
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "et",
  "SignOffText": "quisquam",
  "SignOnConfirmationText": "est",
  "SignOnText": "explicabo",
  "EventDate": "2015-04-27T13:14:00.9089029+02:00",
  "Enabled": false,
  "CreatedDate": "2021-03-28T13:14:00.9089029+02:00",
  "SignOff": true,
  "SignOffTaskEnable": true,
  "SignOffTaskId": 24,
  "SignOffTriggersAssign": false,
  "SignOn": false,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 318,
  "SignOnTriggersAssign": false,
  "UpdatedDate": "2021-04-12T13:14:00.9089029+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 49,
  "Id": 408,
  "PublishFrom": "2015-02-01T13:14:00.9089029+01:00",
  "PublishType": "External",
  "PublishTo": "2021-03-08T13:14:00.9089029+01:00",
  "VisibleForCategories": [
    {
      "Id": 595,
      "Name": "Wolf, Hessel and Hirthe",
      "ToolTip": "Aut ratione placeat iste.",
      "Deleted": true,
      "Rank": 663,
      "Type": "dolore",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "id",
      "ColorBlock": 612,
      "ExtraInfo": "fugit",
      "StyleHint": "sapiente",
      "FullName": "Miss Laurel Wyman III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 425
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 829,
      "Name": "Huel LLC",
      "ToolTip": "In unde sequi aut et omnis ea.",
      "Deleted": true,
      "Rank": 621,
      "Type": "inventore",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "dignissimos",
      "ColorBlock": 485,
      "ExtraInfo": "corporis",
      "StyleHint": "facere",
      "FullName": "Elise Schulist",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 575
        }
      }
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": true,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 314,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 299
    }
  }
}
```