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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 667
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 963,
  "Name": "Pouros, Sauer and Fay",
  "Department": "",
  "OrgNr": "1609096",
  "Number1": "453577",
  "Number2": "983233",
  "UpdatedDate": "2014-08-31T02:49:43.9347802+02:00",
  "CreatedDate": "2016-06-15T02:49:43.9347802+02:00",
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "maiores",
      "Description": "Persevering next generation project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 166
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "maiores",
      "Description": "Persevering next generation project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 166
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 507,
      "Name": "Schoen, Kirlin and Mueller",
      "ToolTip": "Rerum qui quia deserunt iure.",
      "Deleted": false,
      "Rank": 966,
      "Type": "fugiat",
      "ColorBlock": 857,
      "IconHint": "ducimus",
      "Selected": false,
      "LastChanged": "1996-06-12T02:49:43.9347802+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ea",
      "StyleHint": "neque",
      "Hidden": false,
      "FullName": "Anika Waelchi",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 155
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "at",
      "StrippedValue": "est",
      "Description": "Extended zero tolerance array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 436
        }
      }
    },
    {
      "Value": "at",
      "StrippedValue": "est",
      "Description": "Extended zero tolerance array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 436
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ipsam",
      "StrippedValue": "voluptas",
      "Description": "Implemented full-range collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 671
        }
      }
    },
    {
      "Value": "ipsam",
      "StrippedValue": "voluptas",
      "Description": "Implemented full-range collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 671
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quod",
      "StrippedValue": "quaerat",
      "Description": "Progressive background superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 225
        }
      }
    },
    {
      "Value": "quod",
      "StrippedValue": "quaerat",
      "Description": "Progressive background superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 225
        }
      }
    }
  ],
  "Description": "Multi-layered fault-tolerant encoding",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "a",
      "PersonId": 786,
      "Mrmrs": "nisi",
      "Firstname": "Irma",
      "Lastname": "Zieme",
      "MiddleName": "Pagac-Corkery",
      "Title": "non",
      "Description": "Advanced didactic firmware",
      "Email": "kayla@kundewunsch.biz",
      "FullName": "Taurean Rolfson",
      "DirectPhone": "(798)775-3295 x2967",
      "FormalName": "Bode, Kunde and Walker",
      "CountryId": 746,
      "ContactId": 592,
      "ContactName": "Runte LLC",
      "Retired": 836,
      "Rank": 741,
      "ActiveInterests": 549,
      "ContactDepartment": "",
      "ContactCountryId": 135,
      "ContactOrgNr": "1397890",
      "FaxPhone": "(895)432-6436",
      "MobilePhone": "1-809-588-5170",
      "ContactPhone": "(421)838-3963 x6216",
      "AssociateName": "Toy-Rau",
      "AssociateId": 737,
      "UsePersonAddress": false,
      "ContactFax": "deserunt",
      "Kanafname": "voluptates",
      "Kanalname": "asperiores",
      "Post1": "adipisci",
      "Post2": "sed",
      "Post3": "culpa",
      "EmailName": "margaretta_collier@oconnell.uk",
      "ContactFullName": "Theron McClure",
      "ActiveErpLinks": 704,
      "TicketPriorityId": 83,
      "SupportLanguageId": 704,
      "SupportAssociateId": 609,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 231
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "tempore",
  "Xstop": true,
  "ActiveInterests": 483,
  "GroupId": 75,
  "ActiveStatusMonitorId": 48,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 611,
  "DbiAgentId": 709,
  "DbiLastSyncronized": "2015-06-22T02:49:43.9347802+02:00",
  "DbiKey": "et",
  "DbiLastModified": "2012-10-24T02:49:43.9347802+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 180,
  "ActiveErpLinks": 911,
  "BounceEmails": [
    "karen_mueller@jast.ca",
    "lily_oreilly@quitzon.biz"
  ],
  "Domains": [
    "culpa",
    "exercitationem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Clyde Adams PhD",
    "SuperOffice:2": "301299020"
  },
  "ExtraFields": {
    "ExtraFields1": "ratione",
    "ExtraFields2": "maxime"
  },
  "CustomFields": {
    "CustomFields1": "sint",
    "CustomFields2": "adipisci"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 944
    }
  }
}
```