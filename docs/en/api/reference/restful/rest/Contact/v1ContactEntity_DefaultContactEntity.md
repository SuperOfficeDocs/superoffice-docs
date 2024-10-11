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
Last-Modified: Mon, 19 Nov 2012 03:44:57 G11T

{
  "ContactId": 930,
  "Name": "Reynolds LLC",
  "Department": "",
  "OrgNr": "941237",
  "Number1": "879508",
  "Number2": "545369",
  "UpdatedDate": "2012-11-19T03:44:57.1246527+01:00",
  "CreatedDate": "2017-10-05T03:44:57.1246527+02:00",
  "Emails": [
    {
      "Value": "tempora",
      "StrippedValue": "unde",
      "Description": "Optional assymetric strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 110
        }
      }
    },
    {
      "Value": "tempora",
      "StrippedValue": "unde",
      "Description": "Optional assymetric strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 110
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 486,
      "Name": "Bailey LLC",
      "ToolTip": "Consequuntur consectetur tempore quisquam modi quis.",
      "Deleted": false,
      "Rank": 612,
      "Type": "et",
      "ColorBlock": 310,
      "IconHint": "quos",
      "Selected": false,
      "LastChanged": "2012-10-29T03:44:57.1246527+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aspernatur",
      "StyleHint": "neque",
      "Hidden": false,
      "FullName": "Fatima Jaskolski",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 956
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quisquam",
      "StrippedValue": "ipsum",
      "Description": "Cross-group 5th generation throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 849
        }
      }
    },
    {
      "Value": "quisquam",
      "StrippedValue": "ipsum",
      "Description": "Cross-group 5th generation throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 849
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "harum",
      "StrippedValue": "iste",
      "Description": "Assimilated 24/7 info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 35
        }
      }
    },
    {
      "Value": "harum",
      "StrippedValue": "iste",
      "Description": "Assimilated 24/7 info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 35
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ea",
      "StrippedValue": "harum",
      "Description": "Assimilated directional intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 93
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "harum",
      "Description": "Assimilated directional intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 93
        }
      }
    }
  ],
  "Description": "Cloned client-server encoding",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sint",
      "PersonId": 675,
      "Mrmrs": "pariatur",
      "Firstname": "Nigel",
      "Lastname": "O'Conner",
      "MiddleName": "Hilll Group",
      "Title": "recusandae",
      "Description": "Upgradable regional encryption",
      "Email": "chester.grant@stoltenberg.biz",
      "FullName": "Ms. Webster Ledner MD",
      "DirectPhone": "778-872-5745 x56414",
      "FormalName": "Skiles-Rosenbaum",
      "CountryId": 267,
      "ContactId": 307,
      "ContactName": "Wisoky Inc and Sons",
      "Retired": 143,
      "Rank": 996,
      "ActiveInterests": 846,
      "ContactDepartment": "",
      "ContactCountryId": 616,
      "ContactOrgNr": "1415037",
      "FaxPhone": "1-953-230-3547",
      "MobilePhone": "(420)016-1751",
      "ContactPhone": "848-476-7848",
      "AssociateName": "Schamberger-Kautzer",
      "AssociateId": 66,
      "UsePersonAddress": false,
      "ContactFax": "omnis",
      "Kanafname": "dolor",
      "Kanalname": "consequuntur",
      "Post1": "ea",
      "Post2": "sapiente",
      "Post3": "id",
      "EmailName": "thaddeus@ankundingmitchell.uk",
      "ContactFullName": "Clare Deckow",
      "ActiveErpLinks": 574,
      "TicketPriorityId": 146,
      "SupportLanguageId": 847,
      "SupportAssociateId": 364,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 995
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "alias",
  "Xstop": true,
  "ActiveInterests": 141,
  "GroupId": 389,
  "ActiveStatusMonitorId": 86,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 309,
  "DbiAgentId": 749,
  "DbiLastSyncronized": "1997-11-19T03:44:57.1246527+01:00",
  "DbiKey": "vel",
  "DbiLastModified": "2013-08-02T03:44:57.1246527+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 130,
  "ActiveErpLinks": 923,
  "BounceEmails": [
    "berenice@doyle.ca",
    "makayla@hammes.us"
  ],
  "Domains": [
    "ea",
    "rerum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Kacey Fisher",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "praesentium",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "id",
    "CustomFields2": "laudantium"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 617
    }
  }
}
```