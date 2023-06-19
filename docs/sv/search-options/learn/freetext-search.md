---
uid: help-sv-search-freetext
title: Fritextsökning
description: Fritextsökning
author: SuperOffice RnD
so.date: 06.29.2022
keywords: fritext, söka
so.topic: howto
language: sv
---

# Fritextsökning

> [!NOTE]
> Om fälten för fritextsökning inte visas i det övre högra hörnet är detta alternativ inte aktiverat i Inställningar och underhåll.

Textfältet högst upp till höger i SuperOffice CRM kan användas till fritextsökning.

Här kan du söka efter all text i SuperOffice CRM som användarna själva har lagt in i databasen, till exempel företagsnamn, avdelning, information om kontakter och uppföljningar. Du kan söka på text från dialogrutan **Dokument**, men du kan inte söka i det faktiska innehållet i dokument.

![Fritextsökning -screenshot][img1]

> [!NOTE]
> Vissa ord ignoreras vid fritextsökning. [!include[SM](../../learn/includes/are-defined-sm.md)]

## Fritextsökning från textfältet

1. Skriv den text som du vill söka efter (minst tre tecken).
2. Tryck på **ENTER** för att starta sökningen.
    > [!NOTE]
    > Sökningen börjar alltid med text som står i fältet **Vår ref** i dialogrutan **Dokument**.
3. Fönstret **Sökresultat** öppnas och visar alla data som innehåller söktexten, grupperade i flikar. Klicka på en flik för att visa listan med sökresultat.

Du kan öppna en post som visas i träfflistan genom att dubbelklicka på den.

Du kan förhandsgranska poster i [sidopanelen][1]. Klicka på listan högst upp i sidopanelen och välj **Förhandsgranska**. Klicka på en post i sökresultatet för at förhandsgranska den.

## Varför får jag ingen träff på sökord som jag vet finns i databasen?

Om du inte får träff på sökorden i SuperOffice-databasen kanske du måste generera indexet för fritextsökning i Inställningar och underhåll först.

[!include[Examples of searches](includes/freetext-search-examples.md)]

## Relaterade ämnen

* [Använd fönstret Sök][2]
* [Snabbsökning][3]
* [Historiklistan][4]

<!-- Referenced links -->
[1]: ../../learn/getting-started/main-screen/side-panel.md
[2]: find-screen.md
[3]: using-fastsearcher.md
[4]: using-history-list.md

<!-- Referenced images -->
[img1]: media/freetext.bmp
