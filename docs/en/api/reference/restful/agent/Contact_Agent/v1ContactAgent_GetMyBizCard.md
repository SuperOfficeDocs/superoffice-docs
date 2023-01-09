---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
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
| TableRight | TableRight |  |
| FieldProperties | object |  |

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
  "ContactId": 35,
  "Name": "Konopelski Group",
  "Department": "",
  "OrgNr": "1613837",
  "Number1": "867311",
  "Number2": "661566",
  "UpdatedDate": "2008-06-09T17:37:17.2462413+02:00",
  "CreatedDate": "1997-09-25T17:37:17.2462413+02:00",
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "voluptatem",
      "Description": "Open-source heuristic intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 400
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "voluptatem",
      "Description": "Open-source heuristic intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 400
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 530,
      "Name": "Sawayn-Gislason",
      "ToolTip": "Molestiae doloremque dolorem.",
      "Deleted": false,
      "Rank": 870,
      "Type": "voluptate",
      "ColorBlock": 441,
      "IconHint": "quia",
      "Selected": true,
      "LastChanged": "1997-02-15T17:37:17.2472418+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dignissimos",
      "StyleHint": "atque",
      "Hidden": true,
      "FullName": "Werner Doyle",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 64
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "itaque",
      "StrippedValue": "doloribus",
      "Description": "Optimized fresh-thinking projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 727
        }
      }
    },
    {
      "Value": "itaque",
      "StrippedValue": "doloribus",
      "Description": "Optimized fresh-thinking projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 727
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "veniam",
      "StrippedValue": "aspernatur",
      "Description": "Expanded heuristic benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 791
        }
      }
    },
    {
      "Value": "veniam",
      "StrippedValue": "aspernatur",
      "Description": "Expanded heuristic benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 791
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "tenetur",
      "StrippedValue": "odit",
      "Description": "Team-oriented context-sensitive flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 210
        }
      }
    },
    {
      "Value": "tenetur",
      "StrippedValue": "odit",
      "Description": "Team-oriented context-sensitive flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 210
        }
      }
    }
  ],
  "Description": "Multi-tiered motivating toolset",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "qui",
      "PersonId": 261,
      "Mrmrs": "tempore",
      "Firstname": "Kasey",
      "Lastname": "Reichel",
      "MiddleName": "Price, Schmidt and Barrows",
      "Title": "eligendi",
      "Description": "Down-sized cohesive solution",
      "Email": "lura@barrows.us",
      "FullName": "Francisca Rohan",
      "DirectPhone": "158.202.2041 x315",
      "FormalName": "McClure, Pacocha and Marvin",
      "CountryId": 648,
      "ContactId": 132,
      "ContactName": "Kuhn LLC",
      "Retired": 276,
      "Rank": 374,
      "ActiveInterests": 707,
      "ContactDepartment": "",
      "ContactCountryId": 205,
      "ContactOrgNr": "386086",
      "FaxPhone": "(204)435-7456",
      "MobilePhone": "1-688-084-3832",
      "ContactPhone": "470.418.1813 x3911",
      "AssociateName": "Kutch-Stokes",
      "AssociateId": 746,
      "UsePersonAddress": false,
      "ContactFax": "explicabo",
      "Kanafname": "esse",
      "Kanalname": "distinctio",
      "Post1": "vitae",
      "Post2": "illo",
      "Post3": "quis",
      "EmailName": "camron_lynch@baumbach.ca",
      "ContactFullName": "Glenna Schoen III",
      "ActiveErpLinks": 622,
      "TicketPriorityId": 765,
      "SupportLanguageId": 438,
      "SupportAssociateId": 714,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 913
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "quam",
  "Xstop": false,
  "ActiveInterests": 544,
  "GroupId": 428,
  "ActiveStatusMonitorId": 504,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 813,
  "DbiAgentId": 514,
  "DbiLastSyncronized": "2007-06-03T17:37:17.2512414+02:00",
  "DbiKey": "non",
  "DbiLastModified": "2012-11-07T17:37:17.2512414+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 947,
  "ActiveErpLinks": 648,
  "BounceEmails": [
    "margret.effertz@strosin.biz",
    "julio_lakin@wardemard.com"
  ],
  "Domains": [
    "ut",
    "dolorem"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "1849515545"
  },
  "ExtraFields": {
    "ExtraFields1": "beatae",
    "ExtraFields2": "inventore"
  },
  "CustomFields": {
    "CustomFields1": "doloribus",
    "CustomFields2": "sunt"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 734
    }
  }
}
```