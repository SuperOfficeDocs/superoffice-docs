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
  "ContactId": 610,
  "Name": "Von Group",
  "Department": "",
  "OrgNr": "1371841",
  "Number1": "1194849",
  "Number2": "559108",
  "UpdatedDate": "2015-12-18T13:13:59.7194403+01:00",
  "CreatedDate": "2015-01-03T13:13:59.7194403+01:00",
  "Emails": [
    {
      "Value": "accusantium",
      "StrippedValue": "ducimus",
      "Description": "Public-key intermediate structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 638
        }
      }
    },
    {
      "Value": "accusantium",
      "StrippedValue": "ducimus",
      "Description": "Public-key intermediate structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 638
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 195,
      "Name": "Bins Group",
      "ToolTip": "Dolores laborum ab inventore tempora ea ad.",
      "Deleted": true,
      "Rank": 975,
      "Type": "saepe",
      "ColorBlock": 200,
      "IconHint": "corporis",
      "Selected": false,
      "LastChanged": "2021-11-29T13:13:59.7194403+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "cupiditate",
      "Hidden": true,
      "FullName": "Garrett Cummerata",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 673
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "dolores",
      "Description": "Compatible discrete function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 662
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "dolores",
      "Description": "Compatible discrete function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 662
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "quos",
      "StrippedValue": "officiis",
      "Description": "Reduced next generation service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 54
        }
      }
    },
    {
      "Value": "quos",
      "StrippedValue": "officiis",
      "Description": "Reduced next generation service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 54
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eos",
      "StrippedValue": "itaque",
      "Description": "Ameliorated 6th generation frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 65
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "itaque",
      "Description": "Ameliorated 6th generation frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 65
        }
      }
    }
  ],
  "Description": "Centralized intangible superstructure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ad",
      "PersonId": 376,
      "Mrmrs": "dicta",
      "Firstname": "Taurean",
      "Lastname": "Schaden",
      "MiddleName": "Mayert Inc and Sons",
      "Title": "fuga",
      "Description": "Distributed systematic concept",
      "Email": "maxine.hand@jacobs.name",
      "FullName": "Osvaldo Cormier",
      "DirectPhone": "018.582.7194 x001",
      "FormalName": "Runolfsson, Gislason and Kerluke",
      "CountryId": 707,
      "ContactId": 460,
      "ContactName": "Wuckert Inc and Sons",
      "Retired": 880,
      "Rank": 859,
      "ActiveInterests": 555,
      "ContactDepartment": "",
      "ContactCountryId": 151,
      "ContactOrgNr": "1699113",
      "FaxPhone": "1-571-998-1731 x84359",
      "MobilePhone": "612-024-0383 x931",
      "ContactPhone": "469-817-1842",
      "AssociateName": "Koelpin-Frami",
      "AssociateId": 718,
      "UsePersonAddress": false,
      "ContactFax": "et",
      "Kanafname": "quos",
      "Kanalname": "vel",
      "Post1": "laudantium",
      "Post2": "voluptatem",
      "Post3": "id",
      "EmailName": "trinity@cristswift.uk",
      "ContactFullName": "Palma Mable Rice Jr.",
      "ActiveErpLinks": 466,
      "TicketPriorityId": 251,
      "SupportLanguageId": 153,
      "SupportAssociateId": 718,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1199561",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 919
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "aut",
  "Xstop": false,
  "ActiveInterests": 300,
  "GroupId": 145,
  "ActiveStatusMonitorId": 447,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 851,
  "DbiAgentId": 75,
  "DbiLastSyncronized": "2001-01-21T13:13:59.7194403+01:00",
  "DbiKey": "sit",
  "DbiLastModified": "2014-08-06T13:13:59.7194403+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 657,
  "ActiveErpLinks": 602,
  "BounceEmails": [
    "lewis.huel@andersonparisian.info",
    "deanna.boehm@hoppe.us"
  ],
  "Domains": [
    "repudiandae",
    "exercitationem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Andy Emard MD"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "id"
  },
  "CustomFields": {
    "CustomFields1": "nihil",
    "CustomFields2": "exercitationem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 420
    }
  }
}
```