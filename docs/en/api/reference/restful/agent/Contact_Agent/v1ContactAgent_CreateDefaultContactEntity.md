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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 1001,
  "Name": "Nikolaus-Schumm",
  "Department": "",
  "OrgNr": "207915",
  "Number1": "477340",
  "Number2": "454098",
  "UpdatedDate": "2021-08-22T14:13:39.7660185+02:00",
  "CreatedDate": "2018-04-16T14:13:39.7660185+02:00",
  "Emails": [
    {
      "Value": "incidunt",
      "StrippedValue": "incidunt",
      "Description": "Customizable tertiary internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 706
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "incidunt",
      "Description": "Customizable tertiary internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 706
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 713,
      "Name": "Reynolds-Cremin",
      "ToolTip": "Sed ullam ex ducimus et.",
      "Deleted": false,
      "Rank": 253,
      "Type": "ipsam",
      "ColorBlock": 114,
      "IconHint": "aut",
      "Selected": false,
      "LastChanged": "2014-05-16T14:13:39.7660185+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "fugit",
      "StyleHint": "non",
      "Hidden": false,
      "FullName": "Nayeli Franecki",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 324
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quod",
      "StrippedValue": "ea",
      "Description": "Fully-configurable non-volatile capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 701
        }
      }
    },
    {
      "Value": "quod",
      "StrippedValue": "ea",
      "Description": "Fully-configurable non-volatile capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 701
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quam",
      "StrippedValue": "incidunt",
      "Description": "Managed grid-enabled access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 564
        }
      }
    },
    {
      "Value": "quam",
      "StrippedValue": "incidunt",
      "Description": "Managed grid-enabled access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 564
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "laboriosam",
      "StrippedValue": "animi",
      "Description": "Inverse zero administration initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 243
        }
      }
    },
    {
      "Value": "laboriosam",
      "StrippedValue": "animi",
      "Description": "Inverse zero administration initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 243
        }
      }
    }
  ],
  "Description": "Operative next generation standardization",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ullam",
      "PersonId": 430,
      "Mrmrs": "provident",
      "Firstname": "Michel",
      "Lastname": "Rath",
      "MiddleName": "Jacobi-Ratke",
      "Title": "cumque",
      "Description": "Automated dynamic analyzer",
      "Email": "dayna@johnsonrussel.uk",
      "FullName": "Trisha Schmitt",
      "DirectPhone": "379.547.6579",
      "FormalName": "Beer Inc and Sons",
      "CountryId": 735,
      "ContactId": 976,
      "ContactName": "Bode, McGlynn and Kohler",
      "Retired": 699,
      "Rank": 891,
      "ActiveInterests": 692,
      "ContactDepartment": "",
      "ContactCountryId": 742,
      "ContactOrgNr": "1705563",
      "FaxPhone": "(322)834-3326 x7664",
      "MobilePhone": "395-501-4232",
      "ContactPhone": "1-981-139-3086 x60088",
      "AssociateName": "Dicki-Runolfsdottir",
      "AssociateId": 362,
      "UsePersonAddress": false,
      "ContactFax": "praesentium",
      "Kanafname": "rem",
      "Kanalname": "exercitationem",
      "Post1": "sit",
      "Post2": "illum",
      "Post3": "corrupti",
      "EmailName": "jacinthe.kuhn@lang.uk",
      "ContactFullName": "Brandi Simonis",
      "ActiveErpLinks": 705,
      "TicketPriorityId": 734,
      "SupportLanguageId": 155,
      "SupportAssociateId": 291,
      "CategoryName": "VIP Customer",
      "PersonNumber": "879496",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 898
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "et",
  "Xstop": false,
  "ActiveInterests": 314,
  "GroupId": 649,
  "ActiveStatusMonitorId": 224,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 582,
  "DbiAgentId": 109,
  "DbiLastSyncronized": "2024-04-25T14:13:39.7660185+02:00",
  "DbiKey": "odio",
  "DbiLastModified": "2003-01-09T14:13:39.7660185+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 971,
  "ActiveErpLinks": 894,
  "BounceEmails": [
    "lionel@dietrichgreenfelder.biz",
    "coleman_medhurst@stoltenberg.uk"
  ],
  "Domains": [
    "animi",
    "iste"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "335344949",
    "SuperOffice:2": "Amiya Balistreri"
  },
  "ExtraFields": {
    "ExtraFields1": "beatae",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "culpa",
    "CustomFields2": "quis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 102
    }
  }
}
```