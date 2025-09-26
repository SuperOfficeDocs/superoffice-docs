---
uid: help-sv-flow-run-pause-end
title: Kör, pausa och avsluta flöde
description: Kör, pausa och avsluta flöde
keywords: flöde, flödestatus, starta flöde, pausa flöde, körs
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

# Kör, pausa och avsluta flöde

## <a id="status"></a>Flödestatus

* **Inte igång:** Representerar ett nytt flöde som inte har startats än (eller ett avslutat flöde). Triggers är inte aktiverade.

* **Körs:** Inga ändringar är tillåtna medan flödet kör. Automatiska triggers är aktiverade och deltagare läggs till i flödet.

* **Pausad:** Triggers förblir aktiverade. Deltagare läggs till i flödet, men de väntar på att skrida till första steget. Deltagare som redan finns i flödet förblir på sitt nuvarande steg när flödet är pausat. Den här statusen används vid ändringar eller förbättringar av ett flöde.

![Marknadsföringsflöden med olika status och statistik -screenshot][img1]

## Starta flödet för första gången

För att starta ett nytt flöde:

1. Gå till **Marknadsföring** > **Flöden**.
2. Välj det flöde du vill starta.
3. I headern, växla omkopplaren till **PÅ**. Status ändras till **Körs**.

Detta aktiverar flödets triggers. Nya deltagare läggs till i flödets deltagarlista baserat på dessa triggers. Flödesdeltagare kommer att fortskrida genom flödet, åtgärder kommer att utföras tills de uppfyller flödets framgångskriterier, når slutförsteget eller faller bort.

## Pausa flödet

För att tillfälligt stoppa ett pågående flöde:

1. Öppna det flöde du vill pausa.
2. I headern, växla omkopplaren till **AV**. Status ändras till **Pausad**.

* Denna åtgärd fryser den aktuella statusen för alla deltagare, som förblir på sitt nuvarande steg.
* **Triggers förblir aktiva**, vilket gör att deltagarlistan fortsätter att växa. Nya deltagare registreras men placeras i kö.
* **Redigera**-knappen är tillgänglig, vilket tillåter flödesadministratörer att göra uppdateringar i flödet (med vissa begränsningar).

## Återstarta flödet (pausat > körs)

För att återstarta ett pausat flöde, växla omkopplaren till **PÅ** i **Visa Flöde**-skärmen.

* Alla deltagare fortsätter från det steg de befann sig på när flödet pausades.
* Deltagare som registrerades och var i kö under pausen kommer att röra sig till första steget.
* Eventuella ändringar som görs i flödet kommer att gälla för en deltagare om de ännu inte har gått förbi det relevanta steget.

## Avsluta flödet

För att avsluta flödet:

1. Öppna flödet.
2. Välj **Uppgift** > **Avsluta flöde**.

* Flödets status ändras till **Inte igång**.
* Alla triggers för detta flöde avaktiveras och registreringen upphör. Inga nya deltagare kommer att läggas till i flödet.
* Aktiva deltagare får status = *Bortfall*. De kommer inte att slutföra flödet.

> [!CAUTION]
> Denna åtgärd bör endast användas för flöden som inte längre är relevanta. Att avsluta ett flöde är inte avsett för mindre justeringar - använd paus istället. **Avbrutna deltagare kommer inte att fortsätta flödet om du bestämmer dig för att köra det igen.**

Om flödet startas igen efter att ha avslutats, går bara nya deltagare igenom flödet, gamla deltagare behåller statusen Avbruten.

## <a id="delete"></a>Ta bort flöde

1. Pausa flödet. Flödets status ändras till **Pausad**.
1. Avsluta flödet. Status ändras till **Inte igång**.
1. Klicka på <i class="ph ph-dots-three-circle-vertical" aria-label="Uppgiftsmeny"></i> och välj **Ta bort flöde**.
1. Bekräfta åtgärden.

Detta alternativ finns både i **Visa flöde**-skärmen och i översikten över alla flöden.

## Felsökning

### Kan inte köra flödet

Alla nödvändiga inställningar måste vara giltiga innan flödet kan köras. Till exempel kan ett flöde med ett e-poststeg inte köras om e-postinställningar som avsändaradress eller svarsadress saknas. Let efter varningsikonen - verktygstipset beskriver problemet.

### Kan inte ta bort flöde

Du kan inte ta bort ett körande flöde. Pausa först flödet. Avsluta sedan flödet så att statusen ändras till **Inte igång**. Därefter klickar du på <i class="ph ph-dots-three-circle-vertical" aria-label="Uppgiftsmeny"></i> och väljer **Ta bort flöde**.

## Relaterat innehåll

* [Uppdatera flöde][1]

<!-- Referenced links -->
[1]: update.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/flow-status.png
