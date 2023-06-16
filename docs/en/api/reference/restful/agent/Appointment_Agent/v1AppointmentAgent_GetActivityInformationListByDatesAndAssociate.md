---
title: POST Agents/Appointment/GetActivityInformationListByDatesAndAssociate
uid: v1AppointmentAgent_GetActivityInformationListByDatesAndAssociate
generated: true
---

# POST Agents/Appointment/GetActivityInformationListByDatesAndAssociate

```http
POST /api/v1/Agents/Appointment/GetActivityInformationListByDatesAndAssociate
```

Get activity information for one or more days according to the given date interval.


The time portion of the dates is ignored. Private appointments are counted, but may not be visible through tooltips or other more detailed services.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/GetActivityInformationListByDatesAndAssociate?$select=name,department,category/id
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
| Date | date-time | Date that this item is valid for; there is exactly one item per date, ordered by date. |
| ActivityInformation | ActivitySummary | Activity information summary - number of free and busy activities. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Appointment/GetActivityInformationListByDatesAndAssociate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "StartDate": "1997-08-06T16:00:39.6644704+02:00",
  "EndDate": "2023-01-20T16:00:39.6644704+01:00",
  "AssociateId": 993
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Date": "2005-02-23T16:00:39.6644704+01:00",
    "ActivityInformation": null,
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 507
      }
    }
  },
  {
    "Date": "2005-02-23T16:00:39.6644704+01:00",
    "ActivityInformation": null,
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 507
      }
    }
  }
]
```