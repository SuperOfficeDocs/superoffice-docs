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
  "ContactId": 162,
  "Name": "Ledner Group",
  "Department": "",
  "OrgNr": "977811",
  "Number1": "1196112",
  "Number2": "1268307",
  "UpdatedDate": "2002-11-10T14:13:39.8286111+01:00",
  "CreatedDate": "2021-06-11T14:13:39.8286111+02:00",
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "doloremque",
      "Description": "Programmable interactive function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 388
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "doloremque",
      "Description": "Programmable interactive function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 388
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 780,
      "Name": "Okuneva LLC",
      "ToolTip": "Nobis ut quia ratione provident accusantium.",
      "Deleted": false,
      "Rank": 887,
      "Type": "illo",
      "ColorBlock": 213,
      "IconHint": "reprehenderit",
      "Selected": false,
      "LastChanged": "2020-04-16T14:13:39.8286111+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "tempore",
      "StyleHint": "iste",
      "Hidden": false,
      "FullName": "Karlee Schultz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 116
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "iure",
      "Description": "Organic 6th generation framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 535
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "iure",
      "Description": "Organic 6th generation framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 535
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "deserunt",
      "StrippedValue": "repellat",
      "Description": "Re-contextualized explicit internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 914
        }
      }
    },
    {
      "Value": "deserunt",
      "StrippedValue": "repellat",
      "Description": "Re-contextualized explicit internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 914
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "odit",
      "StrippedValue": "ratione",
      "Description": "Quality-focused solution-oriented productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 502
        }
      }
    },
    {
      "Value": "odit",
      "StrippedValue": "ratione",
      "Description": "Quality-focused solution-oriented productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 502
        }
      }
    }
  ],
  "Description": "Cross-group object-oriented infrastructure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "omnis",
      "PersonId": 206,
      "Mrmrs": "sunt",
      "Firstname": "Garfield",
      "Lastname": "Weber",
      "MiddleName": "Jenkins, Nitzsche and Larkin",
      "Title": "et",
      "Description": "Down-sized context-sensitive software",
      "Email": "jacinto@roberts.biz",
      "FullName": "Elwyn Schamberger",
      "DirectPhone": "(517)991-6288",
      "FormalName": "Friesen Inc and Sons",
      "CountryId": 529,
      "ContactId": 388,
      "ContactName": "Bode, Bahringer and Feeney",
      "Retired": 533,
      "Rank": 753,
      "ActiveInterests": 884,
      "ContactDepartment": "",
      "ContactCountryId": 443,
      "ContactOrgNr": "1480250",
      "FaxPhone": "1-076-820-7113",
      "MobilePhone": "185-886-2893 x200",
      "ContactPhone": "652-517-6415 x79267",
      "AssociateName": "McClure-Hayes",
      "AssociateId": 969,
      "UsePersonAddress": true,
      "ContactFax": "numquam",
      "Kanafname": "et",
      "Kanalname": "sunt",
      "Post1": "accusamus",
      "Post2": "iste",
      "Post3": "itaque",
      "EmailName": "kyleigh_donnelly@dachmaggio.us",
      "ContactFullName": "Augustus O'Keefe",
      "ActiveErpLinks": 249,
      "TicketPriorityId": 194,
      "SupportLanguageId": 149,
      "SupportAssociateId": 181,
      "CategoryName": "VIP Customer",
      "PersonNumber": "540374",
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
  "NoMailing": false,
  "Kananame": "at",
  "Xstop": true,
  "ActiveInterests": 830,
  "GroupId": 532,
  "ActiveStatusMonitorId": 161,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 365,
  "DbiAgentId": 601,
  "DbiLastSyncronized": "2018-09-15T14:13:39.8286111+02:00",
  "DbiKey": "dolor",
  "DbiLastModified": "2004-01-03T14:13:39.8286111+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 40,
  "ActiveErpLinks": 546,
  "BounceEmails": [
    "genevieve@satterfieldkrajcik.ca",
    "myriam@ryanrutherford.us"
  ],
  "Domains": [
    "sed",
    "cumque"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Nico Zieme",
    "SuperOffice:2": "Brayan Powlowski"
  },
  "ExtraFields": {
    "ExtraFields1": "nobis",
    "ExtraFields2": "est"
  },
  "CustomFields": {
    "CustomFields1": "autem",
    "CustomFields2": "aliquid"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 379
    }
  }
}
```