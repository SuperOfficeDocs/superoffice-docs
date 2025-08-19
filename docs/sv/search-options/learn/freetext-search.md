---
uid: help-sv-search-freetext
title: Fritextsökning
description: Fritextsökning
author: SuperOffice RnD
date: 05.25.2023
keywords: fritext, söka
content_type: howto
language: sv
---

# Fritextsökning

Textfältet högst upp till höger i SuperOffice CRM kan användas till fritextsökning. Här kan du söka efter all text i SuperOffice CRM som användarna själva har lagt in i databasen, till exempel företagsnamn, avdelning, information om kontakter och uppföljningar.

![Fritextsökning -screenshot][img1]

> [!NOTE]
> Om fälten för fritextsökning inte visas i det övre högra hörnet är detta alternativ inte aktiverat i Inställningar och underhåll.

## Steg

1. Skriv den text som du vill söka efter (minst tre tecken).

2. Tryck på **ENTER** för att starta sökningen.

3. Fönstret **Sökresultat** öppnas och visar alla data som innehåller söktexten, grupperade i flikar.

    * Klicka på en flik för att visa listan med sökresultat.
    * Du kan öppna en post som visas i träfflistan genom att dubbelklicka på den.

> [!TIP]
> Du kan förhandsgranska poster i [sidopanelen][1]. Klicka på listan högst upp i sidopanelen och välj **Förhandsgranska**. Klicka på en post i sökresultatet för at förhandsgranska den.

## Exempel på sökningar

* Om du söker på "office" visas även SuperOffice i listan med träffar.
* Om du stavar ett ord fel får du förslag. En sökning på "ofice" (felstavat) ger också träffen "SuperOffice". Detta är också mycket användbart om du bara kommer ihåg en del av ett företagsnamn eller namnet på en kontakt som du söker efter.
* En sökning på "123" kommer också att generera en träff som "SAP 123", eftersom siffrorna också indexeras.
* En sökning på "IBM" kommer också att generera en träff som "I.B.M.", eftersom indexeraren även tar bort citattecken, punkt och liknande tecken i indexet.

## Begränsningar och ignorerade ord

Du kan söka på text från dialogrutan **Dokument**, men du kan inte söka i det faktiska innehållet i dokument. Sökningen börjar alltid med text som står i fältet **Vår ref** i dialogrutan **Dokument**.

> [!NOTE]
> Vissa ord ignoreras vid fritextsökning. Dessa definieras under Inställningar och underhåll.

## Varför får jag ingen träff på sökord som jag vet finns i databasen?

Om du inte får träff på sökorden i SuperOffice-databasen kanske du måste generera indexet för fritextsökning i Inställningar och underhåll först.

## Relaterat innehåll

* [Använd fönstret Sök][2]
* [Snabbsökning][3]
* [Historiklistan][4]

<!-- Referenced links -->
[1]: ../../learn/getting-started/main-screen/side-panel.md
[2]: find-screen.md
[3]: index.md#fastsearcher
[4]: ../../learn/basics/history.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/search-options/freetext-search-box.png
