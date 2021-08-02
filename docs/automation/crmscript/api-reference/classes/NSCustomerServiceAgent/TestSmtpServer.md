---
uid: crmscript_ref_NSCustomerServiceAgent_TestSmtpServer
title: NSSmtpTestResult TestSmtpServer(String smtpUri, String from, Bool useStoredPassword)
intellisense: NSCustomerServiceAgent.TestSmtpServer
keywords: NSCustomerServiceAgent, TestSmtpServer
so.topic: reference
---

This method will do a test of a SMTP account, by sending an email to a special @superoffice.com account

**Parameters:**
 - **smtpUri** An URI containing information to connect to the SMTP server, eg. smtps://myuser:mypassword@smtp.myserver.com:465. Note that username and password must be url encoded
 - **from** The from-address used in the test
 - **useStoredPassword** Use database persisted password

**Returns:** S

```crmscript
NSCustomerServiceAgent agent;
String smtpUri;
String from;
Bool useStoredPassword;
NSSmtpTestResult res = agent.TestSmtpServer(smtpUri, from, useStoredPassword);
```

