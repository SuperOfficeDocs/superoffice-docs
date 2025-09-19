---
title: POST Agents/Appointment/GetVideoMeetingConnectedState
uid: v1AppointmentAgent_GetVideoMeetingConnectedState
generated: true
content_type: reference
---

# POST Agents/Appointment/GetVideoMeetingConnectedState

```http
POST /api/v1/Agents/Appointment/GetVideoMeetingConnectedState
```

Get the current users connected state.


This indicates if a user is configured to use VideoMeetings.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/GetVideoMeetingConnectedState?$select=name,department,category/id
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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: UserConnectedState

| Property Name | Type |  Description |
|----------------|------|--------------|
| IsConnected | bool | If true, the user is configured for VideoMeetings |
| ProviderId | string | Information about the provider configured on the tenant |
| LoginUrl | string | The URL to create a new Authorization record in the VideoMeetings provider |

## Sample request

```http!
POST /api/v1/Agents/Appointment/GetVideoMeetingConnectedState
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "IsConnected": false,
  "ProviderId": "est",
  "LoginUrl": "http://www.example.com/"
}
```