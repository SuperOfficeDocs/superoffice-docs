---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
generated: true
---

# POST Agents/Contact/GetContactEntity

```http
POST /api/v1/Agents/Contact/GetContactEntity
```

Gets a ContactEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=360
POST /api/v1/Agents/Contact/GetContactEntity?$select=name,department,category/id
```


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
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 698,
  "Name": "Will-O'Hara",
  "Department": "",
  "OrgNr": "897405",
  "Number1": "192421",
  "Number2": "1380144",
  "UpdatedDate": "1999-12-03T11:16:08.8815948+01:00",
  "CreatedDate": "2014-03-21T11:16:08.8815948+01:00",
  "Emails": [
    {
      "Value": "maxime",
      "StrippedValue": "et",
      "Description": "Distributed non-volatile paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 259
        }
      }
    },
    {
      "Value": "maxime",
      "StrippedValue": "et",
      "Description": "Distributed non-volatile paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 259
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 90,
      "Name": "Steuber, Schowalter and Bode",
      "ToolTip": "Hic perferendis et alias sed similique.",
      "Deleted": false,
      "Rank": 253,
      "Type": "esse",
      "ColorBlock": 149,
      "IconHint": "sunt",
      "Selected": true,
      "LastChanged": "2006-05-15T11:16:08.8815948+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "mollitia",
      "StyleHint": "ea",
      "Hidden": true,
      "FullName": "Gayle Jacobson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 519
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "quae",
      "Description": "Mandatory well-modulated attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 54
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "quae",
      "Description": "Mandatory well-modulated attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 54
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "veritatis",
      "Description": "Multi-tiered 4th generation capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 991
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "veritatis",
      "Description": "Multi-tiered 4th generation capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 991
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "doloribus",
      "StrippedValue": "non",
      "Description": "Diverse global alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 36
        }
      }
    },
    {
      "Value": "doloribus",
      "StrippedValue": "non",
      "Description": "Diverse global alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 36
        }
      }
    }
  ],
  "Description": "Business-focused demand-driven neural-net",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "illum",
      "PersonId": 548,
      "Mrmrs": "maxime",
      "Firstname": "Jerald",
      "Lastname": "Olson",
      "MiddleName": "Boehm, Stehr and Halvorson",
      "Title": "perspiciatis",
      "Description": "Multi-channelled local archive",
      "Email": "maynard_rau@terry.ca",
      "FullName": "Boyd Hermiston",
      "DirectPhone": "730-557-4940",
      "FormalName": "Herzog-Cremin",
      "CountryId": 913,
      "ContactId": 103,
      "ContactName": "Larson-Price",
      "Retired": 633,
      "Rank": 117,
      "ActiveInterests": 531,
      "ContactDepartment": "",
      "ContactCountryId": 457,
      "ContactOrgNr": "1417305",
      "FaxPhone": "(851)638-9663",
      "MobilePhone": "109.256.1640 x71911",
      "ContactPhone": "1-366-963-4093 x242",
      "AssociateName": "Hartmann, Ziemann and Wunsch",
      "AssociateId": 977,
      "UsePersonAddress": false,
      "ContactFax": "deleniti",
      "Kanafname": "consequatur",
      "Kanalname": "sapiente",
      "Post1": "ut",
      "Post2": "eum",
      "Post3": "neque",
      "EmailName": "yvette@leuschke.ca",
      "ContactFullName": "Prof. Crystel Lilyan Beier V",
      "ActiveErpLinks": 161,
      "TicketPriorityId": 97,
      "SupportLanguageId": 758,
      "SupportAssociateId": 872,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 37
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "voluptates",
  "Xstop": false,
  "ActiveInterests": 360,
  "GroupId": 247,
  "ActiveStatusMonitorId": 642,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 905,
  "DbiAgentId": 871,
  "DbiLastSyncronized": "2005-09-25T11:16:08.8815948+02:00",
  "DbiKey": "quo",
  "DbiLastModified": "1997-01-09T11:16:08.8815948+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 356,
  "ActiveErpLinks": 143,
  "BounceEmails": [
    "cierra@dooley.name",
    "linwood.hartmann@hudsonrogahn.ca"
  ],
  "Domains": [
    "sed",
    "facere"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "370837783",
    "SuperOffice:2": "571367546"
  },
  "ExtraFields": {
    "ExtraFields1": "iure",
    "ExtraFields2": "maxime"
  },
  "CustomFields": {
    "CustomFields1": "nobis",
    "CustomFields2": "voluptas"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 595
    }
  }
}
```