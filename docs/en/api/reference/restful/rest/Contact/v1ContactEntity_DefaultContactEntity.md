---
title: GET Contact/default
uid: v1ContactEntity_DefaultContactEntity
generated: true
content_type: reference
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
Last-Modified: Wed, 11 Aug 2021 03:41:58 G8T

{
  "ContactId": 997,
  "Name": "Kemmer-Pouros",
  "Department": "",
  "OrgNr": "1032252",
  "Number1": "645947",
  "Number2": "992389",
  "UpdatedDate": "2021-08-11T03:41:58.5742886+02:00",
  "CreatedDate": "2013-12-14T03:41:58.5742886+01:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "quasi",
      "Description": "Multi-lateral multi-tasking approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 576
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "quasi",
      "Description": "Multi-lateral multi-tasking approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 576
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 796,
      "Name": "Ruecker Group",
      "ToolTip": "Iure placeat excepturi debitis corrupti cumque.",
      "Deleted": true,
      "Rank": 197,
      "Type": "nihil",
      "ColorBlock": 644,
      "IconHint": "ipsum",
      "Selected": false,
      "LastChanged": "2001-10-20T03:41:58.5742886+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "debitis",
      "StyleHint": "ab",
      "Hidden": false,
      "FullName": "Ladarius Hagenes",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 507
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "reiciendis",
      "StrippedValue": "quas",
      "Description": "Streamlined leading edge productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 683
        }
      }
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "quas",
      "Description": "Streamlined leading edge productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 683
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "voluptate",
      "StrippedValue": "officiis",
      "Description": "Innovative discrete focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 799
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "officiis",
      "Description": "Innovative discrete focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 799
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "saepe",
      "StrippedValue": "non",
      "Description": "Organized fault-tolerant open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 758
        }
      }
    },
    {
      "Value": "saepe",
      "StrippedValue": "non",
      "Description": "Organized fault-tolerant open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 758
        }
      }
    }
  ],
  "Description": "Vision-oriented static hardware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "maxime",
      "PersonId": 674,
      "Mrmrs": "quam",
      "Firstname": "Sonny",
      "Lastname": "Strosin",
      "MiddleName": "Conn Group",
      "Title": "dolorem",
      "Description": "Ameliorated didactic projection",
      "Email": "adrianna@hermann.co.uk",
      "FullName": "Vergie Luettgen",
      "DirectPhone": "884.790.1771 x9855",
      "FormalName": "Schneider LLC",
      "CountryId": 100,
      "ContactId": 438,
      "ContactName": "Jacobs-Brekke",
      "Retired": 151,
      "Rank": 945,
      "ActiveInterests": 493,
      "ContactDepartment": "",
      "ContactCountryId": 802,
      "ContactOrgNr": "1320909",
      "FaxPhone": "(622)032-2643 x193",
      "MobilePhone": "762-184-6801 x30561",
      "ContactPhone": "028.702.2567",
      "AssociateName": "Boyle, Dicki and McKenzie",
      "AssociateId": 62,
      "UsePersonAddress": false,
      "ContactFax": "dolorum",
      "Kanafname": "iusto",
      "Kanalname": "ipsa",
      "Post1": "quia",
      "Post2": "voluptas",
      "Post3": "ab",
      "EmailName": "kirstin@abernathyjacobs.ca",
      "ContactFullName": "Avery Barrows",
      "ActiveErpLinks": 119,
      "TicketPriorityId": 751,
      "SupportLanguageId": 844,
      "SupportAssociateId": 264,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1862291",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 914
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "ea",
  "Xstop": false,
  "ActiveInterests": 476,
  "GroupId": 261,
  "ActiveStatusMonitorId": 849,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 505,
  "DbiAgentId": 1000,
  "DbiLastSyncronized": "2024-08-05T03:41:58.5742886+02:00",
  "DbiKey": "possimus",
  "DbiLastModified": "2012-09-15T03:41:58.5742886+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 904,
  "ActiveErpLinks": 244,
  "BounceEmails": [
    "nat.runolfsson@blick.info",
    "janae@carterkling.biz"
  ],
  "Domains": [
    "cum",
    "debitis"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "1336198351",
    "SuperOffice:2": "604437103"
  },
  "ExtraFields": {
    "ExtraFields1": "nihil",
    "ExtraFields2": "sed"
  },
  "CustomFields": {
    "CustomFields1": "nesciunt",
    "CustomFields2": "recusandae"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 14
    }
  }
}
```