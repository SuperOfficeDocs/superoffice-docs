---
title: POST Agents/Project/GetProjectEventEntityFromProjectId
id: v1ProjectAgent_GetProjectEventEntityFromProjectId
---

# POST Agents/Project/GetProjectEventEntityFromProjectId

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
  "ProjectId": 961
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "corrupti",
  "SignOffText": "eum",
  "SignOnConfirmationText": "recusandae",
  "SignOnText": "dolor",
  "EventDate": "2017-12-15T18:28:49.7731373+01:00",
  "Enabled": false,
  "CreatedDate": "1995-02-25T18:28:49.7731373+01:00",
  "SignOff": true,
  "SignOffTaskEnable": true,
  "SignOffTaskId": 834,
  "SignOffTriggersAssign": true,
  "SignOn": true,
  "SignOnTaskEnable": true,
  "SignOnTaskId": 431,
  "SignOnTriggersAssign": true,
  "UpdatedDate": "2021-04-23T18:28:49.7731373+02:00",
  "CreatedBy": {
    "AssociateId": 478,
    "Name": "Bergnaum-Mante",
    "PersonId": 151,
    "Rank": 968,
    "Tooltip": "quis",
    "Type": "AnonymousAssociate",
    "GroupIdx": 937,
    "FullName": "Alejandrin Greenfelder",
    "FormalName": "Nikolaus-O'Connell",
    "Deleted": true,
    "EjUserId": 991,
    "UserName": "Smith-Fay",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 231
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 575,
    "Name": "Predovic, Schiller and Batz",
    "PersonId": 985,
    "Rank": 774,
    "Tooltip": "accusamus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 223,
    "FullName": "Archibald Pagac",
    "FormalName": "Little-Donnelly",
    "Deleted": true,
    "EjUserId": 211,
    "UserName": "Wiegand-Auer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 978
      }
    }
  },
  "ProjectId": 309,
  "Id": 818,
  "PublishFrom": "2005-09-08T18:28:49.774109+02:00",
  "PublishType": "External",
  "PublishTo": "2012-04-12T18:28:49.774109+02:00",
  "VisibleForCategories": [
    {
      "Id": 821,
      "Name": "Hauck-Mayer",
      "ToolTip": "Est dolores voluptas.",
      "Deleted": false,
      "Rank": 572,
      "Type": "nihil",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "quam",
      "ColorBlock": 225,
      "ExtraInfo": "enim",
      "StyleHint": "quis",
      "FullName": "Miss Jerod Aufderhar",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 506
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 145,
      "Name": "Padberg Group",
      "ToolTip": "Beatae non ea dolorem id.",
      "Deleted": true,
      "Rank": 301,
      "Type": "cumque",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "quaerat",
      "ColorBlock": 877,
      "ExtraInfo": "deserunt",
      "StyleHint": "est",
      "FullName": "Natasha Zieme",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 605
        }
      }
    }
  ],
  "IsPublished": true,
  "IsVisibleForMembers": false,
  "IsVisibleForCategories": true,
  "IsVisibleForPersonInterests": true,
  "ProjectEventId": 184,
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
      "FieldLength": 209
    }
  }
}
```