---
uid: crmscript_ref_Timer
title: Timer
intellisense: Void.Timer
so.topic: reference
---

# Timer

## Example
    
    Timer timer;
    timer.start();
    
    // code you want to time
    
    timer.stop();
    Float timeTaken = timer.getSeconds();
    print("The code took " + timeTaken.toString(5) + " seconds to complete");
