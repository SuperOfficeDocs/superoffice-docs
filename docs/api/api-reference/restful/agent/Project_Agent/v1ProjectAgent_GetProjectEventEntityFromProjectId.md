---
title: GetProjectEventEntityFromProjectId
id: v1ProjectAgent_GetProjectEventEntityFromProjectId
---

# GetProjectEventEntityFromProjectId

```http
POST /api/v1/Agents/Project/GetProjectEventEntityFromProjectId
```

Get a ProjectEventEntity based on a projectId.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Project/GetProjectEventEntityFromProjectId?$select=name,department,category/id
```


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

## Request Body: request  

ProjectId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProjectId | int32 |  |


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
POST /api/v1/Agents/Project/GetProjectEventEntityFromProjectId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 222
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "inventore",
  "SignOffText": "qui",
  "SignOnConfirmationText": "qui",
  "SignOnText": "corrupti",
  "EventDate": "2018-06-10T14:58:04.8494601+02:00",
  "Enabled": true,
  "CreatedDate": "2008-11-04T14:58:04.8494601+01:00",
  "SignOff": false,
  "SignOffTaskEnable": true,
  "SignOffTaskId": 623,
  "SignOffTriggersAssign": true,
  "SignOn": true,
  "SignOnTaskEnable": true,
  "SignOnTaskId": 172,
  "SignOnTriggersAssign": true,
  "UpdatedDate": "1999-08-12T14:58:04.8494601+02:00",
  "CreatedBy": {
    "AssociateId": 505,
    "Name": "Spinka-Padberg",
    "PersonId": 215,
    "Rank": 43,
    "Tooltip": "corporis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 282,
    "FullName": "Emile Pfeffer III",
    "FormalName": "Okuneva-Treutel",
    "Deleted": true,
    "EjUserId": 675,
    "UserName": "Howell-Champlin",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 354
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 190,
    "Name": "Thiel, Predovic and Marks",
    "PersonId": 304,
    "Rank": 963,
    "Tooltip": "cum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 218,
    "FullName": "Friedrich McKenzie",
    "FormalName": "Monahan Inc and Sons",
    "Deleted": false,
    "EjUserId": 117,
    "UserName": "Terry Group",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 921
      }
    }
  },
  "ProjectId": 498,
  "Id": 860,
  "PublishFrom": "2010-04-10T14:58:04.8494601+02:00",
  "PublishType": "External",
  "PublishTo": "2012-06-26T14:58:04.8494601+02:00",
  "VisibleForCategories": [
    {
      "Id": 917,
      "Name": "Stoltenberg-Stehr",
      "ToolTip": "Nihil facilis impedit et ex atque.",
      "Deleted": false,
      "Rank": 934,
      "Type": "laboriosam",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "dicta",
      "ColorBlock": 527,
      "ExtraInfo": "voluptatibus",
      "StyleHint": "vel",
      "FullName": "Ms. Delaney Stoltenberg",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 807
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 105,
      "Name": "Gusikowski, Howe and Gutkowski",
      "ToolTip": "Molestias id.",
      "Deleted": true,
      "Rank": 189,
      "Type": "consequuntur",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "quibusdam",
      "ColorBlock": 392,
      "ExtraInfo": "aperiam",
      "StyleHint": "dolorem",
      "FullName": "Hannah Harris",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 105
        }
      }
    }
  ],
  "IsPublished": true,
  "IsVisibleForMembers": true,
  "IsVisibleForCategories": false,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 311,
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
      "FieldLength": 448
    }
  }
}
```