---
title: POST Agents/Contact/CreateDefaultContactEntity
uid: v1ContactAgent_CreateDefaultContactEntity
generated: true
content_type: reference
---

# POST Agents/Contact/CreateDefaultContactEntity

```http
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
```

Loading default values into a new ContactEntity.








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
  "ContactId": 149,
  "Name": "Kerluke, Batz and Funk",
  "Department": "",
  "OrgNr": "736190",
  "Number1": "869833",
  "Number2": "56083",
  "UpdatedDate": "2015-02-12T03:41:53.2463712+01:00",
  "CreatedDate": "2016-04-26T03:41:53.2463712+02:00",
  "Emails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "autem",
      "Description": "Triple-buffered needs-based portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 26
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "autem",
      "Description": "Triple-buffered needs-based portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 26
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 706,
      "Name": "Carter LLC",
      "ToolTip": "Expedita fuga.",
      "Deleted": true,
      "Rank": 765,
      "Type": "maiores",
      "ColorBlock": 885,
      "IconHint": "voluptatem",
      "Selected": true,
      "LastChanged": "2002-12-12T03:41:53.2463712+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "culpa",
      "Hidden": false,
      "FullName": "Ms. Desmond Alysa Hahn",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 372
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "mollitia",
      "StrippedValue": "molestiae",
      "Description": "Total global core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 345
        }
      }
    },
    {
      "Value": "mollitia",
      "StrippedValue": "molestiae",
      "Description": "Total global core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 345
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "autem",
      "StrippedValue": "veniam",
      "Description": "Re-contextualized bottom-line paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 981
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "veniam",
      "Description": "Re-contextualized bottom-line paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 981
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "sit",
      "Description": "Reactive transitional instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 933
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "sit",
      "Description": "Reactive transitional instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 933
        }
      }
    }
  ],
  "Description": "Virtual empowering capacity",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptas",
      "PersonId": 282,
      "Mrmrs": "debitis",
      "Firstname": "Jeanie",
      "Lastname": "Grady",
      "MiddleName": "Leuschke, Kuhic and Buckridge",
      "Title": "expedita",
      "Description": "Universal non-volatile model",
      "Email": "kirk.wolff@bergewaters.info",
      "FullName": "Prof. Dortha Sawayn PhD",
      "DirectPhone": "735.064.5557 x4390",
      "FormalName": "Grady, Hand and Dicki",
      "CountryId": 187,
      "ContactId": 201,
      "ContactName": "Yundt-Ledner",
      "Retired": 220,
      "Rank": 672,
      "ActiveInterests": 57,
      "ContactDepartment": "",
      "ContactCountryId": 808,
      "ContactOrgNr": "1331519",
      "FaxPhone": "(243)085-8448 x3193",
      "MobilePhone": "298-039-7162 x520",
      "ContactPhone": "293.614.7959 x99714",
      "AssociateName": "Corkery, Legros and Aufderhar",
      "AssociateId": 57,
      "UsePersonAddress": false,
      "ContactFax": "labore",
      "Kanafname": "tempore",
      "Kanalname": "est",
      "Post1": "consequatur",
      "Post2": "velit",
      "Post3": "ratione",
      "EmailName": "alvera@pfeffer.co.uk",
      "ContactFullName": "Sterling Taurean Hane Jr.",
      "ActiveErpLinks": 375,
      "TicketPriorityId": 352,
      "SupportLanguageId": 835,
      "SupportAssociateId": 555,
      "CategoryName": "VIP Customer",
      "PersonNumber": "645451",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 973
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptas",
  "Xstop": true,
  "ActiveInterests": 444,
  "GroupId": 623,
  "ActiveStatusMonitorId": 457,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 592,
  "DbiAgentId": 337,
  "DbiLastSyncronized": "1999-10-28T03:41:53.2463712+02:00",
  "DbiKey": "in",
  "DbiLastModified": "2007-07-22T03:41:53.2463712+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 70,
  "ActiveErpLinks": 281,
  "BounceEmails": [
    "evan_kuphal@schillerterry.com",
    "wyman_koch@mitchell.co.uk"
  ],
  "Domains": [
    "hic",
    "fuga"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "993530700",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "placeat",
    "ExtraFields2": "magnam"
  },
  "CustomFields": {
    "CustomFields1": "inventore",
    "CustomFields2": "odit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 604
    }
  }
}
```