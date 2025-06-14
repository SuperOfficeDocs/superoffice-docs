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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Associates": [
    595,
    969
  ],
  "StartTime": "1998-11-01T17:54:02.3983677+01:00",
  "EndTime": "1999-12-04T17:54:02.3983677+01:00",
  "Count": 590,
  "IsAllDay": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "AvailableTimeStart": "2012-12-23T17:54:02.3983677+01:00",
    "AvailableTimeEnd": "2000-06-26T17:54:02.3983677+02:00",
    "RecommendedTimeStart": "2013-09-11T17:54:02.3983677+02:00",
    "RecommendedTimeEnd": "2017-10-14T17:54:02.3983677+02:00",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 144
      }
    }
  },
  {
    "AvailableTimeStart": "2012-12-23T17:54:02.3983677+01:00",
    "AvailableTimeEnd": "2000-06-26T17:54:02.3983677+02:00",
    "RecommendedTimeStart": "2013-09-11T17:54:02.3983677+02:00",
    "RecommendedTimeEnd": "2017-10-14T17:54:02.3983677+02:00",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 144
      }
    }
  }
]
```