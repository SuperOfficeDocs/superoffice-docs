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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "QuoteVersionId": 895
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "IsOk": false,
  "UserExplanation": "dolorem",
  "TechExplanation": "exercitationem",
  "ErrorCode": "autem",
  "ChangedSale": {
    "ContactName": "Medhurst-Marks",
    "SaleDate": "2019-09-03T16:48:30.3789325+02:00",
    "SaleId": 206,
    "Probability": 317,
    "Title": "aut",
    "Amount": 28077.505999999998,
    "Currency": "corrupti",
    "ProjectName": "Wehner, Witting and Dicki",
    "AssociateFullName": "Ashlynn Steuber",
    "Description": "Open-source secondary projection",
    "Status": "Lost",
    "WeightedAmount": 15011.859999999999,
    "ProjectId": 365,
    "EarningPercent": 20512.03,
    "Earning": 26485.433999999997,
    "ContactId": 135,
    "AssociateId": 151,
    "PersonId": 349,
    "SaleTypeId": 191,
    "SaleTypeName": "Gerhold-Bogisich",
    "PersonFullName": "Juston Block",
    "Completed": "Completed",
    "ActiveErpLinks": 497,
    "NextDueDate": "2013-07-29T16:48:30.3799347+02:00",
    "Number": "857081",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 515
      }
    }
  },
  "ChangedQuote": {
    "QuoteId": 246,
    "SaleId": 146,
    "QuoteConnectionId": 773,
    "ERPQuoteKey": "aut",
    "ERPOrderKey": "exercitationem",
    "ActiveQuoteVersionId": 778,
    "AcceptedQuoteAlternativeId": 444,
    "UseValuesFromQuote": 988,
    "DocumentId": 8,
    "PoNumber": "322140",
    "OrderComment": "ea",
    "PreferredEmailCulture": "jalyn@purdyhickle.com",
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
        "FieldLength": 113
      }
    }
  },
  "ChangedQuoteVersion": {
    "QuoteVersionId": 558,
    "ERPQuoteVersionKey": "in",
    "QuoteId": 396,
    "Description": "Cloned empowering capability",
    "Number": "948382",
    "State": "Archived",
    "ArchivedState": "Archived",
    "Status": "Error",
    "Reason": "",
    "LikelyQuoteAlternativeId": 237,
    "SentDate": "2018-03-23T16:48:30.3799347+01:00",
    "FollowupId": 238,
    "ExpirationDate": "2008-01-07T16:48:30.3799347+01:00",
    "DeliveryCountryId": 647,
    "HasOwnDeliveryAddress": false,
    "InvoiceCountryId": 526,
    "HasOwnInvoiceAddress": false,
    "ERPPaymentTermsKey": "explicabo",
    "ERPPaymentTypeKey": "earum",
    "ERPDeliveryTermsKey": "vel",
    "ERPDeliveryTypeKey": "perferendis",
    "Rank": 285,
    "ApprovedBy": 342,
    "ApprovedText": "sit",
    "ApprovedRegisteredBy": 529,
    "ApprovedRegisteredDate": "2006-01-10T16:48:30.3799347+01:00",
    "ExtraField1": "quisquam",
    "ExtraField2": "ex",
    "ExtraField3": "eos",
    "ExtraField4": "ea",
    "ExtraField5": "expedita",
    "LastRecalculated": "1998-10-06T16:48:30.3819346+02:00",
    "Updated": "1995-02-25T16:48:30.3819346+01:00",
    "UpdatedAssociateId": 429,
    "Registered": "2004-11-27T16:48:30.3819346+01:00",
    "RegisteredAssociateId": 131,
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
        "FieldLength": 917
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
          "FieldLength": 453
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
          "FieldLength": 453
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
        "Reason": "mesh robust functionalities"
      },
      "FieldType": "System.Int32",
      "FieldLength": 985
    }
  }
}
```