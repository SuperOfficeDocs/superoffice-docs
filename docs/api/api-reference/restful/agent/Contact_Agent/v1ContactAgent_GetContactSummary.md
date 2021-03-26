---
title: POST Agents/Contact/GetContactSummary
id: v1ContactAgent_GetContactSummary
---

# POST Agents/Contact/GetContactSummary

```http
POST /api/v1/Agents/Contact/GetContactSummary
```

Get summary of contact and its recent activity.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactSummary?$select=name,department,category/id
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

ContactId, Limit 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 |  |
| Limit | int32 |  |


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
POST /api/v1/Agents/Contact/GetContactSummary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 578,
  "Limit": 681
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Contact": {
    "ContactId": 464,
    "Name": "West-Pfannerstill",
    "OrgNr": "706638",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "modi",
    "DirectPhone": "1-746-525-7653",
    "AssociateId": 158,
    "CountryId": 434,
    "EmailAddress": "chasity@westpurdy.name",
    "Kananame": "distinctio",
    "EmailAddressName": "johann_effertz@durgan.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ms. Luis Schaden",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "nisi",
    "FullName": "Christy Maggio",
    "IsOwnerContact": false,
    "ActiveErpLinks": 442,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 712
      }
    }
  },
  "Tickets": [
    {
      "TicketId": 570,
      "TicketStatus": 191,
      "Title": "aliquid",
      "Registered": "2000-03-23T16:48:29.1958946+01:00"
    },
    {
      "TicketId": 570,
      "TicketStatus": 191,
      "Title": "aliquid",
      "Registered": "2000-03-23T16:48:29.1958946+01:00"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 308,
      "DocumentId": 665,
      "Date": "2010-07-20T16:48:29.1958946+02:00",
      "Description": "Integrated composite knowledge base",
      "Completed": "Completed",
      "Registered": "2011-01-10T16:48:29.1958946+01:00"
    },
    {
      "AppointmentId": 308,
      "DocumentId": 665,
      "Date": "2010-07-20T16:48:29.1958946+02:00",
      "Description": "Integrated composite knowledge base",
      "Completed": "Completed",
      "Registered": "2011-01-10T16:48:29.1958946+01:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 997,
      "DocumentId": 549,
      "Date": "2005-10-12T16:48:29.1958946+02:00",
      "Description": "Cloned even-keeled synergy",
      "Completed": "Completed",
      "Registered": "2015-10-11T16:48:29.1958946+02:00"
    },
    {
      "AppointmentId": 997,
      "DocumentId": 549,
      "Date": "2005-10-12T16:48:29.1958946+02:00",
      "Description": "Cloned even-keeled synergy",
      "Completed": "Completed",
      "Registered": "2015-10-11T16:48:29.1958946+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 692,
      "SaleDate": "2011-01-21T16:48:29.1958946+01:00",
      "Probability": 386,
      "Heading": "quia",
      "Amount": 6048.62,
      "Currency": "amet",
      "AmountInBaseCurrency": 13701.848,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2020-11-07T16:48:29.1958946+01:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 800,
      "Name": "Bailey, Anderson and Steuber",
      "CompanyName": "McGlynn-Klocko",
      "FirstMessage": "magnam",
      "LastMessage": "corrupti",
      "WhenRequested": "2003-01-23T16:48:29.1958946+01:00",
      "WhenEnded": "2004-11-11T16:48:29.1958946+01:00"
    }
  ]
}
```