---
title: Readiness to hand
description: Readiness to hand
author: Christian Mogensen
so.date: 12.09.2011
keywords: design,ui
so.topic: concept
so.envir:                     # cloud or onsite
so.client:                    # online, web, win, pocket, or mobile
---

# Readiness to hand

The user’s time and effort are valuable. Every time the user has to click something to get more information or to perform a task, we are making the user more frustrated.

So instead of forcing the user to always use menus, we present the most common commands as buttons in the user interface – as buttons on the surface of the window, not hidden inside a sub-window, but directly accessible by the user.

![Readiness to hand][img1]

The less work the user has to do to execute a command, the closer to hand the command is. The trick is to figure out which commands are most common and to put those closest to the user.

Think of how a messy programmer organizes his desk. In the center, closest to hand is the keyboard. In piles around the keyboard are reference books and papers the programmer is using to do his work. He doesn’t read them all the time but looks at the material every now and then. Over in the bookshelf are books the programmer isn’t using.

SuperOffice tries to organize its displays in the same way – the most useful things are closest to the user.

If you start SuperOffice CRM 5 client, you’ll see buttons laid out around the edges of the window. Click on the PROJECT button on the left side, and a history list drops down along with a search field. The search field automatically receives the keyboard focus, so that the user can just start typing to search on name (the most common type of search). So the number of clicks is reduced.

The initial sketches we had worked more like the IE Back button. You clicked once on a small button to activate the list, or on a different button to do another search. The big problem with this was that we suddenly had three little buttons that people had to click to get the history list or the search results. Small buttons are hard to click. More clicks are frustrating.

Since clicking on things in the history list was the one thing that users would be doing all day long (typically users work with just three or four companies during a day) we wanted to make that less work. So instead of waiting for a button click, we just show the history once we know what area of the application you are interested in.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/readiness-to-hand.jpg
