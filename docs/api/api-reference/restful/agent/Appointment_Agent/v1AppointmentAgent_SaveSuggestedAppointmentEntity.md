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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "SuggestedAppointmentId": 83,
  "Name": "Gleason, Rosenbaum and O'Keefe",
  "Tooltip": "libero",
  "Rank": 605,
  "Deleted": false,
  "DaysFuture": 818,
  "Duration": "sint",
  "AutoSuggest": true,
  "IsMilestone": false,
  "AssignToMember": false,
  "Text": "voluptatibus",
  "ProjectTypeStatusLink": {
    "ProjectTypeStatusLinkId": 287,
    "ProjTypeId": 472,
    "ProjTypeName": "Becker, Dickinson and Braun",
    "ProjTypeTooltip": "tenetur",
    "ProjStatusId": 109,
    "ProjStatusName": "Windler LLC",
    "ProjStatusTooltip": "quia"
  },
  "SaleTypeStageLink": {
    "SaleTypeStageLinkId": 185,
    "SaleTypeId": 6,
    "SaleTypeName": "Klocko LLC",
    "SaleTypeTooltip": "sed",
    "ProbId": 153,
    "ProbName": "Hegmann, Bergnaum and Legros",
    "ProbTooltip": "dignissimos",
    "Probability": 960
  },
  "Type": {
    "Id": 121,
    "Value": "expedita",
    "Tooltip": "animi"
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SuggestedAppointmentId": 359,
  "Name": "Romaguera, Breitenberg and Shanahan",
  "Tooltip": "natus",
  "Rank": 385,
  "Deleted": false,
  "DaysFuture": 659,
  "Duration": "ipsa",
  "AutoSuggest": true,
  "IsMilestone": true,
  "AssignToMember": false,
  "Text": "quae",
  "ProjectTypeStatusLink": {
    "ProjectTypeStatusLinkId": 274,
    "ProjTypeId": 295,
    "ProjTypeName": "Gerlach, Kassulke and Greenholt",
    "ProjTypeTooltip": "non",
    "ProjStatusId": 344,
    "ProjStatusName": "Dickinson, McKenzie and Bayer",
    "ProjStatusTooltip": "dolore",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 119
      }
    }
  },
  "SaleTypeStageLink": {
    "SaleTypeStageLinkId": 693,
    "SaleTypeId": 835,
    "SaleTypeName": "Cartwright-Anderson",
    "SaleTypeTooltip": "exercitationem",
    "ProbId": 448,
    "ProbName": "Bradtke, Boyle and O'Keefe",
    "ProbTooltip": "aliquam",
    "Probability": 514,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "reinvent world-class functionalities"
        },
        "FieldType": "System.String",
        "FieldLength": 658
      }
    }
  },
  "Type": {
    "Id": 179,
    "Value": "non",
    "Tooltip": "autem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 970
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
      "FieldType": "System.Int32",
      "FieldLength": 796
    }
  }
}
```