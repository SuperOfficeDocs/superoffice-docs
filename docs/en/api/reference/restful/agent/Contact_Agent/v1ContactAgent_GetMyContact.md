---
title: POST Agents/Contact/GetMyContact
uid: v1ContactAgent_GetMyContact
generated: true
---

# POST Agents/Contact/GetMyContact

```http
POST /api/v1/Agents/Contact/GetMyContact
```

Gets the contact belonging to the currently logged on user.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyContact?$select=name,department,category/id
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
POST /api/v1/Agents/Contact/GetMyContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 408,
  "Name": "Hand, Ratke and Bechtelar",
  "Department": "",
  "OrgNr": "865287",
  "Number1": "1586308",
  "Number2": "1010531",
  "UpdatedDate": "2014-03-26T03:45:23.1861021+01:00",
  "CreatedDate": "2020-07-24T03:45:23.1861021+02:00",
  "Emails": [
    {
      "Value": "autem",
      "StrippedValue": "eum",
      "Description": "Persevering leading edge process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 313
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "eum",
      "Description": "Persevering leading edge process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 313
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 715,
      "Name": "Bergstrom, Funk and Wiza",
      "ToolTip": "Voluptates dolorum.",
      "Deleted": true,
      "Rank": 366,
      "Type": "nihil",
      "ColorBlock": 147,
      "IconHint": "tempore",
      "Selected": true,
      "LastChanged": "2013-12-17T03:45:23.1861021+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "et",
      "Hidden": true,
      "FullName": "Reynold Upton DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 277
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "itaque",
      "Description": "Upgradable hybrid extranet",
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
      "Value": "est",
      "StrippedValue": "itaque",
      "Description": "Upgradable hybrid extranet",
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
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "repellendus",
      "Description": "Universal attitude-oriented challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 300
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "repellendus",
      "Description": "Universal attitude-oriented challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 300
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "eaque",
      "StrippedValue": "iure",
      "Description": "Open-architected upward-trending projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 88
        }
      }
    },
    {
      "Value": "eaque",
      "StrippedValue": "iure",
      "Description": "Open-architected upward-trending projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 88
        }
      }
    }
  ],
  "Description": "Focused secondary hardware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "excepturi",
      "PersonId": 109,
      "Mrmrs": "ab",
      "Firstname": "Abner",
      "Lastname": "Cormier",
      "MiddleName": "Mertz, Padberg and Littel",
      "Title": "enim",
      "Description": "Down-sized value-added standardization",
      "Email": "kaci@leuschke.info",
      "FullName": "Emmy Adams",
      "DirectPhone": "987.516.2070 x114",
      "FormalName": "Schmidt, Dibbert and Hilll",
      "CountryId": 92,
      "ContactId": 454,
      "ContactName": "Schmidt Inc and Sons",
      "Retired": 471,
      "Rank": 125,
      "ActiveInterests": 861,
      "ContactDepartment": "",
      "ContactCountryId": 353,
      "ContactOrgNr": "1523904",
      "FaxPhone": "1-773-785-7771",
      "MobilePhone": "(611)920-8078 x33301",
      "ContactPhone": "891-847-3805 x45765",
      "AssociateName": "Smith-Rolfson",
      "AssociateId": 11,
      "UsePersonAddress": true,
      "ContactFax": "facilis",
      "Kanafname": "aliquam",
      "Kanalname": "fuga",
      "Post1": "voluptas",
      "Post2": "quidem",
      "Post3": "sed",
      "EmailName": "fritz_schuster@senger.ca",
      "ContactFullName": "Patsy Jolie Altenwerth III",
      "ActiveErpLinks": 757,
      "TicketPriorityId": 292,
      "SupportLanguageId": 882,
      "SupportAssociateId": 119,
      "CategoryName": "VIP Customer",
      "PersonNumber": "625169",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 203
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "qui",
  "Xstop": false,
  "ActiveInterests": 338,
  "GroupId": 539,
  "ActiveStatusMonitorId": 109,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 166,
  "DbiAgentId": 183,
  "DbiLastSyncronized": "2012-01-03T03:45:23.1861021+01:00",
  "DbiKey": "placeat",
  "DbiLastModified": "2023-02-14T03:45:23.1861021+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 72,
  "ActiveErpLinks": 153,
  "BounceEmails": [
    "nora_rath@kemmer.ca",
    "brycen@jenkins.us"
  ],
  "Domains": [
    "ducimus",
    "error"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Jamir Ebert",
    "SuperOffice:2": "Elliot Renner"
  },
  "ExtraFields": {
    "ExtraFields1": "cupiditate",
    "ExtraFields2": "aspernatur"
  },
  "CustomFields": {
    "CustomFields1": "nemo",
    "CustomFields2": "voluptatem"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 123
    }
  }
}
```