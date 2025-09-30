---
uid: help-sv-flow-participants
title: Flödesdeltagare
description: Flödesdeltagare
keywords: flöde, flödesdeltagare, deltagar, deltagarlistan, deltagarstatus, slutförd, bortfall, framgångsgrad, framgångskriterier
author: Bergfrid Dias, Trude Lien Smedbråten
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: flows
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: sv
---

# Flödesdeltagare

## Steg

För att visa listan över deltagare för ett specifikt flöde:

1. Gå till **Marknadsföring** > **Flöden**.
2. Klicka för att välja ett flöde.
3. Välj fliken **Deltagare**.
4. Välj valfritt vad du vill gruppera listan efter.

![Deltagarlistan för flödet -screenshot][img1]

Använd kugghjulet (<i class="ph ph-gear" aria-hidden="true"></i>) i listans header för att anpassa kolumnerna.

![Deltagarlistan för flödet, anpassa kolumner -screenshot][img2]

## Deltagarstatus

| Status | Beskrivning |
|---|---|
| Körs | Deltagaren är aktiv i flödet. |
| Slutförd | Deltagaren har avslutat alla steg i flödet. |
| Slutförd med framgång | Deltagaren har avslutat flödet och uppfyllt framgångskriteriet. Inkluderas i flödets framgångsgrad. |
| Bortfall | Deltagaren har hoppat av, alltid med en specificerad bortfallsorsak. |
| Avbruten | Deltagaren kommer inte att slutföra flödet eftersom en administratör avslutade flödet. |

## <a id="logic"></a>Registrering och progression genom flödet

Före varje steg omvärderar SuperOffice CRM om deltagaren kan fortsätta.

För alla stegtyper:

1. Är deltagarens status *Pågåande*?
2. Uppfyller deltagaren det definierade framgångskriteriet?
3. Är kontakten markerad som en tidigare anställd?
4. Är kontakten tillagd i exkluderingslistan?

Ytterligare för e-poststeg:

1. Är deras samtycke giltigt?
2. Är kontakten prenumererad på flödets prenumerationstyp?
3. Har kontakten registrerad e-postadress?
4. Är e-postadressen redan aktiv inom flödet?
5. Är e-postadressen inte blockerad?

Ytterligare för SMS-steg:

1. Har kontakten registrerat mobilnummer för SMS?

### Hur påverkar framgångskriterier registreringen

* Kontakter som redan uppfyller framgångskriterierna kommer ändå att läggas till i flödet och räknas som framgångar. Deras progression genom flödets steg beror på konfigurationen.

* Kontakter som uppfyller framgångskriterierna efter att ha avslutat ett flöde kommer inte att inkluderas i flödets framgångsgrad, eftersom det inträffade efter deras aktiva deltagande.

### Vilken gren följer en deltagare?

I en delning följer deltagare den första (vänstermost) grenen där de uppfyller de angivna villkoren.

## Uppgifter

* Lägg till i urval: Inkluderar deltagaren i ett statiskt urval.
* Lägg till i flöde: Indikerar att denna kontakt föreslås för registrering i ett annat flöde.
* Ta bort från flöde: Tar bort all information om kontaktens deltagande i det aktuella flödet.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-participants.png
[img2]: ../../../../media/loc/en/marketing/flow-participant-columns.png
