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
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=3
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
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 412,
  "Name": "Labadie, Halvorson and Ratke",
  "Department": "",
  "OrgNr": "1078283",
  "Number1": "882334",
  "Number2": "1424246",
  "UpdatedDate": "2001-10-17T12:57:33.5087192+02:00",
  "CreatedDate": "2010-11-10T12:57:33.5087192+01:00",
  "Emails": [
    {
      "Value": "voluptate",
      "StrippedValue": "esse",
      "Description": "Mandatory mobile system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 823
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "esse",
      "Description": "Mandatory mobile system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 823
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 285,
      "Name": "Runolfsson, Cruickshank and Gleason",
      "ToolTip": "Quos est quis natus animi veniam modi molestiae.",
      "Deleted": true,
      "Rank": 755,
      "Type": "enim",
      "ColorBlock": 127,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2014-09-18T12:57:33.5087192+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "molestiae",
      "StyleHint": "illum",
      "Hidden": false,
      "FullName": "Mrs. Rose Erna Cassin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 321
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "praesentium",
      "StrippedValue": "atque",
      "Description": "Function-based system-worthy methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 533
        }
      }
    },
    {
      "Value": "praesentium",
      "StrippedValue": "atque",
      "Description": "Function-based system-worthy methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 533
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "blanditiis",
      "StrippedValue": "quo",
      "Description": "Networked tertiary application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 244
        }
      }
    },
    {
      "Value": "blanditiis",
      "StrippedValue": "quo",
      "Description": "Networked tertiary application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 244
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "corporis",
      "StrippedValue": "pariatur",
      "Description": "Configurable tangible paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 425
        }
      }
    },
    {
      "Value": "corporis",
      "StrippedValue": "pariatur",
      "Description": "Configurable tangible paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 425
        }
      }
    }
  ],
  "Description": "Visionary modular application",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "atque",
      "PersonId": 887,
      "Mrmrs": "qui",
      "Firstname": "Mary",
      "Lastname": "Rogahn",
      "MiddleName": "Hudson Group",
      "Title": "saepe",
      "Description": "Expanded scalable implementation",
      "Email": "scottie@bashirian.com",
      "FullName": "Tremayne Hintz",
      "DirectPhone": "1-756-673-6158",
      "FormalName": "Bernhard-Bechtelar",
      "CountryId": 242,
      "ContactId": 641,
      "ContactName": "Barrows, Stracke and Gutmann",
      "Retired": 234,
      "Rank": 505,
      "ActiveInterests": 626,
      "ContactDepartment": "",
      "ContactCountryId": 959,
      "ContactOrgNr": "666299",
      "FaxPhone": "(139)665-5936 x2963",
      "MobilePhone": "328-335-5422 x73991",
      "ContactPhone": "1-951-940-8681 x2093",
      "AssociateName": "Herzog-Marquardt",
      "AssociateId": 376,
      "UsePersonAddress": false,
      "ContactFax": "nesciunt",
      "Kanafname": "repudiandae",
      "Kanalname": "ex",
      "Post1": "adipisci",
      "Post2": "enim",
      "Post3": "sint",
      "EmailName": "jerrell@rippin.us",
      "ContactFullName": "Judy Macejkovic",
      "ActiveErpLinks": 82,
      "TicketPriorityId": 822,
      "SupportLanguageId": 160,
      "SupportAssociateId": 352,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 951
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "ex",
  "Xstop": false,
  "ActiveInterests": 534,
  "GroupId": 870,
  "ActiveStatusMonitorId": 671,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 817,
  "DbiAgentId": 402,
  "DbiLastSyncronized": "1999-03-10T12:57:33.5087192+01:00",
  "DbiKey": "officia",
  "DbiLastModified": "1997-01-07T12:57:33.5087192+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 313,
  "ActiveErpLinks": 256,
  "BounceEmails": [
    "carmella.turcotte@mullereffertz.biz",
    "peter_lueilwitz@pfeffer.com"
  ],
  "Domains": [
    "quibusdam",
    "architecto"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Mariane Lakin Sr.",
    "SuperOffice:2": "Prof. Alexander Joe Graham V"
  },
  "ExtraFields": {
    "ExtraFields1": "expedita",
    "ExtraFields2": "sequi"
  },
  "CustomFields": {
    "CustomFields1": "aliquam",
    "CustomFields2": "similique"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 836
    }
  }
}
```