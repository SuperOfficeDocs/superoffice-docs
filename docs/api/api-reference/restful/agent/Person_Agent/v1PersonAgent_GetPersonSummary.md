---
title: GetPersonSummary
id: v1PersonAgent_GetPersonSummary
---

# GetPersonSummary

```http
POST /api/v1/Agents/Person/GetPersonSummary
```

Get summary of person and recent activity.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Person/GetPersonSummary?$select=name,department,category/id
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

PersonId, Limit 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 |  |
| Limit | int32 |  |


## Response: object

Summary of person, with recent activities, chats, and requests included.



Carrier object for PersonSummary.
Services for the PersonSummary Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| Person |  | Simple Person data. |
| Tickets | array | Recent tickets on person |
| Followups | array | Recent follow-ups on person |
| Documents | array | Recent documents on person |
| Sales | array | Recent sales on person |
| Chats | array | Recent chats with person |

## Sample Request

```http!
POST /api/v1/Agents/Person/GetPersonSummary
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 271,
  "Limit": 132
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Person": {
    "Position": "autem",
    "PersonId": 553,
    "Mrmrs": "non",
    "Firstname": "Elnora",
    "Lastname": "Herman",
    "MiddleName": "Franecki Inc and Sons",
    "Title": "nemo",
    "Description": "Multi-channelled holistic migration",
    "Email": "antwan@hermistonboehm.info",
    "FullName": "Liliane Cassin V",
    "DirectPhone": "(507)318-2443 x00343",
    "FormalName": "Jaskolski, Mohr and Von",
    "CountryId": 544,
    "ContactId": 788,
    "ContactName": "Donnelly Group",
    "Retired": 139,
    "Rank": 493,
    "ActiveInterests": 807,
    "ContactDepartment": "",
    "ContactCountryId": 205,
    "ContactOrgNr": "368214",
    "FaxPhone": "736-247-0488 x823",
    "MobilePhone": "276.060.1005 x87261",
    "ContactPhone": "(221)520-7025 x435",
    "AssociateName": "Bode, Williamson and McGlynn",
    "AssociateId": 147,
    "UsePersonAddress": true,
    "ContactFax": "sed",
    "Kanafname": "molestiae",
    "Kanalname": "numquam",
    "Post1": "ut",
    "Post2": "ex",
    "Post3": "deserunt",
    "EmailName": "garrick@reillymueller.co.uk",
    "ContactFullName": "Michele Frami",
    "ActiveErpLinks": 17,
    "TicketPriorityId": 633,
    "SupportLanguageId": 853,
    "SupportAssociateId": 213,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 281
      }
    }
  },
  "Tickets": [
    {
      "TicketId": 523,
      "TicketStatus": 943,
      "Title": "fugit",
      "Registered": "2009-10-22T14:58:04.5814657+02:00"
    },
    {
      "TicketId": 523,
      "TicketStatus": 943,
      "Title": "fugit",
      "Registered": "2009-10-22T14:58:04.5814657+02:00"
    }
  ],
  "Followups": [
    {
      "AppointmentId": 180,
      "DocumentId": 364,
      "Date": "2017-02-01T14:58:04.5814657+01:00",
      "Description": "Total actuating hardware",
      "Completed": "Completed",
      "Registered": "2001-05-22T14:58:04.5814657+02:00"
    },
    {
      "AppointmentId": 180,
      "DocumentId": 364,
      "Date": "2017-02-01T14:58:04.5814657+01:00",
      "Description": "Total actuating hardware",
      "Completed": "Completed",
      "Registered": "2001-05-22T14:58:04.5814657+02:00"
    }
  ],
  "Documents": [
    {
      "AppointmentId": 761,
      "DocumentId": 745,
      "Date": "2004-06-25T14:58:04.5814657+02:00",
      "Description": "Versatile background algorithm",
      "Completed": "Completed",
      "Registered": "2019-08-03T14:58:04.5814657+02:00"
    },
    {
      "AppointmentId": 761,
      "DocumentId": 745,
      "Date": "2004-06-25T14:58:04.5814657+02:00",
      "Description": "Versatile background algorithm",
      "Completed": "Completed",
      "Registered": "2019-08-03T14:58:04.5814657+02:00"
    }
  ],
  "Sales": [
    {
      "SaleId": 458,
      "SaleDate": "1995-11-06T14:58:04.5814657+01:00",
      "Probability": 896,
      "Heading": "asperiores",
      "Amount": 29475.27,
      "Currency": "et",
      "AmountInBaseCurrency": 6738.0999999999995,
      "Status": "Lost",
      "Completed": "Completed",
      "Registered": "2016-05-30T14:58:04.5814657+02:00"
    }
  ],
  "Chats": [
    {
      "ChatSessionId": 989,
      "Name": "Jenkins-Hermann",
      "CompanyName": "Wuckert-Donnelly",
      "FirstMessage": "iste",
      "LastMessage": "a",
      "WhenRequested": "2014-07-04T14:58:04.5814657+02:00",
      "WhenEnded": "2017-05-16T14:58:04.5814657+02:00"
    }
  ]
}
```