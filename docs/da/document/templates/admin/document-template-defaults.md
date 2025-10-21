---
uid: help-da-document-template-defaults
title: Standardværdier for nye dokumentskabeloner
description: Standardværdier for nye dokumentskabeloner
keywords: nummertildeling, ny tæller, dokumentskabelon tæller, standardværdier
author: digitaldiina
date: 10.21.2025
version: 11.5
content_type: howto
category: document
topic: template
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /da/admin/options/learn/number-allocation/document-template-defaults
language: da
---

# Standardværdier for nye dokumentskabeloner

Du kan angive [standardværdier][1] for nye dokumentskabeloner, hvis det er nødvendigt. Det betyder, at værdien i feltet **Vores ref.** på dialogboksen Dokument øges med 1, hver gang netop denne skabelon bruges. Hvis du ikke markerer **Opret nye tællere automatisk for nye dokumentskabeloner**, bruges den samme tæller til alle dokumentskabeloner, så værdien i feltet **Vores ref.** øges med 1, hver gang en skabelon bruges.

> [!NOTE]
> Hvorvidt feltet **Vores ref.** på dialogboksen Dokument fungerer som et tællerfelt, afhænger af, om {snum}skabelonvariablen er angivet for den pågældende skabelon. Dette defineres på skærmbilledet Lister: Klik på **Dokumentskabelon**, dobbeltklik derefter på dokumentskabelonen under **Forekomster**, og rediger feltet **Vores ref. (standard)** i dialogboksen **Rediger forekomst**.

## Angivelse af, at nye dokumentskabeloner skal have deres egen tæller

1. Gå til Indstillinger og vedligeholdelse, og vælg <i class="ph ph-sliders-horizontal" aria-hidden="true"></i> **Indstillinger**.

1. Vælg fanen **Nummertildeling**.

1. Nederst på fanen skal du vælge **Opret nye tællere automatisk for nye dokumentskabeloner**.

1. Klik på **Standardværdier**.

1. Marker **Entydig**, hvis du ønsker, at værdierne i feltet **Vores ref.** skal være unikke. Det er nyttigt, når SuperOffice CRM-brugere selv allokerer værdier.

1. Markér **Tillad tomt** for at tillade tomme tællerfelter. Det er nyttigt, når tællerværdierne skal være unikke. Hvis **Tillad tomt**er markeret, betyder det, at kravet om unikke værdier ikke gælder for tomme felter.

1. Marker **Skrivebeskyttet**, hvis du ikke ønsker, at SuperOffice CRM-brugere selv skal kunne indtaste værdier i feltet **Vores ref.**.

1. Marker **Tildel**, hvis du vil bruge den automatiske tællerfunktion, så systemet indsætter værdier i feltet **Vores ref.** for dig.

    [Se resultaterne af forskellige kombinationer af disse værdier][1].

1. Angiv den værdi, tælleren skal starte med, i feltet **Næste nummer**.

1. Klik på **Gem**.

<!-- Referenced links -->
[1]: ../../../admin/options/configure-number-allocation.md

<!-- Referenced images -->
