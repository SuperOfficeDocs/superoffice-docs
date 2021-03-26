---
title: PUT Product/{id}
id: v1Product_PutProduct
---

# PUT Product/{id}

```http
PUT /api/v1/Product/{id}
```

Updates the existing Product






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The Product id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Product/{id}?$select=name,department,category/id
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

## Request Body: entity  

The Product to be saved. 

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


## Response: object

Information about a Product from the ERP system. This may be fetched from SuperOffice Product table through the SO Connector



Carrier object for Product.
Services for the Product Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IQuoteAgent">Quote Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | Product updated. |
| 400 | Bad request. Entity to save is not in request body. |

Response body: object

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
PUT /api/v1/Product/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ProductId": 79,
  "ERPProductKey": "aut",
  "ERPPriceListKey": "deserunt",
  "Name": "Kuhlman, Roberts and Waelchi",
  "Description": "Phased tertiary analyzer",
  "Code": "non",
  "PriceUnit": "debitis",
  "QuantityUnit": "accusamus",
  "IsSubscription": false,
  "SubscriptionUnit": "dolor",
  "DefaultSubscriptionQuantity": 7621.888,
  "ItemNumber": "1055597",
  "Url": "http://www.example.com/",
  "ProductCategoryKey": "VIP Customer",
  "ProductFamilyKey": "placeat",
  "ProductTypeKey": "laudantium",
  "VAT": 11852.788,
  "VATInfo": "optio",
  "UnitCost": 6083.094,
  "UnitMinimumPrice": 22498.986,
  "UnitListPrice": 19462.14,
  "InAssortment": false,
  "Supplier": "et",
  "SupplierCode": "voluptatibus",
  "Rights": "corrupti",
  "Rule": "deleniti",
  "ExtraInfo": [
    {
      "Name": "Homenick, Jenkins and Parisian",
      "Value": "dignissimos",
      "Type": "Image"
    },
    {
      "Name": "Homenick, Jenkins and Parisian",
      "Value": "dignissimos",
      "Type": "Image"
    }
  ],
  "RawExtraInfo": "autem",
  "ExtraField1": "fuga",
  "ExtraField2": "fugiat",
  "ExtraField3": "voluptatem",
  "ExtraField4": "nulla",
  "ExtraField5": "accusantium",
  "InStock": 11467.306
}
```

```http_
HTTP/1.1 200 Product updated.
Content-Type: application/json; charset=utf-8

{
  "ProductId": 978,
  "ERPProductKey": "dolor",
  "ERPPriceListKey": "vel",
  "Name": "Cremin, Glover and Kunde",
  "Description": "Balanced disintermediate projection",
  "Code": "ea",
  "PriceUnit": "blanditiis",
  "QuantityUnit": "qui",
  "IsSubscription": true,
  "SubscriptionUnit": "fugiat",
  "DefaultSubscriptionQuantity": 14043.454,
  "ItemNumber": "999977",
  "Url": "http://www.example.com/",
  "ProductCategoryKey": "VIP Customer",
  "ProductFamilyKey": "aut",
  "ProductTypeKey": "eum",
  "VAT": 15177.962,
  "VATInfo": "consequuntur",
  "UnitCost": 14469.678,
  "UnitMinimumPrice": 15532.104,
  "UnitListPrice": 26726.752,
  "InAssortment": false,
  "Supplier": "tempora",
  "SupplierCode": "quam",
  "Rights": "qui",
  "Rule": "ratione",
  "ExtraInfo": [
    {
      "Name": "Marquardt LLC",
      "Value": "iure",
      "Type": "Image",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 356
        }
      }
    },
    {
      "Name": "Marquardt LLC",
      "Value": "iure",
      "Type": "Image",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 356
        }
      }
    }
  ],
  "RawExtraInfo": "et",
  "ExtraField1": "delectus",
  "ExtraField2": "consequuntur",
  "ExtraField3": "sunt",
  "ExtraField4": "repellendus",
  "ExtraField5": "molestiae",
  "InStock": 26281.724,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "architect world-class initiatives"
      },
      "FieldType": "System.Int32",
      "FieldLength": 740
    }
  }
}
```