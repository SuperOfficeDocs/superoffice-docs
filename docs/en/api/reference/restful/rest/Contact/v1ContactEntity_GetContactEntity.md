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
GET /api/v1/Contact/{id}?fk=False
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
Last-Modified: Wed, 07 Apr 2021 03:45:28 G4T

{
  "ContactId": 72,
  "Name": "VonRueden Inc and Sons",
  "Department": "innovate open-source supply-chains",
  "OrgNr": "1682826",
  "Number1": "749589",
  "Number2": "604097",
  "UpdatedDate": "2021-04-07T03:45:28.1859455+02:00",
  "CreatedDate": "2004-09-24T03:45:28.1859455+02:00",
  "Emails": [
    {
      "Value": "cum",
      "StrippedValue": "unde",
      "Description": "Right-sized tangible success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 329
        }
      }
    },
    {
      "Value": "cum",
      "StrippedValue": "unde",
      "Description": "Right-sized tangible success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 329
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 227,
      "Name": "Sporer Group",
      "ToolTip": "Tenetur qui molestias aliquid itaque ipsam suscipit qui.",
      "Deleted": false,
      "Rank": 879,
      "Type": "qui",
      "ColorBlock": 754,
      "IconHint": "dolor",
      "Selected": false,
      "LastChanged": "2020-03-14T03:45:28.1859455+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "deleniti",
      "StyleHint": "repellendus",
      "Hidden": false,
      "FullName": "Kenny Kshlerin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 254
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "rerum",
      "StrippedValue": "repellendus",
      "Description": "Expanded impactful protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 378
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "repellendus",
      "Description": "Expanded impactful protocol",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 378
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "inventore",
      "StrippedValue": "ex",
      "Description": "Down-sized interactive approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 20
        }
      }
    },
    {
      "Value": "inventore",
      "StrippedValue": "ex",
      "Description": "Down-sized interactive approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 20
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quia",
      "StrippedValue": "alias",
      "Description": "Down-sized real-time focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 38
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "alias",
      "Description": "Down-sized real-time focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 38
        }
      }
    }
  ],
  "Description": "Balanced explicit circuit",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quibusdam",
      "PersonId": 470,
      "Mrmrs": "cumque",
      "Firstname": "Davin",
      "Lastname": "Gutkowski",
      "MiddleName": "Nienow, Osinski and VonRueden",
      "Title": "deleniti",
      "Description": "De-engineered attitude-oriented open system",
      "Email": "elwyn.hills@breitenberg.uk",
      "FullName": "Dr. Annamarie Kertzmann Sr.",
      "DirectPhone": "(593)237-9743 x260",
      "FormalName": "Prohaska-Kemmer",
      "CountryId": 230,
      "ContactId": 85,
      "ContactName": "Prohaska Inc and Sons",
      "Retired": 631,
      "Rank": 516,
      "ActiveInterests": 852,
      "ContactDepartment": "",
      "ContactCountryId": 197,
      "ContactOrgNr": "1621253",
      "FaxPhone": "089.335.0871",
      "MobilePhone": "1-929-829-8071",
      "ContactPhone": "219.672.3347",
      "AssociateName": "Hodkiewicz, Miller and VonRueden",
      "AssociateId": 43,
      "UsePersonAddress": true,
      "ContactFax": "in",
      "Kanafname": "molestiae",
      "Kanalname": "sit",
      "Post1": "quam",
      "Post2": "sit",
      "Post3": "eos",
      "EmailName": "ludwig_little@ullrich.us",
      "ContactFullName": "Gene Heller",
      "ActiveErpLinks": 217,
      "TicketPriorityId": 897,
      "SupportLanguageId": 323,
      "SupportAssociateId": 917,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1725591",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 542
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptas",
  "Xstop": false,
  "ActiveInterests": 961,
  "GroupId": 585,
  "ActiveStatusMonitorId": 974,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 980,
  "DbiAgentId": 410,
  "DbiLastSyncronized": "2006-04-05T03:45:28.1859455+02:00",
  "DbiKey": "voluptatum",
  "DbiLastModified": "2003-10-12T03:45:28.1859455+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 257,
  "ActiveErpLinks": 267,
  "BounceEmails": [
    "orlo@hand.info",
    "alanis@lyncherdman.ca"
  ],
  "Domains": [
    "possimus",
    "labore"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Vito Upton",
    "SuperOffice:2": "Daniela Schuppe"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptate",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "perferendis",
    "CustomFields2": "laborum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 154
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```