---
title: UpdateQuoteVersionPrices
id: v1QuoteAgent_UpdateQuoteVersionPrices
---

# UpdateQuoteVersionPrices

```http
POST /api/v1/Agents/Quote/UpdateQuoteVersionPrices
```

Update price on the all the quotelines for each alternative in the current quote version







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Quote/UpdateQuoteVersionPrices?$select=name,department,category/id
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

QuoteVersionId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| QuoteVersionId | int32 |  |


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
POST /api/v1/Agents/Quote/UpdateQuoteVersionPrices
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 47
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "IsOk": false,
  "UserExplanation": "porro",
  "TechExplanation": "rerum",
  "ErrorCode": "et",
  "ChangedSale": {
    "ContactName": "Flatley Group",
    "SaleDate": "2012-03-11T14:58:04.9494322+01:00",
    "SaleId": 277,
    "Probability": 533,
    "Title": "qui",
    "Amount": 3450.534,
    "Currency": "iure",
    "ProjectName": "Moen, Rohan and Heller",
    "AssociateFullName": "Violette Towne",
    "Description": "Cross-platform asynchronous algorithm",
    "Status": "Lost",
    "WeightedAmount": 17268.34,
    "ProjectId": 72,
    "EarningPercent": 10708.877999999999,
    "Earning": 3566.4919999999997,
    "ContactId": 555,
    "AssociateId": 624,
    "PersonId": 385,
    "SaleTypeId": 44,
    "SaleTypeName": "Marks, Effertz and Kemmer",
    "PersonFullName": "Lia Flatley",
    "Completed": "Completed",
    "ActiveErpLinks": 976,
    "NextDueDate": "1997-02-19T14:58:04.9494322+01:00",
    "Number": "1012355",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 288
      }
    }
  },
  "ChangedQuote": {
    "QuoteId": 303,
    "SaleId": 150,
    "QuoteConnectionId": 363,
    "ERPQuoteKey": "placeat",
    "ERPOrderKey": "excepturi",
    "ActiveQuoteVersionId": 601,
    "AcceptedQuoteAlternativeId": 31,
    "UseValuesFromQuote": 747,
    "DocumentId": 694,
    "PoNumber": "742582",
    "OrderComment": "reiciendis",
    "PreferredEmailCulture": "hunter@kertzmann.biz",
    "ActiveQuoteVersion": {},
    "FavoriteQuoteAlternative": {},
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 531
      }
    }
  },
  "ChangedQuoteVersion": {
    "QuoteVersionId": 172,
    "ERPQuoteVersionKey": "incidunt",
    "QuoteId": 738,
    "Description": "Innovative transitional contingency",
    "Number": "396682",
    "State": "Archived",
    "ArchivedState": "Archived",
    "Status": "Error",
    "Reason": "",
    "LikelyQuoteAlternativeId": 293,
    "SentDate": "1998-06-22T14:58:04.9504317+02:00",
    "FollowupId": 61,
    "ExpirationDate": "2004-11-12T14:58:04.9504317+01:00",
    "DeliveryCountryId": 406,
    "HasOwnDeliveryAddress": true,
    "InvoiceCountryId": 927,
    "HasOwnInvoiceAddress": false,
    "ERPPaymentTermsKey": "vel",
    "ERPPaymentTypeKey": "dolor",
    "ERPDeliveryTermsKey": "provident",
    "ERPDeliveryTypeKey": "repudiandae",
    "Rank": 575,
    "ApprovedBy": 130,
    "ApprovedText": "et",
    "ApprovedRegisteredBy": 174,
    "ApprovedRegisteredDate": "2005-10-14T14:58:04.9504317+02:00",
    "ExtraField1": "minima",
    "ExtraField2": "est",
    "ExtraField3": "totam",
    "ExtraField4": "hic",
    "ExtraField5": "sunt",
    "LastRecalculated": "1996-07-08T14:58:04.9504317+02:00",
    "Updated": "2000-12-16T14:58:04.9504317+01:00",
    "UpdatedAssociateId": 778,
    "Registered": "2005-06-02T14:58:04.9504317+02:00",
    "RegisteredAssociateId": 759,
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
        "FieldLength": 810
      }
    }
  },
  "ChangedQuoteAlternatives": [
    {
      "QuoteLinesHasChanged": true,
      "ChangedQuoteAlternative": {},
      "Changes": {},
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "envisioneer efficient initiatives"
          },
          "FieldType": "System.Int32",
          "FieldLength": 338
        }
      }
    },
    {
      "QuoteLinesHasChanged": true,
      "ChangedQuoteAlternative": {},
      "Changes": {},
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "envisioneer efficient initiatives"
          },
          "FieldType": "System.Int32",
          "FieldLength": 338
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
        "Reason": "benchmark sexy models"
      },
      "FieldType": "System.String",
      "FieldLength": 781
    }
  }
}
```