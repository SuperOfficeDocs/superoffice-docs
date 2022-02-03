---
title: POST Agents/Quote/PlaceOrder
id: v1QuoteAgent_PlaceOrder
---

# POST Agents/Quote/PlaceOrder

```http
POST /api/v1/Agents/Quote/PlaceOrder
```

Place an order in the ERP system.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/PlaceOrder?$select=name,department,category/id
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

QuoteAlternativeId, MarkSaleAsSold, PoNumber, OrderComment, Culture 

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteAlternativeId | int32 |  |
| MarkSaleAsSold | bool |  |
| PoNumber | string |  |
| OrderComment | string |  |
| Culture | string |  |


## Response: object

PluginUrlResponse exists to be able to respond with more than just a true/false, but also an explanation. Such an explanation can be displayed on for instance a disabled “Place Order” button. In addition, an URL can be returned, which the GUI should navigate to/display if it is non-blank. The URL can be an SoProtocol or http(s)



Carrier object for PluginUrlResponse.
Services for the PluginUrlResponse Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IQuoteAgent">Quote Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| IsOk | bool | Answer to the question / An indication if the operation went well. |
| UserExplanation | string | A localized explanation to the answer. |
| TechExplanation | string | Always in English |
| ErrorCode | string | An error code, if available. |
| Changes |  | Tablename/recordid of data changed by this method, that the client may need to reload |
| Url | string | Url that the GUI should navigato to/open, if non-blank. The GUI cannot enforce any rules subsequent to opening the requested url. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Quote/PlaceOrder
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "QuoteAlternativeId": 680,
  "MarkSaleAsSold": true,
  "PoNumber": "844814",
  "OrderComment": "dolorum",
  "Culture": "asperiores"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "IsOk": false,
  "UserExplanation": "iste",
  "TechExplanation": "vero",
  "ErrorCode": "corporis",
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
        "FieldLength": 597
      }
    }
  },
  "Url": "http://www.example.com/",
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
      "FieldLength": 998
    }
  }
}
```