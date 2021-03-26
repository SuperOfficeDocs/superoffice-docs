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
GET /api/v1/Contact/{contactId}/Summary?limit=480
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
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": {
    "ContactId": 830,
    "Name": "Bernier LLC",
    "OrgNr": "790946",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "quis",
    "DirectPhone": "1-721-850-0337 x4810",
    "AssociateId": 110,
    "CountryId": 576,
    "EmailAddress": "andy.johnston@koepp.name",
    "Kananame": "possimus",
    "EmailAddressName": "nedra@bayer.ca",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Kristofer Jewess",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "reprehenderit",
    "FullName": "Estelle Dare",
    "IsOwnerContact": true,
    "ActiveErpLinks": 563,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 18
      }
    }
  },
  "Tickets": [
    {
      "TicketId": 367,
      "TicketStatus": 13,
      "Title": "necessitatibus",
      "Registered": "2020-03-30T09:40:58.9903704+02:00"
    },
    {
      "TicketId": 367,
      "TicketStatus": 13,
      "Title": "necessitatibus",
      "Registered": "2020-03-30T09:40:58.9903704+02:00"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 950,
      "DocumentId": 829,
      "Date": "2011-07-29T09:40:58.9903704+02:00",
      "Description": "Enterprise-wide transitional toolset",
      "Completed": "Completed",
      "Registered": "2013-09-07T09:40:58.9903704+02:00"
    },
    {
      "AppointmentId": 950,
      "DocumentId": 829,
      "Date": "2011-07-29T09:40:58.9903704+02:00",
      "Description": "Enterprise-wide transitional toolset",
      "Completed": "Completed",
      "Registered": "2013-09-07T09:40:58.9903704+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 595,
      "DocumentId": 630,
      "Date": "2010-11-04T09:40:58.9903704+01:00",
      "Description": "Robust non-volatile application",
      "Completed": "Completed",
      "Registered": "2003-08-26T09:40:58.9903704+02:00"
    },
    {
      "AppointmentId": 595,
      "DocumentId": 630,
      "Date": "2010-11-04T09:40:58.9903704+01:00",
      "Description": "Robust non-volatile application",
      "Completed": "Completed",
      "Registered": "2003-08-26T09:40:58.9903704+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 527,
      "SaleDate": "2016-11-19T09:40:58.9903704+01:00",
      "Probability": 517,
      "Heading": "dolorem",
      "Amount": 2757.92,
      "Currency": "laudantium",
      "AmountInBaseCurrency": 15767.153999999999,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2006-12-01T09:40:58.9903704+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 741,
      "Name": "Rice Inc and Sons",
      "CompanyName": "Sanford Group",
      "FirstMessage": "inventore",
      "LastMessage": "excepturi",
      "WhenRequested": "2018-12-29T09:40:58.9903704+01:00",
      "WhenEnded": "2018-02-22T09:40:58.9903704+01:00"
    }
  ]
}
```