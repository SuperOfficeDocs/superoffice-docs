```http!
POST /api/v1/Agents/List/SetVisibleForUserGroupsFromListName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionName": "Luettgen, Luettgen and Herzog",
  "ListItemId": 824,
  "UserGroups": [
    {
      "Id": 904,
      "Name": "Watsica Group",
      "ToolTip": "Amet consequatur accusamus officia fugit voluptates voluptates eum.",
      "Deleted": true,
      "Rank": 543,
      "Type": "eligendi",
      "ColorBlock": 872,
      "IconHint": "eos",
      "Selected": false,
      "LastChanged": "2020-01-17T10:11:00.3183958+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "officia",
      "StyleHint": "hic",
      "Hidden": false,
      "FullName": "Prof. Madison Janelle Connelly"
    }
  ]
}
```