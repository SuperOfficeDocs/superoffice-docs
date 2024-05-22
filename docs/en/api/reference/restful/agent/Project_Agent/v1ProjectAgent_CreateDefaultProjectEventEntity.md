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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "necessitatibus",
  "SignOffText": "et",
  "SignOnConfirmationText": "quos",
  "SignOnText": "voluptatem",
  "EventDate": "2021-02-02T12:57:34.6178406+01:00",
  "Enabled": false,
  "CreatedDate": "2005-09-06T12:57:34.6178406+02:00",
  "SignOff": false,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 291,
  "SignOffTriggersAssign": false,
  "SignOn": true,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 972,
  "SignOnTriggersAssign": true,
  "UpdatedDate": "2013-12-22T12:57:34.6178406+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 273,
  "Id": 697,
  "PublishFrom": "2021-09-20T12:57:34.6178406+02:00",
  "PublishType": "External",
  "PublishTo": "2005-10-18T12:57:34.6178406+02:00",
  "VisibleForCategories": [
    {
      "Id": 202,
      "Name": "Hauck-Wisoky",
      "ToolTip": "Molestiae eveniet accusantium vero ullam quisquam cupiditate voluptatem.",
      "Deleted": false,
      "Rank": 378,
      "Type": "iusto",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "doloremque",
      "ColorBlock": 346,
      "ExtraInfo": "excepturi",
      "StyleHint": "sit",
      "FullName": "Lavon Mitchell",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 611
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 619,
      "Name": "Pacocha-Cruickshank",
      "ToolTip": "Nostrum nemo cumque dolorem magni incidunt qui.",
      "Deleted": false,
      "Rank": 961,
      "Type": "omnis",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "aliquid",
      "ColorBlock": 654,
      "ExtraInfo": "dolor",
      "StyleHint": "adipisci",
      "FullName": "Pansy Callie Crona III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 746
        }
      }
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": true,
  "IsVisibleForCategories": true,
  "IsVisibleForPersonInterests": true,
  "ProjectEventId": 287,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 915
    }
  }
}
```