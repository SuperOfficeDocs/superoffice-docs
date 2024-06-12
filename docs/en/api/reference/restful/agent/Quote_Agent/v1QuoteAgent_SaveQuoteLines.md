---
title: POST Agents/Quote/SaveQuoteLines
uid: v1QuoteAgent_SaveQuoteLines
generated: true
---

# POST Agents/Quote/SaveQuoteLines

```http
POST /api/v1/Agents/Quote/SaveQuoteLines
```

Saves the QuoteLines in the SuperOffice database







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/SaveQuoteLines?$select=name,department,category/id
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

QuoteLines 

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteLines | Array |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteLineId | int32 | Primary key |
| ERPQuoteLineKey | string | The foreign key to the quoteline in ERP system (if it has such a representation). |
| QuoteAlternativeId | int32 | The alternative this line is part of, the conceptual Parent in CRM database. |
| ERPProductKey | string | Foreign key of product+pricelist this line is based on. Can be blank since the QuoteLine doesn’t have to be connected to a product. |
| Status | string | If there was a problem with for instance calculation, this field is set to warning or error. Typically shown as an icon. QuoteStatus is an enum with statuses: OK, OKWithInfo, Warning, Error. |
| Reason | string | If QuoteStatus is not OK, then this field contains a localized explanation that the user can be shown. |
| Quantity | double | How many units; this is a decimal field since you might want to offer fractional units (2.5kg, or 0.5PC). |
| DeliveredQuantity | double | How many units have been delivered - updated by ERP system. |
| Rank | int32 | QuoteLines can be re-ordered, so we must track the ordering. |
| Name | string | The name of the product. Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link. |
| Description | string | A longer description for the product. Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link. |
| Code | string | A value the salesmen use to quickly find the correct product. Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link. |
| QuantityUnit | string | What is the unit (meter, ton, bushel, microsecond, gradus, τρυβλίον, 五合枡, دونم or whatever); Connector handles conversion relative to PriceUnit if they are different. |
| PriceUnit | string | What is the unit (meter, ton, bushel, microsecond, gradus, τρυβλίον, 五合枡, دونم or whatever); read-only for lines that originate in defined products. |
| ItemNumber | string | Norwegian: «Postnummer». Specific numbers from some hierarchy, for instance '1.4.3.2'. Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link. |
| Url | string | A url to the product info. Can be empty. Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link. |
| ProductCategoryKey | string | Either a List id to an id from a connector provided list, or, if the connection doesn't support lists, a text. Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link. |
| ProductFamilyKey | string | Either a List id to an id from a connector provided list, or, if the connection doesn't support lists, a text. Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link. |
| ProductTypeKey | string | Either a List id to an id from a connector provided list, or, if the connection doesn't support lists, a text. Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link. |
| Supplier | string | The name of the supplier. Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link. |
| SupplierCode | string | The suppliers' code or part number for this product. Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link. |
| Thumbnail | string | A small image of the product, typically used to show in a list. Base64 encoded png. |
| VATInfo | string | Tax/VAT information, Extra info about VAT that the connector might insert, and the users might want to specify on the quote. The core CRM product has no business logic for this field, it is wholly up to connectors to use it. |
| VAT | double | Tax/VAT - THIS IS A PERCENTAGE. The connector is responsible for populating this field; the percentage will be used to calculate VAT amounts available as merge fields in the document templates (but amounts are never stored in the database). |
| UnitCost | double | The cost price per unit for this product. May be filled in by connector if it has the Provide-Cost capability. |
| UnitMinimumPrice | double | The minimum price this line can be sold for (to limit discounting). Will come from the connector. List price per unit must exceed the minimum price per unit. |
| UnitListPrice | double | The standard list price; as given by ERP Connector, OR overridden by user |
| ExtraInfo | array | Extra information, supplied by QuoteConnector, used by a future dynamic GUI extension |
| RawExtraInfo | string | Read-only extra information in plain text, supplied by QuoteConnector, used by a future dynamic GUI extension |
| IsSubscription | bool | Is this a subscription product, sold in repeating intervals/amounts? |
| SubscriptionUnit | string | Either a List id to an id from a connector provided list, or, if the connection doesn’t support lists, a text with the actual subscription unit. |
| SubscriptionQuantity | double | The default number of SubscriptionUnits to suggest when creating quote lines from this product |
| SubscriptionStart | date-time | Start date for subscription, as offered |
| ERPDiscountPercent | double | The discount the system calculates based on customer / quantity / whatever. Can be overrided by the salesman in the field 'DiscountPercent' or 'DiscountAmount'. Both fields ERPDiscountPercent and ERPDiscountAmount will be filled out. If UserValueOverride is set to ‘None’ then the value is copied to DiscountPercent. The Percentage is given in integer form, i.e. ‘12%’ is represented as ‘12’. |
| ERPDiscountAmount | double | The discount the system calculates based on customer / quantity / whatever. Can be overrided by the salesman in the field 'DiscountPercent' or 'DiscountAmount'. If UserValueOverride is set to ‘None’ then the value is copied to DiscountAmount. Both fields ERPDiscountPercent and ERPDiscountAmount will be filled out. |
| DiscountPercent | double | The discount for the line, in percent. Both ‘DiscountPercent’ and ‘DiscountAmount’ shall be filled out, but the UserValueOverride field must be set to the field the user actually changed last. If this field is filled out by the user, it overrides any discount suggested by the connector. If the user has not filled this in, the system will copy the ERP discount amount to this field. The Percentage is given in integer form, i.e. ‘12%’ is represented as ‘12’. |
| DiscountAmount | double | The discount for the line, in whatever currency the sale is in. Both ‘DiscountPercent’ and ‘DiscountAmount’ shall be filled out, but the UserValueOverride field must be set to the field the user actually changed last. If this field is filled out by the user, it overrides any discount suggested by the connector. If the user has not filled this in, the system will copy the ERP discount amount to this field. |
| UserValueOverride | string | Has the pre-calculated (from ERP) price information been overridden, and how. If the user has filled out the discountpercentage field, then the UserValueOverride field is set to OverridePercent. (The DiscountAmount, EarningPercent, EarningAmount and TotalPrice fields are calculated based on the DiscountPercent.) |
| EarningPercent | double | The earning, in percent. Both ‘EarningAmount and ‘EarningPercent shall be filled out, but the UserValueOverride field must be set to the field the user actually changed last. The Percentage is given in integer form, i.e. ‘12%’ is represented as ‘12’. |
| EarningAmount | double | The earning, in whatever currency the sale is in. Both ‘EarningAmount and ‘EarningPercent shall be filled out, but the UserValueOverride field must be set to the field the user actually changed last. |
| SubTotal | double | Value to help the user interface, is equal to 'Quantity * ListPrice' |
| TotalPrice | double | TotalPrice  = SubTotal - DiscountAmount or TotalPrice = (UnitCost * Quantity) + EarningAmount, according to what the user changed last. |
| Rights | string | Field1=right&amp;Field2=right, etc. of any fields that have non-standard field access rights. Rights can be one of: N (=None or Hidden), R (=Read-only), W (=Writeable), M (=Mandatory). The fields will mostly be from the Quoteline table, but some added fields that are conceptually part of the quoteline, like Image will also be possibly to set rights on. Will be used by SuperOffice to control the user interface when showing the record. |
| Rule | string | The names of one or more calculation rules that are in effect for this line, comma-separated case-insensitive |
| ExtraField1 | string | This a simple field for adding information that the Connector can provide, and that the qoute document need to display. |
| ExtraField2 | string | This a simple field for adding information that the Connector can provide, and that the qoute document need to display. |
| ExtraField3 | string | This a simple field for adding information that the Connector can provide, and that the qoute document need to display. |
| ExtraField4 | string | This a simple field for adding information that the Connector can provide, and that the qoute document need to display. |
| ExtraField5 | string | This a simple field for adding information that the Connector can provide, and that the qoute document need to display. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Quote/SaveQuoteLines
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "QuoteLines": [
    {
      "QuoteLineId": 875,
      "ERPQuoteLineKey": "doloribus",
      "QuoteAlternativeId": 195,
      "ERPProductKey": "eveniet",
      "Status": "Error",
      "Reason": "",
      "Quantity": 2698.374,
      "DeliveredQuantity": 874.386,
      "Rank": 971,
      "Name": "Mayer-Bradtke",
      "Description": "Function-based bifurcated projection",
      "Code": "hic",
      "QuantityUnit": "alias",
      "PriceUnit": "id",
      "ItemNumber": "1410191",
      "Url": "http://www.example.com/",
      "ProductCategoryKey": "VIP Customer",
      "ProductFamilyKey": "tenetur",
      "ProductTypeKey": "qui",
      "Supplier": "natus",
      "SupplierCode": "minima",
      "Thumbnail": "a",
      "VATInfo": "eaque",
      "VAT": 28735.646,
      "UnitCost": 21336.272,
      "UnitMinimumPrice": 1237.93,
      "UnitListPrice": 4180.756,
      "ExtraInfo": [
        {},
        {}
      ],
      "RawExtraInfo": "eius",
      "IsSubscription": true,
      "SubscriptionUnit": "aperiam",
      "SubscriptionQuantity": 7023.294,
      "SubscriptionStart": "2003-10-26T04:22:27.4403662+01:00",
      "ERPDiscountPercent": 13065.645999999999,
      "ERPDiscountAmount": 19574.964,
      "DiscountPercent": 2259.614,
      "DiscountAmount": 16027.276,
      "UserValueOverride": "DiscountAmount",
      "EarningPercent": 25974.592,
      "EarningAmount": 27065.224,
      "SubTotal": 5108.42,
      "TotalPrice": 5061.41,
      "Rights": "commodi",
      "Rule": "exercitationem",
      "ExtraField1": "repellendus",
      "ExtraField2": "vitae",
      "ExtraField3": "et",
      "ExtraField4": "atque",
      "ExtraField5": "rerum"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "QuoteLineId": 827,
    "ERPQuoteLineKey": "aut",
    "QuoteAlternativeId": 393,
    "ERPProductKey": "rerum",
    "Status": "Error",
    "Reason": "reinvent next-generation web services",
    "Quantity": 11931.137999999999,
    "DeliveredQuantity": 6910.4699999999993,
    "Rank": 501,
    "Name": "Nienow, Muller and Gerhold",
    "Description": "Digitized contextually-based protocol",
    "Code": "non",
    "QuantityUnit": "ipsam",
    "PriceUnit": "quos",
    "ItemNumber": "1122728",
    "Url": "http://www.example.com/",
    "ProductCategoryKey": "VIP Customer",
    "ProductFamilyKey": "rerum",
    "ProductTypeKey": "quasi",
    "Supplier": "omnis",
    "SupplierCode": "ut",
    "Thumbnail": "aliquid",
    "VATInfo": "quis",
    "VAT": 5014.4,
    "UnitCost": 20615.452,
    "UnitMinimumPrice": 7111.0459999999994,
    "UnitListPrice": 21486.703999999998,
    "ExtraInfo": [
      {
        "Name": "Jones, Beer and Nienow",
        "Value": "et",
        "Type": "Image",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 104
          }
        }
      },
      {
        "Name": "Jones, Beer and Nienow",
        "Value": "et",
        "Type": "Image",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 104
          }
        }
      }
    ],
    "RawExtraInfo": "occaecati",
    "IsSubscription": false,
    "SubscriptionUnit": "perferendis",
    "SubscriptionQuantity": 25557.77,
    "SubscriptionStart": "2015-01-23T04:22:27.4403662+01:00",
    "ERPDiscountPercent": 3685.584,
    "ERPDiscountAmount": 30048.791999999998,
    "DiscountPercent": 1457.31,
    "DiscountAmount": 20349.061999999998,
    "UserValueOverride": "DiscountAmount",
    "EarningPercent": 15356.6,
    "EarningAmount": 5747.7559999999994,
    "SubTotal": 13830.341999999999,
    "TotalPrice": 25952.654,
    "Rights": "iste",
    "Rule": "dolores",
    "ExtraField1": "magnam",
    "ExtraField2": "in",
    "ExtraField3": "eos",
    "ExtraField4": "temporibus",
    "ExtraField5": "quis",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 828
      }
    }
  }
]
```