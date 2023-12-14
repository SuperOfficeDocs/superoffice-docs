---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
generated: true
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
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=359
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
  "ContactId": 155,
  "Name": "Baumbach Group",
  "Department": "",
  "OrgNr": "1419142",
  "Number1": "642270",
  "Number2": "592247",
  "UpdatedDate": "2022-11-12T13:57:11.9018093+01:00",
  "CreatedDate": "2020-01-13T13:57:11.9018093+01:00",
  "Emails": [
    {
      "Value": "quod",
      "StrippedValue": "et",
      "Description": "Re-contextualized zero defect solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 349
        }
      }
    },
    {
      "Value": "quod",
      "StrippedValue": "et",
      "Description": "Re-contextualized zero defect solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 349
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 716,
      "Name": "O'Reilly, Halvorson and Heller",
      "ToolTip": "Sint architecto.",
      "Deleted": false,
      "Rank": 861,
      "Type": "delectus",
      "ColorBlock": 858,
      "IconHint": "sed",
      "Selected": false,
      "LastChanged": "2004-01-19T13:57:11.9018093+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eos",
      "StyleHint": "praesentium",
      "Hidden": true,
      "FullName": "Trenton Stracke",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 313
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "consequatur",
      "StrippedValue": "dolorem",
      "Description": "Horizontal intangible workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 852
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "dolorem",
      "Description": "Horizontal intangible workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 852
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "doloremque",
      "StrippedValue": "saepe",
      "Description": "Pre-emptive solution-oriented infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 68
        }
      }
    },
    {
      "Value": "doloremque",
      "StrippedValue": "saepe",
      "Description": "Pre-emptive solution-oriented infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 68
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "repudiandae",
      "Description": "Universal intermediate algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 364
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "repudiandae",
      "Description": "Universal intermediate algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 364
        }
      }
    }
  ],
  "Description": "Managed foreground adapter",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "dolorum",
      "PersonId": 347,
      "Mrmrs": "incidunt",
      "Firstname": "Alphonso",
      "Lastname": "Hackett",
      "MiddleName": "Wiegand LLC",
      "Title": "harum",
      "Description": "Implemented logistical concept",
      "Email": "camron_bernhard@turneroberbrunner.co.uk",
      "FullName": "Ivory Block",
      "DirectPhone": "773-664-7225 x39831",
      "FormalName": "Quitzon Group",
      "CountryId": 469,
      "ContactId": 940,
      "ContactName": "Vandervort, Schiller and Block",
      "Retired": 280,
      "Rank": 976,
      "ActiveInterests": 925,
      "ContactDepartment": "",
      "ContactCountryId": 770,
      "ContactOrgNr": "1491073",
      "FaxPhone": "1-500-060-3748",
      "MobilePhone": "445-106-8613 x762",
      "ContactPhone": "597.244.7530",
      "AssociateName": "Reichel, Wuckert and Ruecker",
      "AssociateId": 947,
      "UsePersonAddress": false,
      "ContactFax": "ad",
      "Kanafname": "laboriosam",
      "Kanalname": "iste",
      "Post1": "quisquam",
      "Post2": "dolor",
      "Post3": "et",
      "EmailName": "felicity.batz@mitchell.info",
      "ContactFullName": "Ms. Raquel Mireille Cruickshank",
      "ActiveErpLinks": 745,
      "TicketPriorityId": 762,
      "SupportLanguageId": 684,
      "SupportAssociateId": 269,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 911
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "accusamus",
  "Xstop": false,
  "ActiveInterests": 158,
  "GroupId": 760,
  "ActiveStatusMonitorId": 84,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 41,
  "DbiAgentId": 595,
  "DbiLastSyncronized": "2013-04-12T13:57:11.9018093+02:00",
  "DbiKey": "doloremque",
  "DbiLastModified": "2000-03-08T13:57:11.9018093+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 401,
  "ActiveErpLinks": 915,
  "BounceEmails": [
    "deontae_schimmel@lubowitzlarson.com",
    "prudence_reilly@king.uk"
  ],
  "Domains": [
    "voluptate",
    "qui"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Immanuel Cummings",
    "SuperOffice:2": "Mrs. Eulalia Koelpin IV"
  },
  "ExtraFields": {
    "ExtraFields1": "atque",
    "ExtraFields2": "consectetur"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "maxime"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 89
    }
  }
}
```