---
uid: help-sv-request-assign
title: Tilldelningsmetoder
description: Tilldelningsmetoder för ärenden
author: Hanne Gunnarsson
so.date: 02.14.2023
keywords: ärende
so.topic: concept
so.user: user
so.user.tooltip: SuperOffice Service
language: sv
---

# Automatiska tilldelningsmetoder för ärenden

För att ett ärende ska vara ditt ansvar, måste ditt namn synas i fältet **Ägare** för ärendet. Detta kan anges manuellt, t.ex. när [ärendet skapas][2]. Men det kan också vara resultatet av en automatisk tilldelning av ärendet. Sådan tilldelning beror på den kategori som ärendet hör till, och den tilldelningsmetod som angetts för kategorin.

## Tilldelningsmetoder

| Metod | Beskrivning |
|---|---|
| Jämn fördelning | Ärenden fördelas jämnt bland kategorins medlemmar. |
| Viktad fördelning | Ärenden fördelas baserat på de [vikttal][3] som har angetts för medlemmar i kategorin. |
| Till användare med minst aktiva ärenden | Nya ärenden tilldelas till den kategorimedlem som har minst antal aktiva ärenden. |
| Tilldela inte | Ärenden tilldelas inte till specifika ärendehandläggare utan alla ärenden placeras i en kö med statusen **Otilldelade**. |

[!include[Get next request in queue](includes/howto-get-next-request.md)]

### Ange tilldelningsmetod för kategori

En ärendehandläggare som har behörighet att administrera kategorier kan specificera tilldelningsmetoden för kategorier:

1. [!include[Go to](../../../learn/includes/goto-sm.md)]
1. Välj **Ärenden** &gt; **Kategorier**.
1. Välj önskad kategori.
1. Välj fliken **Tilldelningsmetod**.
1. Välj lämpliga alternativ.
1. Klicka på **OK**.

## Exempel

Anta att ditt företag har skapat en kategori för varje avdelning i företaget: Användarsupport, Försäljning, Redovisning och så vidare. Du har också specificerat att alla e-postmeddelanden som skickas till <support@company.com> automatiskt ska gå till kategorin "Användarsupport". All personal vid supportavdelningen är medlemmar i denna kategori. För denna kategori har de valt metoden **Jämn fördelning**. Det betyder att alla medlemmar i kategorin får samma antal ärenden och att varje medlem kontinuerligt får upp nya ärenden på skärmen **Egna aktiva ärenden**. Om de i stället hade valt metoden **Tilldela inte** skulle medlemmarna ha varit tvungna att gå in på skärmen **Otilldelade ärenden** själva för att [ta på sig nya ärenden][4].

## Vad vill du göra nu?

* [Behandla ett ärende][1]
* [Skapa ett ärende][2]
* [Acceptera ett ärende][4]
* [Be en annan ärendehandläggare om hjälp (överför)][5]

<!-- Referenced links -->
[1]: ../index.md
[2]: create.md
[3]: ../category/create.md
[4]: accept.md
[5]: transfer.md

<!-- Referenced images -->
