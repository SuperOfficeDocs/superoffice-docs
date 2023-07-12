---
uid: help-sv-page-1-fields
title: Välja sidan-1-fält
description: Välja sidan-1-fält
author: SuperOffice RnD
so.date: 06.29.2022
keywords: udef, anpassa fält
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: sv
---

# Välja sidan-1-fält

> [!NOTE]
> Den här funktionen är inte tillgänglig om ditt företag använder anpassade sidlayouter.

Bland de användardefinierade fält som visas på **Mer**-flikarna i SuperOffice CRM kan du välja *tre* stycken som ska fungera som sidan 1-fält (de kallas så eftersom de visas på "förstasidan" i respektive fönster).

## Var kan jag visa sidan 1-fält?

[!include[List](includes/list-page-1-field-locations.md)]

## Så visar du ett användardefinierat fält på förstasidan

1. [!include[Go to fields and select tab](includes/goto-fields.md)]

1. Markera **Tillåt olika sidan 1-fält för olika användargrupper** längst ner på fliken om du vill definiera olika sidan 1-fält för olika användargrupper. Om det här alternativet inte markeras används fälten du skapar för alla användargrupper.

1. I listan med användargrupper ovan väljer du önskad användargrupp (om du markerade **Tillåt olika sidan 1-fält för olika användargrupper** i föregående steg).

1. I listrutan **Fält 1** väljer du det fält som ska placeras högst upp. Välj vilka fält som ska visas på efterföljande positioner i listrutorna **Fält 2** och **Fält 3**.

1. Klicka på **Spara** om du bara vill spara ändringarna under Inställningar och underhåll eller klicka på **Publicera** om du vill göra ändringarna tillgängliga för SuperOffice CRM-användarna.

## Användargrupper och sidan-1-fält

När du väljer ett namn i listan **Användargrupp** visas de tillgängliga sidan 1-fälten för den valda användargruppen under **Fält 1**, **2** och **3**.

> [!NOTE]
> Användargrupper definieras i fönstret **Listor** och den grupp som en användare tillhör definieras i fönstret Användare.

Om du väljer **(alla användargrupper)** i listan **Användargrupper**, väljer ett eller flera fält och sparar konfigurationen kommer samma val av fält att gälla för alla användargrupper i SuperOffice CRM. Om du sedan väljer en specifik användargrupp kan du åsidosätta de befintliga fältinställningarna för just denna grupp genom att använda en annan specifikation. Om du inte anger något i ett fält lämnas det tomt eftersom åsidosättningen gäller alla tre fälten, oavsett deras innehåll.

> [!NOTE]
> Du måste publicera en åsidosättning för en enskild användargrupp *efter* att du har skapat en konfiguration för alla användargrupper. Annars tillämpas den inte.

<!-- Referenced links -->

<!-- Referenced images -->
