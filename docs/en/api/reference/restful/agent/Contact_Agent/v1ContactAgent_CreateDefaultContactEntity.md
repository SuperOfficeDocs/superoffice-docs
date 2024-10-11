---
title: POST Agents/Contact/CreateDefaultContactEntity
uid: v1ContactAgent_CreateDefaultContactEntity
generated: true
---

# POST Agents/Contact/CreateDefaultContactEntity

```http
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 601,
  "Name": "Grant LLC",
  "Department": "",
  "OrgNr": "1418821",
  "Number1": "633604",
  "Number2": "1111625",
  "UpdatedDate": "2023-09-30T03:44:52.2771517+02:00",
  "CreatedDate": "2016-02-13T03:44:52.2771517+01:00",
  "Emails": [
    {
      "Value": "quae",
      "StrippedValue": "qui",
      "Description": "Optimized heuristic adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 897
        }
      }
    },
    {
      "Value": "quae",
      "StrippedValue": "qui",
      "Description": "Optimized heuristic adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 897
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 930,
      "Name": "Runolfsdottir, Marquardt and Bergstrom",
      "ToolTip": "Sunt atque eos asperiores.",
      "Deleted": false,
      "Rank": 868,
      "Type": "id",
      "ColorBlock": 329,
      "IconHint": "nulla",
      "Selected": false,
      "LastChanged": "2008-06-18T03:44:52.2771517+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "in",
      "StyleHint": "et",
      "Hidden": true,
      "FullName": "Modesta Daugherty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 621
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "eaque",
      "StrippedValue": "non",
      "Description": "Business-focused bi-directional benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 166
        }
      }
    },
    {
      "Value": "eaque",
      "StrippedValue": "non",
      "Description": "Business-focused bi-directional benchmark",
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
  "Phones": [
    {
      "Value": "qui",
      "StrippedValue": "blanditiis",
      "Description": "Seamless object-oriented installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 475
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "blanditiis",
      "Description": "Seamless object-oriented installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 475
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quibusdam",
      "StrippedValue": "animi",
      "Description": "Optimized regional standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 653
        }
      }
    },
    {
      "Value": "quibusdam",
      "StrippedValue": "animi",
      "Description": "Optimized regional standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 653
        }
      }
    }
  ],
  "Description": "Multi-tiered composite structure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "et",
      "PersonId": 940,
      "Mrmrs": "corporis",
      "Firstname": "Joel",
      "Lastname": "Reinger",
      "MiddleName": "Wolff, Murazik and Franecki",
      "Title": "maiores",
      "Description": "User-centric regional policy",
      "Email": "declan_leannon@koch.ca",
      "FullName": "Milan Volkman I",
      "DirectPhone": "603-843-3849 x64349",
      "FormalName": "Wolff-Adams",
      "CountryId": 586,
      "ContactId": 99,
      "ContactName": "Ruecker, Schaden and Bergnaum",
      "Retired": 365,
      "Rank": 941,
      "ActiveInterests": 418,
      "ContactDepartment": "",
      "ContactCountryId": 807,
      "ContactOrgNr": "599823",
      "FaxPhone": "163-538-1202 x6805",
      "MobilePhone": "1-689-740-4064 x69454",
      "ContactPhone": "680-679-8421 x50913",
      "AssociateName": "Barton LLC",
      "AssociateId": 630,
      "UsePersonAddress": false,
      "ContactFax": "inventore",
      "Kanafname": "ut",
      "Kanalname": "est",
      "Post1": "sit",
      "Post2": "harum",
      "Post3": "expedita",
      "EmailName": "jaquan@oberbrunner.us",
      "ContactFullName": "Ethyl Pfeffer",
      "ActiveErpLinks": 483,
      "TicketPriorityId": 603,
      "SupportLanguageId": 447,
      "SupportAssociateId": 432,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 257
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "at",
  "Xstop": true,
  "ActiveInterests": 972,
  "GroupId": 841,
  "ActiveStatusMonitorId": 452,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 311,
  "DbiAgentId": 941,
  "DbiLastSyncronized": "2018-04-22T03:44:52.2927719+02:00",
  "DbiKey": "ea",
  "DbiLastModified": "2004-06-17T03:44:52.2927719+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 435,
  "ActiveErpLinks": 853,
  "BounceEmails": [
    "deanna_huels@kertzmann.co.uk",
    "ross_grady@murphyconsidine.ca"
  ],
  "Domains": [
    "odio",
    "sunt"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Ubaldo Kessler IV",
    "SuperOffice:2": "Marvin Barton"
  },
  "ExtraFields": {
    "ExtraFields1": "blanditiis",
    "ExtraFields2": "pariatur"
  },
  "CustomFields": {
    "CustomFields1": "nam",
    "CustomFields2": "dolor"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 618
    }
  }
}
```