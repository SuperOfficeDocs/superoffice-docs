---
title: POST Agents/Quote/CreateQuoteAlternative
id: v1QuoteAgent_CreateQuoteAlternative
---

# POST Agents/Quote/CreateQuoteAlternative

```http
POST /api/v1/Agents/Quote/CreateQuoteAlternative
```

Create a new quote alternative on a version.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/CreateQuoteAlternative?$select=name,department,category/id
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

QuoteVersionId, QuoteAlternativeName, QuoteAlternativeDescription 

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteVersionId | int32 |  |
| QuoteAlternativeName | string |  |
| QuoteAlternativeDescription | string |  |


## Response: object

Information about a connection to the ERP system.



Carrier object for QuoteAlternative.
Services for the QuoteAlternative Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IQuoteAgent">Quote Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteAlternativeId | int32 | Primary key |
| ERPQuoteAlternativeKey | string | Key that identifies this alternative in the ERP system, if it exists there. |
| QuoteVersionId | int32 | The version that owns this alternative (the chain is Sale 1-&gt;1 Quote 1-&gt;+ QuoteVersion 1-&gt;+ QuoteAlternative. |
| Name | string | Name of Alternative. Shown in tab in user interface, intentionally kept short |
| Description | string | The tool-tip to use in the user interface (on the tab, for instance). |
| Status | string | If there was a problem with for instance calculation, this field is set to warning or error. |
| Reason | string | If there was a problem, this field contains a localized explanation of the problem and possible steps to fix it that the user can be shown. |
| ERPDiscountPercent | double | The discount the system calculates based on customer /amount / whatever. Can be overridden by the sales rep in the field ‘DiscountPercent’ or ‘DiscountAmount’. Both the two ‘ERPDiscountPercent’ and ‘ERPDiscountAmount’ shall be filled out. If UserValueOverride is 'None', then the ERPDiscountAmount shall be copied into DiscountAmount and ERPDiscountPercent into DiscountPercent. The Percentage is given in integer form, i.e. ‘12%’ is represented as ‘12’. |
| ERPDiscountAmount | double | The discount the system calculates based on customer /amount / whatever. Can be overridden by the user in the field ‘DiscountPercent’ or ‘DiscountAmount’. Both the two ‘ERPDiscountPercent’ and ‘ERPDiscountAmount’ shall be filled out. If UserValueOverride is 'None', then the ERPDiscountAmount shall be copied into DiscountAmount and ERPDiscountPercent into DiscountPercent. |
| DiscountPercent | double | The discount the sales rep specifies, in percent. Both the two ‘DiscountPercent’ and ‘DiscountAmount’ shall be filled out, but the UserValueOverride field must be set to the field the user actually changed. If this field is filled out by the user, it overrides the discount suggested by the connector. If the user has not filled any values, the system will copy the ERP discount percent value into this field. The Percentage is given in integer form, i.e. ‘12%’ is represented as ‘12’. |
| DiscountAmount | double | The discount the sales rep specifies, in whatever currency the sale is in. Both the two ‘DiscountPercent’ and ‘DiscountAmount’ shall be filled out, but the UserValueOverride field must be set to the field the user actually changed. If this field is filled out by the user, it overrides the discount suggested by the connector. If the user has not filled any values, the system will copy the ERP discount amount value into this field. |
| UserValueOverride | string | Has the pre-calculated (from ERP) price information been overridden, and how. If the user has filled out the discountpercentage field, then the UserValueOverride field is set to OverridePercent. (The DiscountAmount, EarningPercent, EarningAmount and TotalPrice fields are calculated based on the discountPercent.) |
| VATInfo | string | Extra info about VAT that the connector might insert. This field has no business logic in the CRM code, but is available as a merge field in the quote documents. |
| VAT | double | Tax/VAT - THIS IS AN AMOUNT, available as a merge field in the quote document. The SuperOffice quote connector will calculate this field based on the vat PERCENTAGES on the individual lines; other connectors may implement other algorithms at will. |
| EarningPercent | double | The earning on this alternative, in percent of total. The Percentage is given in integer form, i.e. ‘12%’ is represented as ‘12’. |
| EarningAmount | double | Earning on this alternative, as an absolute amount |
| SubTotal | double | Value to help the user interface, is computed by summing the totalprice of the quotelines, and NOT by summing their subtotals |
| TotalPrice | double | Sum of the QuoteLines.TotalPrice - AlternativeDiscount or QuoteLines.TotalCost + Earning based on what, if anything, the user has entered last. Shall be calculated by the connector. |
| ExtraField1 | string | Optional information added by Quote Connector; usable in the quote document merge process |
| ExtraField2 | string | Optional information added by Quote Connector; usable in the quote document merge process |
| ExtraField3 | string | Optional information added by Quote Connector; usable in the quote document merge process |
| ExtraField4 | string | Optional information added by Quote Connector; usable in the quote document merge process |
| ExtraField5 | string | Optional information added by Quote Connector; usable in the quote document merge process |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Quote/CreateQuoteAlternative
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 449,
  "QuoteAlternativeName": "Shanahan, Dooley and Russel",
  "QuoteAlternativeDescription": "Progressive coherent structure"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "QuoteAlternativeId": 890,
  "ERPQuoteAlternativeKey": "esse",
  "QuoteVersionId": 886,
  "Name": "Harber LLC",
  "Description": "Diverse bifurcated support",
  "Status": "Error",
  "Reason": "",
  "ERPDiscountPercent": 23699.308,
  "ERPDiscountAmount": 28754.45,
  "DiscountPercent": 23313.826,
  "DiscountAmount": 9674.658,
  "UserValueOverride": "DiscountAmount",
  "VATInfo": "velit",
  "VAT": 29205.746,
  "EarningPercent": 11385.822,
  "EarningAmount": 25056.329999999998,
  "SubTotal": 1178.384,
  "TotalPrice": 12724.039999999999,
  "ExtraField1": "vero",
  "ExtraField2": "illo",
  "ExtraField3": "in",
  "ExtraField4": "rerum",
  "ExtraField5": "omnis",
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
      "FieldLength": 527
    }
  }
}
```