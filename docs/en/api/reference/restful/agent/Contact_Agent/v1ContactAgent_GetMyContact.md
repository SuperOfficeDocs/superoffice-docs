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
| TableRight | TableRight |  |
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
  "ContactId": 803,
  "Name": "Weissnat Group",
  "Department": "",
  "OrgNr": "744061",
  "Number1": "246644",
  "Number2": "951638",
  "UpdatedDate": "2010-08-03T17:37:17.2312418+02:00",
  "CreatedDate": "2012-01-04T17:37:17.2312418+01:00",
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Future-proofed client-server local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 990
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Future-proofed client-server local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 990
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 655,
      "Name": "Collier, Mueller and Waters",
      "ToolTip": "Ea vitae ea.",
      "Deleted": true,
      "Rank": 883,
      "Type": "neque",
      "ColorBlock": 644,
      "IconHint": "ipsa",
      "Selected": false,
      "LastChanged": "2004-05-14T17:37:17.2322421+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "cumque",
      "StyleHint": "similique",
      "Hidden": false,
      "FullName": "Alexandro Sipes",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 467
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "sed",
      "StrippedValue": "non",
      "Description": "Adaptive fault-tolerant instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 66
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "non",
      "Description": "Adaptive fault-tolerant instruction set",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 66
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "sit",
      "StrippedValue": "laudantium",
      "Description": "Digitized systemic standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 543
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "laudantium",
      "Description": "Digitized systemic standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 543
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quia",
      "StrippedValue": "maiores",
      "Description": "Enterprise-wide analyzing portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 102
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "maiores",
      "Description": "Enterprise-wide analyzing portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 102
        }
      }
    }
  ],
  "Description": "Multi-layered zero administration challenge",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "at",
      "PersonId": 232,
      "Mrmrs": "saepe",
      "Firstname": "Nat",
      "Lastname": "Schuster",
      "MiddleName": "Mills, Hoppe and Bergnaum",
      "Title": "sed",
      "Description": "Switchable real-time artificial intelligence",
      "Email": "madilyn.homenick@hirthe.co.uk",
      "FullName": "Clarissa Homenick III",
      "DirectPhone": "103-985-0601 x65374",
      "FormalName": "Daugherty, Rowe and Schinner",
      "CountryId": 793,
      "ContactId": 249,
      "ContactName": "Leffler LLC",
      "Retired": 890,
      "Rank": 179,
      "ActiveInterests": 654,
      "ContactDepartment": "",
      "ContactCountryId": 327,
      "ContactOrgNr": "625215",
      "FaxPhone": "061.049.6427 x178",
      "MobilePhone": "809-680-7126",
      "ContactPhone": "582.890.1907 x96068",
      "AssociateName": "Keeling-Boyer",
      "AssociateId": 845,
      "UsePersonAddress": true,
      "ContactFax": "consequatur",
      "Kanafname": "soluta",
      "Kanalname": "assumenda",
      "Post1": "quae",
      "Post2": "itaque",
      "Post3": "laborum",
      "EmailName": "cyrus@mraztreutel.biz",
      "ContactFullName": "Felicity Bernhard",
      "ActiveErpLinks": 572,
      "TicketPriorityId": 639,
      "SupportLanguageId": 623,
      "SupportAssociateId": 960,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 881
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "fuga",
  "Xstop": false,
  "ActiveInterests": 585,
  "GroupId": 764,
  "ActiveStatusMonitorId": 573,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 375,
  "DbiAgentId": 187,
  "DbiLastSyncronized": "1998-01-20T17:37:17.2362438+01:00",
  "DbiKey": "eos",
  "DbiLastModified": "2002-02-02T17:37:17.2362438+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 345,
  "ActiveErpLinks": 677,
  "BounceEmails": [
    "mustafa_hauck@oconner.info",
    "abdiel_wunsch@hermiston.biz"
  ],
  "Domains": [
    "voluptate",
    "at"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "630251896",
    "SuperOffice:2": "Deven Dibbert I"
  },
  "ExtraFields": {
    "ExtraFields1": "officia",
    "ExtraFields2": "magni"
  },
  "CustomFields": {
    "CustomFields1": "ex",
    "CustomFields2": "officia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 91
    }
  }
}
```