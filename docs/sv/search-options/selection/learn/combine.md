---
uid: help-sv-selection-combine
title: Skapa kombinationsurval
description: I den här guiden lär du dig hur du skapar ett kombinerat urval.
keywords: kombinera urval, kombinationsurval, urval
author: Bergfrid Dias
date: 03.21.2025
version: 10.5.3
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
redirect_from: /sv/search-options/selection/learn/create/combine
---

# Skapa kombinationsurval

De två urvalen som kombineras kan vara statiska eller dynamiska. Det finns vissa emellertid begränsningar för vad som kan kombineras:

* Om du väljer att skapa ett kombinationsurval som består av företag, blir alla typer av urval tillgängliga.
* Om du däremot väljer att skapa ett kombinationsurval som består av försäljningar, projekt, dokument händelser eller produkter, blir bara urval av den valda typen tillgängliga.

## Hitta data

1. Öppna ett av urvalen som du vill kombinera.

1. Klicka på **Uppgift**-knappen (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) och välj **Kombinera urval med**. Ett nytt urvalsfönster öppnas.

1. Skriv in namnet på det nya urvalet i fältet där det står *Urvalsnamn*. Det här fältet måste fyllas i.

1. I fältet **Urval av** väljer du vad urvalet ska innehålla. Valen här är begränsade till **Företag/kontakt** och den typ av urval du har valt. Det här kan inte ändras efter det har sparats i databasen.

1. I fältet **Urvalet är** är **Kombination** valt som standard.

1. Under **Urval 2** väljer du det andra urvalet som du vill kombinera.

    > [!NOTE]
    > Om du har valt **Företag/kontakter** under **Urval av**, kan du välja bland alla typer av urval här (ett försäljningsurval innehåller även företag/kontakter som är kopplade till försäljningarna). Men om kombinationsurvalet består av Försäljning, Dokument, Händelser, Ärenden, Formulärinlämningar, Chattkonversationer, Utskick eller Produkter måste du välja bland samma typ av urval för **Urval 1** och **Urval 2**.

1. Under **Jämför** väljer du vilka händelser från de två urvalen som ska ingå i kombinationsurvalet.

| Ikon | Alternativ | Beskrivning |
|:-:|---|---|
| <i class="ph ph-subtract" aria-label="Only in one selection icon"></i> | Endast i urval 1/Endast i urval 2 | Visar poster som finns med i urval 1 eller urval 2 och tar inte med poster som finns med i både urval 1 och 2. |
| <i class="ph ph-intersect" aria-label="Common entries icon"></i> | Gemensamma | Visar endast poster som finns i både urval 1 och 2. |
| <i class="ph ph-exclude" aria-label="Difference icon"></i> | Olika | Visar endast poster som finns antingen i urval 1 eller i urval 2. |
| <i class="ph ph-unite" aria-label="All entries icon"></i> | Alla | Visar alla poster i både urval 1 och 2. |

## Välj detaljer

Ange egenskaper enligt anvisningarna i steg 2 i instruktionsguiden [Skapa urval][1].

## Slutför

1. Klicka eventuellt på stjärnikonen (<i class="ph ph-star" aria-hidden="true"></i>) för att lägga till urvalet i [dina favoriter][2].

1. Klicka på **Spara**.

När urvalet har sparats, kan du [redigera det][3] för att ändra både kombinationstypen och vilka urval som ska kombineras. Det går däremot inte att ändra fältet **Urval av**.

## Exempel på kombinationsurval

### Företag och försäljning

1. Skapa ett kombinationsurval för företag/kontakter baserat på två befintliga urval: "Kunder i Sverige" (urval 1) och "Genomförda försäljningar i fjol" (urval 2).
2. Välj kombinationstypen **Endast i urval 1**. Resultatet innehåller då kunder i Sverige som ni inte sålde något till i fjol.
3. Spara resultatet som ett statiskt urval med namnet "Kunder i Sverige utan försäljning" och ge någon av säljarna ansvaret att följa upp dessa kunder.

### Händelser

1. Skapa ett kombinationsurval för händelser baserat på två befintliga urval: "Händelser som är kopplade till mina kunder" (urval 1) och "Planerade händelser nästa månad" (urval 2).
2. Välj kombinationstypen **Gemensamma**. Resultatet är då en översikt över händelser som du måste genomföra nästa månad. Du kan till exempel exportera dem till en fil med hjälp av funktionen **Exportera till fil**.

> [!NOTE]
> Om du bara vill jämföra de kontakter som är knutna till de här två urvalen markerar du **Jämför bara företag**.

<!-- Referenced links -->
[1]: create.md
[3]: update/index.md
[2]: ../../../learn/basics/fav.md
