---
title: POST Agents/Project/SaveProjectEventEntity
id: v1ProjectAgent_SaveProjectEventEntity
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


## Response: object

The ProjectEvent Service. The service implements all services working with the ProjectEvent object



Carrier object for ProjectEventEntity.
Services for the ProjectEventEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IProjectAgent">Project Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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

## Sample Request

```http!
POST /api/v1/Agents/Project/SaveProjectEventEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "temporibus",
  "SignOffText": "dolores",
  "SignOnConfirmationText": "qui",
  "SignOnText": "est",
  "EventDate": "2006-06-04T16:48:30.3309359+02:00",
  "Enabled": false,
  "CreatedDate": "2012-01-30T16:48:30.3309359+01:00",
  "SignOff": true,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 875,
  "SignOffTriggersAssign": false,
  "SignOn": false,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 955,
  "SignOnTriggersAssign": true,
  "UpdatedDate": "1994-09-06T16:48:30.3309359+02:00",
  "CreatedBy": {
    "AssociateId": 77,
    "Name": "Collier LLC",
    "PersonId": 859,
    "Rank": 77,
    "Tooltip": "non",
    "Type": "AnonymousAssociate",
    "GroupIdx": 599,
    "FullName": "Emilio Leffler",
    "FormalName": "Zemlak-Franecki",
    "Deleted": false,
    "EjUserId": 676,
    "UserName": "Franecki LLC"
  },
  "UpdatedBy": {
    "AssociateId": 351,
    "Name": "Hartmann-Smitham",
    "PersonId": 288,
    "Rank": 660,
    "Tooltip": "atque",
    "Type": "AnonymousAssociate",
    "GroupIdx": 883,
    "FullName": "Kevin Bergnaum",
    "FormalName": "Lang-O'Kon",
    "Deleted": false,
    "EjUserId": 278,
    "UserName": "Mayer, Brekke and Auer"
  },
  "ProjectId": 945,
  "Id": 354,
  "PublishFrom": "2020-10-15T16:48:30.3319348+02:00",
  "PublishType": "External",
  "PublishTo": "2006-07-02T16:48:30.3319348+02:00",
  "VisibleForCategories": [
    {
      "Id": 882,
      "Name": "Daniel Inc and Sons",
      "ToolTip": "Fugit nihil est rerum quibusdam qui.",
      "Deleted": false,
      "Rank": 418,
      "Type": "ducimus",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "porro",
      "ColorBlock": 129,
      "ExtraInfo": "laudantium",
      "StyleHint": "atque",
      "FullName": "Tatyana Hyatt"
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 555,
      "Name": "Kemmer, Harber and Keeling",
      "ToolTip": "Dolorem perspiciatis sed molestias modi voluptate et.",
      "Deleted": false,
      "Rank": 459,
      "Type": "eum",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "vero",
      "ColorBlock": 44,
      "ExtraInfo": "corporis",
      "StyleHint": "distinctio",
      "FullName": "Dannie Fadel"
    }
  ],
  "IsPublished": true,
  "IsVisibleForMembers": true,
  "IsVisibleForCategories": false,
  "IsVisibleForPersonInterests": true,
  "ProjectEventId": 675
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "rerum",
  "SignOffText": "aut",
  "SignOnConfirmationText": "earum",
  "SignOnText": "a",
  "EventDate": "2021-03-19T16:48:30.3349379+01:00",
  "Enabled": false,
  "CreatedDate": "2005-06-18T16:48:30.3349379+02:00",
  "SignOff": false,
  "SignOffTaskEnable": true,
  "SignOffTaskId": 121,
  "SignOffTriggersAssign": false,
  "SignOn": false,
  "SignOnTaskEnable": true,
  "SignOnTaskId": 473,
  "SignOnTriggersAssign": true,
  "UpdatedDate": "2012-12-04T16:48:30.3349379+01:00",
  "CreatedBy": {
    "AssociateId": 427,
    "Name": "Bernhard, Trantow and Jacobs",
    "PersonId": 931,
    "Rank": 603,
    "Tooltip": "expedita",
    "Type": "AnonymousAssociate",
    "GroupIdx": 98,
    "FullName": "Christina Kutch",
    "FormalName": "Schumm, Waters and Cartwright",
    "Deleted": true,
    "EjUserId": 278,
    "UserName": "Koepp, Gutkowski and Gerhold",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 584
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 796,
    "Name": "Hegmann-Mertz",
    "PersonId": 570,
    "Rank": 256,
    "Tooltip": "voluptates",
    "Type": "AnonymousAssociate",
    "GroupIdx": 124,
    "FullName": "Russ Hayes",
    "FormalName": "Gutkowski, Nienow and Pacocha",
    "Deleted": true,
    "EjUserId": 348,
    "UserName": "Corkery-Rice",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 907
      }
    }
  },
  "ProjectId": 421,
  "Id": 962,
  "PublishFrom": "2005-12-07T16:48:30.335934+01:00",
  "PublishType": "External",
  "PublishTo": "2005-01-09T16:48:30.335934+01:00",
  "VisibleForCategories": [
    {
      "Id": 392,
      "Name": "Auer, Ward and Friesen",
      "ToolTip": "Et aut.",
      "Deleted": false,
      "Rank": 338,
      "Type": "repellat",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "unde",
      "ColorBlock": 518,
      "ExtraInfo": "sint",
      "StyleHint": "nam",
      "FullName": "Bailey O'Reilly",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 635
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 405,
      "Name": "Ondricka-Skiles",
      "ToolTip": "Aliquid aut provident.",
      "Deleted": true,
      "Rank": 162,
      "Type": "eaque",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "dolorum",
      "ColorBlock": 175,
      "ExtraInfo": "esse",
      "StyleHint": "vitae",
      "FullName": "Vincent Huel",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 799
        }
      }
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": true,
  "IsVisibleForCategories": true,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 101,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 144
    }
  }
}
```