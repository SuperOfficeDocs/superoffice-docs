---
title: POST Agents/Quote/GenerateQuoteDocuments
id: v1QuoteAgent_GenerateQuoteDocuments
---

# POST Agents/Quote/GenerateQuoteDocuments

```http
POST /api/v1/Agents/Quote/GenerateQuoteDocuments
```

Generate all the documents required to send the Quote as an email to the prospect - or an Order Confirmation; it just depends on the template id's for the lines doc and mail body.

Quote version status is not changed by this method.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/GenerateQuoteDocuments?$select=name,department,category/id
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

QuoteVersionId, EmailBodyTemplateId, AttachMainDocument, QuotedProductsTemplateId, IncludeAttachments, RawMailSubject 

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteVersionId | int32 |  |
| EmailBodyTemplateId | int32 |  |
| AttachMainDocument | bool |  |
| QuotedProductsTemplateId | int32 |  |
| IncludeAttachments | bool |  |
| RawMailSubject | string |  |


## Response: object

Prepare the documents required to publish a quote - Email, main document as pdf, quoted products as pdf, attachments



Carrier object for QuotePublishDocuments.
Services for the QuotePublishDocuments Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IQuoteAgent">Quote Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteDocumentId | int32 | Quote document, as PDF; may be zero if there is no document specified for the version |
| QuotedProductsId | int32 | Quoted products (quote lines or confirmation lines) document, as PDF |
| QuoteAttachmentIds | array | Array of id's of any attachments (standard + custom for this version) |
| MailBody | string | The string that is the content of the mail body; this is the result of merging the mail body template with the current template variable values |
| MailSubject | string | The string that is the mail subject; done by merging the text resource SR_QUOTE_PUBLISH_MAILHEADING with the current template variable values |
| ToEmail | string | The email address of the recipient, taken from the sale's person |
| ToFullName | string | The full name of the recipient, taken from the sale's person |
| ErrorMessage | string | If something went wrong, show this message and do not continue |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Quote/GenerateQuoteDocuments
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 862,
  "EmailBodyTemplateId": 6,
  "AttachMainDocument": false,
  "QuotedProductsTemplateId": 868,
  "IncludeAttachments": true,
  "RawMailSubject": "fuga"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteDocumentId": 670,
  "QuotedProductsId": 858,
  "QuoteAttachmentIds": [
    469,
    458
  ],
  "MailBody": "sunt",
  "MailSubject": "officiis",
  "ToEmail": "keyon@harris.co.uk",
  "ToFullName": "Hilbert Turner",
  "ErrorMessage": "ut",
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
      "FieldType": "System.String",
      "FieldLength": 35
    }
  }
}
```