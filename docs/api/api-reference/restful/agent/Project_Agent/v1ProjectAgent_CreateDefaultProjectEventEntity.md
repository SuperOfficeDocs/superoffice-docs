---
title: CreateDefaultProjectEventEntity
id: v1ProjectAgent_CreateDefaultProjectEventEntity
---

# CreateDefaultProjectEventEntity

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
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "libero",
  "SignOffText": "quo",
  "SignOnConfirmationText": "sit",
  "SignOnText": "dolorem",
  "EventDate": "1998-10-29T14:58:04.8934656+01:00",
  "Enabled": false,
  "CreatedDate": "1998-10-30T14:58:04.8934656+01:00",
  "SignOff": false,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 794,
  "SignOffTriggersAssign": true,
  "SignOn": false,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 297,
  "SignOnTriggersAssign": true,
  "UpdatedDate": "2000-01-01T14:58:04.8934656+01:00",
  "CreatedBy": {
    "AssociateId": 129,
    "Name": "Langworth Group",
    "PersonId": 568,
    "Rank": 817,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 287,
    "FullName": "Melody Murphy",
    "FormalName": "Kohler-Halvorson",
    "Deleted": true,
    "EjUserId": 952,
    "UserName": "Wunsch-Fisher",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 240
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 904,
    "Name": "Turcotte Group",
    "PersonId": 156,
    "Rank": 102,
    "Tooltip": "in",
    "Type": "AnonymousAssociate",
    "GroupIdx": 930,
    "FullName": "Candida Grant",
    "FormalName": "Gleichner Inc and Sons",
    "Deleted": true,
    "EjUserId": 249,
    "UserName": "Berge-Cassin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "monetize transparent niches"
        },
        "FieldType": "System.Int32",
        "FieldLength": 700
      }
    }
  },
  "ProjectId": 141,
  "Id": 550,
  "PublishFrom": "2004-07-16T14:58:04.8944656+02:00",
  "PublishType": "External",
  "PublishTo": "2020-02-15T14:58:04.8944656+01:00",
  "VisibleForCategories": [
    {
      "Id": 464,
      "Name": "Littel-Cronin",
      "ToolTip": "Voluptas amet eveniet.",
      "Deleted": true,
      "Rank": 784,
      "Type": "omnis",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "aut",
      "ColorBlock": 681,
      "ExtraInfo": "eos",
      "StyleHint": "aliquam",
      "FullName": "Mrs. Beryl Rogahn",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 761
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 86,
      "Name": "Gerlach Inc and Sons",
      "ToolTip": "Qui aspernatur dolorem.",
      "Deleted": false,
      "Rank": 724,
      "Type": "alias",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "commodi",
      "ColorBlock": 168,
      "ExtraInfo": "quis",
      "StyleHint": "est",
      "FullName": "Hellen Harvey",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 373
        }
      }
    }
  ],
  "IsPublished": true,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": true,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 398,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "benchmark proactive supply-chains"
      },
      "FieldType": "System.Int32",
      "FieldLength": 99
    }
  }
}
```