---
uid: crmscript_ref_NSAIAgent_DetectLanguage
title: String DetectLanguage(String text)
intellisense: NSAIAgent.DetectLanguage
keywords: NSAIAgent, DetectLanguage
so.topic: reference
---

# String DetectLanguage(String text)

Given a (reasonably short) text, detect the language it is written in

**Parameters:**
 - **text** Text to be analyzed; there may be a cost-per-character so do not send a book here

**Returns:** ISO Language code, such as NO, US, ES, FR

```crmscript
NSAIAgent agent;
String text;
String res = agent.DetectLanguage(text);
```

