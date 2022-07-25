---
title: POST Agents/Project/GetProjectEventEntity
id: v1ProjectAgent_GetProjectEventEntity
---

# POST Agents/Project/GetProjectEventEntity

```http
POST /api/v1/Agents/Project/GetProjectEventEntity
```

Gets a ProjectEventEntity object.

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| projectEventEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Project/GetProjectEventEntity?projectEventEntityId=980
POST /api/v1/Agents/Project/GetProjectEventEntity?$select=name,department,category/id
```

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
POST /api/v1/Agents/Project/GetProjectEventEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "placeat",
  "SignOffText": "saepe",
  "SignOnConfirmationText": "rem",
  "SignOnText": "reiciendis",
  "EventDate": "2010-10-25T18:28:49.9041378+02:00",
  "Enabled": true,
  "CreatedDate": "2016-01-19T18:28:49.9041378+01:00",
  "SignOff": false,
  "SignOffTaskEnable": true,
  "SignOffTaskId": 627,
  "SignOffTriggersAssign": true,
  "SignOn": true,
  "SignOnTaskEnable": true,
  "SignOnTaskId": 378,
  "SignOnTriggersAssign": false,
  "UpdatedDate": "2013-04-15T18:28:49.9041378+02:00",
  "CreatedBy": {
    "AssociateId": 376,
    "Name": "Ernser-O'Connell",
    "PersonId": 799,
    "Rank": 706,
    "Tooltip": "voluptatibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 340,
    "FullName": "Susie Jenkins",
    "FormalName": "Wiza, Kuvalis and Bechtelar",
    "Deleted": false,
    "EjUserId": 208,
    "UserName": "Satterfield, Rosenbaum and Jacobi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 24
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 462,
    "Name": "Greenfelder Inc and Sons",
    "PersonId": 648,
    "Rank": 429,
    "Tooltip": "maiores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 529,
    "FullName": "Austyn Stroman",
    "FormalName": "Lind-Treutel",
    "Deleted": true,
    "EjUserId": 732,
    "UserName": "Cummings LLC",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 889
      }
    }
  },
  "ProjectId": 172,
  "Id": 828,
  "PublishFrom": "2007-03-29T18:28:49.9051439+02:00",
  "PublishType": "External",
  "PublishTo": "1995-05-27T18:28:49.9051439+02:00",
  "VisibleForCategories": [
    {
      "Id": 644,
      "Name": "Mohr Group",
      "ToolTip": "Omnis temporibus quia aut.",
      "Deleted": true,
      "Rank": 723,
      "Type": "sequi",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "natus",
      "ColorBlock": 426,
      "ExtraInfo": "neque",
      "StyleHint": "eos",
      "FullName": "Rosendo Carter",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 403
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 320,
      "Name": "Kozey LLC",
      "ToolTip": "Consequatur at.",
      "Deleted": false,
      "Rank": 271,
      "Type": "amet",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "dolor",
      "ColorBlock": 110,
      "ExtraInfo": "dolorum",
      "StyleHint": "ducimus",
      "FullName": "Jessy Spinka",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 665
        }
      }
    }
  ],
  "IsPublished": true,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": false,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 107,
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
      "FieldLength": 901
    }
  }
}
```
