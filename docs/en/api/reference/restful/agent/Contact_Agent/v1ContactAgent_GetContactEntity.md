---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
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
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=456
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 545,
  "Name": "Huel LLC",
  "Department": "",
  "OrgNr": "1197464",
  "Number1": "920331",
  "Number2": "1203340",
  "UpdatedDate": "2008-10-28T12:15:18.4937585+01:00",
  "CreatedDate": "2009-04-07T12:15:18.4937585+02:00",
  "Emails": [
    {
      "Value": "voluptates",
      "StrippedValue": "corporis",
      "Description": "Customer-focused mobile algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 980
        }
      }
    },
    {
      "Value": "voluptates",
      "StrippedValue": "corporis",
      "Description": "Customer-focused mobile algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 980
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 757,
      "Name": "Daugherty-Schneider",
      "ToolTip": "Vel est quibusdam alias enim officiis hic dicta.",
      "Deleted": false,
      "Rank": 460,
      "Type": "repellendus",
      "ColorBlock": 408,
      "IconHint": "animi",
      "Selected": false,
      "LastChanged": "2019-01-24T12:15:18.4937585+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "odio",
      "StyleHint": "nobis",
      "Hidden": true,
      "FullName": "Delmer Dooley",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 597
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "consequatur",
      "Description": "Secured maximized implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 751
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "consequatur",
      "Description": "Secured maximized implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 751
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ea",
      "StrippedValue": "aut",
      "Description": "Mandatory zero defect Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 21
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "aut",
      "Description": "Mandatory zero defect Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 21
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "consequatur",
      "StrippedValue": "consequuntur",
      "Description": "Managed asynchronous matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 491
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "consequuntur",
      "Description": "Managed asynchronous matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 491
        }
      }
    }
  ],
  "Description": "Devolved needs-based application",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quia",
      "PersonId": 738,
      "Mrmrs": "vitae",
      "Firstname": "Fernando",
      "Lastname": "Prohaska",
      "MiddleName": "Weissnat LLC",
      "Title": "a",
      "Description": "Stand-alone foreground middleware",
      "Email": "frederik@okon.com",
      "FullName": "Fiona Kuvalis DDS",
      "DirectPhone": "969-161-9750",
      "FormalName": "Spinka-Farrell",
      "CountryId": 626,
      "ContactId": 585,
      "ContactName": "Wunsch LLC",
      "Retired": 222,
      "Rank": 378,
      "ActiveInterests": 597,
      "ContactDepartment": "",
      "ContactCountryId": 159,
      "ContactOrgNr": "1645989",
      "FaxPhone": "379-738-9601",
      "MobilePhone": "(694)829-0911",
      "ContactPhone": "454.823.9776",
      "AssociateName": "Stamm, Koch and Wolff",
      "AssociateId": 597,
      "UsePersonAddress": true,
      "ContactFax": "qui",
      "Kanafname": "ipsam",
      "Kanalname": "nisi",
      "Post1": "laboriosam",
      "Post2": "dolor",
      "Post3": "nam",
      "EmailName": "darron@schumm.ca",
      "ContactFullName": "Cynthia Moore",
      "ActiveErpLinks": 748,
      "TicketPriorityId": 847,
      "SupportLanguageId": 112,
      "SupportAssociateId": 292,
      "CategoryName": "VIP Customer",
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
  "NoMailing": false,
  "Kananame": "consequuntur",
  "Xstop": false,
  "ActiveInterests": 544,
  "GroupId": 191,
  "ActiveStatusMonitorId": 483,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 529,
  "DbiAgentId": 133,
  "DbiLastSyncronized": "2019-04-05T12:15:18.4977611+02:00",
  "DbiKey": "et",
  "DbiLastModified": "2005-08-22T12:15:18.4977611+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 609,
  "ActiveErpLinks": 607,
  "BounceEmails": [
    "shane@franecki.co.uk",
    "nicolette@krisfranecki.us"
  ],
  "Domains": [
    "magni",
    "voluptas"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "voluptatibus",
    "ExtraFields2": "necessitatibus"
  },
  "CustomFields": {
    "CustomFields1": "dolores",
    "CustomFields2": "animi"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 750
    }
  }
}
```