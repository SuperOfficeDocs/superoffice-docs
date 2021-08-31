---
title: GetDayInformationListByDatesAndAssociate
id: v1AppointmentAgent_GetDayInformationListByDatesAndAssociate
---

# GetDayInformationListByDatesAndAssociate

```http
POST /api/v1/Agents/Appointment/GetDayInformationListByDatesAndAssociate
```

Get combined day information (activity + redletter summary) for one or more days according to the given date interval.

The time portion of the dates is ignored. Private appointments are counted, but may not be visible through tooltips or other more detailed services.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/GetDayInformationListByDatesAndAssociate?$select=name,department,category/id
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

StartDate, EndDate, AssociateId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| StartDate | date-time |  |
| EndDate | date-time |  |
| AssociateId | int32 |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| ActivityInformation |  | Activity information summary - number of free and busy activities. |
| RedLetterInformation |  | Summary of redletter day information - holiday in own country, and in other countries known to the system. |
| Date | date-time | Date that this item is valid for; there is exactly one item per date, ordered by date. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Appointment/GetDayInformationListByDatesAndAssociate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "StartDate": "2017-11-18T14:58:02.8965683+01:00",
  "EndDate": "2021-01-31T14:58:02.8965683+01:00",
  "AssociateId": 311
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ActivityInformation": {
      "NumBusyActivities": 978,
      "NumFreeActivities": 967,
      "PercentageBusy": 916,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 268
        }
      }
    },
    "RedLetterInformation": {
      "IsOwnCountryHoliday": false,
      "IsOtherCountryHoliday": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "visualize end-to-end ROI"
          },
          "FieldType": "System.String",
          "FieldLength": 902
        }
      }
    },
    "Date": "2006-05-17T14:58:02.8975682+02:00",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "monetize cutting-edge e-commerce"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 699
      }
    }
  },
  {
    "ActivityInformation": {
      "NumBusyActivities": 978,
      "NumFreeActivities": 967,
      "PercentageBusy": 916,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 268
        }
      }
    },
    "RedLetterInformation": {
      "IsOwnCountryHoliday": false,
      "IsOtherCountryHoliday": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "visualize end-to-end ROI"
          },
          "FieldType": "System.String",
          "FieldLength": 902
        }
      }
    },
    "Date": "2006-05-17T14:58:02.8975682+02:00",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "monetize cutting-edge e-commerce"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 699
      }
    }
  }
]
```