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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "eos",
  "SignOffText": "sed",
  "SignOnConfirmationText": "culpa",
  "SignOnText": "quisquam",
  "EventDate": "2020-06-17T17:54:03.4608148+02:00",
  "Enabled": true,
  "CreatedDate": "2022-05-02T17:54:03.4608148+02:00",
  "SignOff": false,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 425,
  "SignOffTriggersAssign": false,
  "SignOn": false,
  "SignOnTaskEnable": true,
  "SignOnTaskId": 557,
  "SignOnTriggersAssign": true,
  "UpdatedDate": "2010-11-11T17:54:03.4608148+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 771,
  "Id": 651,
  "PublishFrom": "2009-01-02T17:54:03.4608148+01:00",
  "PublishType": "External",
  "PublishTo": "2004-11-19T17:54:03.4608148+01:00",
  "VisibleForCategories": [
    {
      "Id": 343,
      "Name": "Rempel, Brakus and Raynor",
      "ToolTip": "Tempore est iure ullam placeat ipsam.",
      "Deleted": true,
      "Rank": 186,
      "Type": "non",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "delectus",
      "ColorBlock": 153,
      "ExtraInfo": "et",
      "StyleHint": "accusamus",
      "FullName": "Tristin Rutherford V"
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 718,
      "Name": "Von, Lowe and Ortiz",
      "ToolTip": "Provident totam iure tenetur.",
      "Deleted": false,
      "Rank": 255,
      "Type": "id",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "autem",
      "ColorBlock": 514,
      "ExtraInfo": "minima",
      "StyleHint": "doloremque",
      "FullName": "Mrs. Vincenzo Ashton VonRueden"
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": true,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 348
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "delectus",
  "SignOffText": "excepturi",
  "SignOnConfirmationText": "nostrum",
  "SignOnText": "et",
  "EventDate": "2023-03-25T17:54:03.47644+01:00",
  "Enabled": true,
  "CreatedDate": "2022-10-02T17:54:03.47644+02:00",
  "SignOff": false,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 477,
  "SignOffTriggersAssign": true,
  "SignOn": true,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 91,
  "SignOnTriggersAssign": false,
  "UpdatedDate": "1999-03-24T17:54:03.47644+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 472,
  "Id": 692,
  "PublishFrom": "2009-05-06T17:54:03.47644+02:00",
  "PublishType": "External",
  "PublishTo": "2020-06-12T17:54:03.47644+02:00",
  "VisibleForCategories": [
    {
      "Id": 118,
      "Name": "Toy Group",
      "ToolTip": "Vel et enim.",
      "Deleted": true,
      "Rank": 486,
      "Type": "sapiente",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "nulla",
      "ColorBlock": 104,
      "ExtraInfo": "iste",
      "StyleHint": "tenetur",
      "FullName": "Mr. Lessie Josh Cormier",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 748
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 69,
      "Name": "Bernhard, Tremblay and Emard",
      "ToolTip": "Non at corporis in dolores consequatur aut.",
      "Deleted": false,
      "Rank": 854,
      "Type": "quisquam",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "expedita",
      "ColorBlock": 975,
      "ExtraInfo": "quia",
      "StyleHint": "illo",
      "FullName": "Sasha Glover",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 736
        }
      }
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": true,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 785,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 649
    }
  }
}
```