---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
generated: true
---

# POST Agents/Contact/GetMyBizCard

```http
POST /api/v1/Agents/Contact/GetMyBizCard
```

Returns all data needed to display the logged on person's business card.


That is company, person, and company interest data.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyBizCard?$select=name,department,category/id
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
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 275,
  "Name": "Vandervort-Ledner",
  "Department": "",
  "OrgNr": "786910",
  "Number1": "1438324",
  "Number2": "849451",
  "UpdatedDate": "2005-06-18T03:44:52.3396483+02:00",
  "CreatedDate": "2003-08-04T03:44:52.3396483+02:00",
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "ut",
      "Description": "Cloned static leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 487
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "ut",
      "Description": "Cloned static leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 487
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 945,
      "Name": "Dickens Inc and Sons",
      "ToolTip": "Laboriosam blanditiis itaque ducimus nisi velit eveniet.",
      "Deleted": false,
      "Rank": 576,
      "Type": "pariatur",
      "ColorBlock": 278,
      "IconHint": "ut",
      "Selected": true,
      "LastChanged": "2022-03-10T03:44:52.3396483+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "unde",
      "StyleHint": "eaque",
      "Hidden": true,
      "FullName": "Mrs. Warren Lemuel Kessler",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 827
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "non",
      "StrippedValue": "assumenda",
      "Description": "Extended dedicated concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 48
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "assumenda",
      "Description": "Extended dedicated concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 48
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "corporis",
      "StrippedValue": "corrupti",
      "Description": "Automated local utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 510
        }
      }
    },
    {
      "Value": "corporis",
      "StrippedValue": "corrupti",
      "Description": "Automated local utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 510
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quas",
      "StrippedValue": "excepturi",
      "Description": "Automated modular definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 624
        }
      }
    },
    {
      "Value": "quas",
      "StrippedValue": "excepturi",
      "Description": "Automated modular definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 624
        }
      }
    }
  ],
  "Description": "Universal client-driven middleware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "in",
      "PersonId": 789,
      "Mrmrs": "libero",
      "Firstname": "Rosalind",
      "Lastname": "Rogahn",
      "MiddleName": "Feeney, Schultz and Farrell",
      "Title": "cum",
      "Description": "Robust impactful hierarchy",
      "Email": "austen@schamberger.biz",
      "FullName": "Carissa Koch",
      "DirectPhone": "588-081-2636",
      "FormalName": "Marquardt, Lebsack and Doyle",
      "CountryId": 28,
      "ContactId": 960,
      "ContactName": "Donnelly, Kuhn and Beatty",
      "Retired": 239,
      "Rank": 371,
      "ActiveInterests": 647,
      "ContactDepartment": "",
      "ContactCountryId": 607,
      "ContactOrgNr": "895184",
      "FaxPhone": "926-354-1252 x1302",
      "MobilePhone": "864.879.3192",
      "ContactPhone": "159-840-5632",
      "AssociateName": "Jacobi-Tillman",
      "AssociateId": 228,
      "UsePersonAddress": false,
      "ContactFax": "est",
      "Kanafname": "repellat",
      "Kanalname": "unde",
      "Post1": "itaque",
      "Post2": "unde",
      "Post3": "possimus",
      "EmailName": "elna@harber.info",
      "ContactFullName": "Marjolaine Miller",
      "ActiveErpLinks": 656,
      "TicketPriorityId": 942,
      "SupportLanguageId": 713,
      "SupportAssociateId": 363,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 205
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "cum",
  "Xstop": true,
  "ActiveInterests": 395,
  "GroupId": 977,
  "ActiveStatusMonitorId": 481,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 857,
  "DbiAgentId": 554,
  "DbiLastSyncronized": "2017-02-16T03:44:52.3396483+01:00",
  "DbiKey": "enim",
  "DbiLastModified": "1998-01-13T03:44:52.3396483+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 11,
  "ActiveErpLinks": 550,
  "BounceEmails": [
    "leanne@reingerfahey.name",
    "halie@gorczany.name"
  ],
  "Domains": [
    "aut",
    "vel"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mabel Langworth",
    "SuperOffice:2": "Pearl Gulgowski"
  },
  "ExtraFields": {
    "ExtraFields1": "atque",
    "ExtraFields2": "architecto"
  },
  "CustomFields": {
    "CustomFields1": "quis",
    "CustomFields2": "error"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 465
    }
  }
}
```