---
uid: help-sv-request-priority-create
title: Skapa prioritet
description: Skapa prioritet
keywords: skapa ärendeprioritet, lägg till prioritet, ny prioritet, ärendeprioritet, Prioriteter-fliken, eskaleringshändelser, eskaleringskedja, ärende, prioritet
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
redirect_from: /sv/request/learn/priority/create
index: true
---

# Skapa ärendeprioritet

De standardprioriteter som finns i systemet är **Hög**, **Medel** och **Låg**. Men du kan både lägga till nya prioriteter och ändra inställningarna för befintliga prioriteter.

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

## Steg

1. I Inställningar och underhåll, gå till  **Ärenden** i navigatorn och välj fliken **Prioriteter**.

1. Klicka på knappen **Lägg till**.

1. Ange ett beskrivande namn i fältet **Prioriteringsnamn**.

1. På fliken **Egenskaper** anger du följande information:

    * Externt
    * Använd som standard
    * Tidsfrist
    * Borttagen

    Mer information om varje fält finns i [Prioriteringsinställningar](#priority-settings).

1. Under **Tidsram**, ange vilka tidsramar som ska gälla för ärendehanteringen.

    * Ange tidsintervall för varje dag i veckan.

    * Du kan också ange dagar som ska uteslutas i fältet **Helgdagar (dag/månad)**. Markera **Inkludera år** om du vill inkludera året i dessa datum.

1. På fliken **Eskaleringshändelser**, ange hur eskaleringskedjan ska reagera vid olika händelser i ärendet. Alternativ:

    * Ärende läst av ägare
    * Bytt ägare (manuellt)
    * Ny information
    * Ärende avslutat
    * Bytt prioritet

        > [!NOTE]
        > Om du väljer **Fortsätt**, behåller ärendet samma nivå i eskaleringskedjan som innan ändringen. Med andra ord används inte tiderna vid en förändring, endast nivån.

    * Nytt ärende
    * Eskalera ärenden inom tidsram

    Mer information om varje alternativ finns i [Prioriteringsinställningar](#escalation-options).

1. Klicka på **Spara**. Prioriteten skapas. Nu kan du t.ex. [koppla eskaleringsnivåer till denna prioritet][1].

## <a id="priority-settings"></a>Prioriteringsinställningar

| Inställning | Beskrivning |
|---|---|
| Namn | Ett beskrivande namn för prioriteten. |
| Borttagen | Anger om prioriteten är aktiv (normal) eller borttagen (otillgänglig). |
| Externt | Markerad betyder att prioriteten är synlig i SuperOffice Customer Centre. |
| Använd som standard | Markerad betyder att denna prioritet är standardprioritet. |
| Tidsfrist | Anger den tidsfrist som ärenden med denna prioritet ska ha. Värdet beräknas baserat på tidsramen och sparas för varje ärende. |
| Tidsram | Tidsintervall för varje veckodag som gäller för ärendehantering. |
| Helgdagar (dag/månad) | Dagar att exkludera från tidsramen, t.ex. helgdagar då eskalering inte ska ske. Ange en kommaseparerad lista, t.ex. 25/12, 26/12. Du kan också använda datumfältet nedan. |
| Inkludera år | Markera för att inkludera år i angivna helgdagar. |
| Eskalera ärenden inom tidsram | Om markerad eskaleras ärenden med denna prioritet endast under den angivna tidsramen. Utanför dessa tider "fryses" eskaleringen. |

## <a id="escalation-options"></a>Eskaleringsalternativ

| Alternativ | Beskrivning |
|---|---|
| Ärende läst av ägare | Om markerad, styrs eskaleringskedjan enligt inställningarna i listan till höger när ärendet läses av ägaren. Val: **Stoppa**, **Fortsätt**, **Omstart**. |
| Bytt ägare (manuellt) | Om markerad, styrs eskaleringskedjan enligt inställningarna i listan till höger när ägaren byts manuellt. |
| Ny information | Om markerad, styrs eskaleringskedjan enligt inställningarna i listan till höger när ny information tillkommer, t.ex. ett nytt meddelande i ärendet. |
| Ärende avslutat | Om markerad, styrs eskaleringskedjan enligt inställningarna i listan till höger när ett ärende avslutas. |
| Bytt prioritet | Om markerad, styrs eskaleringskedjan enligt inställningarna i listan till höger när en annan prioritet sätts på ett ärende. |
| Nytt ärende | Om markerad, styrs eskaleringskedjan enligt inställningarna i listan till höger när ett nytt ärende med denna prioritet skapas. |

<!-- Referenced links -->
[1]: escalation-levels.md
