---
uid: help-sv-duplicates-import
title: Import av dubbletter
description: Import av dubbletter
author: SuperOffice RnD
date: 06.29.2022
keywords: Inställningar för Windows-klient
content_type: concept
language: sv
platform: win
deployment: onsite
---

# Dubbletter

Dubbletter uppstår om samma post finns i både importfilen och i databasen. Du måste alltid ange regler för hantering av dubbletter under en import i en [importbeskrivning][1]. Dessa regler inkluderas sedan i importbeskrivningen när du sparar den. Detta gäller för alla datatyper. Tabellen **Hantering av dubbletter** har följande kolumner:

* **Tabell**: visar vilken datatyp den här regeln för dubbletthantering gäller för. Innehållet i den här kolumnen baseras på det du angav i kolumnen **Fält i SuperOffice CRM** under **Fälttilldelning**.
* **Nyckel**: visar en importnyckel, de kriterier som måste uppfyllas för att en post ska betraktas som en dubblett.
* **Åtgärd**: visar vad som händer om en dubblett påträffas.

## Vad vill du göra nu?

* [Uppdateringsregler för hantering av dubbletter][2]
* [Återställa regler för hantering av dubbletter][3]

<!-- Referenced links -->
[1]: import-descriptions.md
[2]: updating-rules-for-duplicate-handling.md
[3]: resetting-rules-for-duplicate-handling.md

<!-- Referenced images -->
