---
title: SaveProjectEventEntity
id: v1ProjectAgent_SaveProjectEventEntity
---

# SaveProjectEventEntity

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "ratione",
  "SignOffText": "id",
  "SignOnConfirmationText": "voluptates",
  "SignOnText": "soluta",
  "EventDate": "2015-05-02T14:58:04.8944656+02:00",
  "Enabled": true,
  "CreatedDate": "2011-05-04T14:58:04.8944656+02:00",
  "SignOff": false,
  "SignOffTaskEnable": false,
  "SignOffTaskId": 355,
  "SignOffTriggersAssign": true,
  "SignOn": false,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 984,
  "SignOnTriggersAssign": false,
  "UpdatedDate": "1996-03-01T14:58:04.8944656+01:00",
  "CreatedBy": {
    "AssociateId": 35,
    "Name": "Kozey-Pollich",
    "PersonId": 328,
    "Rank": 378,
    "Tooltip": "voluptatum",
    "Type": "AnonymousAssociate",
    "GroupIdx": 547,
    "FullName": "Shirley Balistreri",
    "FormalName": "McDermott, Goodwin and Gislason",
    "Deleted": false,
    "EjUserId": 378,
    "UserName": "Metz, Robel and Kassulke"
  },
  "UpdatedBy": {
    "AssociateId": 54,
    "Name": "Orn-Sauer",
    "PersonId": 971,
    "Rank": 671,
    "Tooltip": "porro",
    "Type": "AnonymousAssociate",
    "GroupIdx": 823,
    "FullName": "Anita Murazik",
    "FormalName": "Hoeger, Gottlieb and Lebsack",
    "Deleted": true,
    "EjUserId": 298,
    "UserName": "Pfannerstill-Leffler"
  },
  "ProjectId": 491,
  "Id": 704,
  "PublishFrom": "2018-03-08T14:58:04.8954672+01:00",
  "PublishType": "External",
  "PublishTo": "2019-12-10T14:58:04.8954672+01:00",
  "VisibleForCategories": [
    {
      "Id": 486,
      "Name": "Moen Group",
      "ToolTip": "Nostrum aut nihil.",
      "Deleted": true,
      "Rank": 660,
      "Type": "impedit",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "voluptates",
      "ColorBlock": 830,
      "ExtraInfo": "et",
      "StyleHint": "laborum",
      "FullName": "Leanne Tillman"
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 487,
      "Name": "Kunde, Gutkowski and Hand",
      "ToolTip": "Cupiditate ab delectus et velit id.",
      "Deleted": false,
      "Rank": 578,
      "Type": "necessitatibus",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "est",
      "ColorBlock": 619,
      "ExtraInfo": "tempora",
      "StyleHint": "non",
      "FullName": "Jenifer Lakin"
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": true,
  "IsVisibleForPersonInterests": true,
  "ProjectEventId": 517
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "minima",
  "SignOffText": "corrupti",
  "SignOnConfirmationText": "voluptas",
  "SignOnText": "et",
  "EventDate": "2006-09-30T14:58:04.898465+02:00",
  "Enabled": true,
  "CreatedDate": "1998-10-06T14:58:04.898465+02:00",
  "SignOff": false,
  "SignOffTaskEnable": true,
  "SignOffTaskId": 246,
  "SignOffTriggersAssign": true,
  "SignOn": true,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 937,
  "SignOnTriggersAssign": true,
  "UpdatedDate": "2009-03-22T14:58:04.898465+01:00",
  "CreatedBy": {
    "AssociateId": 246,
    "Name": "Wuckert-Cole",
    "PersonId": 426,
    "Rank": 407,
    "Tooltip": "odit",
    "Type": "AnonymousAssociate",
    "GroupIdx": 238,
    "FullName": "Ms. Otho Block",
    "FormalName": "Volkman-Pacocha",
    "Deleted": true,
    "EjUserId": 258,
    "UserName": "Dare-Schamberger",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 399
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 74,
    "Name": "Walker-Pouros",
    "PersonId": 88,
    "Rank": 801,
    "Tooltip": "aut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 392,
    "FullName": "Rubie Bergnaum",
    "FormalName": "Pfannerstill, Rogahn and Beier",
    "Deleted": true,
    "EjUserId": 298,
    "UserName": "Tremblay Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "repurpose sexy bandwidth"
        },
        "FieldType": "System.String",
        "FieldLength": 280
      }
    }
  },
  "ProjectId": 456,
  "Id": 179,
  "PublishFrom": "2010-03-03T14:58:04.898465+01:00",
  "PublishType": "External",
  "PublishTo": "2020-12-05T14:58:04.898465+01:00",
  "VisibleForCategories": [
    {
      "Id": 335,
      "Name": "Denesik, Hahn and Cormier",
      "ToolTip": "Hic consequatur iure.",
      "Deleted": true,
      "Rank": 616,
      "Type": "consectetur",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "eos",
      "ColorBlock": 431,
      "ExtraInfo": "aperiam",
      "StyleHint": "est",
      "FullName": "Travon Prohaska",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 122
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 871,
      "Name": "Feil, Eichmann and Thompson",
      "ToolTip": "Eaque ducimus earum error maxime.",
      "Deleted": true,
      "Rank": 82,
      "Type": "dicta",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "natus",
      "ColorBlock": 552,
      "ExtraInfo": "sit",
      "StyleHint": "voluptas",
      "FullName": "Modesto Conroy",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 399
        }
      }
    }
  ],
  "IsPublished": true,
  "IsVisibleForMembers": true,
  "IsVisibleForCategories": true,
  "IsVisibleForPersonInterests": false,
  "ProjectEventId": 97,
  "TableRight": {
    "Mask": "Delete",
    "Reason": "enable plug-and-play mindshare"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "utilize ubiquitous metrics"
      },
      "FieldType": "System.String",
      "FieldLength": 878
    }
  }
}
```