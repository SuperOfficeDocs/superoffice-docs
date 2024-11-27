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
Last-Modified: Thu, 30 Mar 2023 14:45:12 G3T

{
  "ContactId": 910,
  "Name": "Stoltenberg-Terry",
  "Department": "grow web-enabled e-commerce",
  "OrgNr": "1004914",
  "Number1": "751454",
  "Number2": "914530",
  "UpdatedDate": "2023-03-30T14:45:12.6307355+02:00",
  "CreatedDate": "2014-05-27T14:45:12.6307355+02:00",
  "Emails": [
    {
      "Value": "velit",
      "StrippedValue": "soluta",
      "Description": "Down-sized bifurcated instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 175
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "soluta",
      "Description": "Down-sized bifurcated instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 175
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 807,
      "Name": "Koelpin-Orn",
      "ToolTip": "Soluta et rerum.",
      "Deleted": false,
      "Rank": 728,
      "Type": "consectetur",
      "ColorBlock": 444,
      "IconHint": "deserunt",
      "Selected": false,
      "LastChanged": "2019-05-19T14:45:12.6307355+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "similique",
      "StyleHint": "nulla",
      "Hidden": false,
      "FullName": "Miss Kyra Wintheiser",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 50
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "numquam",
      "Description": "Secured zero defect help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 815
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "numquam",
      "Description": "Secured zero defect help-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 815
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "beatae",
      "StrippedValue": "voluptas",
      "Description": "Enterprise-wide zero defect model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 885
        }
      }
    },
    {
      "Value": "beatae",
      "StrippedValue": "voluptas",
      "Description": "Enterprise-wide zero defect model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 885
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ad",
      "StrippedValue": "ut",
      "Description": "Switchable coherent projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 114
        }
      }
    },
    {
      "Value": "ad",
      "StrippedValue": "ut",
      "Description": "Switchable coherent projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 114
        }
      }
    }
  ],
  "Description": "Mandatory explicit attitude",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "animi",
      "PersonId": 39,
      "Mrmrs": "voluptas",
      "Firstname": "Bret",
      "Lastname": "Stroman",
      "MiddleName": "Halvorson LLC",
      "Title": "aut",
      "Description": "Synergized impactful extranet",
      "Email": "carrie_ferry@schowalter.name",
      "FullName": "Mrs. Rhea Rogahn",
      "DirectPhone": "448.024.9657 x478",
      "FormalName": "Schiller Group",
      "CountryId": 528,
      "ContactId": 671,
      "ContactName": "Franecki-Dickens",
      "Retired": 784,
      "Rank": 129,
      "ActiveInterests": 929,
      "ContactDepartment": "",
      "ContactCountryId": 52,
      "ContactOrgNr": "830093",
      "FaxPhone": "1-392-383-9142",
      "MobilePhone": "1-251-300-3317 x9625",
      "ContactPhone": "1-888-297-4582",
      "AssociateName": "Koepp-McDermott",
      "AssociateId": 655,
      "UsePersonAddress": false,
      "ContactFax": "dolor",
      "Kanafname": "delectus",
      "Kanalname": "modi",
      "Post1": "rem",
      "Post2": "ab",
      "Post3": "alias",
      "EmailName": "luigi.mcdermott@moen.name",
      "ContactFullName": "Payton Mosciski",
      "ActiveErpLinks": 511,
      "TicketPriorityId": 170,
      "SupportLanguageId": 214,
      "SupportAssociateId": 363,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 615
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "mollitia",
  "Xstop": true,
  "ActiveInterests": 798,
  "GroupId": 121,
  "ActiveStatusMonitorId": 40,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 85,
  "DbiAgentId": 815,
  "DbiLastSyncronized": "2023-01-11T14:45:12.6307355+01:00",
  "DbiKey": "id",
  "DbiLastModified": "2021-06-06T14:45:12.6307355+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 532,
  "ActiveErpLinks": 137,
  "BounceEmails": [
    "sherwood_kassulke@glover.us",
    "kristofer@parkerkuhlman.com"
  ],
  "Domains": [
    "blanditiis",
    "repudiandae"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Andreanne Rogahn"
  },
  "ExtraFields": {
    "ExtraFields1": "architecto",
    "ExtraFields2": "ullam"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "cumque"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 419
    }
  }
}
```