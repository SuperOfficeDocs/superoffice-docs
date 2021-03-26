---
title: POST Agents/Project/CreateDefaultProjectEventEntity
id: v1ProjectAgent_CreateDefaultProjectEventEntity
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
POST /api/v1/Agents/Project/CreateDefaultProjectEventEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "qui",
  "SignOffText": "et",
  "SignOnConfirmationText": "doloremque",
  "SignOnText": "repellat",
  "EventDate": "2019-02-19T16:48:30.328936+01:00",
  "Enabled": true,
  "CreatedDate": "2018-10-30T16:48:30.328936+01:00",
  "SignOff": true,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 745,
  "SignOffTriggersAssign": false,
  "SignOn": true,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 836,
  "SignOnTriggersAssign": true,
  "UpdatedDate": "2001-01-25T16:48:30.328936+01:00",
  "CreatedBy": {
    "AssociateId": 493,
    "Name": "Rau, Willms and Turcotte",
    "PersonId": 976,
    "Rank": 79,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 377,
    "FullName": "Mrs. Deion Hackett",
    "FormalName": "Stokes, Harber and Paucek",
    "Deleted": false,
    "EjUserId": 16,
    "UserName": "Mayert-Hermiston",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 238
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 948,
    "Name": "Schuster, Wyman and Moen",
    "PersonId": 364,
    "Rank": 705,
    "Tooltip": "odit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 342,
    "FullName": "Dr. Andrew Emmerich",
    "FormalName": "Schoen-Becker",
    "Deleted": true,
    "EjUserId": 467,
    "UserName": "Yundt-Dicki",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "innovate synergistic platforms"
        },
        "FieldType": "System.Int32",
        "FieldLength": 360
      }
    }
  },
  "ProjectId": 488,
  "Id": 283,
  "PublishFrom": "2006-04-13T16:48:30.3299333+02:00",
  "PublishType": "External",
  "PublishTo": "1997-03-11T16:48:30.3299333+01:00",
  "VisibleForCategories": [
    {
      "Id": 892,
      "Name": "Hudson, Kassulke and Turcotte",
      "ToolTip": "Quia similique aliquid doloribus officia.",
      "Deleted": false,
      "Rank": 956,
      "Type": "vitae",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "quam",
      "ColorBlock": 585,
      "ExtraInfo": "et",
      "StyleHint": "optio",
      "FullName": "Robert Terry",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 750
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 22,
      "Name": "Lubowitz Inc and Sons",
      "ToolTip": "Voluptas quod esse.",
      "Deleted": false,
      "Rank": 135,
      "Type": "aut",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "quo",
      "ColorBlock": 250,
      "ExtraInfo": "maiores",
      "StyleHint": "eaque",
      "FullName": "Dr. Annalise Predovic",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 195
        }
      }
    }
  ],
  "IsPublished": true,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": false,
  "IsVisibleForPersonInterests": true,
  "ProjectEventId": 995,
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
      "FieldLength": 632
    }
  }
}
```