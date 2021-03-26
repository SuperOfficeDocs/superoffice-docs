---
title: POST Agents/Quote/ValidateQuoteVersion
id: v1QuoteAgent_ValidateQuoteVersion
---

# POST Agents/Quote/ValidateQuoteVersion

```http
POST /api/v1/Agents/Quote/ValidateQuoteVersion
```

When the user changes one or more values in a quoteline or a quoteAlternative, the connector gets to change the QuoteLines and the alternative, for instance calculate VAT.

ValidateQuoteVersion shall be called when the user presses the validate button, presses the send button or closes the quote dialog. RecalculateQuoteAlternative should typically validate all alternatives, set values in extrafields, and set the state in the version.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/ValidateQuoteVersion?$select=name,department,category/id
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

QuoteVersionId, Action 

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteVersionId | int32 |  |
| Action | string |  |


## Response: object

The QuoteVersionValidated is returned after a call to ValidateQuoteAlternative. It contains flags indicating changes to quote, quoteversion/quotealternative and quotelines.



Carrier object for QuoteVersionValidated.
Services for the QuoteVersionValidated Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IQuoteAgent">Quote Agent</see>.

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
| ChangedSale |  | If the sale has been changed, the carrier will be added. |
| ChangedQuote |  | The validated version is a member of Quote |
| ChangedQuoteVersion |  | The validated QuoteVersion |
| ChangedQuoteAlternatives | array | The changed QuoteAlternatives |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Quote/ValidateQuoteVersion
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 607,
  "Action": "Approve"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "IsOk": false,
  "UserExplanation": "fugiat",
  "TechExplanation": "et",
  "ErrorCode": "doloribus",
  "ChangedSale": {
    "ContactName": "Luettgen, Runolfsdottir and Jerde",
    "SaleDate": "2013-06-04T16:48:30.4139349+02:00",
    "SaleId": 396,
    "Probability": 72,
    "Title": "ea",
    "Amount": 25319.586,
    "Currency": "quae",
    "ProjectName": "Watsica, Kovacek and Kohler",
    "AssociateFullName": "Gennaro Blick",
    "Description": "Right-sized intangible collaboration",
    "Status": "Lost",
    "WeightedAmount": 6380.824,
    "ProjectId": 131,
    "EarningPercent": 16929.868,
    "Earning": 10179.232,
    "ContactId": 100,
    "AssociateId": 635,
    "PersonId": 215,
    "SaleTypeId": 240,
    "SaleTypeName": "Zemlak, Wintheiser and Ritchie",
    "PersonFullName": "Brett Ondricka",
    "Completed": "Completed",
    "ActiveErpLinks": 321,
    "NextDueDate": "2014-12-30T16:48:30.4139349+01:00",
    "Number": "1198857",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 833
      }
    }
  },
  "ChangedQuote": {
    "QuoteId": 977,
    "SaleId": 474,
    "QuoteConnectionId": 980,
    "ERPQuoteKey": "est",
    "ERPOrderKey": "asperiores",
    "ActiveQuoteVersionId": 460,
    "AcceptedQuoteAlternativeId": 792,
    "UseValuesFromQuote": 515,
    "DocumentId": 562,
    "PoNumber": "1030811",
    "OrderComment": "ut",
    "PreferredEmailCulture": "clark@nikolausbecker.info",
    "ActiveQuoteVersion": {},
    "FavoriteQuoteAlternative": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 155
      }
    }
  },
  "ChangedQuoteVersion": {
    "QuoteVersionId": 574,
    "ERPQuoteVersionKey": "sed",
    "QuoteId": 168,
    "Description": "Grass-roots well-modulated time-frame",
    "Number": "1197777",
    "State": "Archived",
    "ArchivedState": "Archived",
    "Status": "Error",
    "Reason": "",
    "LikelyQuoteAlternativeId": 515,
    "SentDate": "2010-10-05T16:48:30.4149343+02:00",
    "FollowupId": 1001,
    "ExpirationDate": "2007-05-15T16:48:30.4149343+02:00",
    "DeliveryCountryId": 951,
    "HasOwnDeliveryAddress": true,
    "InvoiceCountryId": 575,
    "HasOwnInvoiceAddress": true,
    "ERPPaymentTermsKey": "magnam",
    "ERPPaymentTypeKey": "quasi",
    "ERPDeliveryTermsKey": "excepturi",
    "ERPDeliveryTypeKey": "qui",
    "Rank": 61,
    "ApprovedBy": 784,
    "ApprovedText": "facilis",
    "ApprovedRegisteredBy": 864,
    "ApprovedRegisteredDate": "2017-01-27T16:48:30.4149343+01:00",
    "ExtraField1": "praesentium",
    "ExtraField2": "iusto",
    "ExtraField3": "est",
    "ExtraField4": "eaque",
    "ExtraField5": "ut",
    "LastRecalculated": "2003-08-13T16:48:30.4149343+02:00",
    "Updated": "1994-01-19T16:48:30.4149343+01:00",
    "UpdatedAssociateId": 58,
    "Registered": "2014-02-24T16:48:30.4149343+01:00",
    "RegisteredAssociateId": 57,
    "QuoteAlternatives": [
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
        "FieldType": "System.String",
        "FieldLength": 762
      }
    }
  },
  "ChangedQuoteAlternatives": [
    {
      "QuoteLinesHasChanged": false,
      "ChangedQuoteAlternative": {},
      "Changes": {},
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 99
        }
      }
    },
    {
      "QuoteLinesHasChanged": false,
      "ChangedQuoteAlternative": {},
      "Changes": {},
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 99
        }
      }
    }
  ],
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
      "FieldLength": 568
    }
  }
}
```