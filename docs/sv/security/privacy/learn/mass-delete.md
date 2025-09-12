---
uid: help-sv-mass-delete
title: Ta bort flera poster (permanent)
description: I enlighet med GDPR-kraven måste du ha en rättslig grund för att lagra uppgifter för alla dina kontakter. Och när du inte längre har en rättslig grund för att göra detta, måste du ta bort deras uppgifter från alla dina system.
keywords: ta bort flera poster, radera personuppgifter
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: howto
category: privacy
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from: /sv/search-options/selection/learn/howto/mass-delete
---

# Ta bort flera poster (permanent)

I enlighet med GDPR-kraven måste du ha en rättslig grund för att lagra uppgifter för alla dina kontakter. Och när du inte längre har en rättslig grund för att göra detta, måste du ta bort deras uppgifter från alla dina system.

Det betyder att du inte får spara en persons uppgifter för alltid. Som företag måste du tänka på och kunna motivera – hur länge du kommer att behålla personuppgifter innan du raderar dem eller granska de uppgifter du lagrar.

För att ta bort flera poster (kontakter, företag, försäljning, projekt och så vidare) kan du skapa ett urval av dessa poster och ta bort dem på en och samma gång.

> [!NOTE]
> Denna uppgift är endast tillgänglig för användare med administratörsbehörighet. Det är också en åtgärd du bör tänka igenom noga innan du utför den, eftersom den raderar alla markerade poster permanent, både från fönstret Urval och från SuperOffice-databasen.

## Bestämma vilka personuppgifter som behöver raderas och när

Hur länge du kan lagra uppgifter beror på ett antal saker som är specifika för ditt företag och är bland de saker du definierar som en del av din integritetsstrategi.

Du kan till exempel bestämma att du kan motivera att spara personuppgifterna om potentiella kunder i tre år och personuppgifterna för förlorade kunder i fem år eller något liknande.

Kanske bestämmer du dig för att tiden för lagring av personuppgifter kommer att vara längre för personer som har gett sitt samtycke till att ta emot marknadsföringsinformation och förlorade kunder som fortsätter att ställa frågor till ditt företags kundsupport.

Alla dessa villkor måste du klargöra och definiera som en del av din GDPR-strategi. Det rekommenderas att uppsöker juridisk rådgivning i sådana frågor för att säkerställa regelefterlevnad.

När du har fastställt vilka regler som gäller för ditt företag kan du använda urvalsfunktionen och [SAINT-funktionen][2] i SuperOffice CRM för att hitta de kontakter som ska tas bort, och massradera alla kontakter som du inte längre vill behålla i systemet.

## Hitta kontakter som ska tas bort eller granskas med Urval

Urval är ett verktyg för att hitta data i din CRM-databas som uppfyller en viss uppsättning kriterier.

Att ta bort alla kontakter i en viss kundkategori och som du inte har varit i kontakt med under en viss period hjälper dig att hålla din databas uppdaterad.

Du kan till exempel skapa ett urval med alla kontakter som definierats som:

* Potentiella
* Registrerade före ett visst datum
* Som inte har några uttryckliga medgivanden dokumenterade
* Som inte har haft någon interaktion med ditt företag under en viss period

Du kan söka efter kontakter som uppfyller mer än ett kriterium, eller så kan du skapa flera urval och sedan söka efter de data som är gemensamma eller annorlunda genom att skapa ett kombinationsurval.

Urval är ett mycket flexibelt och kraftfullt verktyg, efter att du har behärskat hur du använder det.

## Använd SuperOffice SAINT för att granska dina kontakter

Du kan också använda SAINT för att identifiera möjliga kontakter som behöver raderas.

SAINT står för "SAles INTelligence" och fungerar genom att bidra med några smarta algoritmer i dina CRM-data.

Enkelt uttryckt övervakar SuperOffice SAINT de data du har lagrat i din CRM-lösning och varnar dig om olika statusar eller åtgärdsärenden som du har definierat som viktiga. Det kan vara allt från åtgärder som ännu inte har hänt under en viss tid, till värden som uppfylls eller inte uppfylls, och som du vill bli varnad om, så att du kan vidta de åtgärder som krävs.

SAINT kan också användas för att övervaka kontaktinformation. Det innebär att du till exempel kan använda SAINT för att identifiera kontakter som du inte har haft kontakt med alls under en viss period. Detta skulle ge dig en lista över kontakter som du kanske vill ta bort från din CRM-databas eller behandla på ett visst sätt, baserat på ditt företags GDPR-policy.

SAINT-kriterierna finns under **Räknare (SAINT)** i [kriterielistan][9] i fönstret **Sök**.

Om SAINT är helt nytt för dig, kan det vara bra att ta hjälp av en SuperOffice CRM-expert för att komma igång. Din lokala SuperOffice-kontakt kan hjälpa dig med detta.

## Massuppdatering av kontakter

När du har [skapat ett urval][8] med kontakter som behöver uppdateras kan du snabbt ändra deras uppgifter i bulk.

1. Öppna det önskade urvalet och gå till fliken **Företag/kontakt**.
1. Klicka på **Uppgift**-knappen (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) och välj **Massuppdatering**.
1. Välj vilket fält du vill uppdatera (till exempel rättslig grund eller kategori).
1. Utför ändringarna och bekräfta.

> [!TIP]
> [Massuppdatering][5] hjälper dig att hålla databasen konsekvent och i linje med företagets riktlinjer.

## Massradering av kontakter och företag

För att följa GDPR måste du radera personuppgifter när du inte längre har en rättslig grund för att lagra dem.

> [!CAUTION]
> Endast administratörer kan utföra denna åtgärd. **Raderade poster kan inte återställas.**

### Steg

1. Öppna det önskade urvalet och gå till fliken **Företag/kontakt**.
1. Om du bara vill radera vissa kontakter markerar du dem i fliken Företag/kontakt.
1. Klicka på **Uppgift**-knappen (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) och välj **Ta bort alla kontakter** eller **Ta bort alla företag och kontakter**.
1. Bekräfta raderingen när du uppmanas till det.

<!-- Referenced links -->
[9]: ../../../search-options/learn/search-criteria.md
[8]: ../../../search-options/selection/learn/create.md
[5]: ../../../learn/basics/bulk-update.md
[2]: https://community.superoffice.com/no/learning/best-practices-tips/standard-crm/saint-proactive-customer-follow-up/
