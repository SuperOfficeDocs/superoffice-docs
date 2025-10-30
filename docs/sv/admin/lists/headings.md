---
uid: help-sv-list-headings
title: Listhuvuden
description: Använd rubriker för att gruppera poster i långa listor under Inställningar och underhåll.
keywords: rubrik, organisera lista
author: digitaldiina
date: 10.29.2025
version: 10.5
content_type: reference
audience: settings
audience_tooltip: Inställningar och underhåll
index: true
redirect_from:
  - /sv/admin/lists/learn/organize/index
  - /sv/admin/lists/learn/organize/headings
  - /sv/admin/lists/learn/organize/adding-headings
  - /sv/admin/lists/learn/organize/headings-editing-and-deleting
  - /sv/admin/lists/learn/organize/grouping-items-under-headings
language: sv
---

# Listhuvuden

Listposter kan visas i två nivåer. Den högre nivån kallas postens **rubrik**. En rubrik innehåller grupper av poster som kan visas under det valda objektet i SuperOffice CRM. Samma post kan visas under flera rubriker.

Listan **Rubriker** (längst ned till höger i fönstret **Listor**) visar vilka rubriker de enskilda posterna visas under. Du kan också gå till fliken **Rubriker** för att se vilka poster som visas under en viss rubrik.

## När är det bra att använda rubriker i listor?

Om en lista är mycket lång (innehåller många poster) kan du använda rubriker för att dela in posterna i logiska grupper. Till exempel är posterna i listan **Dokumentmallar** grupperade under rubrikerna **Brev**, **Fax**, **E‑post** och så vidare.

## Arbeta med rubriker i listor

För att hantera rubriker öppnar du fönstret **Listor** och väljer önskad lista från rullgardinsmenyn längst upp till vänster.

> [!NOTE]
> Rubriker är endast tillgängliga för listor där **Använd gruppering och användargruppfiltrering för den här listan** är aktiverat (kryssruta längst upp till höger).
>
> Grupperingsfunktionen är inte tillgänglig för vissa fördefinierade listor (till exempel **Allmänt – Användargrupp**). Om en lista inte går att gruppera är kryssrutan inaktiverad.

Det finns två sätt att koppla rubriker till listposter:

* **Från fliken Poster**: Välj en post och tilldela en eller flera rubriker i panelen **Rubriker**.
* **Från fliken Rubriker**: Välj en rubrik och tilldela de poster som ska visas under den.

Du kan också lägga till, redigera eller ta bort rubriker vid behov.

## <a id="add"></a>Lägg till en rubrik

Innan du kopplar en rubrik till en post måste du lägga till de rubriker du behöver.

1. Gå till fliken **Rubriker**.

1. Klicka på **Lägg till** under listan **Rubriker**.

1. Ange det namn du vill använda för rubriken *(obligatoriskt)* och en beskrivning *(valfritt)*.

    * Fältet **Beskrivning** kan användas för att förklara syftet med rubriken och kan visas som en tooltiptext i gränssnittet.

1. [!include[Save or cancel](includes/save-or-cancel.md)]

Rubriken läggs till i listan **Rubriker**. Upprepa proceduren för att lägga till fler rubriker.

När du har lagt till rubrikerna kan du [välja vilka rubriker varje post ska visas under](#group).

## <a id="group"></a>Gruppera poster under rubriker

Om du vill använda två nivåer i en lista måste du tilldela rubriker till varje post i listan **Poster**. Alternativt kan du använda fliken **Rubriker** för att ange vilka poster som ska höra till varje rubrik.

> [!NOTE]
> Listan måste innehålla ett visst minimiantal poster för att kunna visas med rubriker. Detta antal definieras i [Inställningar för preferenser][3].

### Välj rubriker för en post

Eventuella rubriker som redan är angivna för den valda listan visas i panelen **Rubriker** längst ned till höger. Om fältet är tomt måste du [lägga till rubriker först](#add).

1. Välj önskad post i listan **Poster**.

1. Markera kryssrutan bredvid den rubrik du vill använda i listan **Rubriker**. En bock (<i class="ph ph-check" aria-hidden="true"></i>) visas för att ange att posten hör till rubriken.
    Ändringarna sparas automatiskt.

> [!TIP]
> Du kan tilldela flera rubriker till samma post.

### Välj poster för en rubrik

1. Gå till fliken **Rubriker**.

1. Välj en rubrik i listan.

1. I listan **Poster under denna rubrik** markerar du kryssrutan bredvid varje post som ska visas under den valda rubriken.

1. Upprepa för varje rubrik.

    Ändringarna sparas automatiskt.

## <a id="update"></a>Redigera rubriker

Du redigerar en rubrik genom att dubbelklicka på den i listan **Rubriker** och ändra informationen.

## Ta bort rubriker

Du tar bort rubriker genom att markera den rubrik du vill ta bort och klicka på **Ta bort**.

> [!NOTE]
> Att ta bort en rubrik tar **inte** bort de associerade posterna. Du kan [återställa borttagna rubriker][2].

<!-- Refererade länkar -->
[2]: restore.md
[3]: ../preferences/index.md
