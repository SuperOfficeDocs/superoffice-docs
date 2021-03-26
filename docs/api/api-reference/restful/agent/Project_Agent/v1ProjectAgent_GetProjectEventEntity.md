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
POST /api/v1/Agents/Project/GetProjectEventEntity?projectEventEntityId=492
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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "voluptates",
  "SignOffText": "sit",
  "SignOnConfirmationText": "asperiores",
  "SignOnText": "qui",
  "EventDate": "1995-10-17T16:48:30.3609348+02:00",
  "Enabled": true,
  "CreatedDate": "2013-01-18T16:48:30.3609348+01:00",
  "SignOff": false,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 291,
  "SignOffTriggersAssign": true,
  "SignOn": false,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 534,
  "SignOnTriggersAssign": true,
  "UpdatedDate": "2012-02-05T16:48:30.3609348+01:00",
  "CreatedBy": {
    "AssociateId": 331,
    "Name": "Lang LLC",
    "PersonId": 886,
    "Rank": 361,
    "Tooltip": "dolores",
    "Type": "AnonymousAssociate",
    "GroupIdx": 28,
    "FullName": "Dedric Bernhard",
    "FormalName": "Krajcik Inc and Sons",
    "Deleted": false,
    "EjUserId": 535,
    "UserName": "Doyle Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 856
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 198,
    "Name": "Wilderman-Bruen",
    "PersonId": 512,
    "Rank": 993,
    "Tooltip": "quidem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 232,
    "FullName": "Gregg Waelchi",
    "FormalName": "Jast Inc and Sons",
    "Deleted": true,
    "EjUserId": 46,
    "UserName": "VonRueden, Bednar and Kreiger",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 979
      }
    }
  },
  "ProjectId": 271,
  "Id": 296,
  "PublishFrom": "2019-04-11T16:48:30.3609348+02:00",
  "PublishType": "External",
  "PublishTo": "2002-12-16T16:48:30.3609348+01:00",
  "VisibleForCategories": [
    {
      "Id": 192,
      "Name": "Kuhn Group",
      "ToolTip": "Et eum officia aperiam nemo id dolores.",
      "Deleted": false,
      "Rank": 132,
      "Type": "facere",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "eum",
      "ColorBlock": 90,
      "ExtraInfo": "et",
      "StyleHint": "sed",
      "FullName": "Michelle Bashirian",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "synthesize synergistic mindshare"
          },
          "FieldType": "System.String",
          "FieldLength": 435
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 565,
      "Name": "Heathcote LLC",
      "ToolTip": "Omnis consectetur id blanditiis.",
      "Deleted": false,
      "Rank": 611,
      "Type": "nisi",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "soluta",
      "ColorBlock": 261,
      "ExtraInfo": "accusamus",
      "StyleHint": "voluptatibus",
      "FullName": "Amber Gottlieb",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 820
        }
      }
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": true,
  "IsVisibleForCategories": true,
  "IsVisibleForPersonInterests": true,
  "ProjectEventId": 574,
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
      "FieldLength": 329
    }
  }
}
```