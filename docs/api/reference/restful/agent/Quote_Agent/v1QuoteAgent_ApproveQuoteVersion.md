---
title: POST Agents/Quote/ApproveQuoteVersion
id: v1QuoteAgent_ApproveQuoteVersion
---

# POST Agents/Quote/ApproveQuoteVersion

```http
POST /api/v1/Agents/Quote/ApproveQuoteVersion
```

Approves a quote version







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/ApproveQuoteVersion?$select=name,department,category/id
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

QuoteVersionId, ApprovedByText, ApprovedByAssociateId, ApprovalText 

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteVersionId | int32 |  |
| ApprovedByText | string |  |
| ApprovedByAssociateId | int32 |  |
| ApprovalText | string |  |


## Response: object

ApproveRejectResponse contains a PluginResponse and an appointmentId if the operation created one.



Carrier object for ApproveRejectResponse.
Services for the ApproveRejectResponse Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IQuoteAgent">Quote Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| PluginResponse |  | The response from the operation. |
| CreatedAppointmentId | int32 | Id of the created follow up. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Quote/ApproveQuoteVersion
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 393,
  "ApprovedByText": "doloremque",
  "ApprovedByAssociateId": 460,
  "ApprovalText": "rerum"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PluginResponse": {
    "IsOk": false,
    "UserExplanation": "ut",
    "TechExplanation": "sed",
    "ErrorCode": "est",
    "Changes": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 77
      }
    }
  },
  "CreatedAppointmentId": 85,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 167
    }
  }
}
```