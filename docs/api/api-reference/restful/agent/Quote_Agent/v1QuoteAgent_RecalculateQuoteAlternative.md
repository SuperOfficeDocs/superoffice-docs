---
title: POST Agents/Quote/RecalculateQuoteAlternative
id: v1QuoteAgent_RecalculateQuoteAlternative
---

# POST Agents/Quote/RecalculateQuoteAlternative

```http
POST /api/v1/Agents/Quote/RecalculateQuoteAlternative
```

When the user changes one or more values in a quoteline or a quoteAlternative, the connector gets to change the QuoteLines and the alternative, for instance calculate VAT.

RecalculateQuoteAlternative shall be called when the user changes any of the following fields: Quantity, DiscountAmount, DiscountPercent, listprice (if allowed). RecalculateQuoteAlternative will calculate the TotalPrice and the VAT (if possible) for the lines and the alternative.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/RecalculateQuoteAlternative?$select=name,department,category/id
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

QuoteAlternative 

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteAlternative | int32 |  |


## Response: object

The QuoteAlternativeRecalculated is returned after a call to RecalculateQuoteAlternative. It contains flags indicating changes to quote alternative and quote lines.



Carrier object for QuoteAlternativeRecalculated.
Services for the QuoteAlternativeRecalculated Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IQuoteAgent">Quote Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteLinesHasChanged | bool | If true any of the quotelines for the alternative has been changed. |
| ChangedQuoteAlternative |  | The recalculated QuoteAlternative |
| Changes |  | Tablename/recordid of data changed by this method |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Quote/RecalculateQuoteAlternative
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "QuoteAlternative": 834
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteLinesHasChanged": true,
  "ChangedQuoteAlternative": {
    "QuoteAlternativeId": 950,
    "ERPQuoteAlternativeKey": "autem",
    "QuoteVersionId": 228,
    "Name": "Towne-Ryan",
    "Description": "Synergized radical strategy",
    "Status": "Error",
    "Reason": "",
    "ERPDiscountPercent": 11263.596,
    "ERPDiscountAmount": 7436.982,
    "DiscountPercent": 28184.061999999998,
    "DiscountAmount": 5490.768,
    "UserValueOverride": "DiscountAmount",
    "VATInfo": "magni",
    "VAT": 31170.764,
    "EarningPercent": 14936.644,
    "EarningAmount": 27331.613999999998,
    "SubTotal": 26996.275999999998,
    "TotalPrice": 28403.442,
    "ExtraField1": "voluptas",
    "ExtraField2": "iure",
    "ExtraField3": "corporis",
    "ExtraField4": "et",
    "ExtraField5": "sint",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 917
      }
    }
  },
  "Changes": {
    "AddedRecords": [
      {},
      {}
    ],
    "UpdatedRecords": [
      {},
      {}
    ],
    "DeletedRecords": [
      {},
      {}
    ],
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 949
      }
    }
  },
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
      "FieldLength": 123
    }
  }
}
```