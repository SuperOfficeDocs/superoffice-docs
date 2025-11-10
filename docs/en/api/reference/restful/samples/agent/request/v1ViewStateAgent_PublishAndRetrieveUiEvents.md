```http!
POST /api/v1/Agents/ViewState/PublishAndRetrieveUiEvents
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "LatestKnownEventId": 735,
  "PublishEvents": [
    {
      "EventId": 227,
      "EventName": "White-Spencer",
      "EntityType": "pariatur",
      "EntityKey": 792,
      "AssociateId": 8,
      "AssociateName": "Connelly, Lesch and Oberbrunner",
      "EventDateTime": "2017-02-03T10:11:01.8736815+01:00"
    }
  ],
  "Metrics": [
    {
      "Name": "Fadel LLC",
      "Value": 424
    },
    {
      "Name": "Fadel LLC",
      "Value": 424
    }
  ]
}
```