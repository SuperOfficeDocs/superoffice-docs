---
uid: help-sv-automation-script-tracing
title: Spårning
description: Spårning
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRMScript, spåra, felsök
so.topic: howto
so.user: admin
language: sv
---

# Spårning

Spårningsfunktionen registrerar varje detalj i körningen av ett skript eller makro och sparar i en logg. Varje gång ett skript eller makro används registreras körningen.

Sedan kan du undersöka skriptkörningen genom att spola tillbaka och spola framåt genom inspelningen. Du får en fullständig lista över alla registrerade körningar av skriptet och av vem som skriptet kördes. På så sätt kan du se hur skripten fungerar och se alla variabler vid en angiven tidpunkt.

## Visa spårningar

Fliken **Spårning** innehåller en lista över alla spårningar. Klicka på ett spår i listan om du vill visa information.

## Starta spårningar

* Gå till **CRMScript** &gt; **Felsökningssessioner** och klicka på ![ikon][img1] **Starta spårning av skript** om du vill starta spårningen av skripten i listan.
* Öppna ett skript eller makro i **Felsökning** och klicka på ![ikon][img2] **Spåra skript**.
* Öppna ett skript eller makro på fliken **Makron och skript** och klicka på ![ikon][img2] **Spåra skript**.

## Redigera spårningar

1. Öppna ett spår genom att klicka på det i listan **Spårning**.

2. Klicka på ![ikon][img3] **Redigera spår**. Skärmen **Redigera spår** visas.

3. Fyll i följande fält:

    * **Beskrivning**: Ange en beskrivning av spåret så att det blir lättare att identifiera.
    * **Användarfilter**: Om du vill spåra skriptet för en specifik användare väljer du användaren i listan.
    * **Spårningslösning**: Ange exempelfrekvensen i spårningsloggen.
        Exempel: Ange 1 om du vill logga varje kommando som körs av skriptet. Ange 5 om du vill logga var femte kommando som körs av skriptet.
    * **Behåll spår**: Välj hur länge spårningsloggarna ska behållas.
    * **Aktiverad**: Välj det här alternativet om du vill aktivera spåret.

4. Klicka på **OK** när du är färdig.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../media/icons/run-script.png
[img2]: ../../../../media/icons/btn-script-trace-small.png
[img3]: ../../../../media/icons/edit.png
