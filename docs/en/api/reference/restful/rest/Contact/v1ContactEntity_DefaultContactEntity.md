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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Wed, 25 Apr 2007 16:32:47 G4T

{
  "ContactId": 524,
  "Name": "Emard, Mann and Kuphal",
  "Department": "",
  "OrgNr": "1249018",
  "Number1": "151979",
  "Number2": "666025",
  "UpdatedDate": "2007-04-25T16:32:47.2902636+02:00",
  "CreatedDate": "2006-07-10T16:32:47.2902636+02:00",
  "Emails": [
    {
      "Value": "fugit",
      "StrippedValue": "occaecati",
      "Description": "Mandatory dynamic framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 353
        }
      }
    },
    {
      "Value": "fugit",
      "StrippedValue": "occaecati",
      "Description": "Mandatory dynamic framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 353
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 433,
      "Name": "Braun Inc and Sons",
      "ToolTip": "Amet consectetur et et dolorem.",
      "Deleted": false,
      "Rank": 610,
      "Type": "sit",
      "ColorBlock": 62,
      "IconHint": "neque",
      "Selected": false,
      "LastChanged": "2018-02-13T16:32:47.2902636+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "commodi",
      "Hidden": false,
      "FullName": "Rosalyn Chelsea Bernhard DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 766
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ab",
      "StrippedValue": "officiis",
      "Description": "Reverse-engineered homogeneous analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 84
        }
      }
    },
    {
      "Value": "ab",
      "StrippedValue": "officiis",
      "Description": "Reverse-engineered homogeneous analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 84
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "saepe",
      "StrippedValue": "hic",
      "Description": "Synergistic non-volatile superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 82
        }
      }
    },
    {
      "Value": "saepe",
      "StrippedValue": "hic",
      "Description": "Synergistic non-volatile superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 82
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aliquid",
      "StrippedValue": "ut",
      "Description": "Centralized reciprocal internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 612
        }
      }
    },
    {
      "Value": "aliquid",
      "StrippedValue": "ut",
      "Description": "Centralized reciprocal internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 612
        }
      }
    }
  ],
  "Description": "Self-enabling holistic concept",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "facilis",
      "PersonId": 671,
      "Mrmrs": "nam",
      "Firstname": "Paige",
      "Lastname": "Friesen",
      "MiddleName": "Pfeffer-Hodkiewicz",
      "Title": "non",
      "Description": "Upgradable empowering synergy",
      "Email": "margarette.bernier@schamberger.uk",
      "FullName": "Miss Willard Maryse Moore",
      "DirectPhone": "1-320-703-6829 x86884",
      "FormalName": "Blanda LLC",
      "CountryId": 453,
      "ContactId": 177,
      "ContactName": "Wiegand-Gottlieb",
      "Retired": 263,
      "Rank": 46,
      "ActiveInterests": 721,
      "ContactDepartment": "",
      "ContactCountryId": 260,
      "ContactOrgNr": "1053516",
      "FaxPhone": "(534)438-9391",
      "MobilePhone": "300-513-0684 x64352",
      "ContactPhone": "995.961.3126",
      "AssociateName": "Hudson Inc and Sons",
      "AssociateId": 723,
      "UsePersonAddress": true,
      "ContactFax": "nulla",
      "Kanafname": "laborum",
      "Kanalname": "ut",
      "Post1": "omnis",
      "Post2": "quibusdam",
      "Post3": "sequi",
      "EmailName": "eriberto@kshleringusikowski.name",
      "ContactFullName": "Dr. Valentine Kariane Larkin DDS",
      "ActiveErpLinks": 93,
      "TicketPriorityId": 822,
      "SupportLanguageId": 684,
      "SupportAssociateId": 659,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1266828",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 166
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "nemo",
  "Xstop": false,
  "ActiveInterests": 682,
  "GroupId": 992,
  "ActiveStatusMonitorId": 203,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 628,
  "DbiAgentId": 723,
  "DbiLastSyncronized": "2003-01-04T16:32:47.2902636+01:00",
  "DbiKey": "odit",
  "DbiLastModified": "2015-01-19T16:32:47.2902636+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 999,
  "ActiveErpLinks": 996,
  "BounceEmails": [
    "keenan@framimueller.ca",
    "antonio@rodriguez.ca"
  ],
  "Domains": [
    "numquam",
    "qui"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ansley Quigley",
    "SuperOffice:2": "Ola Prohaska MD"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "enim"
  },
  "CustomFields": {
    "CustomFields1": "animi",
    "CustomFields2": "fugit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 980
    }
  }
}
```