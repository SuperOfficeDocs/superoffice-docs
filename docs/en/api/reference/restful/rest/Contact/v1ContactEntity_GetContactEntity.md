---
title: GET Contact/{id}
uid: v1ContactEntity_GetContactEntity
generated: true
---

# GET Contact/{id}

```http
GET /api/v1/Contact/{id}
```

Gets a ContactEntity object.


Calls the Contact agent service GetContactEntity.





| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the ContactEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |
| fk | bool |  Load foreign keys on this entity into the ExtraFields property as 'app.device.keyname'='123' pairs. |

```http
GET /api/v1/Contact/{id}?$select=name,department,category/id
GET /api/v1/Contact/{id}?fk=True
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


## Response:

ContactEntity found.

| Response | Description |
|----------------|-------------|
| 200 | ContactEntity found. |
| 304 | ContactEntity has not changed since the requested If-Modified-Since date. |
| 404 | Not Found. |

### Response body: ContactEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Contact/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 ContactEntity found.
Content-Type: application/json; charset=utf-8
Last-Modified: Wed, 29 Oct 2014 14:13:48 G10T

{
  "ContactId": 948,
  "Name": "Sipes-Heidenreich",
  "Department": "",
  "OrgNr": "1085071",
  "Number1": "501629",
  "Number2": "1537599",
  "UpdatedDate": "2014-10-29T14:13:48.5226646+01:00",
  "CreatedDate": "2012-01-03T14:13:48.5226646+01:00",
  "Emails": [
    {
      "Value": "voluptatum",
      "StrippedValue": "ad",
      "Description": "Progressive directional Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 511
        }
      }
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "ad",
      "Description": "Progressive directional Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 511
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 796,
      "Name": "Denesik Inc and Sons",
      "ToolTip": "Quam voluptas animi id quas pariatur rem et.",
      "Deleted": true,
      "Rank": 948,
      "Type": "delectus",
      "ColorBlock": 63,
      "IconHint": "quis",
      "Selected": true,
      "LastChanged": "2009-06-07T14:13:48.5226646+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "assumenda",
      "StyleHint": "sit",
      "Hidden": false,
      "FullName": "Melba Heber Beahan III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 307
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sed",
      "StrippedValue": "facere",
      "Description": "Polarised uniform matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 767
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "facere",
      "Description": "Polarised uniform matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 767
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "numquam",
      "StrippedValue": "fuga",
      "Description": "Switchable 24/7 parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 858
        }
      }
    },
    {
      "Value": "numquam",
      "StrippedValue": "fuga",
      "Description": "Switchable 24/7 parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 858
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolorem",
      "StrippedValue": "maiores",
      "Description": "Team-oriented needs-based definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 350
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "maiores",
      "Description": "Team-oriented needs-based definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 350
        }
      }
    }
  ],
  "Description": "Fundamental disintermediate policy",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quaerat",
      "PersonId": 964,
      "Mrmrs": "quia",
      "Firstname": "Adela",
      "Lastname": "Windler",
      "MiddleName": "Kassulke Inc and Sons",
      "Title": "facilis",
      "Description": "Devolved leading edge infrastructure",
      "Email": "lionel.jast@lowe.us",
      "FullName": "Ms. Leon Anastacio Stokes PhD",
      "DirectPhone": "1-021-139-7221",
      "FormalName": "Bartoletti-Jakubowski",
      "CountryId": 234,
      "ContactId": 782,
      "ContactName": "Conroy, Cummerata and Ankunding",
      "Retired": 265,
      "Rank": 805,
      "ActiveInterests": 243,
      "ContactDepartment": "",
      "ContactCountryId": 23,
      "ContactOrgNr": "1164829",
      "FaxPhone": "359.709.1665 x221",
      "MobilePhone": "205-488-1628 x4538",
      "ContactPhone": "903.963.8025 x1914",
      "AssociateName": "Armstrong, Williamson and Zemlak",
      "AssociateId": 475,
      "UsePersonAddress": true,
      "ContactFax": "veritatis",
      "Kanafname": "possimus",
      "Kanalname": "in",
      "Post1": "est",
      "Post2": "quia",
      "Post3": "totam",
      "EmailName": "norbert@haagbotsford.com",
      "ContactFullName": "Jacklyn Schaden",
      "ActiveErpLinks": 909,
      "TicketPriorityId": 401,
      "SupportLanguageId": 97,
      "SupportAssociateId": 964,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1095908",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 1000
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "ipsa",
  "Xstop": false,
  "ActiveInterests": 457,
  "GroupId": 84,
  "ActiveStatusMonitorId": 796,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 392,
  "DbiAgentId": 922,
  "DbiLastSyncronized": "1999-01-30T14:13:48.5226646+01:00",
  "DbiKey": "omnis",
  "DbiLastModified": "2000-05-04T14:13:48.5226646+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 279,
  "ActiveErpLinks": 764,
  "BounceEmails": [
    "scottie.connelly@oconner.info",
    "vivian@harris.info"
  ],
  "Domains": [
    "dolorum",
    "deleniti"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Susie Jedediah Bednar",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "enim",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "magnam",
    "CustomFields2": "voluptates"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 338
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```