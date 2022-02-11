---
title: POST Agents/Quote/UpdateQuoteVersionPrices
id: v1QuoteAgent_UpdateQuoteVersionPrices
---

# POST Agents/Quote/UpdateQuoteVersionPrices

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 273
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "IsOk": false,
  "UserExplanation": "vel",
  "TechExplanation": "at",
  "ErrorCode": "et",
  "ChangedSale": {
    "ContactName": "Herzog-Gibson",
    "SaleDate": "2005-11-02T18:28:49.9301388+01:00",
    "SaleId": 63,
    "Probability": 940,
    "Title": "qui",
    "Amount": 14272.235999999999,
    "Currency": "maxime",
    "ProjectName": "Nicolas, Grimes and Blick",
    "AssociateFullName": "Dejah Padberg",
    "Description": "Focused intangible customer loyalty",
    "Status": "Lost",
    "WeightedAmount": 11097.493999999999,
    "ProjectId": 562,
    "EarningPercent": 23542.608,
    "Earning": 20032.528,
    "ContactId": 340,
    "AssociateId": 611,
    "PersonId": 385,
    "SaleTypeId": 442,
    "SaleTypeName": "Quigley, Kohler and White",
    "PersonFullName": "Kristina Goyette",
    "Completed": "Completed",
    "ActiveErpLinks": 402,
    "NextDueDate": "2015-08-13T18:28:49.9301388+02:00",
    "Number": "491188",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 542
      }
    }
  },
  "ChangedQuote": {
    "QuoteId": 374,
    "SaleId": 426,
    "QuoteConnectionId": 924,
    "ERPQuoteKey": "dolores",
    "ERPOrderKey": "error",
    "ActiveQuoteVersionId": 961,
    "AcceptedQuoteAlternativeId": 194,
    "UseValuesFromQuote": 973,
    "DocumentId": 7,
    "PoNumber": "1536776",
    "OrderComment": "animi",
    "PreferredEmailCulture": "cole.breitenberg@gottlieb.us",
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
        "FieldLength": 276
      }
    }
  },
  "ChangedQuoteVersion": {
    "QuoteVersionId": 65,
    "ERPQuoteVersionKey": "consequatur",
    "QuoteId": 491,
    "Description": "Profound next generation concept",
    "Number": "1180845",
    "State": "Archived",
    "ArchivedState": "Archived",
    "Status": "Error",
    "Reason": "",
    "LikelyQuoteAlternativeId": 146,
    "SentDate": "2007-12-18T18:28:49.9311086+01:00",
    "FollowupId": 758,
    "ExpirationDate": "2021-02-09T18:28:49.9311086+01:00",
    "DeliveryCountryId": 578,
    "HasOwnDeliveryAddress": false,
    "InvoiceCountryId": 614,
    "HasOwnInvoiceAddress": false,
    "ERPPaymentTermsKey": "sunt",
    "ERPPaymentTypeKey": "amet",
    "ERPDeliveryTermsKey": "vel",
    "ERPDeliveryTypeKey": "nobis",
    "Rank": 131,
    "ApprovedBy": 429,
    "ApprovedText": "laboriosam",
    "ApprovedRegisteredBy": 600,
    "ApprovedRegisteredDate": "2008-03-22T18:28:49.9311086+01:00",
    "ExtraField1": "sit",
    "ExtraField2": "ut",
    "ExtraField3": "fuga",
    "ExtraField4": "nobis",
    "ExtraField5": "ut",
    "LastRecalculated": "2002-06-30T18:28:49.9311086+02:00",
    "Updated": "2018-12-28T18:28:49.9311086+01:00",
    "UpdatedAssociateId": 895,
    "Registered": "2000-10-18T18:28:49.9311086+02:00",
    "RegisteredAssociateId": 932,
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
        "FieldLength": 186
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
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 302
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
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 302
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
      "FieldLength": 261
    }
  }
}
```