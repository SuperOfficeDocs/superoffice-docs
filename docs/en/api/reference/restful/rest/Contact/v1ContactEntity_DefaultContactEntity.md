---
title: GET Contact/default
uid: v1ContactEntity_DefaultContactEntity
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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
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
Last-Modified: Sat, 04 Apr 2015 15:29:29 G4T

{
  "ContactId": 188,
  "Name": "Nader-Kris",
  "Department": "",
  "OrgNr": "719543",
  "Number1": "1072102",
  "Number2": "1352665",
  "UpdatedDate": "2015-04-04T15:29:29.480205+02:00",
  "CreatedDate": "2014-04-23T15:29:29.480205+02:00",
  "Emails": [
    {
      "Value": "consequatur",
      "StrippedValue": "aut",
      "Description": "Centralized systemic toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 138
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "aut",
      "Description": "Centralized systemic toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 138
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 716,
      "Name": "McLaughlin, Zulauf and Moen",
      "ToolTip": "Aliquid quia perferendis.",
      "Deleted": false,
      "Rank": 807,
      "Type": "praesentium",
      "ColorBlock": 738,
      "IconHint": "quo",
      "Selected": false,
      "LastChanged": "2014-09-02T15:29:29.480205+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ullam",
      "StyleHint": "nam",
      "Hidden": false,
      "FullName": "Prof. Kade Ortiz III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 64
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "molestiae",
      "StrippedValue": "vel",
      "Description": "Cross-group optimizing flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 475
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "vel",
      "Description": "Cross-group optimizing flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 475
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "illum",
      "StrippedValue": "fugit",
      "Description": "Function-based didactic service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 670
        }
      }
    },
    {
      "Value": "illum",
      "StrippedValue": "fugit",
      "Description": "Function-based didactic service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 670
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "labore",
      "StrippedValue": "nobis",
      "Description": "Total static software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 867
        }
      }
    },
    {
      "Value": "labore",
      "StrippedValue": "nobis",
      "Description": "Total static software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 867
        }
      }
    }
  ],
  "Description": "Ergonomic responsive knowledge user",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "rerum",
      "PersonId": 131,
      "Mrmrs": "et",
      "Firstname": "Serena",
      "Lastname": "Schimmel",
      "MiddleName": "Rice, Willms and Hodkiewicz",
      "Title": "id",
      "Description": "Centralized hybrid standardization",
      "Email": "america.champlin@gutkowskihintz.co.uk",
      "FullName": "Anabel Kohler",
      "DirectPhone": "933-426-3287",
      "FormalName": "Hilll-O'Keefe",
      "CountryId": 285,
      "ContactId": 610,
      "ContactName": "Will-O'Reilly",
      "Retired": 812,
      "Rank": 210,
      "ActiveInterests": 662,
      "ContactDepartment": "",
      "ContactCountryId": 229,
      "ContactOrgNr": "277000",
      "FaxPhone": "1-153-987-5760 x560",
      "MobilePhone": "(388)856-4587 x4606",
      "ContactPhone": "1-193-285-9349 x29442",
      "AssociateName": "King-Koch",
      "AssociateId": 10,
      "UsePersonAddress": true,
      "ContactFax": "quos",
      "Kanafname": "rerum",
      "Kanalname": "quasi",
      "Post1": "veniam",
      "Post2": "sequi",
      "Post3": "magnam",
      "EmailName": "chauncey.marks@mertz.biz",
      "ContactFullName": "Dr. Toy Gwendolyn Russel MD",
      "ActiveErpLinks": 402,
      "TicketPriorityId": 291,
      "SupportLanguageId": 571,
      "SupportAssociateId": 583,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 337
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "quas",
  "Xstop": false,
  "ActiveInterests": 348,
  "GroupId": 605,
  "ActiveStatusMonitorId": 803,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 87,
  "DbiAgentId": 937,
  "DbiLastSyncronized": "2005-12-16T15:29:29.4852049+01:00",
  "DbiKey": "eligendi",
  "DbiLastModified": "2021-01-24T15:29:29.4852049+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 42,
  "ActiveErpLinks": 892,
  "BounceEmails": [
    "lela.wyman@hammes.uk",
    "reyes.pollich@koss.name"
  ],
  "Domains": [
    "voluptatum",
    "nisi"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Edd Hamill",
    "SuperOffice:2": "Verda Mann DDS"
  },
  "ExtraFields": {
    "ExtraFields1": "eligendi",
    "ExtraFields2": "odit"
  },
  "CustomFields": {
    "CustomFields1": "provident",
    "CustomFields2": "quis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 353
    }
  }
}
```