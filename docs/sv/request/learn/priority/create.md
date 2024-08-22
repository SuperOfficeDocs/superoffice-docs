---
uid: help-sv-request-priority-create
title: Skapa prioritet
description: Skapa prioritet
author: Hanne Gunnarsson
date: 07.03.2023
keywords: ärende, prioritet
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Skapa ärendeprioritet

De standardprioriteter som finns i systemet är **Hög**, **Medel** och **Låg**. Men du kan både lägga till nya prioriteter och ändra inställningarna för befintliga prioriteter.

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

**Steg:**

1. I Inställningar och underhåll, gå till knappen **Ärenden** i navigatorn och välj fliken **Prioriteter**.

1. Klicka på knappen **Lägg till**.

1. Ange ett beskrivande namn i fältet **Prioriteringsnamn**.

1. På fliken **Egenskaper** anger du följande information:

    * Externt
    * Använd som standard
    * Tidsfrist
    * Borttagen

    Mer information om varje fält finns i [Prioriteringsinställningar](#priority-settings).

1. Under **Tidsram** anger du vilka tidsramar som ska gälla för ärendehanteringen.

    * Ange tidsintervall för varje dag i veckan.

    * Du kan också ange dagar som ska uteslutas i fältet **Helgdagar (dag/månad)**. Välj **Inkludera år** om du vill inkludera året i dessa datum.

1. På fliken **Eskaleringshändelser** anges vad som ska ske i eskaleringskedjan vid olika händelser i ärendet. Alternativ:

    * Ärende läst av ägare
    * Bytt ägare (manuellt)
    * Ny information
    * Ärende avslutat
    * Bytt prioritet

        > [!NOTE]
        > Om du väljer **Fortsätt** får ärendet samma nivå i eskaleringskedjan som det hade före ändringen. Med andra ord så används inte tiderna om det blir en förändring, utan endast nivån.

    * Nytt ärende
    * Eskalera ärenden inom tidsram

    Mer information om varje alternativ finns i [Prioriteringsinställningar](#escalation-options).

1. Klicka på **Spara**. Prioriteten skapas. Nu kan du t.ex. [koppla eskaleringsnivåer till denna prioritet][1].

## <a id="priority-settings"></a>Prioriteringsinställningar

| Inställning | Beskrivning |
|---|---|
| Namn | Ett beskrivande namn för prioriteten. |
| Borttagen | Är prioriteten aktiv (normal) eller borttagen (inte tillgänglig).|
| Externt | Om du markerar detta alternativ är prioriteten tillgänglig via SuperOffice Customer Centre. |
| Använd som standard | Om du markerar detta alternativ används den aktuella prioriteten som standardprioritet. |
| Tidsfrist | Den tidsfrist som ärenden med denna prioritet ska ha. Detta värde beräknas utifrån tidsramen för prioriteten och sparas för varje ärende. Resultatet anger när ärendets tidsfrist går ut. |
| Tidsram | Tidsintervall för varje veckodag som gäller för behandling av ärenden. |
| Helgdagar (dag/månad) | Dagar att utesluta från tidsramen. Fridagar ställs in för lediga dagar då man inte vill att ärenden ska kunna eskaleras. Formatet är en kommaseparerad lista med dag/månad. Om du t.ex. vill utesluta 25:e och 26:e december skriver du in följande: 25/12, 26/12. Du kan också lägga till datum med hjälp av datumfältet nedan. |
| Inkludera år | Markeras detta inkluderas året i semesterdatumen. |
| Eskalera ärenden inom tidsram | Om det här alternativet är markerat, eskaleras ärenden med den här prioriteten endast under prioritetens definierade tidsram. Eskaleringen "fryses" utanför de tidsramar som har angetts på fliken **Tidsram**. |

## <a id="escalation-options"></a>Eskaleringsalternativ

| Alternativ | Beskrivning |
|---|---|
| Ärende läst av ägare | Om detta alternativ markeras, styrs eskaleringskedjan på det sätt som specificeras i listrutan till höger när ett ärende läses av ägaren. I alla listrutorna på denna flik kan du välja mellan åtgärderna: **Stoppa**, **Fortsätt** och **Omstart**. |
| Bytt ägare (manuellt) | Om detta alternativ markeras, styrs eskaleringskedjan på det sätt som specificeras i listrutan till höger när ett ärende byter ägare manuellt. |
| Ny information | Om detta alternativ markeras, styrs eskaleringskedjan på det sätt som specificeras i listrutan till höger när det kommer ny information i ett ärende. Till exempel om kunden eller användaren lägger till ett nytt meddelande i ärendet. |
| Ärende avslutat | Om detta alternativ markeras, styrs eskaleringskedjan på det sätt som specificeras i listrutan till höger när ett ärende avslutas. |
| Bytt prioritet | Om detta alternativ markeras, styrs eskaleringskedjan på det sätt som specificeras i listrutan till höger när ett ärendes prioritet ändras till den aktuella prioriteten. |
| Nytt ärende | Om detta alternativ markeras, styrs eskaleringskedjan på det sätt som specificeras i listrutan till höger när det kommer in ett nytt ärende med den aktuella prioriteten till systemet. |

<!-- Referenced links -->
[1]: escalation-levels.md

<!-- Referenced images -->
