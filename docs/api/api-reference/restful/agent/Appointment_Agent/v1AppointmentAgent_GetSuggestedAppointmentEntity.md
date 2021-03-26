---
title: POST Agents/Appointment/GetSuggestedAppointmentEntity
id: v1AppointmentAgent_GetSuggestedAppointmentEntity
---

# POST Agents/Appointment/GetSuggestedAppointmentEntity

```http
POST /api/v1/Agents/Appointment/GetSuggestedAppointmentEntity
```

Gets a SuggestedAppointmentEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| suggestedAppointmentEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/GetSuggestedAppointmentEntity?suggestedAppointmentEntityId=377
POST /api/v1/Agents/Appointment/GetSuggestedAppointmentEntity?$select=name,department,category/id
```


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
POST /api/v1/Agents/Appointment/GetSuggestedAppointmentEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "SuggestedAppointmentId": 870,
  "Name": "Fadel-Kunde",
  "Tooltip": "accusantium",
  "Rank": 382,
  "Deleted": false,
  "DaysFuture": 547,
  "Duration": "voluptatem",
  "AutoSuggest": true,
  "IsMilestone": true,
  "AssignToMember": false,
  "Text": "sit",
  "ProjectTypeStatusLink": {
    "ProjectTypeStatusLinkId": 710,
    "ProjTypeId": 732,
    "ProjTypeName": "Keeling Group",
    "ProjTypeTooltip": "et",
    "ProjStatusId": 213,
    "ProjStatusName": "Lindgren LLC",
    "ProjStatusTooltip": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 925
      }
    }
  },
  "SaleTypeStageLink": {
    "SaleTypeStageLinkId": 670,
    "SaleTypeId": 806,
    "SaleTypeName": "Kunde, Williamson and Rogahn",
    "SaleTypeTooltip": "et",
    "ProbId": 195,
    "ProbName": "Kilback-O'Kon",
    "ProbTooltip": "numquam",
    "Probability": 837,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 695
      }
    }
  },
  "Type": {
    "Id": 280,
    "Value": "natus",
    "Tooltip": "optio",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 397
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
      "FieldLength": 334
    }
  }
}
```