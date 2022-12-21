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
  "ContactId": 33,
  "Name": "Hagenes, Dickinson and Waelchi",
  "Department": "",
  "OrgNr": "526174",
  "Number1": "1278956",
  "Number2": "874954",
  "UpdatedDate": "2005-01-28T02:49:43.9347802+01:00",
  "CreatedDate": "2014-01-09T02:49:43.9347802+01:00",
  "Emails": [
    {
      "Value": "praesentium",
      "StrippedValue": "est",
      "Description": "Sharable zero tolerance attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 214
        }
      }
    },
    {
      "Value": "praesentium",
      "StrippedValue": "est",
      "Description": "Sharable zero tolerance attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 214
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 545,
      "Name": "Jakubowski, Bergstrom and Huels",
      "ToolTip": "Autem illum.",
      "Deleted": true,
      "Rank": 850,
      "Type": "commodi",
      "ColorBlock": 634,
      "IconHint": "natus",
      "Selected": false,
      "LastChanged": "2017-04-26T02:49:43.9347802+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "suscipit",
      "StyleHint": "provident",
      "Hidden": false,
      "FullName": "Samir Gerhold",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 648
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "dicta",
      "StrippedValue": "consequatur",
      "Description": "Stand-alone user-facing system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 47
        }
      }
    },
    {
      "Value": "dicta",
      "StrippedValue": "consequatur",
      "Description": "Stand-alone user-facing system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 47
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "debitis",
      "StrippedValue": "ea",
      "Description": "Multi-channelled high-level knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 367
        }
      }
    },
    {
      "Value": "debitis",
      "StrippedValue": "ea",
      "Description": "Multi-channelled high-level knowledge user",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 367
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "iste",
      "Description": "Decentralized encompassing implementation",
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
      "Value": "et",
      "StrippedValue": "iste",
      "Description": "Decentralized encompassing implementation",
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
  "Description": "Enterprise-wide real-time protocol",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "facere",
      "PersonId": 854,
      "Mrmrs": "ad",
      "Firstname": "Vance",
      "Lastname": "Schamberger",
      "MiddleName": "Baumbach-Mante",
      "Title": "nihil",
      "Description": "Decentralized scalable implementation",
      "Email": "theron.goodwin@beatty.us",
      "FullName": "Buddy Lang",
      "DirectPhone": "1-672-946-4319 x464",
      "FormalName": "Gottlieb Group",
      "CountryId": 352,
      "ContactId": 125,
      "ContactName": "Bahringer-Cummings",
      "Retired": 636,
      "Rank": 788,
      "ActiveInterests": 216,
      "ContactDepartment": "",
      "ContactCountryId": 524,
      "ContactOrgNr": "824242",
      "FaxPhone": "170-834-7822",
      "MobilePhone": "446.607.2671",
      "ContactPhone": "(546)111-9712 x1509",
      "AssociateName": "Emmerich, Kris and Reilly",
      "AssociateId": 222,
      "UsePersonAddress": true,
      "ContactFax": "reiciendis",
      "Kanafname": "sapiente",
      "Kanalname": "magnam",
      "Post1": "id",
      "Post2": "consequatur",
      "Post3": "ullam",
      "EmailName": "clair.nicolas@koss.co.uk",
      "ContactFullName": "Aiyana Ortiz DVM",
      "ActiveErpLinks": 198,
      "TicketPriorityId": 626,
      "SupportLanguageId": 142,
      "SupportAssociateId": 373,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 135
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "fugit",
  "Xstop": false,
  "ActiveInterests": 222,
  "GroupId": 60,
  "ActiveStatusMonitorId": 667,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 372,
  "DbiAgentId": 123,
  "DbiLastSyncronized": "2012-05-31T02:49:43.9504047+02:00",
  "DbiKey": "qui",
  "DbiLastModified": "2006-09-07T02:49:43.9504047+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 389,
  "ActiveErpLinks": 924,
  "BounceEmails": [
    "lorenza_sporer@koch.info",
    "mattie@oreillyullrich.uk"
  ],
  "Domains": [
    "officia",
    "ut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1441404186",
    "SuperOffice:2": "Mrs. Melissa Shields"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "nam"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "aspernatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 599
    }
  }
}
```