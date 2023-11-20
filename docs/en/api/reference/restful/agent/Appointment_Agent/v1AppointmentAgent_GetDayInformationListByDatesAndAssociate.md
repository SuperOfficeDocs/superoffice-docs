---
title: POST Agents/Appointment/GetDayInformationListByDatesAndAssociate
uid: v1AppointmentAgent_GetDayInformationListByDatesAndAssociate
generated: true
---

# POST Agents/Appointment/GetDayInformationListByDatesAndAssociate

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
| StartDate | String |  |
| EndDate | String |  |
| AssociateId | Integer |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| ActivityInformation | ActivitySummary | Activity information summary - number of free and busy activities. |
| RedLetterInformation | RedLetterSummary | Summary of redletter day information - holiday in own country, and in other countries known to the system. |
| Date | date-time | Date that this item is valid for; there is exactly one item per date, ordered by date. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Appointment/GetDayInformationListByDatesAndAssociate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "StartDate": "2010-01-14T13:38:12.8740699+01:00",
  "EndDate": "2018-06-03T13:38:12.8740699+02:00",
  "AssociateId": 757
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "ActivityInformation": null,
    "RedLetterInformation": null,
    "Date": "1999-12-15T13:38:12.8740699+01:00",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 325
      }
    }
  },
  {
    "ActivityInformation": null,
    "RedLetterInformation": null,
    "Date": "1999-12-15T13:38:12.8740699+01:00",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 325
      }
    }
  }
]
```