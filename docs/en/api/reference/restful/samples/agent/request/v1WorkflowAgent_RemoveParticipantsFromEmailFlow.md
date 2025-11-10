```http!
POST /api/v1/Agents/Workflow/RemoveParticipantsFromEmailFlow
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "EmailFlowId": 241,
  "WorkflowInstanceIds": [
    46,
    774
  ]
}
```