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
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 911,
  "Name": "Mayert-Homenick",
  "Department": "",
  "OrgNr": "1253261",
  "Number1": "988862",
  "Number2": "310878",
  "UpdatedDate": "2012-01-24T16:00:40.4143897+01:00",
  "CreatedDate": "2012-07-07T16:00:40.4143897+02:00",
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "debitis",
      "Description": "Ameliorated client-server forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 907
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "debitis",
      "Description": "Ameliorated client-server forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 907
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 582,
      "Name": "Dietrich Inc and Sons",
      "ToolTip": "Molestiae aut.",
      "Deleted": true,
      "Rank": 860,
      "Type": "quisquam",
      "ColorBlock": 507,
      "IconHint": "quae",
      "Selected": true,
      "LastChanged": "2011-01-12T16:00:40.4143897+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "laboriosam",
      "Hidden": false,
      "FullName": "Joanne Hyatt",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 266
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "id",
      "StrippedValue": "fugit",
      "Description": "Front-line multimedia extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 282
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "fugit",
      "Description": "Front-line multimedia extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 282
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "ab",
      "StrippedValue": "illo",
      "Description": "Function-based 5th generation capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 415
        }
      }
    },
    {
      "Value": "ab",
      "StrippedValue": "illo",
      "Description": "Function-based 5th generation capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 415
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nihil",
      "StrippedValue": "modi",
      "Description": "Integrated dynamic productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 296
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "modi",
      "Description": "Integrated dynamic productivity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 296
        }
      }
    }
  ],
  "Description": "Visionary client-server project",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "occaecati",
      "PersonId": 833,
      "Mrmrs": "et",
      "Firstname": "May",
      "Lastname": "Mertz",
      "MiddleName": "Casper Group",
      "Title": "quasi",
      "Description": "Multi-lateral 4th generation workforce",
      "Email": "imani@little.com",
      "FullName": "Mr. Yoshiko Walker",
      "DirectPhone": "(404)608-9755 x1686",
      "FormalName": "Deckow LLC",
      "CountryId": 781,
      "ContactId": 173,
      "ContactName": "Barrows, Rutherford and Hegmann",
      "Retired": 245,
      "Rank": 284,
      "ActiveInterests": 331,
      "ContactDepartment": "",
      "ContactCountryId": 286,
      "ContactOrgNr": "1476067",
      "FaxPhone": "(582)930-3915",
      "MobilePhone": "178.087.0783 x071",
      "ContactPhone": "331-722-6484 x5916",
      "AssociateName": "Paucek-Raynor",
      "AssociateId": 868,
      "UsePersonAddress": false,
      "ContactFax": "dolor",
      "Kanafname": "quaerat",
      "Kanalname": "numquam",
      "Post1": "repellendus",
      "Post2": "qui",
      "Post3": "ipsum",
      "EmailName": "sammy@schmittnikolaus.us",
      "ContactFullName": "Matteo Harber",
      "ActiveErpLinks": 886,
      "TicketPriorityId": 827,
      "SupportLanguageId": 278,
      "SupportAssociateId": 955,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 686
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "deleniti",
  "Xstop": true,
  "ActiveInterests": 906,
  "GroupId": 959,
  "ActiveStatusMonitorId": 212,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 996,
  "DbiAgentId": 158,
  "DbiLastSyncronized": "2022-05-28T16:00:40.4143897+02:00",
  "DbiKey": "nesciunt",
  "DbiLastModified": "2018-01-16T16:00:40.4143897+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 178,
  "ActiveErpLinks": 455,
  "BounceEmails": [
    "boyd_rath@prosaccoconnelly.us",
    "general_heaney@orn.us"
  ],
  "Domains": [
    "eveniet",
    "laborum"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Zackary Murray",
    "SuperOffice:2": "Hugh Kovacek"
  },
  "ExtraFields": {
    "ExtraFields1": "nam",
    "ExtraFields2": "accusamus"
  },
  "CustomFields": {
    "CustomFields1": "corporis",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 869
    }
  }
}
```