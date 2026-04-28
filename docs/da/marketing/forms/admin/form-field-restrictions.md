---
uid: help-da-marketing-forms-field-restrictions
title: Begrænsninger for formularfelter
description: Lær, hvordan du styrer, hvilke felter der er tilgængelige i formularer, og om formularindsendelser kan overskrive eksisterende data i disse felter.
keywords: begrænsninger for formularfelter, formular, felt, tillad ikke overskrivning, overskrivning, vis ikke i formularer
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
language: da
---

# Begrænsninger for formularfelter

Begrænsninger for formularfelter giver dig mulighed for at styre, hvilke felter der er tilgængelige i formularer, og om en formularindsendelse kan overskrive eksisterende data i disse felter.

Som standard overskriver formularindsendelser ikke eksisterende data. Den person, der bygger formularen, kan vælge at aktivere overskrivning for de enkelte felter. Brug feltbegrænsninger til at fjerne denne mulighed fra følsomme felter eller forhindre, at et felt vises i formulargeneratoren overhovedet.

> [!CAUTION]
> Formularer på et websted kan udfyldes af alle. Tilladelse til overskrivning medfører risici, herunder utilsigtet datatab, uautoriserede ændringer af følsomme felter og kompromitteret dataintegritet som følge af forkerte indtastninger. Håndter følsomme felter med omhu.

## Sådan administrerer du feltbegrænsninger

Feltbegrænsninger konfigureres i **Indstillinger og vedligeholdelse** og kræver administratorrettigheder.

1. Gå til **Indstillinger og vedligeholdelse**.
1. Vælg <i class="ph ph-bullseye" aria-hidden="true"></i> **Marketing** i navigatoren.
1. Vælg fanen **Begrænsninger for formularfelter**.

![Admin Marketing - Indstil begrænsninger for formularfelter, der er synlige i Marketing-formularer -screenshot][img1]

## Tilføj en feltbegrænsning

1. Vælg et felt på rullelisten i sektionen **Felter med begrænsninger**.
1. Vælg begrænsningstypen for feltet.
1. Vælg **Gem**.

Gentag for at tilføje begrænsninger for flere felter.

## Begrænsningsindstillinger

* **Tillad ikke overskrivning:** Overskrivningsindstillingen fjernes fra dette felt i alle formularer, herunder formularer, der allerede er udgivet. Feltet er fortsat tilgængeligt i formulargeneratoren og kan stadig føjes til formularer, men indsendte data overskriver aldrig eksisterende værdier.

* **Vis ikke i formularer:** Feltet fjernes helt fra formulargeneratoren og kan ikke føjes til nye formularer. Eksisterende udgivne formularer, der allerede indeholder feltet, påvirkes ikke.

## Fjern en feltbegrænsning

1. Find feltet på listen **Felter med begrænsninger**.
1. Vælg fjern-ikonet (<i class="ph ph-x-circle" aria-hidden="true"></i>) ud for feltet.
1. Vælg **Gem**.

Fjernelse af en begrænsning gendanner standardfunktionaliteten. Feltet bliver igen tilgængeligt i formulargeneratoren, og formularejeren kan vælge, om der skal tillades overskrivning.

## Relateret indhold

* [Feltindstillinger][1]
* [Opret en ny formular][2]
* [Administrere skrifttyper til formularer][3]

<!-- Referenced links -->
[1]: ../learn/field-options.md
[2]: ../learn/create.md
[3]: manage-fonts.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/admin/admin-marketing-form-field-restrictions.png
