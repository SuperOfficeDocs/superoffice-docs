---
title: POST Agents/Quote/GenerateQuoteDocuments
uid: v1QuoteAgent_GenerateQuoteDocuments
generated: true
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
| QuoteVersionId | Integer |  |
| EmailBodyTemplateId | Integer |  |
| AttachMainDocument | Boolean |  |
| QuotedProductsTemplateId | Integer |  |
| IncludeAttachments | Boolean |  |
| RawMailSubject | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: QuotePublishDocuments

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Quote/GenerateQuoteDocuments
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 352,
  "EmailBodyTemplateId": 603,
  "AttachMainDocument": false,
  "QuotedProductsTemplateId": 616,
  "IncludeAttachments": false,
  "RawMailSubject": "consequatur"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteDocumentId": 964,
  "QuotedProductsId": 914,
  "QuoteAttachmentIds": [
    312,
    131
  ],
  "MailBody": "laboriosam",
  "MailSubject": "doloremque",
  "ToEmail": "kris_kunde@lehner.co.uk",
  "ToFullName": "Tony Gusikowski",
  "ErrorMessage": "voluptatum",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 258
    }
  }
}
```