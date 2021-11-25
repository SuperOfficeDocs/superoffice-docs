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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "sequi",
  "SignOffText": "quam",
  "SignOnConfirmationText": "ducimus",
  "SignOnText": "corrupti",
  "EventDate": "1995-03-20T18:28:49.875143+01:00",
  "Enabled": false,
  "CreatedDate": "2016-05-15T18:28:49.875143+02:00",
  "SignOff": true,
  "SignOffTaskEnable": true,
  "SignOffTaskId": 158,
  "SignOffTriggersAssign": false,
  "SignOn": false,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 24,
  "SignOnTriggersAssign": false,
  "UpdatedDate": "2016-11-16T18:28:49.875143+01:00",
  "CreatedBy": {
    "AssociateId": 594,
    "Name": "DuBuque LLC",
    "PersonId": 286,
    "Rank": 274,
    "Tooltip": "laudantium",
    "Type": "AnonymousAssociate",
    "GroupIdx": 363,
    "FullName": "Bradley Mante",
    "FormalName": "Greenholt LLC",
    "Deleted": false,
    "EjUserId": 651,
    "UserName": "Moen-Nicolas"
  },
  "UpdatedBy": {
    "AssociateId": 913,
    "Name": "Friesen-Hermiston",
    "PersonId": 681,
    "Rank": 537,
    "Tooltip": "architecto",
    "Type": "AnonymousAssociate",
    "GroupIdx": 577,
    "FullName": "Clyde Larkin",
    "FormalName": "Collier Group",
    "Deleted": false,
    "EjUserId": 135,
    "UserName": "Emard LLC"
  },
  "ProjectId": 66,
  "Id": 614,
  "PublishFrom": "2016-08-31T18:28:49.8761096+02:00",
  "PublishType": "External",
  "PublishTo": "1999-08-19T18:28:49.8761096+02:00",
  "VisibleForCategories": [
    {
      "Id": 239,
      "Name": "Cronin, Powlowski and Hane",
      "ToolTip": "Illo unde soluta natus a.",
      "Deleted": true,
      "Rank": 607,
      "Type": "enim",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "qui",
      "ColorBlock": 787,
      "ExtraInfo": "molestiae",
      "StyleHint": "aut",
      "FullName": "Jude Smith IV"
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 110,
      "Name": "Greenfelder-Stamm",
      "ToolTip": "Inventore minima et ullam aspernatur repudiandae et.",
      "Deleted": true,
      "Rank": 910,
      "Type": "ut",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "in",
      "ColorBlock": 991,
      "ExtraInfo": "non",
      "StyleHint": "earum",
      "FullName": "Dejah Shields"
    }
  ],
  "IsPublished": true,
  "IsVisibleForMembers": true,
  "IsVisibleForCategories": false,
  "IsVisibleForPersonInterests": true,
  "ProjectEventId": 703
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "id",
  "SignOffText": "iste",
  "SignOnConfirmationText": "dolore",
  "SignOnText": "earum",
  "EventDate": "2005-10-07T18:28:49.8781439+02:00",
  "Enabled": true,
  "CreatedDate": "2015-01-06T18:28:49.8781439+01:00",
  "SignOff": false,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 495,
  "SignOffTriggersAssign": true,
  "SignOn": false,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 347,
  "SignOnTriggersAssign": true,
  "UpdatedDate": "2012-05-23T18:28:49.8781439+02:00",
  "CreatedBy": {
    "AssociateId": 581,
    "Name": "Smitham-Koepp",
    "PersonId": 157,
    "Rank": 28,
    "Tooltip": "enim",
    "Type": "AnonymousAssociate",
    "GroupIdx": 23,
    "FullName": "Jodie Kunde",
    "FormalName": "Goodwin-Grant",
    "Deleted": false,
    "EjUserId": 399,
    "UserName": "Franecki-Ebert",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 337
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 53,
    "Name": "Ferry, Morissette and Heaney",
    "PersonId": 112,
    "Rank": 443,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 446,
    "FullName": "Edmond Jacobi",
    "FormalName": "Goodwin, Carter and Shields",
    "Deleted": false,
    "EjUserId": 772,
    "UserName": "Gerhold, Feeney and Emmerich",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 11
      }
    }
  },
  "ProjectId": 919,
  "Id": 138,
  "PublishFrom": "2008-11-29T18:28:49.8791435+01:00",
  "PublishType": "External",
  "PublishTo": "2004-09-16T18:28:49.8791435+02:00",
  "VisibleForCategories": [
    {
      "Id": 131,
      "Name": "Brown Group",
      "ToolTip": "Assumenda voluptates ad sequi harum.",
      "Deleted": true,
      "Rank": 832,
      "Type": "cupiditate",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "unde",
      "ColorBlock": 972,
      "ExtraInfo": "ad",
      "StyleHint": "odio",
      "FullName": "Pearline Parker",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 717
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 433,
      "Name": "Reinger-Weimann",
      "ToolTip": "Enim nesciunt exercitationem cum.",
      "Deleted": false,
      "Rank": 464,
      "Type": "expedita",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "deserunt",
      "ColorBlock": 626,
      "ExtraInfo": "iure",
      "StyleHint": "molestiae",
      "FullName": "Jaime West",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 190
        }
      }
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": true,
  "IsVisibleForCategories": true,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 809,
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
      "FieldLength": 130
    }
  }
}
```