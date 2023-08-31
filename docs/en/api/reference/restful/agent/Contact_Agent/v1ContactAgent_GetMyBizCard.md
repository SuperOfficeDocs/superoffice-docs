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
  "ContactId": 525,
  "Name": "Swift, Lynch and Veum",
  "Department": "",
  "OrgNr": "1140211",
  "Number1": "985752",
  "Number2": "481860",
  "UpdatedDate": "2003-01-18T03:31:25.9165935+01:00",
  "CreatedDate": "1997-02-22T03:31:25.9165935+01:00",
  "Emails": [
    {
      "Value": "aut",
      "StrippedValue": "ratione",
      "Description": "Visionary assymetric archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 612
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "ratione",
      "Description": "Visionary assymetric archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 612
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 511,
      "Name": "Christiansen-Bashirian",
      "ToolTip": "Vel doloribus laboriosam qui qui modi.",
      "Deleted": false,
      "Rank": 670,
      "Type": "corrupti",
      "ColorBlock": 483,
      "IconHint": "nisi",
      "Selected": false,
      "LastChanged": "2006-09-20T03:31:25.9165935+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "excepturi",
      "StyleHint": "maxime",
      "Hidden": false,
      "FullName": "Garrison Strosin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 391
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "reiciendis",
      "StrippedValue": "modi",
      "Description": "Team-oriented tertiary matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 117
        }
      }
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "modi",
      "Description": "Team-oriented tertiary matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 117
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "consequatur",
      "StrippedValue": "vero",
      "Description": "Reduced eco-centric migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 1000
        }
      }
    },
    {
      "Value": "consequatur",
      "StrippedValue": "vero",
      "Description": "Reduced eco-centric migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 1000
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "repellendus",
      "StrippedValue": "distinctio",
      "Description": "Focused homogeneous framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 828
        }
      }
    },
    {
      "Value": "repellendus",
      "StrippedValue": "distinctio",
      "Description": "Focused homogeneous framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 828
        }
      }
    }
  ],
  "Description": "Synchronised national access",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "provident",
      "PersonId": 301,
      "Mrmrs": "quia",
      "Firstname": "Kenton",
      "Lastname": "Breitenberg",
      "MiddleName": "Schulist Group",
      "Title": "autem",
      "Description": "Profound assymetric architecture",
      "Email": "mac_green@hagenes.name",
      "FullName": "Valentin Zboncak",
      "DirectPhone": "1-376-653-9295 x06008",
      "FormalName": "Lang, Ankunding and Botsford",
      "CountryId": 328,
      "ContactId": 518,
      "ContactName": "Deckow, Ryan and Herman",
      "Retired": 503,
      "Rank": 268,
      "ActiveInterests": 172,
      "ContactDepartment": "",
      "ContactCountryId": 125,
      "ContactOrgNr": "1285818",
      "FaxPhone": "436.922.8892 x381",
      "MobilePhone": "1-553-171-6024",
      "ContactPhone": "427-968-4650",
      "AssociateName": "Luettgen LLC",
      "AssociateId": 36,
      "UsePersonAddress": false,
      "ContactFax": "qui",
      "Kanafname": "aut",
      "Kanalname": "eveniet",
      "Post1": "qui",
      "Post2": "non",
      "Post3": "voluptates",
      "EmailName": "mckayla_terry@wiegand.ca",
      "ContactFullName": "Alessandro Conn",
      "ActiveErpLinks": 980,
      "TicketPriorityId": 951,
      "SupportLanguageId": 320,
      "SupportAssociateId": 690,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 783
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "maiores",
  "Xstop": true,
  "ActiveInterests": 780,
  "GroupId": 856,
  "ActiveStatusMonitorId": 745,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 86,
  "DbiAgentId": 961,
  "DbiLastSyncronized": "2003-12-29T03:31:25.9165935+01:00",
  "DbiKey": "laboriosam",
  "DbiLastModified": "2010-03-18T03:31:25.9165935+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 217,
  "ActiveErpLinks": 842,
  "BounceEmails": [
    "stuart.pollich@conn.name",
    "favian.williamson@romaguerajacobson.com"
  ],
  "Domains": [
    "aut",
    "aut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "442029518"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "error"
  },
  "CustomFields": {
    "CustomFields1": "velit",
    "CustomFields2": "quia"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 635
    }
  }
}
```