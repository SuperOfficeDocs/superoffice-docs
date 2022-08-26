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
| ContactId | int32 |  |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 484
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 993,
  "Name": "Dietrich-Tromp",
  "Department": "morph 24/365 communities",
  "OrgNr": "695426",
  "Number1": "935561",
  "Number2": "983869",
  "UpdatedDate": "2021-09-27T11:10:26.2835604+02:00",
  "CreatedDate": "2011-10-11T11:10:26.2835604+02:00",
  "Emails": [
    {
      "Value": "quam",
      "StrippedValue": "hic",
      "Description": "Right-sized scalable productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 459
        }
      }
    },
    {
      "Value": "quam",
      "StrippedValue": "hic",
      "Description": "Right-sized scalable productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 459
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 263,
      "Name": "Dare-Kovacek",
      "ToolTip": "Perspiciatis architecto voluptas ullam illo sunt quis quibusdam.",
      "Deleted": false,
      "Rank": 968,
      "Type": "ad",
      "ColorBlock": 541,
      "IconHint": "illo",
      "Selected": false,
      "LastChanged": "1999-06-26T11:10:26.2835604+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vitae",
      "StyleHint": "magnam",
      "Hidden": false,
      "FullName": "Dr. Jacinthe Braun",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 773
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "eos",
      "StrippedValue": "id",
      "Description": "Synergized uniform standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 927
        }
      }
    },
    {
      "Value": "eos",
      "StrippedValue": "id",
      "Description": "Synergized uniform standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 927
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "aspernatur",
      "StrippedValue": "quia",
      "Description": "Polarised 6th generation structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 552
        }
      }
    },
    {
      "Value": "aspernatur",
      "StrippedValue": "quia",
      "Description": "Polarised 6th generation structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 552
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatem",
      "StrippedValue": "et",
      "Description": "Fundamental 24 hour monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 208
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "et",
      "Description": "Fundamental 24 hour monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 208
        }
      }
    }
  ],
  "Description": "Multi-layered 24 hour standardization",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quasi",
      "PersonId": 793,
      "Mrmrs": "vitae",
      "Firstname": "Lou",
      "Lastname": "Considine",
      "MiddleName": "Glover Group",
      "Title": "esse",
      "Description": "Enterprise-wide dedicated capacity",
      "Email": "linnea@gutmann.us",
      "FullName": "Esther Medhurst",
      "DirectPhone": "1-378-186-3956",
      "FormalName": "O'Reilly, Wolff and Fadel",
      "CountryId": 267,
      "ContactId": 214,
      "ContactName": "Herman Inc and Sons",
      "Retired": 636,
      "Rank": 252,
      "ActiveInterests": 886,
      "ContactDepartment": "",
      "ContactCountryId": 600,
      "ContactOrgNr": "303188",
      "FaxPhone": "356.837.1858 x0840",
      "MobilePhone": "917-575-6068 x28936",
      "ContactPhone": "(536)242-7853 x899",
      "AssociateName": "Mann, Heathcote and McDermott",
      "AssociateId": 900,
      "UsePersonAddress": false,
      "ContactFax": "rerum",
      "Kanafname": "dicta",
      "Kanalname": "ut",
      "Post1": "eligendi",
      "Post2": "enim",
      "Post3": "ad",
      "EmailName": "stephon_predovic@torp.com",
      "ContactFullName": "Freida Torp",
      "ActiveErpLinks": 802,
      "TicketPriorityId": 409,
      "SupportLanguageId": 671,
      "SupportAssociateId": 748,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 871
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "omnis",
  "Xstop": false,
  "ActiveInterests": 664,
  "GroupId": 815,
  "ActiveStatusMonitorId": 17,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 960,
  "DbiAgentId": 525,
  "DbiLastSyncronized": "2009-03-20T11:10:26.2885535+01:00",
  "DbiKey": "sapiente",
  "DbiLastModified": "2012-12-24T11:10:26.2885535+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 730,
  "ActiveErpLinks": 322,
  "BounceEmails": [
    "garnet@little.info",
    "wiley@reynolds.us"
  ],
  "Domains": [
    "aut",
    "voluptatum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1873434259",
    "SuperOffice:2": "276550569"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "sequi"
  },
  "CustomFields": {
    "CustomFields1": "assumenda",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 353
    }
  }
}
```