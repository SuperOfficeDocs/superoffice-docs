---
title: POST Agents/Project/GetProjectEventEntityFromProjectId
uid: v1ProjectAgent_GetProjectEventEntityFromProjectId
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
| ProjectId | Integer |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ProjectEventEntity

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
| CreatedBy | Associate | The person that created the projectevent |
| UpdatedBy | Associate | The person that last updated the projectevent |
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Project/GetProjectEventEntityFromProjectId
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProjectId": 340
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SignOffConfirmationText": "quisquam",
  "SignOffText": "sed",
  "SignOnConfirmationText": "in",
  "SignOnText": "nesciunt",
  "EventDate": "1999-10-09T12:15:19.8527387+02:00",
  "Enabled": false,
  "CreatedDate": "2014-07-10T12:15:19.8527387+02:00",
  "SignOff": false,
  "SignOffTaskEnable": true,
  "SignOffTaskId": 453,
  "SignOffTriggersAssign": false,
  "SignOn": false,
  "SignOnTaskEnable": false,
  "SignOnTaskId": 307,
  "SignOnTriggersAssign": false,
  "UpdatedDate": "2014-10-19T12:15:19.8527387+02:00",
  "CreatedBy": null,
  "UpdatedBy": null,
  "ProjectId": 1000,
  "Id": 414,
  "PublishFrom": "2022-05-22T12:15:19.8537388+02:00",
  "PublishType": "External",
  "PublishTo": "2002-02-14T12:15:19.8537388+01:00",
  "VisibleForCategories": [
    {
      "Id": 394,
      "Name": "Mohr, Dietrich and Parisian",
      "ToolTip": "Sed necessitatibus ipsam.",
      "Deleted": true,
      "Rank": 708,
      "Type": "et",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "sunt",
      "ColorBlock": 148,
      "ExtraInfo": "et",
      "StyleHint": "vero",
      "FullName": "King Gutkowski",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 475
        }
      }
    }
  ],
  "VisibleForPersonInterests": [
    {
      "Id": 646,
      "Name": "Tromp-Towne",
      "ToolTip": "Dolor nobis ullam dolor id.",
      "Deleted": false,
      "Rank": 864,
      "Type": "beatae",
      "ChildItems": [
        {},
        {}
      ],
      "IconHint": "rem",
      "ColorBlock": 731,
      "ExtraInfo": "illum",
      "StyleHint": "a",
      "FullName": "Jade Robel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 68
        }
      }
    }
  ],
  "IsPublished": false,
  "IsVisibleForMembers": true,
  "IsVisibleForCategories": true,
  "IsVisibleForPersonInterests": true,
  "ProjectEventId": 105,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 751
    }
  }
}
```