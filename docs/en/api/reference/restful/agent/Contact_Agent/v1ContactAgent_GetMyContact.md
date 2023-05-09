---
title: POST Agents/Contact/GetMyContact
uid: v1ContactAgent_GetMyContact
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
POST /api/v1/Agents/Contact/GetMyContact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 422,
  "Name": "Larson-Von",
  "Department": "",
  "OrgNr": "1481116",
  "Number1": "1430529",
  "Number2": "1323632",
  "UpdatedDate": "1996-09-23T03:51:26.8655518+02:00",
  "CreatedDate": "1998-05-23T03:51:26.8655518+02:00",
  "Emails": [
    {
      "Value": "laudantium",
      "StrippedValue": "amet",
      "Description": "Up-sized tangible algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 60
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "amet",
      "Description": "Up-sized tangible algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 60
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 996,
      "Name": "Sawayn Inc and Sons",
      "ToolTip": "Quaerat sit fuga eos molestias perferendis.",
      "Deleted": false,
      "Rank": 531,
      "Type": "aspernatur",
      "ColorBlock": 31,
      "IconHint": "soluta",
      "Selected": false,
      "LastChanged": "2023-03-05T03:51:26.8655518+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "repellat",
      "Hidden": true,
      "FullName": "Ms. Lisette Casper",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 760
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "id",
      "StrippedValue": "dicta",
      "Description": "Optional human-resource frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 294
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "dicta",
      "Description": "Optional human-resource frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 294
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "perferendis",
      "StrippedValue": "nihil",
      "Description": "Vision-oriented motivating migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 817
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "nihil",
      "Description": "Vision-oriented motivating migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 817
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "veritatis",
      "StrippedValue": "voluptatem",
      "Description": "Re-contextualized even-keeled interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 426
        }
      }
    },
    {
      "Value": "veritatis",
      "StrippedValue": "voluptatem",
      "Description": "Re-contextualized even-keeled interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 426
        }
      }
    }
  ],
  "Description": "Innovative needs-based local area network",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "perspiciatis",
      "PersonId": 212,
      "Mrmrs": "et",
      "Firstname": "Golda",
      "Lastname": "Mayer",
      "MiddleName": "Funk, Doyle and Lemke",
      "Title": "aliquid",
      "Description": "Switchable needs-based ability",
      "Email": "gavin@towne.co.uk",
      "FullName": "Virginie Schmeler",
      "DirectPhone": "(717)074-9775 x45286",
      "FormalName": "Powlowski Inc and Sons",
      "CountryId": 291,
      "ContactId": 976,
      "ContactName": "Bruen, Leannon and Renner",
      "Retired": 654,
      "Rank": 477,
      "ActiveInterests": 877,
      "ContactDepartment": "",
      "ContactCountryId": 888,
      "ContactOrgNr": "1133969",
      "FaxPhone": "(074)794-4496 x050",
      "MobilePhone": "629.175.8827 x06819",
      "ContactPhone": "1-958-535-4429",
      "AssociateName": "Morissette-Mohr",
      "AssociateId": 834,
      "UsePersonAddress": false,
      "ContactFax": "velit",
      "Kanafname": "voluptate",
      "Kanalname": "consectetur",
      "Post1": "sunt",
      "Post2": "error",
      "Post3": "voluptatem",
      "EmailName": "malcolm@hodkiewicz.us",
      "ContactFullName": "Jessica Schamberger",
      "ActiveErpLinks": 325,
      "TicketPriorityId": 489,
      "SupportLanguageId": 411,
      "SupportAssociateId": 467,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 699
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "quaerat",
  "Xstop": true,
  "ActiveInterests": 937,
  "GroupId": 423,
  "ActiveStatusMonitorId": 693,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 179,
  "DbiAgentId": 19,
  "DbiLastSyncronized": "2020-06-24T03:51:26.8655518+02:00",
  "DbiKey": "iure",
  "DbiLastModified": "2022-01-20T03:51:26.8655518+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 479,
  "ActiveErpLinks": 698,
  "BounceEmails": [
    "lauren@moen.co.uk",
    "reta@johnstongerlach.name"
  ],
  "Domains": [
    "nisi",
    "aut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Abraham Schaden",
    "SuperOffice:2": "Noah Jacobs"
  },
  "ExtraFields": {
    "ExtraFields1": "explicabo",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "sunt",
    "CustomFields2": "earum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 127
    }
  }
}
```