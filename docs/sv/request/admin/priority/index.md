---
uid: help-sv-request-priority
title: Ärendeprioriteter
description: Ärendeprioriteter
keywords: ärendeprioritet, prioritet, eskalering, ärende
author: Bergfrid Dias
version: 10.5.2
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
language: sv
redirect_from: /sv/request/learn/priority/index
index: true
---

# Ärendeprioriteter

Alla ärenden som registreras i SuperOffice tilldelas en prioritet som återspeglar hur viktigt ärendet är.

De standardprioriteter som finns i systemet är **Hög**, **Medel** och **Låg**. Men du kan både lägga till nya prioriteter och ändra inställningarna för befintliga prioriteter.

Den prioritet som ett visst fall tilldelas kan t.ex. bero på:

* Kontakten
* Företaget
* E-postlådan
* Ett e-postfilter

När ett ärende har fått en prioritet kan den användas för att styra eventuell eskalering av ärendet.

Till exempel kan du ange att ärenden från ett visst företag ska ha VIP-prioritet och att du ska meddelas via e-post om ärendet inte har lästs inom en viss tidsfrist.

## Prioritetsordning

Prioriteter åsidosätter andra prioriteter i följande ordning:

1. Prioritet specificerad för ett e-postfilter
1. Prioritet specificerad för en kontakt
1. Prioritet specificerad för ett företag
1. Prioritet specificerad för en e-postinkorg
1. Standardprioriteter

På grund av denna ordning kommer ett ärende från en kontakt med hög prioritet att få hög prioritet även om den e-postlåda som personen skickar ärendet till har låg prioritet.

## Eskalering

I SuperOffice-ärenden kan du definiera så många prioriteter du vill. För varje prioritet kan du definiera olika eskaleringsnivåer, så att ärendet vidarebefordras inom organisationen om det inte har lästs eller behandlats inom en viss tid.

Till exempel specificerar support- och SLA-avtal att leverantören måste påbörja felsökning inom t.ex. 2 timmar. Du kan sedan definiera åtgärder som gör att ärendet eskaleras och tilldelas till nya ärendehandläggare om det inte har lästs eller behandlats inom denna tid. Du kan definiera så många åtgärder du vill och även meddelas via mobiltelefon.

## Tillgänglighet

Varje prioritet har en tillgänglighetsegenskap kopplad till sig. Om ärendets prioritet är inställd på **Externt**, blir prioriteten tillgänglig via SuperOffice Customer Centre.

Om fler än två prioriteter är tillgängliga externt kan kunden välja vilken prioritet som ska gälla för ärendet. Detta kan leda till att ärendet får en högre prioritet än nödvändigt, eftersom kunden vill få ett svar så snabbt som möjligt och sannolikt väljer den högsta möjliga prioriteten. Därför bör de högsta prioriteterna ställas in som **Internt**, medan **Medel** och **Låg** görs tillgängliga externt.

## Relaterat innehåll

* [Skapa prioritet][1]
* [Ta bort prioriteter][2]
* [Skapa eskaleringsnivåer][3]

<!-- Referenced links -->
[1]: create.md
[2]: delete.md
[3]: escalation-levels.md
