---
title: POST Agents/Appointment/AcceptWithSmtpEmailConfirmation
uid: v1AppointmentAgent_AcceptWithSmtpEmailConfirmation
generated: true
---

# POST Agents/Appointment/AcceptWithSmtpEmailConfirmation

```http
POST /api/v1/Agents/Appointment/AcceptWithSmtpEmailConfirmation
```

Accepting an appointment invitation and send an email confirmation to the meeting organizer.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/AcceptWithSmtpEmailConfirmation?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in:  |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

AppointmentId, UpdateMode, SmtpEMailConnectionInfo 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AppointmentId | Integer |  |
| UpdateMode | String |  |
| SmtpEMailConnectionInfo | EMailConnectionInfo | All information needed to connect to a mailserver <para /> Carrier object for EMailConnectionInfo. Services for the EMailConnectionInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |

## Response:

No Content

| Response | Description |
|----------------|-------------|
| 204 | No Content |

### Response body: TimeZoneData


## Sample request

```http!
POST /api/v1/Agents/Appointment/AcceptWithSmtpEmailConfirmation
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "AppointmentId": 270,
  "UpdateMode": "OnlyThis",
  "SmtpEMailConnectionInfo": null
}
```

## Sample response

```http_
HTTP/1.1 204 No Content
Content-Type: application/json; charset=utf-8

null
```