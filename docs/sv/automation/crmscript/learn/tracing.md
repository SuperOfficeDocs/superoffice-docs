---
uid: help-sv-automation-script-tracing
title: Spårning
description: Spårning
author: Bergfrid Dias
date: 12.20.2023
version: 10.2.11
keywords: CRMScript, spåra, felsök
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Spårning

Spårningsfunktionen registrerar varje detalj i körningen av ett skript eller makro och sparar i en logg. Varje gång ett skript eller makro används registreras körningen.

Sedan kan du undersöka skriptkörningen genom att spola tillbaka och spola framåt genom inspelningen. Du får en fullständig lista över alla registrerade körningar av skriptet och av vem som skriptet kördes. På så sätt kan du se hur skripten fungerar och se alla variabler vid en angiven tidpunkt.

## Visa spårningar

Fliken **Spårning** innehåller en lista över alla spårningar. Klicka på ett spår i listan om du vill visa information.

## Starta spårning

1. Gör en av följande:

    * Öppna ett skript eller makro i **Felsökning** och klicka på **Spåra skript**.
    * Öppna ett skript eller makro på fliken **Makron och skript** och klicka på **Spåra skript**.

2. Ange en **beskrivning** av spåret, för att göra det enklare att identifiera.
3. Valgfritt, ställ in **Användarfilter** om du vill ha ett användarspecifikt spår.
4. Valgfritt, specificera notifierings- och lagringsegenskaper. Se [lista över fält](#fields) nedan.
5. Välj **Aktiverad** för att aktivera spåret.
6. Klicka **OK** när du är klar.

## Slå på/av alla aktiverade spår

1. Gå till **CRMScript** > **Felsökningssessioner**.
2. Klicka på **Starta spårning av skript** för att starta spårningen av skripten i listan.
    Klicka på **Stoppa spårning av skript** för att pausa spårningen.

## Redigera spår

1. Klicka på ett spår i **Spårning** listan för att öppna den.
2. Klicka **Redigera spår**.
3. Uppdatera fälten som behövs.
4. Klicka **OK** när du är klar.

![Trace CRMScript -screenshot][img4]

### <a id="fields"></a>Fält

| Fält | Beskrivning |
|---|---|
| Beskrivning | En förklaring av spåret, för att göra det enklare att identifiera. |
| Användarfilter | Begränsar spårningen till en specifik användare. |
| Spårningslösning | Samplingsfrekvensen av spårloggen. 1 - spår varje utförande av skriptet; 5 - spår var femte utförande; och så vidare. |
| Behåll spår | Hur länge att behålla ett spår innan det raderas. |
| Aktiverad | Aktiverar spåret. |
| Meddela | Om man ska skicka aviseringsmejl. |
| Maximalt antal meddelanden | Begränsar antal mejl skickade. |
| E-postavisering | Var man ska skicka notifikationer. |
| Spara bara om det finns ett ohanterat undantag | Begränsar spår till undantag. |

<!-- Referenced links -->

<!-- Referenced images -->
[img4]: ../../../../media/loc/en/automation/trace.png
