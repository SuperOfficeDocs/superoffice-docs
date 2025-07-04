---
uid: help-sv-request-assign
title: Tilldelningsmetoder
description: Tilldelningsmetoder för ärenden
keywords: automatisk tilldelning, tilldelningsmetod, tilldela ärende, ärende
author: Hanne Gunnarsson, Christian Mogensen, Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: sv
redirect_from: /sv/request/learn/howto/assign
---

# Automatiska tilldelningsmetoder för ärenden

För att ett ärende ska vara ditt ansvar måste ditt namn synas i fältet **Ägare** för ärendet. Detta kan anges manuellt, till exempel när [ärendet skapas][2]. Men det kan också vara resultatet av en automatisk tilldelning. Sådan tilldelning beror på vilken kategori ärendet tillhör och vilken tilldelningsmetod som angetts för kategorin.

## Tilldelningsmetoder

| Metod | Beskrivning |
|---|---|
| Jämn fördelning | Ärenden fördelas jämnt bland kategorins medlemmar. |
| Viktad fördelning | Ärenden fördelas baserat på de [vikttal][3] som har angetts för medlemmar i kategorin. |
| Till användare med minst aktiva ärenden | Nya ärenden tilldelas till den kategorimedlem som har minst antal aktiva ärenden. |
| Tilldela inte | Ärenden tilldelas inte till specifika ärendehandläggare utan alla ärenden placeras i en kö med statusen **Otilldelade**. |

Låt oss illustrera dessa tilldelningsmetoder med tre användare och tre inkommande ärenden.

![Tilldelningsmetoder -screenshot][img1]

### Jämn tilldelning

Tilldelar ärenden jämnt mellan medlemmarna i kategorin enligt en rundgångsmetod.

![Jämn tilldelning -screenshot][img2]

### Viktad tilldelning

Tilldelar ärenden baserat på specifika viktningar för varje medlem i kategorin. Till exempel, om medlem A har en vikt på 1, medlem B har 2, och medlem C har 5, kommer de över 8 ärenden att tilldelas proportionellt.

Ärenden tilldelas probabilistiskt baserat på deras viktningar.

![Request assignment methods, weighted][img3]

| Förfrågan | Slumpvärde | Tilldelad till |
|---|:-:|---|
| Första förfrågan | 7 | Medlem C |
| Andra förfrågan | 2 | Medlem B |
| Tredje förfrågan | 5 | Medlem C |

![Viktad tilldelning -screenshot][img4]

### Till användare med minst aktiva ärenden

Tilldelar nya ärenden till medlemmen med färst aktiva ärenden.

| Förfrågan | Villkor | Tilldelad till |
|---|---|---|
| Första förfrågan | Medlemmarna B och C har färst ärenden | Medlem C |
| Andra förfrågan | Medlem B har färst ärenden | Medlem B |
| Tredje förfrågan | Alla medlemmar har samma antal ärenden | Medlem B |

![Till användaren med minst aktiva ärenden -screenshot][img5]

### Tilldela inte

Tilldelar inte ärenden till specifika medlemmar. Alla ärenden placeras i en kö som standard.

![Tilldela inte -screenshot][img6]

**Hämta nästa ärende i kön**: Om kösystemet är aktiverat för ditt företag kan du klicka på detta alternativ för att få nästa otilldelade ärende i kön för den kategori du tillhör.

## Ange tilldelningsmetod för en kategori

En ärendehandläggare med administratörsrättigheter för kategorier kan ange tilldelningsmetoden:

1. [!include[Go to](../../learn/includes/goto-sm.md)]
1. Välj **Ärenden** > **Kategorier**.
1. Välj önskad kategori.
1. Gå till fliken **Tilldelningsmetod**.
1. Välj lämpliga alternativ.
1. Klicka på **OK**.

## Exempel

<!-- markdownlint-disable-next-line MD034 -->
Anta att ditt företag har skapat en kategori för varje avdelning i företaget: Användarsupport, Försäljning, Redovisning och så vidare. Du har också specificerat att alla e-postmeddelanden som skickas till support@company.com automatiskt ska gå till kategorin "Användarsupport". All personal vid supportavdelningen är medlemmar i denna kategori. För denna kategori har de valt metoden **Jämn fördelning**. Det betyder att alla medlemmar i kategorin får samma antal ärenden och att varje medlem kontinuerligt får upp nya ärenden på skärmen **Egna aktiva ärenden**. Om de i stället hade valt metoden **Tilldela inte** skulle medlemmarna ha varit tvungna att gå in på skärmen **Otilldelade ärenden** själva för att [ta på sig nya ärenden][4].

Om de istället hade valt **Tilldela inte**, skulle de ha varit tvungna att gå in på skärmen **Otilldelade ärenden** för att [ta på sig nya ärenden][4].

## Relaterat innhåll

* [Behandla ett ärende][1]
* [Skapa ett ärende][2]
* [Acceptera ett ärende][4]
* [Be en annan ärendehandläggare om hjälp (överför)][5]
* [Så här konfigurerar du Hämta nästa ärende i kön][6]

<!-- Referenced links -->
[1]: index.md
[2]: create.md
[3]: ../admin/category/create.md
[4]: accept.md
[5]: transfer.md
[6]: ../admin/next-in-queue.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/request/assign-requests.png
[img2]: ../../../media/loc/en/request/assign-requests-even.png
[img3]: ../../../media/loc/en/request/assign-requests-weighted-diagram.png
[img4]: ../../../media/loc/en/request/assign-requests-weighted.png
[img5]: ../../../media/loc/en/request/assign-requests-fewest.png
[img6]: ../../../media/loc/en/request/assign-requests-not.png
