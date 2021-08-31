---
title: SaveSuggestedAppointmentEntity
id: v1AppointmentAgent_SaveSuggestedAppointmentEntity
---

# SaveSuggestedAppointmentEntity

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "SuggestedAppointmentId": 632,
  "Name": "Cronin-Williamson",
  "Tooltip": "ab",
  "Rank": 11,
  "Deleted": true,
  "DaysFuture": 402,
  "Duration": "ea",
  "AutoSuggest": true,
  "IsMilestone": true,
  "AssignToMember": true,
  "Text": "quo",
  "ProjectTypeStatusLink": {
    "ProjectTypeStatusLinkId": 887,
    "ProjTypeId": 855,
    "ProjTypeName": "Boehm LLC",
    "ProjTypeTooltip": "officiis",
    "ProjStatusId": 684,
    "ProjStatusName": "Harris-Yost",
    "ProjStatusTooltip": "sequi"
  },
  "SaleTypeStageLink": {
    "SaleTypeStageLinkId": 205,
    "SaleTypeId": 659,
    "SaleTypeName": "Feest, Lueilwitz and Legros",
    "SaleTypeTooltip": "iusto",
    "ProbId": 904,
    "ProbName": "Gislason, Hagenes and Bernhard",
    "ProbTooltip": "nisi",
    "Probability": 657
  },
  "Type": {
    "Id": 519,
    "Value": "aut",
    "Tooltip": "vel"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SuggestedAppointmentId": 917,
  "Name": "Goldner-Ortiz",
  "Tooltip": "ratione",
  "Rank": 53,
  "Deleted": false,
  "DaysFuture": 447,
  "Duration": "ducimus",
  "AutoSuggest": false,
  "IsMilestone": true,
  "AssignToMember": false,
  "Text": "laudantium",
  "ProjectTypeStatusLink": {
    "ProjectTypeStatusLinkId": 66,
    "ProjTypeId": 835,
    "ProjTypeName": "Macejkovic-Towne",
    "ProjTypeTooltip": "iure",
    "ProjStatusId": 333,
    "ProjStatusName": "Pollich-Schuppe",
    "ProjStatusTooltip": "quia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 20
      }
    }
  },
  "SaleTypeStageLink": {
    "SaleTypeStageLinkId": 235,
    "SaleTypeId": 898,
    "SaleTypeName": "Schiller, Greenfelder and Mraz",
    "SaleTypeTooltip": "enim",
    "ProbId": 507,
    "ProbName": "Altenwerth, Fahey and Toy",
    "ProbTooltip": "earum",
    "Probability": 791,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 349
      }
    }
  },
  "Type": {
    "Id": 621,
    "Value": "maiores",
    "Tooltip": "earum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 575
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
      "FieldLength": 800
    }
  }
}
```