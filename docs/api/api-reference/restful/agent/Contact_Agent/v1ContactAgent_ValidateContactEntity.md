---
title: POST Agents/Contact/ValidateContactEntity
id: v1ContactAgent_ValidateContactEntity
---

# POST Agents/Contact/ValidateContactEntity

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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": {
    "ContactId": 192,
    "Name": "Wilderman LLC",
    "Department": "",
    "OrgNr": "568847",
    "Number1": "1389637",
    "Number2": "1463787",
    "UpdatedDate": "2008-12-30T16:48:29.1958946+01:00",
    "CreatedDate": "2005-11-25T16:48:29.1958946+01:00",
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
    "Description": "Cross-group directional complexity",
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
    "NoMailing": false,
    "Kananame": "aliquid",
    "Xstop": false,
    "ActiveInterests": 576,
    "GroupId": 8,
    "ActiveStatusMonitorId": 525,
    "SupportAssociate": {},
    "TicketPriority": {},
    "CustomerLanguage": {},
    "Deleted": 554,
    "DbiAgentId": 230,
    "DbiLastSyncronized": "1997-08-05T16:48:29.1968947+02:00",
    "DbiKey": "dolores",
    "DbiLastModified": "2016-07-14T16:48:29.1968947+02:00",
    "SupportPerson": {},
    "Address": {},
    "Source": 440,
    "ActiveErpLinks": 801,
    "BounceEmails": [
      "deanna_abernathy@feestbode.co.uk",
      "willow.brown@hickle.name"
    ],
    "UserDefinedFields": {
      "SuperOffice:1": "381954160",
      "SuperOffice:2": "Mr. Zelma Bailey"
    },
    "ExtraFields": {
      "ExtraFields1": "quos",
      "ExtraFields2": "magni"
    },
    "CustomFields": {
      "CustomFields1": "non",
      "CustomFields2": "laboriosam"
    }
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "aut",
  "2": "delectus"
}
```