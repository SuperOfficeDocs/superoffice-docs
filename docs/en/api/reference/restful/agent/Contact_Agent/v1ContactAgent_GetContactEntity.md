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
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=486
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
  "ContactId": 917,
  "Name": "Legros-Ward",
  "Department": "",
  "OrgNr": "964762",
  "Number1": "303754",
  "Number2": "1308845",
  "UpdatedDate": "1998-12-11T14:13:39.7984831+01:00",
  "CreatedDate": "2009-08-02T14:13:39.7984831+02:00",
  "Emails": [
    {
      "Value": "commodi",
      "StrippedValue": "et",
      "Description": "Diverse local synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 667
        }
      }
    },
    {
      "Value": "commodi",
      "StrippedValue": "et",
      "Description": "Diverse local synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 667
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 114,
      "Name": "McGlynn Group",
      "ToolTip": "Nisi et quia omnis odit rerum reiciendis ullam.",
      "Deleted": false,
      "Rank": 249,
      "Type": "dignissimos",
      "ColorBlock": 219,
      "IconHint": "quam",
      "Selected": false,
      "LastChanged": "2023-04-04T14:13:39.7984831+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorem",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Kyle Thompson III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 299
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "ea",
      "StrippedValue": "rerum",
      "Description": "Down-sized discrete forecast",
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
      "Value": "ea",
      "StrippedValue": "rerum",
      "Description": "Down-sized discrete forecast",
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
  "Phones": [
    {
      "Value": "molestiae",
      "StrippedValue": "est",
      "Description": "Optional stable budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 109
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "est",
      "Description": "Optional stable budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 109
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "neque",
      "StrippedValue": "placeat",
      "Description": "Configurable encompassing moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 973
        }
      }
    },
    {
      "Value": "neque",
      "StrippedValue": "placeat",
      "Description": "Configurable encompassing moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 973
        }
      }
    }
  ],
  "Description": "Multi-tiered executive secured line",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "veniam",
      "PersonId": 576,
      "Mrmrs": "rerum",
      "Firstname": "Edison",
      "Lastname": "Daugherty",
      "MiddleName": "Gorczany, Hilll and DuBuque",
      "Title": "maxime",
      "Description": "Multi-tiered mission-critical database",
      "Email": "ulices@shieldsrowe.name",
      "FullName": "Brenden Mills",
      "DirectPhone": "762-876-3296",
      "FormalName": "Upton, Goldner and Greenfelder",
      "CountryId": 455,
      "ContactId": 407,
      "ContactName": "Bartell Group",
      "Retired": 102,
      "Rank": 545,
      "ActiveInterests": 166,
      "ContactDepartment": "",
      "ContactCountryId": 861,
      "ContactOrgNr": "541870",
      "FaxPhone": "949-056-3995 x4910",
      "MobilePhone": "305.704.0119",
      "ContactPhone": "045-648-8081 x556",
      "AssociateName": "Krajcik-Tromp",
      "AssociateId": 158,
      "UsePersonAddress": false,
      "ContactFax": "numquam",
      "Kanafname": "minima",
      "Kanalname": "voluptates",
      "Post1": "voluptas",
      "Post2": "rem",
      "Post3": "voluptates",
      "EmailName": "albin@bartell.name",
      "ContactFullName": "Jana Rosendo Gerhold PhD",
      "ActiveErpLinks": 842,
      "TicketPriorityId": 852,
      "SupportLanguageId": 185,
      "SupportAssociateId": 550,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1292073",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 340
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "placeat",
  "Xstop": true,
  "ActiveInterests": 356,
  "GroupId": 130,
  "ActiveStatusMonitorId": 938,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 552,
  "DbiAgentId": 460,
  "DbiLastSyncronized": "2009-07-29T14:13:39.7984831+02:00",
  "DbiKey": "totam",
  "DbiLastModified": "1998-03-21T14:13:39.7984831+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 940,
  "ActiveErpLinks": 781,
  "BounceEmails": [
    "daniella.sawayn@wuckertthiel.com",
    "alford@goyette.us"
  ],
  "Domains": [
    "quasi",
    "est"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Alverta Pfannerstill"
  },
  "ExtraFields": {
    "ExtraFields1": "beatae",
    "ExtraFields2": "deleniti"
  },
  "CustomFields": {
    "CustomFields1": "omnis",
    "CustomFields2": "ut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 406
    }
  }
}
```