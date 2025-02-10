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
  "ContactId": 912,
  "Name": "Hilpert, Langworth and Kirlin",
  "Department": "",
  "OrgNr": "937622",
  "Number1": "471731",
  "Number2": "1486702",
  "UpdatedDate": "2001-07-20T12:01:27.4627597+02:00",
  "CreatedDate": "2016-01-03T12:01:27.4627597+01:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "hic",
      "Description": "Reverse-engineered maximized benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 433
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "hic",
      "Description": "Reverse-engineered maximized benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 433
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 870,
      "Name": "Legros-Ortiz",
      "ToolTip": "Veritatis consectetur occaecati sit atque.",
      "Deleted": true,
      "Rank": 276,
      "Type": "ut",
      "ColorBlock": 400,
      "IconHint": "possimus",
      "Selected": true,
      "LastChanged": "2020-12-19T12:01:27.4627597+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nam",
      "StyleHint": "aut",
      "Hidden": false,
      "FullName": "Dr. Lera Merl Zulauf",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 904
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "tempore",
      "StrippedValue": "qui",
      "Description": "Future-proofed zero tolerance artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 914
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "qui",
      "Description": "Future-proofed zero tolerance artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 914
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "autem",
      "StrippedValue": "vel",
      "Description": "Upgradable attitude-oriented function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 885
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "vel",
      "Description": "Upgradable attitude-oriented function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 885
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "placeat",
      "StrippedValue": "assumenda",
      "Description": "Secured well-modulated groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 342
        }
      }
    },
    {
      "Value": "placeat",
      "StrippedValue": "assumenda",
      "Description": "Secured well-modulated groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 342
        }
      }
    }
  ],
  "Description": "Reduced responsive toolset",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "rem",
      "PersonId": 353,
      "Mrmrs": "voluptas",
      "Firstname": "Harvey",
      "Lastname": "Wisoky",
      "MiddleName": "Hauck Inc and Sons",
      "Title": "dolorem",
      "Description": "Versatile leading edge knowledge base",
      "Email": "gisselle@stiedemann.biz",
      "FullName": "Presley Berge II",
      "DirectPhone": "675.080.5850 x5793",
      "FormalName": "Carroll Inc and Sons",
      "CountryId": 299,
      "ContactId": 788,
      "ContactName": "Hansen Group",
      "Retired": 546,
      "Rank": 910,
      "ActiveInterests": 581,
      "ContactDepartment": "streamline clicks-and-mortar networks",
      "ContactCountryId": 1002,
      "ContactOrgNr": "560834",
      "FaxPhone": "579-330-4239",
      "MobilePhone": "573.287.1535 x68489",
      "ContactPhone": "(317)235-1108 x575",
      "AssociateName": "Murazik, Roob and Fisher",
      "AssociateId": 331,
      "UsePersonAddress": true,
      "ContactFax": "ea",
      "Kanafname": "expedita",
      "Kanalname": "at",
      "Post1": "in",
      "Post2": "corrupti",
      "Post3": "aut",
      "EmailName": "jaquelin_dibbert@kris.com",
      "ContactFullName": "Kyleigh Witting",
      "ActiveErpLinks": 610,
      "TicketPriorityId": 653,
      "SupportLanguageId": 906,
      "SupportAssociateId": 352,
      "CategoryName": "VIP Customer",
      "PersonNumber": "894993",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 942
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "molestias",
  "Xstop": false,
  "ActiveInterests": 302,
  "GroupId": 338,
  "ActiveStatusMonitorId": 498,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 30,
  "DbiAgentId": 192,
  "DbiLastSyncronized": "2017-10-09T12:01:27.4627597+02:00",
  "DbiKey": "eos",
  "DbiLastModified": "2011-07-26T12:01:27.4627597+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 871,
  "ActiveErpLinks": 663,
  "BounceEmails": [
    "selena.collier@considine.name",
    "baron.stoltenberg@ornfeest.name"
  ],
  "Domains": [
    "mollitia",
    "numquam"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Quinten Lemke",
    "SuperOffice:2": "823184485"
  },
  "ExtraFields": {
    "ExtraFields1": "unde",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "officiis",
    "CustomFields2": "nihil"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 895
    }
  }
}
```