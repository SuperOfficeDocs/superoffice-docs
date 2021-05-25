---
title: Multi-threading
uid: whats_new_70_
description: NetServer 7.0
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: reference
---

# Multi-threading

In the general case, multi-threading/parallel programming is hard. Why?

* Almost always because of synchronization issues

* And because the syntax for working with threads tends to be complicated
  NetServer uses multi-threading internally, and we have some useful infrastructure

* .NET 4.0 and the Task Parallell Library are also very nice

## Easy Multi-threading

If your problem can be partitioned into independent parts, then you’re home free.

* Put each part in a method
* Call the methods in parallell using the ThreadManager
* Use the results

The real trick is to recognize these cases in your code!

### Reading two files

![ALT][img1]

* The two lambdas (statements) are done simultaneously, each in its own thread
* The main thread waits until both complete
* ThreadManager.Invoke will then return

Reading two files is – fairly obviously – something where the parts are independent of each other; so this is a case of easy multi-threading. Whether it actually **runs** any faster is a less obvious question to answer: it depends on where the files are, whether they are competing for channels.

If one is on the net and the other on a local disk, it should definitely run faster. If they’re on the same disk, and competing for the same disk head movement, then it might even be slower. Caching will make the picture less predictable. "Your mileage will vary".

## Why use NetServer ThreadManager

* SoContext, SoDatabase, and other variables that are in the environment are managed for you.

* If you Impersonate inside a thread, we keep track of that.

* If multi-threading is disabled in the config file, your code will be nicely executed in sequence.

* We perform throttling to avoid killing the machine with a gazillion threads.

## When to single-thread

Starting and stopping threads is not free. You should expect significant savings before resorting to multi-threading.

Synchronization is hard. If your problem is in any way dependent on who finishes first, or there are shared data structures… then you are in the sync world

Do you have multiple cores, or are you waiting for external data? If not, then there is no point in multi-threading.

Again, it all depends on your problem. Multi-threading is a powerful tool and you should know about it, and about what NetServer can do to help you. Beyond that, it’s your call.

## Multi-thread db reading

![ALT][img2]

It’s the `ThreadManager.Invoke` call that does the magic. Its parameter is an array of Actions, where an Action is a delegate that takes no parameters and returns void (a method that simply does something). Then we use the lamda syntax to eliminate the syntactical hassle of saying new Action( MyMethod ) and having to write the methods elsewhere: `() =>` simply means "I declare a parameterless block of code, which is as follows".

> [!NOTE]
> The `firstSearch` and `lastSearch` local variables are "captured" into the lambda, and become part of the code that is sent off to the `Invoke` method for execution. This is a *very powerful* mechanism, called **scope capture**, which you can use to pass along all kinds of values. But beware of one thing: **Never, ever update such values from inside the parallel code, if they are shared between multiple methods**. That would break the initial assumption, that your parallel tasks are **independent**. As soon as they share any kind of variable, that is no longer true and YOU become responsible for synchronizing access.

## Alternative approach

![ALT][img3]

Here we have moved the parallel code into a separate method, and use scope capture in the lambdas to send different parameters to them in a very nice and clean way. Recommended, whenever your lambda would otherwise become large, or you see too many similarities.

<!-- Referenced images -->
[img1]: media/image016.jpg
[img2]: media/image017.jpg
[img3]: media/image018.jpg
