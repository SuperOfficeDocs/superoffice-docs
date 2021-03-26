---
title: POST Agents/Appointment/UpdateAppointmentFromIcsResponse
id: v1AppointmentAgent_UpdateAppointmentFromIcsResponse
---

# POST Agents/Appointment/UpdateAppointmentFromIcsResponse

```http
POST /api/v1/Agents/Appointment/UpdateAppointmentFromIcsResponse
```

Update the attendance to an appointment based on incoming ICS RSVPs.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/UpdateAppointmentFromIcsResponse?$select=name,department,category/id
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

EmailAddress, IcsData 

| Property Name | Type |  Description |
|----------------|------|--------------|
| EmailAddress | string |  |
| IcsData | byte |  |


## Response: bool



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: bool


## Sample Request

```http!
POST /api/v1/Agents/Appointment/UpdateAppointmentFromIcsResponse
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "EmailAddress": "jade.padberg@hammespadberg.ca",
  "IcsData": "GIF89....File contents as raw bytes..."
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

true
```