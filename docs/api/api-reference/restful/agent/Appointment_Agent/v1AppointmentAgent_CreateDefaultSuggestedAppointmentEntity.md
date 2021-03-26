---
title: POST Agents/Appointment/CreateDefaultSuggestedAppointmentEntity
id: v1AppointmentAgent_CreateDefaultSuggestedAppointmentEntity
---

# POST Agents/Appointment/CreateDefaultSuggestedAppointmentEntity

```http
POST /api/v1/Agents/Appointment/CreateDefaultSuggestedAppointmentEntity
```

Set default values into a new SuggestedAppointmentEntity.

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
POST /api/v1/Agents/Appointment/CreateDefaultSuggestedAppointmentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SuggestedAppointmentId": 78,
  "Name": "Gusikowski, Murphy and Collins",
  "Tooltip": "reiciendis",
  "Rank": 181,
  "Deleted": true,
  "DaysFuture": 951,
  "Duration": "maxime",
  "AutoSuggest": false,
  "IsMilestone": true,
  "AssignToMember": false,
  "Text": "voluptates",
  "ProjectTypeStatusLink": {
    "ProjectTypeStatusLinkId": 480,
    "ProjTypeId": 918,
    "ProjTypeName": "Dicki-Gleichner",
    "ProjTypeTooltip": "quis",
    "ProjStatusId": 965,
    "ProjStatusName": "Gleason, Yost and Prosacco",
    "ProjStatusTooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 93
      }
    }
  },
  "SaleTypeStageLink": {
    "SaleTypeStageLinkId": 295,
    "SaleTypeId": 951,
    "SaleTypeName": "Huels, Ebert and Huel",
    "SaleTypeTooltip": "laborum",
    "ProbId": 830,
    "ProbName": "Herzog-Gaylord",
    "ProbTooltip": "odio",
    "Probability": 189,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 239
      }
    }
  },
  "Type": {
    "Id": 963,
    "Value": "qui",
    "Tooltip": "libero",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "recontextualize web-enabled convergence"
        },
        "FieldType": "System.String",
        "FieldLength": 658
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
      "FieldLength": 190
    }
  }
}
```