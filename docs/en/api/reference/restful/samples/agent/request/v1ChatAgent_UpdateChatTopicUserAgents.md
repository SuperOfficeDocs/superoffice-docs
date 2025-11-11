```http!
POST /api/v1/Agents/Chat/UpdateChatTopicUserAgents
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ChatTopicId": 276,
  "Useragents": [
    {
      "TopicId": 534,
      "User": null,
      "CanListen": false,
      "CanRespond": true,
      "CanManage": false,
      "CanNotify": false
    },
    {
      "TopicId": 534,
      "User": null,
      "CanListen": false,
      "CanRespond": true,
      "CanManage": false,
      "CanNotify": false
    }
  ]
}
```