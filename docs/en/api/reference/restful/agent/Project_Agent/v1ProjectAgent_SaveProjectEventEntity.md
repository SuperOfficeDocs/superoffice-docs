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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "eos",
  "SignOffText": "vel",
  "SignOnConfirmationText": "aspernatur",
  "SignOnText": "voluptatem",
  "EventDate": "2003-07-03T10:17:55.8790557+02:00",
  "Enabled": false,
  "CreatedDate": "1999-09-18T10:17:55.8790557+02:00",
  "SignOff": true,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 878,
  "SignOffTriggersAssign": false,
  "SignOn": false,
  "SignOnTaskEnable": true,
  "SignOnTaskId": 530,
  "SignOnTriggersAssign": false,
  "UpdatedDate": "2007-08-22T10:17:55.8790557+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 460,
  "Id": 761,
  "PublishFrom": "2024-04-13T10:17:55.8790557+02:00",
  "PublishType": "External",
  "PublishTo": "2000-12-10T10:17:55.8790557+01:00",
  "VisibleForCategories": [
    {
      "Id": 394,
      "Name": "Dach-Satterfield",
      "ToolTip": "Rerum perferendis nobis sunt quis quis.",
      "Deleted": false,
      "Rank": 397,
      "Type": "quo",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "a",
      "ColorBlock": 436,
      "ExtraInfo": "exercitationem",
      "StyleHint": "soluta",
      "FullName": "Mrs. Harry Kendall Daugherty"
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 982,
      "Name": "Abbott Inc and Sons",
      "ToolTip": "Magni excepturi fugit eaque soluta.",
      "Deleted": true,
      "Rank": 734,
      "Type": "praesentium",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "non",
      "ColorBlock": 763,
      "ExtraInfo": "corrupti",
      "StyleHint": "cum",
      "FullName": "Odell Schaefer"
    }
  ],
  "IsPublished": true,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": false,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 249
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "temporibus",
  "SignOffText": "soluta",
  "SignOnConfirmationText": "et",
  "SignOnText": "consequatur",
  "EventDate": "1998-05-01T10:17:55.8790557+02:00",
  "Enabled": true,
  "CreatedDate": "2013-06-14T10:17:55.8790557+02:00",
  "SignOff": true,
  "SignOffTaskEnable": true,
  "SignOffTaskId": 531,
  "SignOffTriggersAssign": true,
  "SignOn": true,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 995,
  "SignOnTriggersAssign": false,
  "UpdatedDate": "2008-11-30T10:17:55.8790557+01:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 599,
  "Id": 901,
  "PublishFrom": "2000-06-12T10:17:55.8790557+02:00",
  "PublishType": "External",
  "PublishTo": "2005-06-17T10:17:55.8790557+02:00",
  "VisibleForCategories": [
    {
      "Id": 724,
      "Name": "Hamill, Anderson and Steuber",
      "ToolTip": "Quis itaque.",
      "Deleted": false,
      "Rank": 987,
      "Type": "consequatur",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "aut",
      "ColorBlock": 591,
      "ExtraInfo": "voluptate",
      "StyleHint": "sapiente",
      "FullName": "Cornell Von",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 678
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 463,
      "Name": "Beahan-Kshlerin",
      "ToolTip": "Reprehenderit ad fuga ut laborum facere.",
      "Deleted": false,
      "Rank": 848,
      "Type": "repellat",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "qui",
      "ColorBlock": 421,
      "ExtraInfo": "possimus",
      "StyleHint": "id",
      "FullName": "Grady Mann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 496
        }
      }
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": false,
  "IsVisibleForPersonInterests": true,
  "ProjectEventId": 73,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 341
    }
  }
}
```