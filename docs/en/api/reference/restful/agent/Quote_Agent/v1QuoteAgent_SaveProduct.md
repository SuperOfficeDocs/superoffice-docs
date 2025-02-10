---
title: POST Agents/Quote/SaveProduct
uid: v1QuoteAgent_SaveProduct
generated: true
---

# POST Agents/Quote/SaveProduct

```http
POST /api/v1/Agents/Quote/SaveProduct
```

Updates the existing Product or creates a new Product if the id parameter is empty








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

The Product to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProductId | Integer | Primary key |
| ERPProductKey | String | Reference/foreign key to the product in the given pricelist in the product supplier system, if it exists there. |
| ERPPriceListKey | String | Foreign key to the price list that this product is a part of, or the primary key of the pricelist if this is a built-in pricelist. |
| Name | String | The name to use in the user interface. |
| Description | String | The description to use, with potentially several lines. Will be used as tool-tip to use in the list user interface too. |
| Code | String | The product code / article number in the product supplier system. |
| PriceUnit | String | What is the unit (meter, ton, bushel, microsecond, gradus, τρυβλίον, 五合枡, دونم or whatever); read-only for lines that originate in defined products |
| QuantityUnit | String | What is the unit (meter, ton, bushel, microsecond, gradus, τρυβλίον, 五合枡, دونم or whatever); Connector handles conversion relative to PriceUnit if they are different |
| IsSubscription | Boolean | Is this a subscription product, sold in repeating intervals/amounts? |
| SubscriptionUnit | String | Either a List id to an id from a connector provided list, or, if the connection doesn’t support lists, a text with the actual subscription unit. |
| DefaultSubscriptionQuantity | Number | The default number of SubscriptionUnits to suggest when creating quote lines from this product |
| ItemNumber | String | Line item number, NOR: «Postnummer». Specific numbers from some hierarchy, for instance “1.4.3.2P”. Typically used to sort the items in the quote by some standard way. |
| Url | String | URL to product information web page. |
| ProductCategoryKey | String | Either a List id to an id from a connector provided list, or, if the connection doesn’t support lists, a text with the actual product category. |
| ProductFamilyKey | String | Either a List id to an id from a connector provided list, or, if the connection doesn't support lists, a text with the actual product family. |
| ProductTypeKey | String | Either a List id to an id from a connector provided list, or, if the connection doesn’t support lists, a text with the actual product type. |
| VAT | Number | Tax/VAT if available from ERP system. THIS IS A PERCENTAGE. In the Superoffice product register, this field is available in the product admin GUI. |
| VATInfo | String | A field for putting VATInfo you need to show in the final quoteDocument, like the VAT type that is used. Not used in any business logic in SuperOffice; available to document templates. |
| UnitCost | Number | The cost price. Might not be given, use Decimal.MinValue to signal this. |
| UnitMinimumPrice | Number | The minimum price this salesman can offer to his customer. This might be cost price if there is no policy. Might not be given, use Decimal.MinValue to signal this. |
| UnitListPrice | Number | (Basic Price, normal price, standard price.) This is the basic price from which the discount is computed from. The ListPrice will stay the same even when a larger amount is ordered. |
| InAssortment | Boolean | True for products that should currently be offered, false when the product is discontinued and should not ordinarily be offered. When false the product no longer appears in search results. |
| Supplier | String | In SuperOffice, an id from the contact table, when saved as an ERP cache, the name of the supplier |
| SupplierCode | String | Suppliers part code/number or other key-like field |
| Rights | String | Field1=right&amp;Field2=right, etc. of any fields that have non-standard field access rights. Rights can be one of: N (=None or Hidden), R (=Read-only), W (=Writeable), M (=Mandatory). The fields will mostly be from the Quoteline table, but some added fields that are conceptually part of the quoteline, like Image will also be possibly to set rights on. Will be used by SuperOffice to control the user interface when showing the record. |
| Rule | String | The names of one or more calculation rules that are in effect for this line, comma-separated case-insensitive. Will NOT be used by SuperOffice. |
| ExtraInfo | Array | Extra information, supplied by QuoteConnector, used by a future dynamic GUI extension |
| RawExtraInfo | String | Read-only extra information in plain text, supplied by QuoteConnector, used by a future dynamic GUI extension |
| ExtraField1 | String | This a simple field for adding information that the Connector can provide, and that the qoute document need to display. |
| ExtraField2 | String | This a simple field for adding information that the Connector can provide, and that the qoute document need to display. |
| ExtraField3 | String | This a simple field for adding information that the Connector can provide, and that the qoute document need to display. |
| ExtraField4 | String | This a simple field for adding information that the Connector can provide, and that the qoute document need to display. |
| ExtraField5 | String | This a simple field for adding information that the Connector can provide, and that the qoute document need to display. |
| InStock | Number | Negative numbers will be interpreted as how many is ordered. Might not be available. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: Product

| Property Name | Type |  Description |
|----------------|------|--------------|
| ProductId | int32 | Primary key |
| ERPProductKey | string | Reference/foreign key to the product in the given pricelist in the product supplier system, if it exists there. |
| ERPPriceListKey | string | Foreign key to the price list that this product is a part of, or the primary key of the pricelist if this is a built-in pricelist. |
| Name | string | The name to use in the user interface. |
| Description | string | The description to use, with potentially several lines. Will be used as tool-tip to use in the list user interface too. |
| Code | string | The product code / article number in the product supplier system. |
| PriceUnit | string | What is the unit (meter, ton, bushel, microsecond, gradus, τρυβλίον, 五合枡, دونم or whatever); read-only for lines that originate in defined products |
| QuantityUnit | string | What is the unit (meter, ton, bushel, microsecond, gradus, τρυβλίον, 五合枡, دونم or whatever); Connector handles conversion relative to PriceUnit if they are different |
| IsSubscription | bool | Is this a subscription product, sold in repeating intervals/amounts? |
| SubscriptionUnit | string | Either a List id to an id from a connector provided list, or, if the connection doesn’t support lists, a text with the actual subscription unit. |
| DefaultSubscriptionQuantity | double | The default number of SubscriptionUnits to suggest when creating quote lines from this product |
| ItemNumber | string | Line item number, NOR: «Postnummer». Specific numbers from some hierarchy, for instance “1.4.3.2P”. Typically used to sort the items in the quote by some standard way. |
| Url | string | URL to product information web page. |
| ProductCategoryKey | string | Either a List id to an id from a connector provided list, or, if the connection doesn’t support lists, a text with the actual product category. |
| ProductFamilyKey | string | Either a List id to an id from a connector provided list, or, if the connection doesn't support lists, a text with the actual product family. |
| ProductTypeKey | string | Either a List id to an id from a connector provided list, or, if the connection doesn’t support lists, a text with the actual product type. |
| VAT | double | Tax/VAT if available from ERP system. THIS IS A PERCENTAGE. In the Superoffice product register, this field is available in the product admin GUI. |
| VATInfo | string | A field for putting VATInfo you need to show in the final quoteDocument, like the VAT type that is used. Not used in any business logic in SuperOffice; available to document templates. |
| UnitCost | double | The cost price. Might not be given, use Decimal.MinValue to signal this. |
| UnitMinimumPrice | double | The minimum price this salesman can offer to his customer. This might be cost price if there is no policy. Might not be given, use Decimal.MinValue to signal this. |
| UnitListPrice | double | (Basic Price, normal price, standard price.) This is the basic price from which the discount is computed from. The ListPrice will stay the same even when a larger amount is ordered. |
| InAssortment | bool | True for products that should currently be offered, false when the product is discontinued and should not ordinarily be offered. When false the product no longer appears in search results. |
| Supplier | string | In SuperOffice, an id from the contact table, when saved as an ERP cache, the name of the supplier |
| SupplierCode | string | Suppliers part code/number or other key-like field |
| Rights | string | Field1=right&amp;Field2=right, etc. of any fields that have non-standard field access rights. Rights can be one of: N (=None or Hidden), R (=Read-only), W (=Writeable), M (=Mandatory). The fields will mostly be from the Quoteline table, but some added fields that are conceptually part of the quoteline, like Image will also be possibly to set rights on. Will be used by SuperOffice to control the user interface when showing the record. |
| Rule | string | The names of one or more calculation rules that are in effect for this line, comma-separated case-insensitive. Will NOT be used by SuperOffice. |
| ExtraInfo | array | Extra information, supplied by QuoteConnector, used by a future dynamic GUI extension |
| RawExtraInfo | string | Read-only extra information in plain text, supplied by QuoteConnector, used by a future dynamic GUI extension |
| ExtraField1 | string | This a simple field for adding information that the Connector can provide, and that the qoute document need to display. |
| ExtraField2 | string | This a simple field for adding information that the Connector can provide, and that the qoute document need to display. |
| ExtraField3 | string | This a simple field for adding information that the Connector can provide, and that the qoute document need to display. |
| ExtraField4 | string | This a simple field for adding information that the Connector can provide, and that the qoute document need to display. |
| ExtraField5 | string | This a simple field for adding information that the Connector can provide, and that the qoute document need to display. |
| InStock | double | Negative numbers will be interpreted as how many is ordered. Might not be available. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Quote/SaveProduct
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ProductId": 135,
  "ERPProductKey": "quia",
  "ERPPriceListKey": "qui",
  "Name": "Prosacco-Williamson",
  "Description": "Automated didactic pricing structure",
  "Code": "totam",
  "PriceUnit": "et",
  "QuantityUnit": "et",
  "IsSubscription": false,
  "SubscriptionUnit": "neque",
  "DefaultSubscriptionQuantity": 1096.8999999999999,
  "ItemNumber": "608570",
  "Url": "http://www.example.com/",
  "ProductCategoryKey": "VIP Customer",
  "ProductFamilyKey": "ea",
  "ProductTypeKey": "sequi",
  "VAT": 13426.055999999999,
  "VATInfo": "et",
  "UnitCost": 22922.076,
  "UnitMinimumPrice": 14475.946,
  "UnitListPrice": 12090.972,
  "InAssortment": false,
  "Supplier": "eos",
  "SupplierCode": "dolor",
  "Rights": "doloremque",
  "Rule": "sunt",
  "ExtraInfo": [
    {
      "Name": "Cremin Group",
      "Value": "laudantium",
      "Type": "Image"
    },
    {
      "Name": "Cremin Group",
      "Value": "laudantium",
      "Type": "Image"
    }
  ],
  "RawExtraInfo": "hic",
  "ExtraField1": "sed",
  "ExtraField2": "repellat",
  "ExtraField3": "quisquam",
  "ExtraField4": "mollitia",
  "ExtraField5": "cumque",
  "InStock": 16246.655999999999
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ProductId": 185,
  "ERPProductKey": "nihil",
  "ERPPriceListKey": "reiciendis",
  "Name": "Boyer-Hettinger",
  "Description": "Enterprise-wide methodical benchmark",
  "Code": "voluptatem",
  "PriceUnit": "vero",
  "QuantityUnit": "aperiam",
  "IsSubscription": false,
  "SubscriptionUnit": "voluptatibus",
  "DefaultSubscriptionQuantity": 21884.721999999998,
  "ItemNumber": "393777",
  "Url": "http://www.example.com/",
  "ProductCategoryKey": "VIP Customer",
  "ProductFamilyKey": "qui",
  "ProductTypeKey": "sapiente",
  "VAT": 28011.692,
  "VATInfo": "quis",
  "UnitCost": 9423.938,
  "UnitMinimumPrice": 25567.172,
  "UnitListPrice": 5707.014,
  "InAssortment": true,
  "Supplier": "sunt",
  "SupplierCode": "illum",
  "Rights": "sint",
  "Rule": "voluptates",
  "ExtraInfo": [
    {
      "Name": "Huel-Jast",
      "Value": "nemo",
      "Type": "Image",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 4
        }
      }
    },
    {
      "Name": "Huel-Jast",
      "Value": "nemo",
      "Type": "Image",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 4
        }
      }
    }
  ],
  "RawExtraInfo": "et",
  "ExtraField1": "est",
  "ExtraField2": "quod",
  "ExtraField3": "saepe",
  "ExtraField4": "cum",
  "ExtraField5": "quia",
  "InStock": 10003.728,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 731
    }
  }
}
```