---
title: GetProjectEventEntity
id: v1ProjectAgent_GetProjectEventEntity
---

# GetProjectEventEntity

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
POST /api/v1/Agents/Project/GetProjectEventEntity?projectEventEntityId=10
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
  "SignOffConfirmationText": "fugit",
  "SignOffText": "cum",
  "SignOnConfirmationText": "ut",
  "SignOnText": "esse",
  "EventDate": "2006-08-21T14:58:04.9224663+02:00",
  "Enabled": true,
  "CreatedDate": "2007-01-15T14:58:04.9224663+01:00",
  "SignOff": true,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 430,
  "SignOffTriggersAssign": true,
  "SignOn": false,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 793,
  "SignOnTriggersAssign": true,
  "UpdatedDate": "2001-02-13T14:58:04.9224663+01:00",
  "CreatedBy": {
    "AssociateId": 655,
    "Name": "Christiansen, Jacobson and Purdy",
    "PersonId": 217,
    "Rank": 716,
    "Tooltip": "libero",
    "Type": "AnonymousAssociate",
    "GroupIdx": 494,
    "FullName": "Kaylin Boyer",
    "FormalName": "Osinski Inc and Sons",
    "Deleted": false,
    "EjUserId": 534,
    "UserName": "Goyette-Koelpin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 94
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 483,
    "Name": "Weber, Baumbach and Osinski",
    "PersonId": 178,
    "Rank": 849,
    "Tooltip": "distinctio",
    "Type": "AnonymousAssociate",
    "GroupIdx": 986,
    "FullName": "Walker Bashirian",
    "FormalName": "Luettgen, Rohan and Quitzon",
    "Deleted": false,
    "EjUserId": 283,
    "UserName": "Little-Dickinson",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 260
      }
    }
  },
  "ProjectId": 779,
  "Id": 469,
  "PublishFrom": "2016-06-25T14:58:04.9234646+02:00",
  "PublishType": "External",
  "PublishTo": "2003-11-07T14:58:04.9234646+01:00",
  "VisibleForCategories": [
    {
      "Id": 862,
      "Name": "Reynolds-Wyman",
      "ToolTip": "Fuga dolorem ipsam ea est et.",
      "Deleted": true,
      "Rank": 689,
      "Type": "et",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "id",
      "ColorBlock": 726,
      "ExtraInfo": "est",
      "StyleHint": "voluptatem",
      "FullName": "Tracey Lesch",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 919
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 72,
      "Name": "Koss-Mann",
      "ToolTip": "Voluptate ea corporis voluptas.",
      "Deleted": false,
      "Rank": 127,
      "Type": "esse",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "saepe",
      "ColorBlock": 116,
      "ExtraInfo": "quasi",
      "StyleHint": "quas",
      "FullName": "Chadrick Roberts",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 600
        }
      }
    }
  ],
  "IsPublished": true,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": true,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 940,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "productize bricks-and-clicks action-items"
      },
      "FieldType": "System.String",
      "FieldLength": 259
    }
  }
}
```