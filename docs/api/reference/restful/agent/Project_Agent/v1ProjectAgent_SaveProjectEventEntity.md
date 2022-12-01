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


## Response: 

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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "possimus",
  "SignOffText": "numquam",
  "SignOnConfirmationText": "ducimus",
  "SignOnText": "repellendus",
  "EventDate": "2018-09-05T02:49:44.9372128+02:00",
  "Enabled": false,
  "CreatedDate": "2014-12-07T02:49:44.9372128+01:00",
  "SignOff": false,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 33,
  "SignOffTriggersAssign": false,
  "SignOn": true,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 73,
  "SignOnTriggersAssign": false,
  "UpdatedDate": "2014-03-20T02:49:44.9372128+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 458,
  "Id": 575,
  "PublishFrom": "2001-04-20T02:49:44.9372128+02:00",
  "PublishType": "External",
  "PublishTo": "2014-06-30T02:49:44.9372128+02:00",
  "VisibleForCategories": [
    {
      "Id": 400,
      "Name": "Haag, Howe and Herman",
      "ToolTip": "Officiis et et iusto fuga quis.",
      "Deleted": true,
      "Rank": 26,
      "Type": "eligendi",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "ratione",
      "ColorBlock": 305,
      "ExtraInfo": "voluptatem",
      "StyleHint": "et",
      "FullName": "Idella McLaughlin IV"
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 375,
      "Name": "Ankunding, Buckridge and Ortiz",
      "ToolTip": "Incidunt quia quibusdam quos.",
      "Deleted": false,
      "Rank": 775,
      "Type": "nihil",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "repudiandae",
      "ColorBlock": 957,
      "ExtraInfo": "deserunt",
      "StyleHint": "enim",
      "FullName": "Verner Windler"
    }
  ],
  "IsPublished": true,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": true,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 768
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "nemo",
  "SignOffText": "soluta",
  "SignOnConfirmationText": "autem",
  "SignOnText": "et",
  "EventDate": "2002-01-21T02:49:44.9372128+01:00",
  "Enabled": false,
  "CreatedDate": "2005-03-25T02:49:44.9372128+01:00",
  "SignOff": true,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 303,
  "SignOffTriggersAssign": false,
  "SignOn": false,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 164,
  "SignOnTriggersAssign": false,
  "UpdatedDate": "2007-03-15T02:49:44.9372128+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 953,
  "Id": 94,
  "PublishFrom": "2005-11-24T02:49:44.9372128+01:00",
  "PublishType": "External",
  "PublishTo": "2018-05-07T02:49:44.9372128+02:00",
  "VisibleForCategories": [
    {
      "Id": 436,
      "Name": "Hudson-Littel",
      "ToolTip": "Rerum voluptatum deleniti.",
      "Deleted": true,
      "Rank": 8,
      "Type": "error",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "beatae",
      "ColorBlock": 763,
      "ExtraInfo": "commodi",
      "StyleHint": "aut",
      "FullName": "Phoebe Altenwerth",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 731
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 319,
      "Name": "Osinski, Pfannerstill and Morissette",
      "ToolTip": "Omnis quibusdam quia cupiditate blanditiis quo.",
      "Deleted": false,
      "Rank": 913,
      "Type": "ut",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "dolore",
      "ColorBlock": 381,
      "ExtraInfo": "libero",
      "StyleHint": "officia",
      "FullName": "Mrs. Bradford Gottlieb",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 497
        }
      }
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": false,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 6,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 128
    }
  }
}
```