---
title: POST Agents/Appointment/ValidateDays
uid: v1AppointmentAgent_ValidateDays
generated: true
---

# POST Agents/Appointment/ValidateDays

```http
POST /api/v1/Agents/Appointment/ValidateDays
```

Validates the set of dates to calculate any conflicts.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/ValidateDays?$select=name,department,category/id
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

AppointmentEntity, Dates 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AppointmentEntity | AppointmentEntity | Partial AppointmentEntity class associating the generated AppointmentEntity with an interface. |
| Dates | Array |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Date | date-time | Date of the recurrence. |
| IsConflict | bool | Is there a conflict for this occurrence. |
| Description | string | Conflict or day (e.g. red, blue, etc. letter-day) name. |
| DescriptionStyleHint | string | Style hint for the description (i.e. red for red-letter-days) |
| Tooltip | string | Description of conflict or other things happening this day. |

## Sample request

```http!
POST /api/v1/Agents/Appointment/ValidateDays
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "AppointmentEntity": null,
  "Dates": [
    "vel",
    "iusto"
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Date": "1998-08-09T13:38:12.9521841+02:00",
    "IsConflict": false,
    "Description": "Pre-emptive background process improvement",
    "DescriptionStyleHint": "Visionary foreground array",
    "Tooltip": "sed"
  },
  {
    "Date": "1998-08-09T13:38:12.9521841+02:00",
    "IsConflict": false,
    "Description": "Pre-emptive background process improvement",
    "DescriptionStyleHint": "Visionary foreground array",
    "Tooltip": "sed"
  }
]
```