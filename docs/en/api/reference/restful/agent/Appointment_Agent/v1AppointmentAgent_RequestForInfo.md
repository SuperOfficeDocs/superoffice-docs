---
title: POST Agents/Appointment/RequestForInfo
uid: v1AppointmentAgent_RequestForInfo
generated: true
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
| AssociateIdForNewContact | Integer |  |
| Channel | String |  |
| Regarding | String |  |
| ContactName | String |  |
| PersonFirstname | String |  |
| PersonLastname | String |  |
| EmailAddress | String |  |
| PhoneNumber | String |  |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: SalesActivity

| Property Name | Type |  Description |
|----------------|------|--------------|
| RequestedContacts | array | The companies that match the request |
| RequestedPerson | Person | The person that matches the request. |
| SalesRep | Person | The sales representative for the person that matches the request. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Appointment/RequestForInfo
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateIdForNewContact": 44,
  "Channel": "cumque",
  "Regarding": "veniam",
  "ContactName": "Haag, Okuneva and Roberts",
  "PersonFirstname": "Josianne",
  "PersonLastname": "Cole",
  "EmailAddress": "brice@fadelthompson.info",
  "PhoneNumber": "464091"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "RequestedContacts": [
    {
      "ContactId": 150,
      "Name": "Prosacco, Brakus and Brakus",
      "OrgNr": "707421",
      "Department": "",
      "URL": "http://www.example.com/",
      "City": "vitae",
      "DirectPhone": "804.037.6386",
      "AssociateId": 190,
      "CountryId": 808,
      "EmailAddress": "ardella_wilderman@stehr.name",
      "Kananame": "odit",
      "EmailAddressName": "xzavier@stroman.uk",
      "URLName": "http://www.example.com/",
      "AssociateFullName": "Rick Cole",
      "BusinessName": "Information Technology",
      "CategoryName": "VIP Customer",
      "CountryName": "Sokovia",
      "Address": null,
      "FormattedAddress": "odit",
      "FullName": "Celia Koelpin",
      "IsOwnerContact": true,
      "ActiveErpLinks": 629,
      "Number1": "920311",
      "Number2": "296318",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 86
        }
      }
    }
  ],
  "RequestedPerson": null,
  "SalesRep": null,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 395
    }
  }
}
```