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
GET /api/v1/Contact/{contactId}/Summary?limit=362
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
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": {
    "ContactId": 952,
    "Name": "Kuphal-Langworth",
    "OrgNr": "1344117",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "occaecati",
    "DirectPhone": "516.888.3437",
    "AssociateId": 168,
    "CountryId": 35,
    "EmailAddress": "laila@murphy.ca",
    "Kananame": "sapiente",
    "EmailAddressName": "roselyn_mccullough@jakubowskiconsidine.uk",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Dr. Douglas Jewess",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "natus",
    "FullName": "Mathilde Legros",
    "IsOwnerContact": true,
    "ActiveErpLinks": 527,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 82
      }
    }
  },
  "Tickets": [
    {
      "TicketId": 666,
      "TicketStatus": 918,
      "Title": "repudiandae",
      "Registered": "2004-07-06T15:05:41.9850035+02:00"
    },
    {
      "TicketId": 666,
      "TicketStatus": 918,
      "Title": "repudiandae",
      "Registered": "2004-07-06T15:05:41.9850035+02:00"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 184,
      "DocumentId": 53,
      "Date": "2008-09-09T15:05:41.9850035+02:00",
      "Description": "Public-key leading edge groupware",
      "Completed": "Completed",
      "Registered": "2012-03-20T15:05:41.9850035+01:00"
    },
    {
      "AppointmentId": 184,
      "DocumentId": 53,
      "Date": "2008-09-09T15:05:41.9850035+02:00",
      "Description": "Public-key leading edge groupware",
      "Completed": "Completed",
      "Registered": "2012-03-20T15:05:41.9850035+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 65,
      "DocumentId": 409,
      "Date": "2007-09-16T15:05:41.9850035+02:00",
      "Description": "Networked directional artificial intelligence",
      "Completed": "Completed",
      "Registered": "2020-01-10T15:05:41.9850035+01:00"
    },
    {
      "AppointmentId": 65,
      "DocumentId": 409,
      "Date": "2007-09-16T15:05:41.9850035+02:00",
      "Description": "Networked directional artificial intelligence",
      "Completed": "Completed",
      "Registered": "2020-01-10T15:05:41.9850035+01:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 892,
      "SaleDate": "2004-10-22T15:05:41.9850035+02:00",
      "Probability": 354,
      "Heading": "consectetur",
      "Amount": 29362.446,
      "Currency": "sed",
      "AmountInBaseCurrency": 31205.237999999998,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2011-02-05T15:05:41.9850035+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 769,
      "Name": "Orn, Littel and Kuhn",
      "CompanyName": "Emmerich-Wolf",
      "FirstMessage": "mollitia",
      "LastMessage": "tempore",
      "WhenRequested": "2004-06-16T15:05:41.9850035+02:00",
      "WhenEnded": "2011-12-16T15:05:41.9850035+01:00"
    }
  ]
}
```