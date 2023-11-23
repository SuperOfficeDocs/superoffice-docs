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
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=311
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
  "ContactId": 946,
  "Name": "Swift Inc and Sons",
  "Department": "",
  "OrgNr": "671871",
  "Number1": "869050",
  "Number2": "1120620",
  "UpdatedDate": "2021-10-07T13:38:13.3115228+02:00",
  "CreatedDate": "2021-04-20T13:38:13.3115228+02:00",
  "Emails": [
    {
      "Value": "aliquam",
      "StrippedValue": "in",
      "Description": "User-friendly multimedia projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 406
        }
      }
    },
    {
      "Value": "aliquam",
      "StrippedValue": "in",
      "Description": "User-friendly multimedia projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 406
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 561,
      "Name": "Reichert, Eichmann and Bartoletti",
      "ToolTip": "Molestias odit voluptas sed quibusdam similique sunt.",
      "Deleted": false,
      "Rank": 479,
      "Type": "sed",
      "ColorBlock": 430,
      "IconHint": "est",
      "Selected": true,
      "LastChanged": "2021-11-12T13:38:13.3115228+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolor",
      "StyleHint": "voluptas",
      "Hidden": false,
      "FullName": "Amiya Boyer III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 879
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "rem",
      "StrippedValue": "similique",
      "Description": "Synergistic intangible artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 983
        }
      }
    },
    {
      "Value": "rem",
      "StrippedValue": "similique",
      "Description": "Synergistic intangible artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 983
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "nesciunt",
      "StrippedValue": "quisquam",
      "Description": "Cross-platform exuding matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 60
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "quisquam",
      "Description": "Cross-platform exuding matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 60
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "recusandae",
      "StrippedValue": "ullam",
      "Description": "Mandatory contextually-based encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 273
        }
      }
    },
    {
      "Value": "recusandae",
      "StrippedValue": "ullam",
      "Description": "Mandatory contextually-based encryption",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 273
        }
      }
    }
  ],
  "Description": "Inverse systematic complexity",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "officia",
      "PersonId": 631,
      "Mrmrs": "commodi",
      "Firstname": "Cody",
      "Lastname": "Walter",
      "MiddleName": "Macejkovic-Conroy",
      "Title": "aut",
      "Description": "Horizontal scalable framework",
      "Email": "karlie_cole@raynorkris.co.uk",
      "FullName": "Aubree Schmitt",
      "DirectPhone": "886.603.7751 x6896",
      "FormalName": "Kunze Inc and Sons",
      "CountryId": 423,
      "ContactId": 158,
      "ContactName": "Stamm-Yost",
      "Retired": 955,
      "Rank": 85,
      "ActiveInterests": 79,
      "ContactDepartment": "",
      "ContactCountryId": 638,
      "ContactOrgNr": "1163080",
      "FaxPhone": "(143)031-2497 x32299",
      "MobilePhone": "416-239-3567 x245",
      "ContactPhone": "586.759.1039 x712",
      "AssociateName": "Lowe-Murphy",
      "AssociateId": 640,
      "UsePersonAddress": false,
      "ContactFax": "laborum",
      "Kanafname": "vel",
      "Kanalname": "quia",
      "Post1": "facilis",
      "Post2": "explicabo",
      "Post3": "consequatur",
      "EmailName": "brock_gerlach@rath.co.uk",
      "ContactFullName": "Baron Volkman",
      "ActiveErpLinks": 563,
      "TicketPriorityId": 536,
      "SupportLanguageId": 71,
      "SupportAssociateId": 923,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 764
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "non",
  "Xstop": false,
  "ActiveInterests": 745,
  "GroupId": 829,
  "ActiveStatusMonitorId": 874,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 414,
  "DbiAgentId": 684,
  "DbiLastSyncronized": "2017-07-09T13:38:13.3115228+02:00",
  "DbiKey": "recusandae",
  "DbiLastModified": "2007-01-08T13:38:13.3115228+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 481,
  "ActiveErpLinks": 611,
  "BounceEmails": [
    "fabiola@gleichner.us",
    "myron_dietrich@pagacyost.biz"
  ],
  "Domains": [
    "voluptatem",
    "qui"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Laron Casper",
    "SuperOffice:2": "Monroe Bechtelar DDS"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "ea"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 859
    }
  }
}
```