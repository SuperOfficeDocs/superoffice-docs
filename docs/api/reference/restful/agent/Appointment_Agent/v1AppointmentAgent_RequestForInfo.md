---
title: POST Agents/Appointment/RequestForInfo
id: v1AppointmentAgent_RequestForInfo
---

# POST Agents/Appointment/RequestForInfo

```http
POST /api/v1/Agents/Appointment/RequestForInfo
```

Submits a request for information.

The request is added to the task list of the user that is responsible for this contact. Based on wether the person the request is made for is found or not, the following happens: If the person is found, the person, person's contact and sales representative is returned. If neither the person nor the contact is found a new person and contact is created (if sufficient data is supplied), and the person, person's contact and sales representative is returned. If the contact and not the person is found a new person is created on this contact, and the contact, salesrep, and person is returned (if there was enough data to return the person). If more than one contact is found a list of contacts is returned.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Appointment/RequestForInfo?$select=name,department,category/id
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

AssociateIdForNewContact, Channel, Regarding, ContactName, PersonFirstname, PersonLastname, EmailAddress, PhoneNumber 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateIdForNewContact | int32 |  |
| Channel | string |  |
| Regarding | string |  |
| ContactName | string |  |
| PersonFirstname | string |  |
| PersonLastname | string |  |
| EmailAddress | string |  |
| PhoneNumber | string |  |


## Response: object

Carrier object for SalesActivity.
Services for the SalesActivity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| RequestedContacts | array | The companies that match the request |
| RequestedPerson |  | The person that matches the request. |
| SalesRep |  | The sales representative for the person that matches the request. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Appointment/RequestForInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "AssociateIdForNewContact": 308,
  "Channel": "ut",
  "Regarding": "rerum",
  "ContactName": "Larkin-Bode",
  "PersonFirstname": "Dylan",
  "PersonLastname": "Hyatt",
  "EmailAddress": "roy@mosciskigerlach.biz",
  "PhoneNumber": "999224"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RequestedContacts": [
    {
      "ContactId": 495,
      "Name": "Kulas, Fritsch and Ziemann",
      "OrgNr": "392436",
      "Department": "",
      "URL": "http://www.example.com/",
      "City": "debitis",
      "DirectPhone": "1-260-867-5172 x886",
      "AssociateId": 774,
      "CountryId": 299,
      "EmailAddress": "sincere@leuschke.co.uk",
      "Kananame": "sit",
      "EmailAddressName": "mckayla_lebsack@danielcollins.co.uk",
      "URLName": "http://www.example.com/",
      "AssociateFullName": "Dr. Timmy Kozey",
      "BusinessName": "Information Technology",
      "CategoryName": "VIP Customer",
      "CountryName": "Sokovia",
      "Address": {},
      "FormattedAddress": "enim",
      "FullName": "Lane Champlin",
      "IsOwnerContact": true,
      "ActiveErpLinks": 465,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 720
        }
      }
    }
  ],
  "RequestedPerson": {
    "Position": "optio",
    "PersonId": 810,
    "Mrmrs": "rerum",
    "Firstname": "Rylee",
    "Lastname": "Bogan",
    "MiddleName": "Fadel, Boyer and Abernathy",
    "Title": "maiores",
    "Description": "Universal bandwidth-monitored protocol",
    "Email": "chaya_williamson@sporer.ca",
    "FullName": "Una Ondricka",
    "DirectPhone": "(514)584-7564",
    "FormalName": "VonRueden Inc and Sons",
    "CountryId": 704,
    "ContactId": 381,
    "ContactName": "Wolf Inc and Sons",
    "Retired": 674,
    "Rank": 4,
    "ActiveInterests": 622,
    "ContactDepartment": "",
    "ContactCountryId": 342,
    "ContactOrgNr": "693888",
    "FaxPhone": "1-575-718-3458 x45042",
    "MobilePhone": "866-051-3151",
    "ContactPhone": "(556)675-0788",
    "AssociateName": "Hessel, Greenholt and Kunde",
    "AssociateId": 607,
    "UsePersonAddress": true,
    "ContactFax": "excepturi",
    "Kanafname": "nemo",
    "Kanalname": "nihil",
    "Post1": "non",
    "Post2": "doloribus",
    "Post3": "labore",
    "EmailName": "horacio@dickiweimann.biz",
    "ContactFullName": "Solon Thiel",
    "ActiveErpLinks": 208,
    "TicketPriorityId": 726,
    "SupportLanguageId": 37,
    "SupportAssociateId": 922,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 36
      }
    }
  },
  "SalesRep": {
    "Position": "eum",
    "PersonId": 545,
    "Mrmrs": "quasi",
    "Firstname": "Alva",
    "Lastname": "Murray",
    "MiddleName": "Toy Inc and Sons",
    "Title": "dolore",
    "Description": "Stand-alone background protocol",
    "Email": "ronny.langworth@paucekjohnson.biz",
    "FullName": "Meredith Dicki",
    "DirectPhone": "723.531.8353",
    "FormalName": "Johnston LLC",
    "CountryId": 850,
    "ContactId": 872,
    "ContactName": "Marquardt Group",
    "Retired": 648,
    "Rank": 57,
    "ActiveInterests": 93,
    "ContactDepartment": "",
    "ContactCountryId": 409,
    "ContactOrgNr": "388797",
    "FaxPhone": "638-673-7770 x44508",
    "MobilePhone": "115.815.7308 x0107",
    "ContactPhone": "(224)343-7574 x40740",
    "AssociateName": "Little Inc and Sons",
    "AssociateId": 317,
    "UsePersonAddress": false,
    "ContactFax": "esse",
    "Kanafname": "nihil",
    "Kanalname": "provident",
    "Post1": "rerum",
    "Post2": "veniam",
    "Post3": "facere",
    "EmailName": "buford.farrell@quigley.us",
    "ContactFullName": "Karson Sipes",
    "ActiveErpLinks": 366,
    "TicketPriorityId": 591,
    "SupportLanguageId": 641,
    "SupportAssociateId": 975,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 517
      }
    }
  },
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
      "FieldLength": 859
    }
  }
}
```