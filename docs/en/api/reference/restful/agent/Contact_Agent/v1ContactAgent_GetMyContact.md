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
  "ContactId": 172,
  "Name": "Fritsch-Abshire",
  "Department": "",
  "OrgNr": "1237836",
  "Number1": "1219428",
  "Number2": "974072",
  "UpdatedDate": "2018-09-11T11:44:33.0879646+02:00",
  "CreatedDate": "2010-03-16T11:44:33.0879646+01:00",
  "Emails": [
    {
      "Value": "autem",
      "StrippedValue": "asperiores",
      "Description": "Synchronised empowering customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 577
        }
      }
    },
    {
      "Value": "autem",
      "StrippedValue": "asperiores",
      "Description": "Synchronised empowering customer loyalty",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 577
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 967,
      "Name": "West-Mertz",
      "ToolTip": "Molestiae autem unde.",
      "Deleted": false,
      "Rank": 284,
      "Type": "ea",
      "ColorBlock": 212,
      "IconHint": "culpa",
      "Selected": false,
      "LastChanged": "2008-09-12T11:44:33.0879646+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "veniam",
      "StyleHint": "voluptas",
      "Hidden": false,
      "FullName": "Prof. Bernice Jeramy Green",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 351
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "animi",
      "StrippedValue": "asperiores",
      "Description": "Virtual uniform info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 950
        }
      }
    },
    {
      "Value": "animi",
      "StrippedValue": "asperiores",
      "Description": "Virtual uniform info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 950
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ut",
      "StrippedValue": "assumenda",
      "Description": "Assimilated bi-directional interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 181
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "assumenda",
      "Description": "Assimilated bi-directional interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 181
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "cupiditate",
      "StrippedValue": "ab",
      "Description": "Automated explicit internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 633
        }
      }
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "ab",
      "Description": "Automated explicit internet solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 633
        }
      }
    }
  ],
  "Description": "Sharable encompassing budgetary management",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eius",
      "PersonId": 760,
      "Mrmrs": "et",
      "Firstname": "Maci",
      "Lastname": "Walter",
      "MiddleName": "Kovacek Inc and Sons",
      "Title": "quidem",
      "Description": "Object-based bifurcated contingency",
      "Email": "elisabeth@greenholt.uk",
      "FullName": "Ms. Jasper Oberbrunner II",
      "DirectPhone": "562.547.4128",
      "FormalName": "Lind-Nicolas",
      "CountryId": 970,
      "ContactId": 736,
      "ContactName": "Predovic, Metz and Koss",
      "Retired": 841,
      "Rank": 171,
      "ActiveInterests": 342,
      "ContactDepartment": "",
      "ContactCountryId": 358,
      "ContactOrgNr": "1357565",
      "FaxPhone": "1-666-495-8940 x14841",
      "MobilePhone": "034-003-8615 x2635",
      "ContactPhone": "1-271-722-4526 x6777",
      "AssociateName": "Gutkowski-Harvey",
      "AssociateId": 483,
      "UsePersonAddress": false,
      "ContactFax": "autem",
      "Kanafname": "porro",
      "Kanalname": "laboriosam",
      "Post1": "quis",
      "Post2": "qui",
      "Post3": "officiis",
      "EmailName": "delia_stroman@mohr.uk",
      "ContactFullName": "Ulises Mohr",
      "ActiveErpLinks": 33,
      "TicketPriorityId": 43,
      "SupportLanguageId": 936,
      "SupportAssociateId": 661,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 393
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "reiciendis",
  "Xstop": false,
  "ActiveInterests": 683,
  "GroupId": 424,
  "ActiveStatusMonitorId": 144,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 697,
  "DbiAgentId": 46,
  "DbiLastSyncronized": "1998-09-11T11:44:33.0879646+02:00",
  "DbiKey": "qui",
  "DbiLastModified": "2008-12-15T11:44:33.0879646+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 525,
  "ActiveErpLinks": 256,
  "BounceEmails": [
    "lucy@schowalter.ca",
    "ricardo_doyle@nolanwhite.uk"
  ],
  "Domains": [
    "ut",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Myrl Vandervort",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "tempora"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "quia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 368
    }
  }
}
```