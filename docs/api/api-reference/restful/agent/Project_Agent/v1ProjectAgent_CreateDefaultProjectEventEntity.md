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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "non",
  "SignOffText": "autem",
  "SignOnConfirmationText": "sit",
  "SignOnText": "odio",
  "EventDate": "2015-03-23T18:28:49.873117+01:00",
  "Enabled": true,
  "CreatedDate": "2013-10-23T18:28:49.873117+02:00",
  "SignOff": true,
  "SignOffTaskEnable": true,
  "SignOffTaskId": 641,
  "SignOffTriggersAssign": false,
  "SignOn": false,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 975,
  "SignOnTriggersAssign": true,
  "UpdatedDate": "2009-10-31T18:28:49.873117+01:00",
  "CreatedBy": {
    "AssociateId": 785,
    "Name": "O'Hara, Jenkins and Schulist",
    "PersonId": 522,
    "Rank": 787,
    "Tooltip": "dolor",
    "Type": "AnonymousAssociate",
    "GroupIdx": 959,
    "FullName": "Dr. Ashleigh Goldner",
    "FormalName": "Abshire-Christiansen",
    "Deleted": true,
    "EjUserId": 250,
    "UserName": "Vandervort, Fadel and Schuppe",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 378
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 397,
    "Name": "Reynolds Inc and Sons",
    "PersonId": 18,
    "Rank": 161,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 494,
    "FullName": "Alyson Jacobi",
    "FormalName": "Okuneva Group",
    "Deleted": true,
    "EjUserId": 200,
    "UserName": "Cassin LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 599
      }
    }
  },
  "ProjectId": 780,
  "Id": 457,
  "PublishFrom": "1997-12-20T18:28:49.8741431+01:00",
  "PublishType": "External",
  "PublishTo": "1999-02-11T18:28:49.8741431+01:00",
  "VisibleForCategories": [
    {
      "Id": 563,
      "Name": "Johns, Jaskolski and Johnston",
      "ToolTip": "Maxime impedit vitae qui a.",
      "Deleted": false,
      "Rank": 597,
      "Type": "similique",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "pariatur",
      "ColorBlock": 909,
      "ExtraInfo": "blanditiis",
      "StyleHint": "et",
      "FullName": "Wellington Anderson",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 651
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 239,
      "Name": "Funk, Rippin and Baumbach",
      "ToolTip": "Quo et doloribus expedita aspernatur accusantium ut.",
      "Deleted": true,
      "Rank": 349,
      "Type": "cupiditate",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "doloremque",
      "ColorBlock": 983,
      "ExtraInfo": "non",
      "StyleHint": "fuga",
      "FullName": "Annetta Upton Jr.",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 892
        }
      }
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": true,
  "IsVisibleForCategories": false,
  "IsVisibleForPersonInterests": true,
  "ProjectEventId": 705,
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
      "FieldType": "System.String",
      "FieldLength": 861
    }
  }
}
```