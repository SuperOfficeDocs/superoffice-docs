---
title: POST Agents/Appointment/SaveWithCustomInvitation
uid: v1AppointmentAgent_SaveWithCustomInvitation
generated: true
---

# POST Agents/Appointment/SaveWithCustomInvitation

```http
POST /api/v1/Agents/Appointment/SaveWithCustomInvitation
```

Save a booking and send a custom invitation email to participants







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/SaveWithCustomInvitation?$select=name,department,category/id
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

AppointmentEntity, UpdateMode, SendEmailToParticipants, SmtpEMailConnectionInfo, ImapEMailConnectionInfo, EmailBody, Subject, TemplateLanguage 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AppointmentEntity | AppointmentEntity | Partial AppointmentEntity class associating the generated AppointmentEntity with an interface. |
| UpdateMode | String |  |
| SendEmailToParticipants | Boolean |  |
| SmtpEMailConnectionInfo | EMailConnectionInfo | All information needed to connect to a mailserver <para /> Carrier object for EMailConnectionInfo. Services for the EMailConnectionInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |
| ImapEMailConnectionInfo | EMailConnectionInfo | All information needed to connect to a mailserver <para /> Carrier object for EMailConnectionInfo. Services for the EMailConnectionInfo Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IEMailAgent">EMail Agent</see>. |
| EmailBody | String |  |
| Subject | String |  |
| TemplateLanguage | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: AppointmentSaveData

| Property Name | Type |  Description |
|----------------|------|--------------|
| AppointmentEntity | AppointmentEntity | Updated AppointmentEntity |
| EmailCreated | bool | Flag for if an email was created for webtools, or if an email is queued on an smtp server |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Appointment/SaveWithCustomInvitation
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "AppointmentEntity": null,
  "UpdateMode": "OnlyThis",
  "SendEmailToParticipants": true,
  "SmtpEMailConnectionInfo": null,
  "ImapEMailConnectionInfo": null,
  "EmailBody": "joey@waters.name",
  "Subject": "consequatur",
  "TemplateLanguage": "quo"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "AppointmentEntity": null,
  "EmailCreated": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 44
    }
  }
}
```