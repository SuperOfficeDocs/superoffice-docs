---
title: POST Agents/Marketing/SaveFormSubmissionEntity
uid: v1MarketingAgent_SaveFormSubmissionEntity
---

# POST Agents/Marketing/SaveFormSubmissionEntity

```http
POST /api/v1/Agents/Marketing/SaveFormSubmissionEntity
```

Updates the existing FormSubmissionEntity or creates a new FormSubmissionEntity if the id parameter is empty








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

## Request Body: entity  

The FormSubmissionEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| FormSubmissionId | int32 | Primary key |
| FormId | int32 | The id of the parent form. |
| WhenSubmitted | date-time | The time of the submit. |
| ContactId | int32 | The optional id of the contact of the person who submitted. |
| PersonId | int32 | The optional id of the person who submitted. |
| EmailAddress | string | The email address of the person who submitted |
| ResponseShipmentAddrId | int32 | The id of the s_shipment_addr that is the response mail |
| Response | string | The JSON-formatted response from this form |
| Status | string | What is the status of this submission |
| ProcessingLog | string | A log of what happened during processing |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

| Property Name | Type |  Description |
|----------------|------|--------------|
| FormSubmissionId | int32 | Primary key |
| FormId | int32 | The id of the parent form. |
| WhenSubmitted | date-time | The time of the submit. |
| ContactId | int32 | The optional id of the contact of the person who submitted. |
| PersonId | int32 | The optional id of the person who submitted. |
| EmailAddress | string | The email address of the person who submitted |
| ResponseShipmentAddrId | int32 | The id of the s_shipment_addr that is the response mail |
| Response | string | The JSON-formatted response from this form |
| Status | string | What is the status of this submission |
| ProcessingLog | string | A log of what happened during processing |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Marketing/SaveFormSubmissionEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "FormSubmissionId": 635,
  "FormId": 917,
  "WhenSubmitted": "1998-06-21T02:49:44.7172985+02:00",
  "ContactId": 574,
  "PersonId": 730,
  "EmailAddress": "elissa@willms.name",
  "ResponseShipmentAddrId": 602,
  "Response": "modi",
  "Status": "EmailVerification",
  "ProcessingLog": "qui"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "FormSubmissionId": 20,
  "FormId": 310,
  "WhenSubmitted": "2009-04-15T02:49:44.7172985+02:00",
  "ContactId": 61,
  "PersonId": 336,
  "EmailAddress": "tristin@okeefe.biz",
  "ResponseShipmentAddrId": 709,
  "Response": "aliquid",
  "Status": "EmailVerification",
  "ProcessingLog": "delectus",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 155
    }
  }
}
```