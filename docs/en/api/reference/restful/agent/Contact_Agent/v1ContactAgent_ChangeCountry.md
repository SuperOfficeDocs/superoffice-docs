---
title: POST Agents/Contact/ChangeCountry
uid: v1ContactAgent_ChangeCountry
generated: true
---

# POST Agents/Contact/ChangeCountry

```http
POST /api/v1/Agents/Contact/ChangeCountry
```

Change country regenerates the default values and localized information such as phone number and address format







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/ChangeCountry?$select=name,department,category/id
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

ContactEntity, ToCountryId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactEntity | ContactEntity | The Contact Service. The service implements all services working with the Contact object <para /> Carrier object for ContactEntity. Services for the ContactEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IContactAgent">Contact Agent</see>. |
| ToCountryId | Integer |  |

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
POST /api/v1/Agents/Contact/ChangeCountry
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactEntity": null,
  "ToCountryId": 827
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 642,
  "Name": "Maggio Inc and Sons",
  "Department": "",
  "OrgNr": "891685",
  "Number1": "699042",
  "Number2": "1068076",
  "UpdatedDate": "2002-02-05T13:38:13.3427643+01:00",
  "CreatedDate": "2016-08-02T13:38:13.3427643+02:00",
  "Emails": [
    {
      "Value": "totam",
      "StrippedValue": "magni",
      "Description": "Secured leading edge policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 883
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "magni",
      "Description": "Secured leading edge policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 883
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 649,
      "Name": "Feil LLC",
      "ToolTip": "Occaecati deleniti et optio et.",
      "Deleted": false,
      "Rank": 208,
      "Type": "a",
      "ColorBlock": 605,
      "IconHint": "quo",
      "Selected": false,
      "LastChanged": "2007-07-03T13:38:13.3427643+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aliquid",
      "StyleHint": "qui",
      "Hidden": true,
      "FullName": "Prof. Maynard Ruecker",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 572
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "beatae",
      "Description": "Open-source intangible matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 407
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "beatae",
      "Description": "Open-source intangible matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 407
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "debitis",
      "StrippedValue": "reprehenderit",
      "Description": "Front-line actuating moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 38
        }
      }
    },
    {
      "Value": "debitis",
      "StrippedValue": "reprehenderit",
      "Description": "Front-line actuating moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 38
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptate",
      "StrippedValue": "quia",
      "Description": "Up-sized hybrid toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 234
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "quia",
      "Description": "Up-sized hybrid toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 234
        }
      }
    }
  ],
  "Description": "Right-sized high-level software",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "non",
      "PersonId": 284,
      "Mrmrs": "hic",
      "Firstname": "Margaretta",
      "Lastname": "Adams",
      "MiddleName": "Frami, Baumbach and Nienow",
      "Title": "cumque",
      "Description": "Monitored non-volatile website",
      "Email": "caleb@fadel.uk",
      "FullName": "Alba Jacobson Jr.",
      "DirectPhone": "1-235-670-0908 x9619",
      "FormalName": "Shields-Leannon",
      "CountryId": 789,
      "ContactId": 310,
      "ContactName": "Kub-Witting",
      "Retired": 232,
      "Rank": 667,
      "ActiveInterests": 939,
      "ContactDepartment": "",
      "ContactCountryId": 179,
      "ContactOrgNr": "370289",
      "FaxPhone": "861-837-0290",
      "MobilePhone": "(415)483-1534 x43257",
      "ContactPhone": "277.168.1714 x690",
      "AssociateName": "Hodkiewicz-Powlowski",
      "AssociateId": 107,
      "UsePersonAddress": false,
      "ContactFax": "fugit",
      "Kanafname": "quo",
      "Kanalname": "dolor",
      "Post1": "totam",
      "Post2": "quae",
      "Post3": "enim",
      "EmailName": "colton@krisolson.ca",
      "ContactFullName": "Sierra West",
      "ActiveErpLinks": 813,
      "TicketPriorityId": 879,
      "SupportLanguageId": 957,
      "SupportAssociateId": 466,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 329
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "expedita",
  "Xstop": false,
  "ActiveInterests": 452,
  "GroupId": 243,
  "ActiveStatusMonitorId": 688,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 42,
  "DbiAgentId": 741,
  "DbiLastSyncronized": "2017-06-01T13:38:13.3427643+02:00",
  "DbiKey": "voluptatum",
  "DbiLastModified": "2010-02-09T13:38:13.3427643+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 342,
  "ActiveErpLinks": 397,
  "BounceEmails": [
    "rosalee@kris.co.uk",
    "stacey@croninmclaughlin.name"
  ],
  "Domains": [
    "numquam",
    "et"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Olin Vicenta Murray",
    "SuperOffice:2": "Malinda Hirthe"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "modi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 953
    }
  }
}
```