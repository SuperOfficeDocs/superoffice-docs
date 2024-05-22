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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 92,
  "Name": "Schmidt Group",
  "Department": "",
  "OrgNr": "604522",
  "Number1": "942261",
  "Number2": "859764",
  "UpdatedDate": "2008-09-11T12:57:33.5399622+02:00",
  "CreatedDate": "2011-03-01T12:57:33.5399622+01:00",
  "Emails": [
    {
      "Value": "molestiae",
      "StrippedValue": "magni",
      "Description": "Up-sized 6th generation encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 76
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "magni",
      "Description": "Up-sized 6th generation encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 76
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 554,
      "Name": "Hodkiewicz, Hermiston and Block",
      "ToolTip": "Velit et.",
      "Deleted": true,
      "Rank": 785,
      "Type": "est",
      "ColorBlock": 228,
      "IconHint": "quod",
      "Selected": true,
      "LastChanged": "2022-04-09T12:57:33.5399622+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eos",
      "StyleHint": "vero",
      "Hidden": true,
      "FullName": "Johan Gusikowski",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 69
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Mandatory hybrid system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 311
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Mandatory hybrid system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 311
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "laboriosam",
      "StrippedValue": "velit",
      "Description": "Configurable even-keeled portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 821
        }
      }
    },
    {
      "Value": "laboriosam",
      "StrippedValue": "velit",
      "Description": "Configurable even-keeled portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 821
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "vel",
      "StrippedValue": "voluptatem",
      "Description": "Public-key responsive core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 607
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "voluptatem",
      "Description": "Public-key responsive core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 607
        }
      }
    }
  ],
  "Description": "Optional exuding capability",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quo",
      "PersonId": 911,
      "Mrmrs": "expedita",
      "Firstname": "Daija",
      "Lastname": "Nolan",
      "MiddleName": "Lowe-Brekke",
      "Title": "vitae",
      "Description": "Ergonomic systemic approach",
      "Email": "tatum_wolf@gutkowskiquitzon.co.uk",
      "FullName": "Manley Padberg",
      "DirectPhone": "365.204.6835",
      "FormalName": "Steuber-Torp",
      "CountryId": 240,
      "ContactId": 722,
      "ContactName": "Reilly-Powlowski",
      "Retired": 711,
      "Rank": 770,
      "ActiveInterests": 8,
      "ContactDepartment": "",
      "ContactCountryId": 417,
      "ContactOrgNr": "1545598",
      "FaxPhone": "932.656.1557",
      "MobilePhone": "(876)508-0665 x169",
      "ContactPhone": "385.649.4206",
      "AssociateName": "Tromp Inc and Sons",
      "AssociateId": 144,
      "UsePersonAddress": false,
      "ContactFax": "at",
      "Kanafname": "numquam",
      "Kanalname": "vitae",
      "Post1": "sit",
      "Post2": "totam",
      "Post3": "nam",
      "EmailName": "nya.thompson@eichmannwehner.us",
      "ContactFullName": "Miss Efrain Darwin Stracke",
      "ActiveErpLinks": 305,
      "TicketPriorityId": 71,
      "SupportLanguageId": 826,
      "SupportAssociateId": 430,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 124
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "nostrum",
  "Xstop": false,
  "ActiveInterests": 358,
  "GroupId": 338,
  "ActiveStatusMonitorId": 823,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 918,
  "DbiAgentId": 804,
  "DbiLastSyncronized": "2015-11-23T12:57:33.5399622+01:00",
  "DbiKey": "aut",
  "DbiLastModified": "1997-01-25T12:57:33.5399622+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 480,
  "ActiveErpLinks": 153,
  "BounceEmails": [
    "nick@koepp.uk",
    "dusty_reichert@bergstrom.biz"
  ],
  "Domains": [
    "suscipit",
    "quis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Faye Kutch",
    "SuperOffice:2": "Constantin Tremblay"
  },
  "ExtraFields": {
    "ExtraFields1": "molestiae",
    "ExtraFields2": "blanditiis"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "dolore"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 270
    }
  }
}
```