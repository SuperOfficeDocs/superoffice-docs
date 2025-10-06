---
uid: help-sv-udef-layout
title: Anpassa användargränssnitt
description: Anpassa användargränssnitt
author: Bergfrid Dias
date: 01.29.2024
version: 10
keywords: udef, anpassa fält
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
index: true
---

# Anpassa användargränssnitt

[!include[License requirement](../../includes/req-dev-tools.md)]

SuperOffice version 10 (utgiven i oktober 2021) introducerade [Skärmdesigner][1] med anpassningsbara skärmlayouter för specifika användargrupper. Eventuella anpassade skärmlayouter med skärmdesignern kan åsidosätta de inställningar som beskrivs nedan.

När du [lägger till nya fält][2], placeras de under varandra som standard. Varje fält består av en ledtext med ett datafält till höger. Du kan bestämma var i rutan dessa fält ska placeras.

## Var du ska börja

1. [!inkludera[Gå till Fält och välj flik](includes/goto-fields.md)]

**Hur du väljer fält:**

* Klicka på ett fält i rutnätet för att markera det.
* Klicka och dra i rutnätet för att markera flera fält.
* Klicka på ett fält i listan **Fält** för att markera både ledtexten och datafältet i rutnätet.

## Flytta fält

* Klicka och dra med musen. Fälten passas automatiskt in i rutnätet.
* Klicka på ett fält och använd piltangenterna på tangentbordet.
* Klicka på ett fält och använd piltangenterna i nedre högra hörnet (<i class="ph ph-arrow-circle-left" aria-hidden="true"></i> <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> <i class="ph ph-arrow-circle-up" aria-hidden="true"></i> <i class="ph ph-arrow-circle-down" aria-hidden="true"></i>).
* Dubbelklicka på ett fält och ange positionsvärdena **X** och **Y** i dialogrutan **Fält**.

## Ange position

1. Ange följande i fälten till höger om **Ledtext**:

    **X**: Horisontell position för ledtexten. Ju högre siffr, desto längre till höger.

    **Y**: Vertikal position för ledtexten. Ju högre siffr, desto längre ner.

2. Ange följande i fälten till höger om **Data**:

    **X**: Horisontell position för datafältet. Ju högre siffr, desto längre till höger.

    **Y**: Vertikal position för datafältet. Ju högre siffr, desto längre ner.

## Justera fält (höger/vänster)

Markera de fält du vill justera och klicka på vänsterjustera (<i class="ph ph-text-align-left" aria-hidden="true"></i>) eller högerjustera (<i class="ph ph-text-align-right" aria-hidden="true"></i>) under rutnätet.

## Ändra bredden på ett fält

1. Dubbelklicka på det relevanta fältet i listan **Fält** eller i rutnätet.
2. Ange bredden på ledtexten i fältet till höger om **Ledtext**.
3. Ange bredden på datafältet i fältet till höger om **Data**.

## Redigera tabbordningen för fälten på fliken Mer

Tabbordningen är ordningen som du flyttar mellan de olika fälten när du trycker på tabbtangenten. Du kan ändra tabbordningen så att den överensstämmer med den logiska sekvens enligt vilken användarna normalt lägger in data i fälten.

Tabbordningen visas i listan **Namn** på vänster sida av fönstret. Ordningen är inte densamma som fältens fysiska placering, vilken visas i förhandsgranskningsfältet längst upp till höger.

**Steg:**

1. Välj önskat fält under listan.

1. Klicka på <i class="ph ph-arrow-circle-up" aria-label="Arrow up"></i> <i class="ph ph-arrow-circle-down" aria-label="Arrow down"></i> under listan för att flytta fältet uppåt eller nedåt.

1. Klicka på **Publicera** för att ändringarna ska vara tillgängliga för SuperOffice CRM-användarna.

## <a id="page-1"></a>Visa användardefinierat fält på förstasidan

1. Markera **Tillåt olika sidan 1-fält för olika användargrupper** längst ner på fliken om du vill definiera olika sidan 1-fält för olika användargrupper. Om det här alternativet inte markeras används fälten du skapar för alla användargrupper.

1. I listan med användargrupper ovan väljer du önskad användargrupp (om du markerade **Tillåt olika sidan 1-fält för olika användargrupper** i föregående steg).

1. I listrutan **Fält 1** väljer du det fält som ska placeras högst upp. Välj vilka fält som ska visas på efterföljande positioner i listrutorna **Fält 2** och **Fält 3**.

1. Klicka på **Spara** om du bara vill spara ändringarna under Inställningar och underhåll eller klicka på **Publicera** för att göra ändringarna tillgängliga för SuperOffice CRM-användarna.

### Användargrupper och sidan-1-fält

Användargrupper definieras i fönstret **Listor** och den grupp som en användare tillhör definieras i fönstret Användare.

När du väljer ett namn i listan **Användargrupp** visas de tillgängliga sidan 1-fälten för den valda användargruppen under **Fält 1**, **2** och **3**.

Om du väljer **(alla användargrupper)** i listan **Användargrupper**, väljer ett eller flera fält och sparar konfigurationen kommer samma val av fält att gälla för alla användargrupper i SuperOffice CRM. Om du sedan väljer en specifik användargrupp kan du åsidosätta de befintliga fältinställningarna för just denna grupp genom att använda en annan specifikation. Om du inte anger något i ett fält lämnas det tomt eftersom åsidosättningen gäller alla tre fälten, oavsett deras innehåll.

> [!NOTE]
> Du måste publicera en åsidosättning för en enskild användargrupp *efter* att du har skapat en konfiguration för alla användargrupper. Annars tillämpas den inte.

<!-- Referenced links -->
[1]: ../../customization/screen-designer/admin/index.md
[2]: add-udef.md
