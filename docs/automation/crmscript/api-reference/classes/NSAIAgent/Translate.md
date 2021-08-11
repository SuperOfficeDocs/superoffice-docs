---
uid: crmscript_ref_NSAIAgent_Translate
title: String Translate(String text, String targetLanguage)
intellisense: NSAIAgent.Translate
keywords: NSAIAgent, Translate
so.topic: reference
---

# String Translate(String text, String targetLanguage)

Translate a text from one language to another. Language of the text is automatically detected.

**Parameters:**
 - **text** Text to be translated. Language of the text is automatically detected.
 - **targetLanguage** ISO Language code (such as FR) to translate the text into.

**Returns:** Translated text

```crmscript
NSAIAgent agent;
String text;
String targetLanguage;
String res = agent.Translate(text, targetLanguage);
```

