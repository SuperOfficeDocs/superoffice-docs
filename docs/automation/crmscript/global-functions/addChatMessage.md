---
description: Integer addChatMessage(Integer sessionId, String message, Integer type, String author, Integer specialType, String specialParams)
path: /EJScript/Global functions/Integer addChatMessage(Integer sessionId, String message, Integer type, String author, Integer specialType, String specialParams)
intellisense: 1
langref: 1
keywords: addChatMessage(Integer,String,Integer,String,Integer,String)---


This function allows you to add a message to a chat session.
- sessionId: The id of the chat session.
- message: The text of the message you want to add in HTML format. A few tags, such as \<b>, \<i>, \<ul> are allowed. Other tags and attributes will be removed.
- type: 1 to indicate the message is to the customer
- author: The string used as the author of the message, placed above the message bubble.
- specialType: Mostly internally used. Use the value 0 for no special type. Use the value 16 to indicate the message is from a chatbot.
- specialParams: Various params based on the specialType. Specifically, for specialType=16, you can add "showAt=\<datetime>" to specify when the message should show up to create a delay before the botmessage is shown.


