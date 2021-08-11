---
uid: crmscript_ref_NSAIAgent_DetectSentiment
title: Sentiment DetectSentiment(String text)
intellisense: NSAIAgent.DetectSentiment
keywords: NSAIAgent, DetectSentiment
so.topic: reference
---

# Sentiment DetectSentiment(String text)

Detect the sentiment of a (reasonably short) text. Sentiment analysis may cause a translation to be made, since sentiment analysis only supports a limited set of languages

**Parameters:**
 - **text** Text to be analyzed

**Returns:** The sentiment information: score (-100 to +100) and confidence

```crmscript
NSAIAgent agent;
String text;
Sentiment res = agent.DetectSentiment(text);
```

