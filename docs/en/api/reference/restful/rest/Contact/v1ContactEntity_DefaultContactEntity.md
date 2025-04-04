---
title: GET Contact/default
uid: v1ContactEntity_DefaultContactEntity
generated: true
---

# GET Contact/default

```http
GET /api/v1/Contact/default
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Contact agent service CreateDefaultContactEntity.







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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntity

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

## Sample request

```http!
GET /api/v1/Contact/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Fri, 03 Mar 2023 13:14:08 G3T

{
  "ContactId": 192,
  "Name": "Boehm-Lebsack",
  "Department": "",
  "OrgNr": "1108667",
  "Number1": "778861",
  "Number2": "608625",
  "UpdatedDate": "2023-03-03T13:14:08.5085+01:00",
  "CreatedDate": "2007-11-17T13:14:08.5085+01:00",
  "Emails": [
    {
      "Value": "velit",
      "StrippedValue": "totam",
      "Description": "Devolved maximized ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 999
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "totam",
      "Description": "Devolved maximized ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 999
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 716,
      "Name": "Baumbach LLC",
      "ToolTip": "Officia ducimus perspiciatis dolor.",
      "Deleted": true,
      "Rank": 281,
      "Type": "voluptas",
      "ColorBlock": 390,
      "IconHint": "ea",
      "Selected": false,
      "LastChanged": "2020-08-23T13:14:08.5085+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "similique",
      "StyleHint": "consequatur",
      "Hidden": false,
      "FullName": "Liliane Harvey",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 626
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "repellat",
      "StrippedValue": "voluptates",
      "Description": "Enhanced tangible interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 496
        }
      }
    },
    {
      "Value": "repellat",
      "StrippedValue": "voluptates",
      "Description": "Enhanced tangible interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 496
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "facilis",
      "StrippedValue": "aspernatur",
      "Description": "Fundamental discrete utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 73
        }
      }
    },
    {
      "Value": "facilis",
      "StrippedValue": "aspernatur",
      "Description": "Fundamental discrete utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 73
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "velit",
      "StrippedValue": "maxime",
      "Description": "Open-architected tangible process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 63
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "maxime",
      "Description": "Open-architected tangible process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 63
        }
      }
    }
  ],
  "Description": "Assimilated explicit success",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eum",
      "PersonId": 880,
      "Mrmrs": "aut",
      "Firstname": "Chelsey",
      "Lastname": "Green",
      "MiddleName": "Zemlak Group",
      "Title": "sint",
      "Description": "Cloned solution-oriented parallelism",
      "Email": "nikko@faheywalsh.com",
      "FullName": "Estelle Schamberger",
      "DirectPhone": "1-668-710-3714 x52581",
      "FormalName": "Abernathy LLC",
      "CountryId": 796,
      "ContactId": 961,
      "ContactName": "Wiegand-Prohaska",
      "Retired": 305,
      "Rank": 154,
      "ActiveInterests": 474,
      "ContactDepartment": "",
      "ContactCountryId": 174,
      "ContactOrgNr": "989523",
      "FaxPhone": "(456)829-4276 x0763",
      "MobilePhone": "433.639.9734",
      "ContactPhone": "293.459.2345 x169",
      "AssociateName": "Murazik, Jast and Altenwerth",
      "AssociateId": 903,
      "UsePersonAddress": false,
      "ContactFax": "facilis",
      "Kanafname": "beatae",
      "Kanalname": "et",
      "Post1": "inventore",
      "Post2": "laborum",
      "Post3": "suscipit",
      "EmailName": "alisha@schowalter.biz",
      "ContactFullName": "Percival Cassin",
      "ActiveErpLinks": 964,
      "TicketPriorityId": 439,
      "SupportLanguageId": 125,
      "SupportAssociateId": 364,
      "CategoryName": "VIP Customer",
      "PersonNumber": "265878",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 514
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "magni",
  "Xstop": false,
  "ActiveInterests": 502,
  "GroupId": 113,
  "ActiveStatusMonitorId": 493,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 407,
  "DbiAgentId": 790,
  "DbiLastSyncronized": "2019-04-14T13:14:08.5085+02:00",
  "DbiKey": "aut",
  "DbiLastModified": "2014-07-12T13:14:08.5085+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 385,
  "ActiveErpLinks": 485,
  "BounceEmails": [
    "jed@little.us",
    "destin_nitzsche@abshirekuhic.uk"
  ],
  "Domains": [
    "aut",
    "neque"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1303525204",
    "SuperOffice:2": "Keaton Walsh"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "dolorum"
  },
  "CustomFields": {
    "CustomFields1": "repellendus",
    "CustomFields2": "necessitatibus"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 660
    }
  }
}
```