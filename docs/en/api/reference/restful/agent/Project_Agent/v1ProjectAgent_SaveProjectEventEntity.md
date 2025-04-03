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
  "SignOffConfirmationText": "nostrum",
  "SignOffText": "nisi",
  "SignOnConfirmationText": "a",
  "SignOnText": "dolore",
  "EventDate": "2001-09-02T14:28:22.242884+02:00",
  "Enabled": false,
  "CreatedDate": "2020-10-25T14:28:22.242884+01:00",
  "SignOff": false,
  "SignOffTaskEnable": true,
  "SignOffTaskId": 973,
  "SignOffTriggersAssign": true,
  "SignOn": false,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 718,
  "SignOnTriggersAssign": false,
  "UpdatedDate": "2017-06-25T14:28:22.242884+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 566,
  "Id": 298,
  "PublishFrom": "2008-03-31T14:28:22.242884+02:00",
  "PublishType": "External",
  "PublishTo": "2001-10-07T14:28:22.242884+02:00",
  "VisibleForCategories": [
    {
      "Id": 854,
      "Name": "Dare, Feeney and Wiegand",
      "ToolTip": "Perferendis hic deserunt consequatur sit est officiis.",
      "Deleted": true,
      "Rank": 127,
      "Type": "qui",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "consequatur",
      "ColorBlock": 88,
      "ExtraInfo": "voluptates",
      "StyleHint": "qui",
      "FullName": "Anika Schmidt"
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 694,
      "Name": "Hilpert Inc and Sons",
      "ToolTip": "Officiis ea tenetur eos autem.",
      "Deleted": true,
      "Rank": 68,
      "Type": "ex",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "nisi",
      "ColorBlock": 605,
      "ExtraInfo": "eaque",
      "StyleHint": "error",
      "FullName": "Toni Hagenes"
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": false,
  "IsVisibleForPersonInterests": true,
  "ProjectEventId": 228
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "deleniti",
  "SignOffText": "modi",
  "SignOnConfirmationText": "qui",
  "SignOnText": "at",
  "EventDate": "2017-06-26T14:28:22.242884+02:00",
  "Enabled": false,
  "CreatedDate": "2006-12-07T14:28:22.242884+01:00",
  "SignOff": false,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 60,
  "SignOffTriggersAssign": true,
  "SignOn": false,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 697,
  "SignOnTriggersAssign": true,
  "UpdatedDate": "2022-10-28T14:28:22.242884+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 499,
  "Id": 791,
  "PublishFrom": "2017-04-17T14:28:22.242884+02:00",
  "PublishType": "External",
  "PublishTo": "2022-08-24T14:28:22.242884+02:00",
  "VisibleForCategories": [
    {
      "Id": 796,
      "Name": "Volkman-Thompson",
      "ToolTip": "Doloribus occaecati consequatur magnam ut amet voluptatem ea.",
      "Deleted": false,
      "Rank": 38,
      "Type": "veniam",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "repellat",
      "ColorBlock": 422,
      "ExtraInfo": "quod",
      "StyleHint": "asperiores",
      "FullName": "Michael Schamberger",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 465
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 902,
      "Name": "Abbott Group",
      "ToolTip": "Quidem id aliquam ipsa est soluta itaque similique.",
      "Deleted": false,
      "Rank": 770,
      "Type": "ipsum",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "sit",
      "ColorBlock": 882,
      "ExtraInfo": "at",
      "StyleHint": "quis",
      "FullName": "Mrs. Estel Kiarra Morar DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 168
        }
      }
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": true,
  "IsVisibleForCategories": false,
  "IsVisibleForPersonInterests": true,
  "ProjectEventId": 413,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 900
    }
  }
}
```