---
title: POST Agents/Appointment/SaveSuggestedAppointmentEntity
id: v1AppointmentAgent_SaveSuggestedAppointmentEntity
---

# POST Agents/Appointment/SaveSuggestedAppointmentEntity

```http
POST /api/v1/Agents/Appointment/SaveSuggestedAppointmentEntity
```

Updates the existing SuggestedAppointmentEntity or creates a new SuggestedAppointmentEntity if the id parameter is empty








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

The SuggestedAppointmentEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| SuggestedAppointmentId | int32 | Primary key |
| Name | string | Item name, visible in Guide |
| Tooltip | string | Tooltip / description |
| Rank | int32 | Rank, controls rank of non-instantiated items in Guide |
| Deleted | bool | 0 -&gt; record is active 1 -&gt; record is 'deleted' and should not be shown in lists |
| DaysFuture | int32 | How many days into the future the appointment should be scheduled |
| Duration | string | Duration in minutes of suggested appointment |
| AutoSuggest | bool | Should this appointment be auto-suggested |
| IsMilestone | bool | Is this a milestone activity |
| AssignToMember | bool | Should this appointment be assigned to project member |
| Text | string | The suggested text of the new appointment |
| ProjectTypeStatusLink |  | Project type and project status link info |
| SaleTypeStageLink |  | Sale type and stage link info |
| Type |  | Type of the suggested appointment |


## Response: object

Carrier object for SuggestedAppointmentEntity.
Services for the SuggestedAppointmentEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| SuggestedAppointmentId | int32 | Primary key |
| Name | string | Item name, visible in Guide |
| Tooltip | string | Tooltip / description |
| Rank | int32 | Rank, controls rank of non-instantiated items in Guide |
| Deleted | bool | 0 -&gt; record is active 1 -&gt; record is 'deleted' and should not be shown in lists |
| DaysFuture | int32 | How many days into the future the appointment should be scheduled |
| Duration | string | Duration in minutes of suggested appointment |
| AutoSuggest | bool | Should this appointment be auto-suggested |
| IsMilestone | bool | Is this a milestone activity |
| AssignToMember | bool | Should this appointment be assigned to project member |
| Text | string | The suggested text of the new appointment |
| ProjectTypeStatusLink |  | Project type and project status link info |
| SaleTypeStageLink |  | Sale type and stage link info |
| Type |  | Type of the suggested appointment |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Appointment/SaveSuggestedAppointmentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "SuggestedAppointmentId": 366,
  "Name": "Stokes-Ernser",
  "Tooltip": "ut",
  "Rank": 33,
  "Deleted": false,
  "DaysFuture": 636,
  "Duration": "enim",
  "AutoSuggest": false,
  "IsMilestone": true,
  "AssignToMember": false,
  "Text": "ut",
  "ProjectTypeStatusLink": {
    "ProjectTypeStatusLinkId": 261,
    "ProjTypeId": 934,
    "ProjTypeName": "Robel Inc and Sons",
    "ProjTypeTooltip": "illum",
    "ProjStatusId": 518,
    "ProjStatusName": "Boehm, Kohler and Kuhn",
    "ProjStatusTooltip": "facilis"
  },
  "SaleTypeStageLink": {
    "SaleTypeStageLinkId": 551,
    "SaleTypeId": 767,
    "SaleTypeName": "Terry, Parisian and Ryan",
    "SaleTypeTooltip": "consequatur",
    "ProbId": 522,
    "ProbName": "Wunsch, Block and Hahn",
    "ProbTooltip": "similique",
    "Probability": 477
  },
  "Type": {
    "Id": 503,
    "Value": "impedit",
    "Tooltip": "sunt"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SuggestedAppointmentId": 406,
  "Name": "Cartwright-Jakubowski",
  "Tooltip": "culpa",
  "Rank": 963,
  "Deleted": true,
  "DaysFuture": 317,
  "Duration": "aspernatur",
  "AutoSuggest": true,
  "IsMilestone": false,
  "AssignToMember": false,
  "Text": "eos",
  "ProjectTypeStatusLink": {
    "ProjectTypeStatusLinkId": 561,
    "ProjTypeId": 967,
    "ProjTypeName": "Hermann, Lang and O'Reilly",
    "ProjTypeTooltip": "voluptas",
    "ProjStatusId": 527,
    "ProjStatusName": "Robel, Windler and Veum",
    "ProjStatusTooltip": "deserunt",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 219
      }
    }
  },
  "SaleTypeStageLink": {
    "SaleTypeStageLinkId": 815,
    "SaleTypeId": 959,
    "SaleTypeName": "Olson, Gaylord and Kautzer",
    "SaleTypeTooltip": "totam",
    "ProbId": 913,
    "ProbName": "Crooks LLC",
    "ProbTooltip": "consectetur",
    "Probability": 150,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 833
      }
    }
  },
  "Type": {
    "Id": 570,
    "Value": "eum",
    "Tooltip": "aut",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 321
      }
    }
  },
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
      "FieldLength": 571
    }
  }
}
```