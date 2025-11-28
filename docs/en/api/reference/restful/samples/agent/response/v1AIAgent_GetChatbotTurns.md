```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Timestamp": "2024-11-24T14:28:15.123456+01:00",
    "UserPrompt": "What are your business hours?",
    "UserDisplayText": "What are your business hours?",
    "BotResponse": "Our support team is available Monday through Friday, 9:00 AM to 5:00 PM CET. For urgent issues outside business hours, you can submit a ticket through our online portal.",
    "BotActions": {
      "action1": "View Full Schedule",
      "action2": "Submit Ticket"
    },
    "Attachments": [
      "business-hours.pdf"
    ]
  },
  {
    "Timestamp": "2024-11-24T14:30:22.456789+01:00",
    "UserPrompt": "How do I reset my password?",
    "UserDisplayText": "How do I reset my password?",
    "BotResponse": "To reset your password, click on 'Forgot Password' on the login page. You'll receive an email with a secure link to create a new password. The link is valid for 24 hours.",
    "BotActions": {
      "action1": "Open Password Reset Page",
      "action2": "Contact Support"
    },
    "Attachments": [
      "password-reset-guide.pdf",
      "security-tips.pdf"
    ]
  }
]
```
