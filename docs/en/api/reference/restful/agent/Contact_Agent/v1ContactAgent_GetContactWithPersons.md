---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
---

# POST Agents/Contact/GetContactWithPersons

```http
POST /api/v1/Agents/Contact/GetContactWithPersons
```

Returns the contact with all the contact persons belonging to the contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactWithPersons?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: request 

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 471
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 928,
  "Name": "Crooks Inc and Sons",
  "Department": "",
  "OrgNr": "372112",
  "Number1": "1563799",
  "Number2": "974971",
  "UpdatedDate": "2006-04-24T11:22:37.6804887+02:00",
  "CreatedDate": "2011-03-18T11:22:37.6804887+01:00",
  "Emails": [
    {
      "Value": "nisi",
      "StrippedValue": "officia",
      "Description": "Phased exuding implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 222
        }
      }
    },
    {
      "Value": "nisi",
      "StrippedValue": "officia",
      "Description": "Phased exuding implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 222
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 19,
      "Name": "O'Kon Inc and Sons",
      "ToolTip": "Tempora quo.",
      "Deleted": false,
      "Rank": 548,
      "Type": "quia",
      "ColorBlock": 408,
      "IconHint": "voluptatem",
      "Selected": false,
      "LastChanged": "2012-12-06T11:22:37.6804887+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quis",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Donato Jeramy Trantow Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 441
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "omnis",
      "StrippedValue": "dolores",
      "Description": "Triple-buffered 6th generation model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 854
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "dolores",
      "Description": "Triple-buffered 6th generation model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 854
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "temporibus",
      "StrippedValue": "perspiciatis",
      "Description": "Fundamental tangible interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 167
        }
      }
    },
    {
      "Value": "temporibus",
      "StrippedValue": "perspiciatis",
      "Description": "Fundamental tangible interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 167
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "accusamus",
      "StrippedValue": "quod",
      "Description": "Expanded optimal system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 167
        }
      }
    },
    {
      "Value": "accusamus",
      "StrippedValue": "quod",
      "Description": "Expanded optimal system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 167
        }
      }
    }
  ],
  "Description": "Ergonomic exuding orchestration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "soluta",
      "PersonId": 793,
      "Mrmrs": "ad",
      "Firstname": "Diana",
      "Lastname": "Ferry",
      "MiddleName": "Senger Group",
      "Title": "odit",
      "Description": "Switchable zero defect infrastructure",
      "Email": "katarina_schuppe@nitzsche.ca",
      "FullName": "Giovanna Ruecker",
      "DirectPhone": "1-642-389-0701 x84566",
      "FormalName": "Medhurst, Reilly and O'Hara",
      "CountryId": 188,
      "ContactId": 952,
      "ContactName": "Dietrich-Langosh",
      "Retired": 110,
      "Rank": 759,
      "ActiveInterests": 346,
      "ContactDepartment": "",
      "ContactCountryId": 101,
      "ContactOrgNr": "287923",
      "FaxPhone": "597.645.1088 x967",
      "MobilePhone": "848-464-0907 x54606",
      "ContactPhone": "815.182.2109 x3433",
      "AssociateName": "Nicolas, Gleason and Kerluke",
      "AssociateId": 600,
      "UsePersonAddress": true,
      "ContactFax": "ipsum",
      "Kanafname": "sunt",
      "Kanalname": "perspiciatis",
      "Post1": "non",
      "Post2": "illo",
      "Post3": "qui",
      "EmailName": "eda@tremblay.com",
      "ContactFullName": "Ms. Katherine Reichel",
      "ActiveErpLinks": 172,
      "TicketPriorityId": 338,
      "SupportLanguageId": 788,
      "SupportAssociateId": 49,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 515
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "illum",
  "Xstop": false,
  "ActiveInterests": 924,
  "GroupId": 81,
  "ActiveStatusMonitorId": 811,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 557,
  "DbiAgentId": 856,
  "DbiLastSyncronized": "2008-11-24T11:22:37.6804887+01:00",
  "DbiKey": "necessitatibus",
  "DbiLastModified": "2012-12-24T11:22:37.6804887+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 113,
  "ActiveErpLinks": 22,
  "BounceEmails": [
    "jazmyne_lang@hoegerwest.co.uk",
    "danika_conn@daugherty.com"
  ],
  "Domains": [
    "possimus",
    "nisi"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Micheal Jayda Lakin II",
    "SuperOffice:2": "Troy Prosacco Sr."
  },
  "ExtraFields": {
    "ExtraFields1": "repudiandae",
    "ExtraFields2": "quod"
  },
  "CustomFields": {
    "CustomFields1": "deserunt",
    "CustomFields2": "aliquid"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 526
    }
  }
}
```