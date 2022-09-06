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

## Response

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
  "ContactId": 296,
  "Name": "Emmerich, Kihn and Ebert",
  "Department": "",
  "OrgNr": "696137",
  "Number1": "1107999",
  "Number2": "1833736",
  "UpdatedDate": "2011-12-30T11:10:26.2985528+01:00",
  "CreatedDate": "2015-04-22T11:10:26.2985528+02:00",
  "Emails": [
    {
      "Value": "molestiae",
      "StrippedValue": "exercitationem",
      "Description": "Up-sized contextually-based framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 951
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "exercitationem",
      "Description": "Up-sized contextually-based framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 951
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 267,
      "Name": "Bergnaum Group",
      "ToolTip": "Vel eum.",
      "Deleted": false,
      "Rank": 487,
      "Type": "necessitatibus",
      "ColorBlock": 269,
      "IconHint": "debitis",
      "Selected": false,
      "LastChanged": "2021-01-22T11:10:26.2985528+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sed",
      "StyleHint": "dicta",
      "Hidden": true,
      "FullName": "Yasmine Jenkins",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 316
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "voluptates",
      "StrippedValue": "aspernatur",
      "Description": "Multi-layered secondary algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 252
        }
      }
    },
    {
      "Value": "voluptates",
      "StrippedValue": "aspernatur",
      "Description": "Multi-layered secondary algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 252
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "illo",
      "StrippedValue": "possimus",
      "Description": "Quality-focused intangible challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 447
        }
      }
    },
    {
      "Value": "illo",
      "StrippedValue": "possimus",
      "Description": "Quality-focused intangible challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 447
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "dolores",
      "StrippedValue": "eos",
      "Description": "Horizontal holistic knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 442
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "eos",
      "Description": "Horizontal holistic knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 442
        }
      }
    }
  ],
  "Description": "Ameliorated fault-tolerant hardware",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "consequatur",
      "PersonId": 118,
      "Mrmrs": "odit",
      "Firstname": "Daryl",
      "Lastname": "Walter",
      "MiddleName": "Batz LLC",
      "Title": "fugiat",
      "Description": "Sharable reciprocal synergy",
      "Email": "rosemarie@welchwilderman.co.uk",
      "FullName": "Emmett Rowe",
      "DirectPhone": "(003)566-4206 x6633",
      "FormalName": "Kiehn Inc and Sons",
      "CountryId": 124,
      "ContactId": 189,
      "ContactName": "Keeling, Crona and Schuster",
      "Retired": 112,
      "Rank": 45,
      "ActiveInterests": 758,
      "ContactDepartment": "",
      "ContactCountryId": 208,
      "ContactOrgNr": "692501",
      "FaxPhone": "853.604.9683 x2066",
      "MobilePhone": "580.915.1857 x91869",
      "ContactPhone": "678.532.1146 x0214",
      "AssociateName": "Watsica-Bednar",
      "AssociateId": 210,
      "UsePersonAddress": false,
      "ContactFax": "aperiam",
      "Kanafname": "nostrum",
      "Kanalname": "aut",
      "Post1": "fugit",
      "Post2": "sed",
      "Post3": "nihil",
      "EmailName": "jacky_pfeffer@moenkuvalis.biz",
      "ContactFullName": "Kendrick Franecki",
      "ActiveErpLinks": 628,
      "TicketPriorityId": 198,
      "SupportLanguageId": 787,
      "SupportAssociateId": 437,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 630
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "at",
  "Xstop": false,
  "ActiveInterests": 151,
  "GroupId": 749,
  "ActiveStatusMonitorId": 972,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 544,
  "DbiAgentId": 145,
  "DbiLastSyncronized": "2020-01-31T11:10:26.3028425+01:00",
  "DbiKey": "nesciunt",
  "DbiLastModified": "1998-08-31T11:10:26.3028425+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 938,
  "ActiveErpLinks": 760,
  "BounceEmails": [
    "annetta@mcclurestreich.name",
    "lynn_carroll@barrowscruickshank.uk"
  ],
  "Domains": [
    "at",
    "maxime"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1972609785",
    "SuperOffice:2": "2079474524"
  },
  "ExtraFields": {
    "ExtraFields1": "architecto",
    "ExtraFields2": "sequi"
  },
  "CustomFields": {
    "CustomFields1": "molestias",
    "CustomFields2": "veniam"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 571
    }
  }
}
```
