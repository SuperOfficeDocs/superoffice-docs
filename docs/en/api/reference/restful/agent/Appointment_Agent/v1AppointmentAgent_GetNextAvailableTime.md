---
title: POST Agents/Appointment/GetNextAvailableTime
uid: v1AppointmentAgent_GetNextAvailableTime
generated: true
---

# POST Agents/Appointment/GetNextAvailableTime

```http
POST /api/v1/Agents/Appointment/GetNextAvailableTime
```

An array of the soonest-available working time slots.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/GetNextAvailableTime?$select=name,department,category/id
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

Associates, StartTime, EndTime, Count, IsAllDay 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Associates | Array |  |
| StartTime | String |  |
| EndTime | String |  |
| Count | Integer |  |
| IsAllDay | Boolean |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| AvailableTimeStart | date-time | The available start date time. |
| AvailableTimeEnd | date-time | The available end date time. |
| RecommendedTimeStart | date-time | The recommended start date time. |
| RecommendedTimeEnd | date-time | The recomended end date time. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Appointment/GetNextAvailableTime
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Associates": [
    130,
    442
  ],
  "StartTime": "2004-07-14T13:57:11.2157245+02:00",
  "EndTime": "2014-04-29T13:57:11.2157245+02:00",
  "Count": 609,
  "IsAllDay": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AvailableTimeStart": "2022-11-22T13:57:11.2157245+01:00",
    "AvailableTimeEnd": "2015-05-25T13:57:11.2157245+02:00",
    "RecommendedTimeStart": "1997-12-05T13:57:11.2157245+01:00",
    "RecommendedTimeEnd": "1999-02-12T13:57:11.2157245+01:00",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 560
      }
    }
  },
  {
    "AvailableTimeStart": "2022-11-22T13:57:11.2157245+01:00",
    "AvailableTimeEnd": "2015-05-25T13:57:11.2157245+02:00",
    "RecommendedTimeStart": "1997-12-05T13:57:11.2157245+01:00",
    "RecommendedTimeEnd": "1999-02-12T13:57:11.2157245+01:00",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 560
      }
    }
  }
]
```