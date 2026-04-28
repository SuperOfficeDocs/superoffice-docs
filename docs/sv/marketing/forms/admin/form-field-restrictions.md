---
uid: help-sv-marketing-forms-field-restrictions
title: Begränsningar för formulärfält
description: Lär dig hur du kontrollerar vilka fält som är tillgängliga i formulär och om formulärinskick kan skriva över befintliga data i dessa fält.
keywords: begränsningar för formulärfält, formulär, fält, tillåt inte överskrivning, överskrivning, visa inte i formulär
author: digitaldiina
date: 05.04.2026
version: 11.13
content_type: howto
category: marketing
topic: forms
license: marketingessentials
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: sv
---

# Begränsningar för formulärfält

Fältbegränsningar för formulär låter dig styra vilka fält som är tillgängliga i formulär och om ett formulärinskick kan skriva över befintliga data i dessa fält.

Som standard skriver inte formulärinskick över befintliga data. Personen som bygger formuläret kan välja att aktivera överskrivning för enskilda fält. Använd fältbegränsningar för att ta bort det alternativet från känsliga fält eller för att förhindra att ett fält visas i formulärverktyget alls.

> [!CAUTION]
> Formulär på en webbplats kan fyllas i av vem som helst. Att tillåta överskrivningar innebär risker, bland annat oavsiktlig dataförlust, obehöriga ändringar av känsliga fält och äventyrad dataintegritet genom felaktiga uppgifter. Hantera känsliga fält med försiktighet.

## Hantera fältbegränsningar

Fältbegränsningar konfigureras i **Inställningar och underhåll** och kräver administratörsbehörighet.

1. Gå till **Inställningar och underhåll**.
1. Välj <i class="ph ph-bullseye" aria-hidden="true"></i> **Marketing** från navigatorn.
1. Välj fliken **Begränsningar för formulärfält**.

![Admin Marketing - Ange begränsningar för formulärfält som visas i Marketing-formulär -screenshot][img1]

## Lägg till en fältbegränsning

1. Välj ett fält i listrutan i avsnittet **Fält med begränsningar**.
1. Välj begränsningstypen för det fältet.
1. Välj **Spara**.

Upprepa för att lägga till begränsningar för fler fält.

## Begränsningsalternativ

* **Tillåt inte överskrivning:** Överskrivningsalternativet tas bort från det här fältet i alla formulär, inklusive formulär som redan har publicerats. Fältet är fortfarande tillgängligt i formulärverktyget och kan fortfarande läggas till formulär, men inskickade data skriver aldrig över befintliga värden.

* **Visa inte i formulär:** Fältet tas bort helt från formulärverktyget och kan inte läggas till nya formulär. Befintliga publicerade formulär som redan innehåller fältet påverkas inte.

## Ta bort en fältbegränsning

1. Leta upp fältet i listan **Fält med begränsningar**.
1. Välj ta bort-ikonen (<i class="ph ph-x-circle" aria-hidden="true"></i>) bredvid fältet.
1. Välj **Spara**.

Om du tar bort en begränsning återställs standardbeteendet. Fältet blir tillgängligt i formulärverktyget igen och formulärägaren kan välja om överskrivning ska tillåtas.

## Relaterat innehåll

* [Fältalternativ][1]
* [Skapa nytt formulär][2]
* [Hantera typsnitt för formulär][3]

<!-- Referenced links -->
[1]: ../learn/field-options.md
[2]: ../learn/create.md
[3]: manage-fonts.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/admin/admin-marketing-form-field-restrictions.png
