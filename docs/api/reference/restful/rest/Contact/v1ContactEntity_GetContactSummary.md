---
title: GET Contact/{id}/Summary
id: v1ContactEntity_GetContactSummary
---

# GET Contact/{id}/Summary

```http
GET /api/v1/Contact/{contactId}/Summary
```

Get summary of contact and its recent activity.






| Path Part | Type | Description |
|-----------|------|-------------|
| contactId | int32 | The contact id to summarize. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| limit | int32 |  Max number of items to include in summary lists. |

```http
GET /api/v1/Contact/{contactId}/Summary?limit=762
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: object

Summary of contact with recent activities, chats, and requests included.



Carrier object for ContactSummary.
Services for the ContactSummary Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Contact |  | Simple Contact data. |
| Tickets | array | Recent tickets on contact |
| Followups | array | Recent follow-ups on contact |
| Documents | array | Recent documents on contact |
| Sales | array | Recent sales on contact |
| Chats | array | Recent chats with contact |

## Sample Request

```http!
GET /api/v1/Contact/{contactId}/Summary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": {
    "ContactId": 559,
    "Name": "Towne-Bradtke",
    "OrgNr": "1166219",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "doloribus",
    "DirectPhone": "1-437-784-3317",
    "AssociateId": 38,
    "CountryId": 582,
    "EmailAddress": "betty@ward.co.uk",
    "Kananame": "enim",
    "EmailAddressName": "marty_donnelly@botsford.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Roslyn Romaguera",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "magnam",
    "FullName": "Haskell Jenkins",
    "IsOwnerContact": true,
    "ActiveErpLinks": 443,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 6
      }
    }
  },
  "Tickets": [
    {
      "TicketId": 578,
      "TicketStatus": 978,
      "Title": "est",
      "Registered": "2014-06-25T18:25:50.3655947+02:00"
    },
    {
      "TicketId": 578,
      "TicketStatus": 978,
      "Title": "est",
      "Registered": "2014-06-25T18:25:50.3655947+02:00"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 311,
      "DocumentId": 672,
      "Date": "2021-10-16T18:25:50.3655947+02:00",
      "Description": "Networked bottom-line ability",
      "Completed": "Completed",
      "Registered": "2001-09-28T18:25:50.3655947+02:00"
    },
    {
      "AppointmentId": 311,
      "DocumentId": 672,
      "Date": "2021-10-16T18:25:50.3655947+02:00",
      "Description": "Networked bottom-line ability",
      "Completed": "Completed",
      "Registered": "2001-09-28T18:25:50.3655947+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 127,
      "DocumentId": 637,
      "Date": "2018-03-13T18:25:50.3655947+01:00",
      "Description": "Integrated client-driven local area network",
      "Completed": "Completed",
      "Registered": "2007-02-23T18:25:50.3655947+01:00"
    },
    {
      "AppointmentId": 127,
      "DocumentId": 637,
      "Date": "2018-03-13T18:25:50.3655947+01:00",
      "Description": "Integrated client-driven local area network",
      "Completed": "Completed",
      "Registered": "2007-02-23T18:25:50.3655947+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 189,
      "SaleDate": "1999-04-15T18:25:50.3655947+02:00",
      "Probability": 737,
      "Heading": "cupiditate",
      "Amount": 16143.234,
      "Currency": "ea",
      "AmountInBaseCurrency": 18033.036,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "1997-04-04T18:25:50.3655947+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 686,
      "Name": "Erdman Group",
      "CompanyName": "Wolff LLC",
      "FirstMessage": "ad",
      "LastMessage": "animi",
      "WhenRequested": "2002-11-03T18:25:50.3655947+01:00",
      "WhenEnded": "2008-10-16T18:25:50.3655947+02:00"
    }
  ]
}
```