---
title: ValidateContactEntity
id: v1ContactAgent_ValidateContactEntity
---

# ValidateContactEntity

```http
POST /api/v1/Agents/Contact/ValidateContactEntity
```

Check that entity is ready for saving, return error messages by field.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/ValidateContactEntity?$select=name,department,category/id
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

ContactEntity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactEntity |  | The Contact Service. The service implements all services working with the Contact object <para /> Carrier object for ContactEntity. Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object


## Sample Request

```http!
POST /api/v1/Agents/Contact/ValidateContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": {
    "ContactId": 849,
    "Name": "Johns-Corkery",
    "Department": "",
    "OrgNr": "793205",
    "Number1": "861928",
    "Number2": "603632",
    "UpdatedDate": "2012-10-09T14:58:03.7254597+02:00",
    "CreatedDate": "1995-07-31T14:58:03.7254597+02:00",
    "Emails": [
      {},
      {}
    ],
    "Interests": [
      {},
      {}
    ],
    "Urls": [
      {},
      {}
    ],
    "Phones": [
      {},
      {}
    ],
    "Faxes": [
      {},
      {}
    ],
    "Description": "Progressive secondary capability",
    "UpdatedBy": {},
    "CreatedBy": {},
    "Associate": {},
    "Business": {},
    "Category": {},
    "Country": {},
    "Persons": [
      {},
      {}
    ],
    "NoMailing": true,
    "Kananame": "ut",
    "Xstop": false,
    "ActiveInterests": 253,
    "GroupId": 740,
    "ActiveStatusMonitorId": 556,
    "SupportAssociate": {},
    "TicketPriority": {},
    "CustomerLanguage": {},
    "Deleted": 768,
    "DbiAgentId": 61,
    "DbiLastSyncronized": "2011-01-20T14:58:03.7254597+01:00",
    "DbiKey": "qui",
    "DbiLastModified": "1995-11-20T14:58:03.7254597+01:00",
    "SupportPerson": {},
    "Address": {},
    "Source": 764,
    "ActiveErpLinks": 117,
    "BounceEmails": [
      "valentina.wintheiser@larsonweber.us",
      "shemar_kuhic@mckenzie.us"
    ],
    "UserDefinedFields": {
      "SuperOffice:1": "Nina Batz",
      "SuperOffice:2": "Berneice Beier"
    },
    "ExtraFields": {
      "ExtraFields1": "sunt",
      "ExtraFields2": "consequatur"
    },
    "CustomFields": {
      "CustomFields1": "corrupti",
      "CustomFields2": "recusandae"
    }
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "et",
  "2": "et"
}
```