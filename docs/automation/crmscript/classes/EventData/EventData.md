---
title: EventData
path: /EJScript/Classes/EventData
intellisense: 1
classref: 1
sortOrder: 285
---


EventData gives you access to contextual information in an EventHandler, such as the name of the created company or the amount of the sale. It also has properties which will be investigated after the event handler has finished, allowing you to e.g. show a message or prevent the save of an entity.




###Example code:###


    // Check if a sale has a high enough value. Return a message and block the sale for values < 100. Set for event "Before save sale"
    
    EventData ed = getEventData();
    
    if (ed.getInputValue("SaleEntity.Amount").toInteger() < 100)
    {
      ed.setBlockExecution(true); // Prevents save
      ed.setMessage("Amount too low");
    }




1. autolist

