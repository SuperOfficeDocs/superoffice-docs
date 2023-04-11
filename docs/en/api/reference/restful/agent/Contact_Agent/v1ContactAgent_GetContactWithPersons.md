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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 750
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 802,
  "Name": "Welch, O'Connell and Gislason",
  "Department": "",
  "OrgNr": "1431196",
  "Number1": "1497293",
  "Number2": "1180957",
  "UpdatedDate": "2014-11-07T15:29:21.132818+01:00",
  "CreatedDate": "2022-06-16T15:29:21.132818+02:00",
  "Emails": [
    {
      "Value": "maiores",
      "StrippedValue": "nobis",
      "Description": "Multi-layered contextually-based concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 195
        }
      }
    },
    {
      "Value": "maiores",
      "StrippedValue": "nobis",
      "Description": "Multi-layered contextually-based concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 195
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 831,
      "Name": "Kub, Crona and Aufderhar",
      "ToolTip": "Dolor tempora praesentium maiores eos.",
      "Deleted": true,
      "Rank": 821,
      "Type": "sapiente",
      "ColorBlock": 252,
      "IconHint": "corporis",
      "Selected": false,
      "LastChanged": "1999-01-26T15:29:21.1338182+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "laboriosam",
      "Hidden": false,
      "FullName": "Dr. Lane Annette Weimann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 313
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "nesciunt",
      "StrippedValue": "quia",
      "Description": "Focused 24 hour capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 517
        }
      }
    },
    {
      "Value": "nesciunt",
      "StrippedValue": "quia",
      "Description": "Focused 24 hour capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 517
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "enim",
      "StrippedValue": "ullam",
      "Description": "Public-key human-resource utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 788
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "ullam",
      "Description": "Public-key human-resource utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 788
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "tempora",
      "StrippedValue": "ea",
      "Description": "Customizable non-volatile architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 634
        }
      }
    },
    {
      "Value": "tempora",
      "StrippedValue": "ea",
      "Description": "Customizable non-volatile architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 634
        }
      }
    }
  ],
  "Description": "Optional reciprocal firmware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "et",
      "PersonId": 309,
      "Mrmrs": "cupiditate",
      "Firstname": "Dylan",
      "Lastname": "O'Reilly",
      "MiddleName": "Dooley-Schowalter",
      "Title": "voluptatum",
      "Description": "Configurable scalable collaboration",
      "Email": "mathilde.reilly@starkframi.uk",
      "FullName": "Pedro Hermiston",
      "DirectPhone": "548-198-1991 x53395",
      "FormalName": "Powlowski-Leannon",
      "CountryId": 375,
      "ContactId": 538,
      "ContactName": "White LLC",
      "Retired": 842,
      "Rank": 526,
      "ActiveInterests": 905,
      "ContactDepartment": "",
      "ContactCountryId": 125,
      "ContactOrgNr": "899958",
      "FaxPhone": "872.152.8649 x207",
      "MobilePhone": "749-334-2837",
      "ContactPhone": "357-843-7467",
      "AssociateName": "Runolfsson, Kulas and Konopelski",
      "AssociateId": 662,
      "UsePersonAddress": true,
      "ContactFax": "tenetur",
      "Kanafname": "laborum",
      "Kanalname": "possimus",
      "Post1": "voluptatem",
      "Post2": "numquam",
      "Post3": "excepturi",
      "EmailName": "coty.cartwright@tremblay.com",
      "ContactFullName": "Ms. Scotty Dicki DVM",
      "ActiveErpLinks": 136,
      "TicketPriorityId": 755,
      "SupportLanguageId": 54,
      "SupportAssociateId": 484,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 249
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "rerum",
  "Xstop": false,
  "ActiveInterests": 442,
  "GroupId": 436,
  "ActiveStatusMonitorId": 781,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 11,
  "DbiAgentId": 360,
  "DbiLastSyncronized": "1996-12-25T15:29:21.1373179+01:00",
  "DbiKey": "non",
  "DbiLastModified": "2020-09-18T15:29:21.1373179+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 440,
  "ActiveErpLinks": 508,
  "BounceEmails": [
    "otho@harris.info",
    "vivianne@fadelankunding.us"
  ],
  "Domains": [
    "ratione",
    "aut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Jaiden Thiel"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "eius",
    "CustomFields2": "expedita"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 629
    }
  }
}
```