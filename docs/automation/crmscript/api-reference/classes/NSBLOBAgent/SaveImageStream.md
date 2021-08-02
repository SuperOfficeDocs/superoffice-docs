---
uid: crmscript_ref_NSBLOBAgent_SaveImageStream
title: Integer SaveImageStream(Integer type, NSImage image, String description)
intellisense: NSBLOBAgent.SaveImageStream
keywords: NSBLOBAgent, SaveImageStream
so.topic: reference
---

Stores an image in the database without linking it to a project or a person. It is possible to ChangePersonImage or ChangeProjectImage to attach image later.

**Parameters:**
 - **type** The type of the image.
     - Enum: 1 = PersonImage 
     - Enum: 2 = ProjectImage 
     - Enum: 3 = EventImage 
     - Enum: 4 = Thumbnail 
     - Enum: 5 = StatusMonitorImage 
     - Enum: 6 = BatchTask 
     - Enum: 7 = ProductImage 
     - Enum: 8 = ProductThumbnail 
     - Enum: 9 = QuoteLineImage 
     - Enum: 10 = QuoteLineThumbnail 
     - Enum: 11 = AccessToken 
     - Enum: 12 = RefreshToken 
     - Enum: 13 = Dashboard 
     - Enum: 14 = DashboardTile 
     - Enum: 15 = ChatTopicImage 
     - Enum: 16 = FormsBackgroundImage 
     - Enum: 17 = ContactImage 
 - **image** Image to store
 - **description** Image description

**Returns:** Integer

```crmscript
NSBLOBAgent agent;
Integer type;
NSImage image;
String description;
Integer res = agent.SaveImageStream(type, image, description);
```

