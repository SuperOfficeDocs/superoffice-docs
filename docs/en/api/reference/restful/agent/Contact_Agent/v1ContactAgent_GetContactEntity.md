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
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=689
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 976,
  "Name": "Williamson, Zemlak and Carter",
  "Department": "",
  "OrgNr": "950912",
  "Number1": "708343",
  "Number2": "1858996",
  "UpdatedDate": "2012-07-04T03:51:26.8343195+02:00",
  "CreatedDate": "2008-06-29T03:51:26.8343195+02:00",
  "Emails": [
    {
      "Value": "tenetur",
      "StrippedValue": "quisquam",
      "Description": "Open-architected clear-thinking portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 577
        }
      }
    },
    {
      "Value": "tenetur",
      "StrippedValue": "quisquam",
      "Description": "Open-architected clear-thinking portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 577
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 121,
      "Name": "Pouros Group",
      "ToolTip": "Excepturi sint aspernatur ea incidunt quidem dolorem.",
      "Deleted": false,
      "Rank": 739,
      "Type": "excepturi",
      "ColorBlock": 139,
      "IconHint": "cum",
      "Selected": false,
      "LastChanged": "2006-09-03T03:51:26.8343195+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "deleniti",
      "StyleHint": "harum",
      "Hidden": true,
      "FullName": "Mr. Dewayne Predovic DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 583
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "corporis",
      "StrippedValue": "nihil",
      "Description": "Versatile solution-oriented local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 422
        }
      }
    },
    {
      "Value": "corporis",
      "StrippedValue": "nihil",
      "Description": "Versatile solution-oriented local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 422
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "inventore",
      "StrippedValue": "reiciendis",
      "Description": "Integrated foreground attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 789
        }
      }
    },
    {
      "Value": "inventore",
      "StrippedValue": "reiciendis",
      "Description": "Integrated foreground attitude",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 789
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "repellat",
      "StrippedValue": "sit",
      "Description": "Upgradable local infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 888
        }
      }
    },
    {
      "Value": "repellat",
      "StrippedValue": "sit",
      "Description": "Upgradable local infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 888
        }
      }
    }
  ],
  "Description": "Horizontal tangible customer loyalty",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "magni",
      "PersonId": 988,
      "Mrmrs": "iusto",
      "Firstname": "Sharon",
      "Lastname": "Wehner",
      "MiddleName": "Runte-Schultz",
      "Title": "tempore",
      "Description": "Multi-lateral mission-critical website",
      "Email": "rosario.walker@gusikowskipredovic.co.uk",
      "FullName": "Molly Ondricka DDS",
      "DirectPhone": "364-536-9117 x496",
      "FormalName": "Jacobi-Hilll",
      "CountryId": 578,
      "ContactId": 449,
      "ContactName": "Nader-Hessel",
      "Retired": 680,
      "Rank": 534,
      "ActiveInterests": 97,
      "ContactDepartment": "",
      "ContactCountryId": 809,
      "ContactOrgNr": "697588",
      "FaxPhone": "701-482-2624 x933",
      "MobilePhone": "(541)134-7828 x259",
      "ContactPhone": "(602)487-0797 x40965",
      "AssociateName": "Kulas LLC",
      "AssociateId": 105,
      "UsePersonAddress": true,
      "ContactFax": "aut",
      "Kanafname": "dolor",
      "Kanalname": "eos",
      "Post1": "et",
      "Post2": "rerum",
      "Post3": "ut",
      "EmailName": "rickey@welch.ca",
      "ContactFullName": "Miss Daisy Bednar",
      "ActiveErpLinks": 525,
      "TicketPriorityId": 205,
      "SupportLanguageId": 345,
      "SupportAssociateId": 145,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 201
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "laboriosam",
  "Xstop": false,
  "ActiveInterests": 870,
  "GroupId": 350,
  "ActiveStatusMonitorId": 813,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 684,
  "DbiAgentId": 460,
  "DbiLastSyncronized": "2016-12-06T03:51:26.8499374+01:00",
  "DbiKey": "in",
  "DbiLastModified": "2023-04-19T03:51:26.8499374+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 4,
  "ActiveErpLinks": 37,
  "BounceEmails": [
    "leilani_harvey@mannmurphy.us",
    "cameron@funkfadel.name"
  ],
  "Domains": [
    "ab",
    "perferendis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Deon Rudolph Cole",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "officia",
    "ExtraFields2": "quae"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "id"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 978
    }
  }
}
```