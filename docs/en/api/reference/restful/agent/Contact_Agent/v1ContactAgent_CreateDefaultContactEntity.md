---
title: POST Agents/Contact/CreateDefaultContactEntity
uid: v1ContactAgent_CreateDefaultContactEntity
generated: true
---

# POST Agents/Contact/CreateDefaultContactEntity

```http
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
```

Set default values into a new ContactEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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
POST /api/v1/Agents/Contact/CreateDefaultContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 182,
  "Name": "Legros LLC",
  "Department": "disintermediate sticky users",
  "OrgNr": "757008",
  "Number1": "1202267",
  "Number2": "1564288",
  "UpdatedDate": "1998-11-13T11:06:34.0964784+01:00",
  "CreatedDate": "2008-12-19T11:06:34.0964784+01:00",
  "Emails": [
    {
      "Value": "nisi",
      "StrippedValue": "enim",
      "Description": "Robust national focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 317
        }
      }
    },
    {
      "Value": "nisi",
      "StrippedValue": "enim",
      "Description": "Robust national focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 317
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 339,
      "Name": "Von Group",
      "ToolTip": "Quos quaerat sint voluptatem et neque occaecati qui.",
      "Deleted": true,
      "Rank": 197,
      "Type": "consectetur",
      "ColorBlock": 188,
      "IconHint": "in",
      "Selected": true,
      "LastChanged": "2007-11-23T11:06:34.0964784+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ab",
      "StyleHint": "molestiae",
      "Hidden": false,
      "FullName": "Adam Langworth",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 119
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ratione",
      "StrippedValue": "blanditiis",
      "Description": "Balanced transitional website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 895
        }
      }
    },
    {
      "Value": "ratione",
      "StrippedValue": "blanditiis",
      "Description": "Balanced transitional website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 895
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "omnis",
      "StrippedValue": "ad",
      "Description": "Diverse actuating alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 29
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "ad",
      "Description": "Diverse actuating alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 29
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "enim",
      "StrippedValue": "excepturi",
      "Description": "Persevering heuristic database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 112
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "excepturi",
      "Description": "Persevering heuristic database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 112
        }
      }
    }
  ],
  "Description": "Open-architected multi-state groupware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "qui",
      "PersonId": 938,
      "Mrmrs": "accusantium",
      "Firstname": "Lysanne",
      "Lastname": "O'Reilly",
      "MiddleName": "Moen-Schulist",
      "Title": "omnis",
      "Description": "Diverse tangible secured line",
      "Email": "faustino@adams.uk",
      "FullName": "Niko McClure",
      "DirectPhone": "002-061-6454",
      "FormalName": "Shanahan-Glover",
      "CountryId": 385,
      "ContactId": 796,
      "ContactName": "Dare, Greenfelder and Harber",
      "Retired": 554,
      "Rank": 713,
      "ActiveInterests": 292,
      "ContactDepartment": "",
      "ContactCountryId": 947,
      "ContactOrgNr": "1402587",
      "FaxPhone": "571-583-4856 x5828",
      "MobilePhone": "(156)846-8427",
      "ContactPhone": "(210)523-4826",
      "AssociateName": "Johnston Group",
      "AssociateId": 555,
      "UsePersonAddress": false,
      "ContactFax": "itaque",
      "Kanafname": "sed",
      "Kanalname": "eum",
      "Post1": "molestiae",
      "Post2": "incidunt",
      "Post3": "magnam",
      "EmailName": "piper_connelly@beahan.name",
      "ContactFullName": "Shaina Price",
      "ActiveErpLinks": 993,
      "TicketPriorityId": 787,
      "SupportLanguageId": 963,
      "SupportAssociateId": 555,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 55
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "sit",
  "Xstop": false,
  "ActiveInterests": 247,
  "GroupId": 290,
  "ActiveStatusMonitorId": 215,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 15,
  "DbiAgentId": 278,
  "DbiLastSyncronized": "2003-10-29T11:06:34.0964784+01:00",
  "DbiKey": "vel",
  "DbiLastModified": "2006-12-13T11:06:34.0964784+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 510,
  "ActiveErpLinks": 830,
  "BounceEmails": [
    "noelia@purdy.name",
    "cydney@jacobi.ca"
  ],
  "Domains": [
    "velit",
    "officia"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Wyman Gleichner",
    "SuperOffice:2": "Elvie Auer"
  },
  "ExtraFields": {
    "ExtraFields1": "minima",
    "ExtraFields2": "nostrum"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "pariatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 664
    }
  }
}
```