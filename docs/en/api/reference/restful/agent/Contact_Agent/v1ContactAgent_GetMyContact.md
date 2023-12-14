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
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 89,
  "Name": "Towne Group",
  "Department": "",
  "OrgNr": "1445520",
  "Number1": "1237950",
  "Number2": "325175",
  "UpdatedDate": "1999-11-06T13:57:11.9342044+01:00",
  "CreatedDate": "2020-11-17T13:57:11.9342044+01:00",
  "Emails": [
    {
      "Value": "reiciendis",
      "StrippedValue": "quia",
      "Description": "Polarised national projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 46
        }
      }
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "quia",
      "Description": "Polarised national projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 46
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 138,
      "Name": "Bosco, Rodriguez and Bogan",
      "ToolTip": "Ratione quia.",
      "Deleted": false,
      "Rank": 119,
      "Type": "nulla",
      "ColorBlock": 36,
      "IconHint": "quaerat",
      "Selected": false,
      "LastChanged": "2000-08-30T13:57:11.9342044+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "inventore",
      "StyleHint": "quos",
      "Hidden": false,
      "FullName": "Margarett Schmitt",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 838
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "iste",
      "StrippedValue": "sit",
      "Description": "Public-key human-resource analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 196
        }
      }
    },
    {
      "Value": "iste",
      "StrippedValue": "sit",
      "Description": "Public-key human-resource analyzer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 196
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "delectus",
      "Description": "Enterprise-wide solution-oriented initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 728
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "delectus",
      "Description": "Enterprise-wide solution-oriented initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 728
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "atque",
      "StrippedValue": "cupiditate",
      "Description": "Re-engineered reciprocal concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 361
        }
      }
    },
    {
      "Value": "atque",
      "StrippedValue": "cupiditate",
      "Description": "Re-engineered reciprocal concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 361
        }
      }
    }
  ],
  "Description": "Cloned grid-enabled framework",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "velit",
      "PersonId": 840,
      "Mrmrs": "veniam",
      "Firstname": "Trudie",
      "Lastname": "Kub",
      "MiddleName": "Mosciski, Runolfsson and Kulas",
      "Title": "quod",
      "Description": "Robust holistic challenge",
      "Email": "talon.leannon@dach.ca",
      "FullName": "Mrs. Gayle Nienow",
      "DirectPhone": "682.393.8100",
      "FormalName": "Schultz-Ferry",
      "CountryId": 332,
      "ContactId": 252,
      "ContactName": "Fisher, Hegmann and Russel",
      "Retired": 346,
      "Rank": 22,
      "ActiveInterests": 709,
      "ContactDepartment": "",
      "ContactCountryId": 883,
      "ContactOrgNr": "891925",
      "FaxPhone": "093.583.8964 x87689",
      "MobilePhone": "1-457-444-2606 x67154",
      "ContactPhone": "784-029-6045 x9407",
      "AssociateName": "White, Hyatt and Weimann",
      "AssociateId": 556,
      "UsePersonAddress": true,
      "ContactFax": "aspernatur",
      "Kanafname": "ipsa",
      "Kanalname": "unde",
      "Post1": "perferendis",
      "Post2": "blanditiis",
      "Post3": "saepe",
      "EmailName": "maverick@wildermanratke.uk",
      "ContactFullName": "Anthony Champlin",
      "ActiveErpLinks": 362,
      "TicketPriorityId": 450,
      "SupportLanguageId": 699,
      "SupportAssociateId": 692,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 767
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptas",
  "Xstop": false,
  "ActiveInterests": 488,
  "GroupId": 761,
  "ActiveStatusMonitorId": 785,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 567,
  "DbiAgentId": 578,
  "DbiLastSyncronized": "2013-09-11T13:57:11.9342044+02:00",
  "DbiKey": "similique",
  "DbiLastModified": "2022-08-29T13:57:11.9342044+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 763,
  "ActiveErpLinks": 260,
  "BounceEmails": [
    "junior@reichel.uk",
    "armando_kilback@schmidt.name"
  ],
  "Domains": [
    "a",
    "voluptate"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "738371880",
    "SuperOffice:2": "Lucie Halvorson"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "eveniet"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "veniam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 901
    }
  }
}
```