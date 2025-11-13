---
uid: help-sv-add-company-category
title: Företagskategori och kategorigrupp
description: Skapa eller uppdatera företagskategorier, tilldela kategorigrupper och aktivera spårning av leadstatus.
keywords: företagskategori, kategorigrupp, leadstatus, potentiell kund, listor
author: digitaldiina
date: 12.11.2025
version: 11.6
content_type: howto
category: sale
topic: lead
license: salesessentials
audience: settings
audience_tooltip: Inställningar och underhåll
index: true
language: sv
---

# Företagskategori och kategorigrupp

[!include[Må vara administratör](../../learn/includes/req-admin.md)]

Listan **Företag – Kategori** definierar typerna av företag i databasen, såsom *Kund*, *Partner* eller *Lead*.
Varje kategori kan tillhöra en **Kategorigrupp** som avgör hur den uppträder i sökningar, automatiseringar och lead-hantering.

Du administrerar företagskategorier under **Inställningar och underhåll** via **Listor** > **Företag – Kategori**.

## Om kategorigrupp

Kategorigrupper ger ett sätt att klassificera kategorier efter syfte och förhindra oönskade automatiseringsändringar. Till exempel ska ett företag märkt som *Kund* aldrig automatiskt återgå till en *Lead* på grund av ett formulärinlämning.

| Kategorigrupp | Beskrivning |
|---|---|
| Kund | Används för befintliga kunder, såsom *Kund A*, *Kund B* eller *VIP-kund*. |
| Förlorad | Används för tidigare kunder eller förlorade möjligheter. |
| Partner | Används för återförsäljare, integratörer eller affärspartners. |
| Potentiell kund | Används för leads eller prospekt som ännu inte blivit kunder. Endast denna grupp kan ha **Lead-status** aktiverad. |
| Annan | Används för vilken annan typ av företag som helst. |

## Lägg till företagskategori

1. Välj <i class="ph ph-list-bullets" aria-hidden="true"></i> **Listor** i Navigatorn.

1. Från rullgardinsmenyn väljer du **Företag – Kategori**. Fliken **Poster** visar alla befintliga kategorier.

1. Klicka **Lägg till** för att öppna dialogrutan **Redigera listpost**.

1. Ange ett namn för kategorin i fältet **Namn**. *(Obligatoriskt)*

    Detta namn visas i fältet **Kategori** på företagskärmen.

1. Från rullgardinsmenyn **Kategorigrupp** väljer du lämplig grupp.

    Gruppen avgör hur kategorin beter sig i sökningar och automatiseringar, men är inte synlig för slutanvändare.

    * För att kunna aktivera leadstatus senare, väljer du **Potentiell kund**.

1. *(Valfritt)* Skriv en beskrivning för att klargöra hur kategorin ska användas.

1. *(Valfritt)* Välj **Aktivera lead-status för denna kategori** om tillämpligt.

1. Klicka **OK** för att spara den nya kategorin eller **Avbryt** för att avbryta.

![Redigering av en företagskategori i listan Företag – Kategori, som visar att gruppen Potentiell kund är vald och alternativet att aktivera leadstatus för kategorin. -screenshot][img1]

## Redigera eller ta bort företagskategorier

> [!NOTE]
> Redigering eller borttagning av kategorier som används kan leda till inkonsekventa data.
> Att ändra kategorigrupp eller inaktivera lead-status kan lämna företag och kontakter med leadinformation som inte längre kan uppdateras.
> Granska kategoriens användning noggrant innan du gör ändringar.

1. Öppna listan **Företag – Kategori**.

1. För att redigera:

    1. Dubbelklicka en kategori för att öppna den.
    1. Uppdatera **Namn**, **Kategorigrupp** eller alternativet **Lead-status**.
    1. Klicka **OK** för att spara.

1. För att ta bort:

    1. Välj kategorin i listan.
    1. Klicka **Ta bort**.

## Återställ borttagna företagskategorier

1. Öppna listan **Företag – Kategori**.

1. Välj **Visa borttagna poster och rubriker**.

1. Hitta den borttagna kategorin, dubbelklicka den och klicka **Återställ**.

1. Klicka **OK**.

## Relaterat innehåll

* [Potentiella kundkategorier][2]
* [Aktivera lead-status för företagskategorier][1]
* [Hantera lead-statuser][3]
* [Användargruppfiltrering][4]

<!-- Referenced links -->
[1]: index.md
[2]: ../learn/index.md
[3]: add-lead-status.md
[4]: ../../admin/lists/user-group-filtering.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/lead/add-company-category.png
