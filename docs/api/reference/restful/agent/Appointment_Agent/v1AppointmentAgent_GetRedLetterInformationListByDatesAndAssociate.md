---
title: POST Agents/Appointment/GetRedLetterInformationListByDatesAndAssociate
id: v1AppointmentAgent_GetRedLetterInformationListByDatesAndAssociate
---

# POST Agents/Appointment/GetRedLetterInformationListByDatesAndAssociate

```http
POST /api/v1/Agents/Appointment/GetRedLetterInformationListByDatesAndAssociate
```

Get detailed red letter day information (redletter summary + individual day texts) for one or more days according to the given date interval.

The time portion of the dates is ignored.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/GetRedLetterInformationListByDatesAndAssociate?$select=name,department,category/id
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
| Date | date-time | Date that this item is valid for; there is exactly one item per date, ordered by date. |
| RedLetterInformation |  | Summary of redletter day information - holiday in own country, and in other countries known to the system. |
| RedLetterDetails |  | Red letter day text details, all the texts related to the given day. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Appointment/GetRedLetterInformationListByDatesAndAssociate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "StartDate": "2011-02-18T18:28:47.7528443+01:00",
  "EndDate": "1999-05-22T18:28:47.7528443+02:00",
  "AssociateId": 600
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Date": "1999-12-31T18:28:47.7528443+01:00",
    "RedLetterInformation": {
      "IsOwnCountryHoliday": true,
      "IsOtherCountryHoliday": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "syndicate end-to-end supply-chains"
          },
          "FieldType": "System.String",
          "FieldLength": 959
        }
      }
    },
    "RedLetterDetails": {
      "OwnCountryDayTexts": [
        "Sokovia",
        "Sokovia"
      ],
      "OtherCountryDayTexts": [
        "Sokovia",
        "Sokovia"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 215
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
        "FieldLength": 796
      }
    }
  },
  {
    "Date": "1999-12-31T18:28:47.7528443+01:00",
    "RedLetterInformation": {
      "IsOwnCountryHoliday": true,
      "IsOtherCountryHoliday": true,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "syndicate end-to-end supply-chains"
          },
          "FieldType": "System.String",
          "FieldLength": 959
        }
      }
    },
    "RedLetterDetails": {
      "OwnCountryDayTexts": [
        "Sokovia",
        "Sokovia"
      ],
      "OtherCountryDayTexts": [
        "Sokovia",
        "Sokovia"
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 215
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
        "FieldLength": 796
      }
    }
  }
]
```