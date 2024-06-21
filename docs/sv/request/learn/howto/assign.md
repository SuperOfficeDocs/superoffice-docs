---
uid: help-sv-request-assign
title: Tilldelningsmetoder
description: Tilldelningsmetoder för ärenden
keywords: ärende
author: Hanne Gunnarsson, Christian Mogensen, Bergfrid Dias
date: 06.11.2024
version: 10
language: sv
topic: concept
audience: person
audience_tooltip: SuperOffice Service
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

Låt oss illustrera dessa tilldelningsmetoder med tre användare och tre inkommande ärenden.

![Request assignment methods -screenshot][img1]

### Jämn fördelning

Tilldelar ärenden jämnt bland kategoriens medlemmar i en rundgång.

![Request assignment methods, even -screenshot][img2]

### Viktad fördelning

Tilldelar ärenden baserat på specifika viktningar för varje medlem i kategorin. Till exempel, om medlem A har en vikt på 1, medlem B har 2, och medlem C har 5, kommer de över 8 ärenden att tilldelas proportionellt.

ärenden tilldelas probabilistiskt baserat på deras viktningar.

![Request assignment methods, weighted][img3]

| Förfrågan | Slumpvärde | Tilldelad till |
|---|:-:|---|
| Första förfrågan | 7 | Medlem C |
| Andra förfrågan | 2 | Medlem B |
| Tredje förfrågan | 5 | Medlem C |

![Request assignment methods, weighted -screenshot][img4]

### Till användare med minst aktiva ärenden

Tilldelar nya ärenden till medlemmen med färst aktiva ärenden.

| Förfrågan | Villkor | Tilldelad till |
|---|---|---|
| Första förfrågan | Medlemmarna B och C har färst ärenden | Medlem C |
| Andra förfrågan | Medlem B har färst ärenden | Medlem B |
| Tredje förfrågan | Alla medlemmar har samma antal ärenden | Medlem B |

![Request assignment methods, user with fewest open requests -screenshot][img5]

### Tilldela inte

Tilldelar inte ärenden till specifika medlemmar. Alla ärenden placeras i en kö som standard.

![Request assignment methods, do not assign -screenshot][img6]

[!include[Get next request in queue](includes/howto-get-next-request.md)]

## Ange tilldelningsmetod för kategori

En ärendehandläggare som har behörighet att administrera kategorier kan specificera tilldelningsmetoden för kategorier:

1. [!include[Go to](../../../learn/includes/goto-sm.md)]
1. Välj **Ärenden** > **Kategorier**.
1. Välj önskad kategori.
1. Välj fliken **Tilldelningsmetod**.
1. Välj lämpliga alternativ.
1. Klicka på **OK**.

## Exempel

<!-- markdownlint-disable-next-line MD034 -->
Anta att ditt företag har skapat en kategori för varje avdelning i företaget: Användarsupport, Försäljning, Redovisning och så vidare. Du har också specificerat att alla e-postmeddelanden som skickas till support@company.com automatiskt ska gå till kategorin "Användarsupport". All personal vid supportavdelningen är medlemmar i denna kategori. För denna kategori har de valt metoden **Jämn fördelning**. Det betyder att alla medlemmar i kategorin får samma antal ärenden och att varje medlem kontinuerligt får upp nya ärenden på skärmen **Egna aktiva ärenden**. Om de i stället hade valt metoden **Tilldela inte** skulle medlemmarna ha varit tvungna att gå in på skärmen **Otilldelade ärenden** själva för att [ta på sig nya ärenden][4].

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
[img1]: ../../../../media/loc/en/request/assign-requests.png
[img2]: ../../../../media/loc/en/request/assign-requests-even.png
[img3]: ../../../../media/loc/en/request/assign-requests-weighted-diagram.png
[img4]: ../../../../media/loc/en/request/assign-requests-weighted.png
[img5]: ../../../../media/loc/en/request/assign-requests-fewest.png
[img6]: ../../../../media/loc/en/request/assign-requests-not.png
