```http!
POST /api/v1/Agents/Quote/GenerateQuoteDocuments
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 414,
  "EmailBodyTemplateId": 807,
  "AttachMainDocument": true,
  "QuotedProductsTemplateId": 874,
  "IncludeAttachments": false,
  "RawMailSubject": "aut"
}
```