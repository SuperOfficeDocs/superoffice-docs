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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "nihil",
  "SignOffText": "voluptate",
  "SignOnConfirmationText": "officiis",
  "SignOnText": "quis",
  "EventDate": "2022-07-20T11:24:48.4845166+02:00",
  "Enabled": false,
  "CreatedDate": "2012-07-28T11:24:48.4845166+02:00",
  "SignOff": false,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 510,
  "SignOffTriggersAssign": false,
  "SignOn": false,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 837,
  "SignOnTriggersAssign": false,
  "UpdatedDate": "2023-11-16T11:24:48.4845166+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 689,
  "Id": 546,
  "PublishFrom": "2004-06-08T11:24:48.4845166+02:00",
  "PublishType": "External",
  "PublishTo": "2011-06-29T11:24:48.4845166+02:00",
  "VisibleForCategories": [
    {
      "Id": 979,
      "Name": "Brakus, Schamberger and Bode",
      "ToolTip": "Animi qui.",
      "Deleted": true,
      "Rank": 852,
      "Type": "saepe",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "rerum",
      "ColorBlock": 984,
      "ExtraInfo": "aut",
      "StyleHint": "et",
      "FullName": "Dr. Adalberto Koch"
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 884,
      "Name": "Kulas, Hermiston and Jast",
      "ToolTip": "Possimus facere quas.",
      "Deleted": false,
      "Rank": 45,
      "Type": "earum",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "id",
      "ColorBlock": 688,
      "ExtraInfo": "officia",
      "StyleHint": "quia",
      "FullName": "Vance Lang"
    }
  ],
  "IsPublished": true,
  "IsVisibleForMembers": true,
  "IsVisibleForCategories": false,
  "IsVisibleForPersonInterests": true,
  "ProjectEventId": 269
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "nobis",
  "SignOffText": "corporis",
  "SignOnConfirmationText": "dolorem",
  "SignOnText": "earum",
  "EventDate": "2007-08-12T11:24:48.4845166+02:00",
  "Enabled": false,
  "CreatedDate": "2012-02-12T11:24:48.4845166+01:00",
  "SignOff": false,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 816,
  "SignOffTriggersAssign": false,
  "SignOn": false,
  "SignOnTaskEnable": true,
  "SignOnTaskId": 112,
  "SignOnTriggersAssign": false,
  "UpdatedDate": "2013-09-02T11:24:48.4845166+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 575,
  "Id": 51,
  "PublishFrom": "2012-02-21T11:24:48.4845166+01:00",
  "PublishType": "External",
  "PublishTo": "2008-01-12T11:24:48.4845166+01:00",
  "VisibleForCategories": [
    {
      "Id": 353,
      "Name": "Kunde-Herzog",
      "ToolTip": "Dolores ut.",
      "Deleted": true,
      "Rank": 676,
      "Type": "sit",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "accusamus",
      "ColorBlock": 921,
      "ExtraInfo": "repellat",
      "StyleHint": "fugit",
      "FullName": "Jerod Jerde",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 389
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 904,
      "Name": "Prohaska, Schaefer and Walter",
      "ToolTip": "Eligendi quam.",
      "Deleted": false,
      "Rank": 545,
      "Type": "quia",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "magnam",
      "ColorBlock": 719,
      "ExtraInfo": "inventore",
      "StyleHint": "officiis",
      "FullName": "Miss Anibal Schamberger",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 560
        }
      }
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": true,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 849,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 721
    }
  }
}
```