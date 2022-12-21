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
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 23,
  "Name": "Fisher Group",
  "Department": "",
  "OrgNr": "524499",
  "Number1": "1626627",
  "Number2": "1098962",
  "UpdatedDate": "2018-06-23T02:49:43.9504047+02:00",
  "CreatedDate": "1995-10-07T02:49:43.9504047+02:00",
  "Emails": [
    {
      "Value": "officia",
      "StrippedValue": "numquam",
      "Description": "Reduced attitude-oriented installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 974
        }
      }
    },
    {
      "Value": "officia",
      "StrippedValue": "numquam",
      "Description": "Reduced attitude-oriented installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 974
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 570,
      "Name": "Reinger Group",
      "ToolTip": "Qui quasi et veritatis.",
      "Deleted": false,
      "Rank": 893,
      "Type": "tenetur",
      "ColorBlock": 60,
      "IconHint": "esse",
      "Selected": true,
      "LastChanged": "2002-05-18T02:49:43.9504047+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "magni",
      "StyleHint": "rerum",
      "Hidden": false,
      "FullName": "Philip Rau",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 281
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "vero",
      "StrippedValue": "laboriosam",
      "Description": "Enterprise-wide clear-thinking policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 488
        }
      }
    },
    {
      "Value": "vero",
      "StrippedValue": "laboriosam",
      "Description": "Enterprise-wide clear-thinking policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 488
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "cum",
      "StrippedValue": "explicabo",
      "Description": "Re-contextualized regional infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 522
        }
      }
    },
    {
      "Value": "cum",
      "StrippedValue": "explicabo",
      "Description": "Re-contextualized regional infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 522
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "non",
      "StrippedValue": "incidunt",
      "Description": "Exclusive interactive adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 386
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "incidunt",
      "Description": "Exclusive interactive adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 386
        }
      }
    }
  ],
  "Description": "Customizable executive extranet",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "qui",
      "PersonId": 401,
      "Mrmrs": "qui",
      "Firstname": "Shaun",
      "Lastname": "Pfannerstill",
      "MiddleName": "Mertz Group",
      "Title": "dicta",
      "Description": "Optimized 24/7 hierarchy",
      "Email": "evangeline_rowe@wilderman.ca",
      "FullName": "Prof. Lori Durward Schowalter",
      "DirectPhone": "1-292-272-0915 x611",
      "FormalName": "Feest-Rogahn",
      "CountryId": 519,
      "ContactId": 175,
      "ContactName": "O'Kon LLC",
      "Retired": 850,
      "Rank": 612,
      "ActiveInterests": 247,
      "ContactDepartment": "reintermediate world-class methodologies",
      "ContactCountryId": 685,
      "ContactOrgNr": "796124",
      "FaxPhone": "1-761-093-5133 x45502",
      "MobilePhone": "577.271.5392",
      "ContactPhone": "1-905-438-0912",
      "AssociateName": "Schinner LLC",
      "AssociateId": 873,
      "UsePersonAddress": true,
      "ContactFax": "et",
      "Kanafname": "ducimus",
      "Kanalname": "explicabo",
      "Post1": "quaerat",
      "Post2": "nam",
      "Post3": "qui",
      "EmailName": "herminio_doyle@beahan.biz",
      "ContactFullName": "Joseph DuBuque",
      "ActiveErpLinks": 710,
      "TicketPriorityId": 137,
      "SupportLanguageId": 63,
      "SupportAssociateId": 865,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 917
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "reprehenderit",
  "Xstop": true,
  "ActiveInterests": 154,
  "GroupId": 528,
  "ActiveStatusMonitorId": 30,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 961,
  "DbiAgentId": 702,
  "DbiLastSyncronized": "2020-01-18T02:49:43.9504047+01:00",
  "DbiKey": "est",
  "DbiLastModified": "2022-04-09T02:49:43.9504047+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 876,
  "ActiveErpLinks": 759,
  "BounceEmails": [
    "eldred@boyle.biz",
    "elton.emmerich@langosh.us"
  ],
  "Domains": [
    "dolorum",
    "iusto"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1444831863",
    "SuperOffice:2": "382370723"
  },
  "ExtraFields": {
    "ExtraFields1": "dolorem",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "saepe"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 609
    }
  }
}
```