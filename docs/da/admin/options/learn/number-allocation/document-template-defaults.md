---
uid: help-da-document-template-defaults
title: Standardværdier for nye dokumentskabeloner
description: Standardværdier for nye dokumentskabeloner
author: Bergfrid Dias
date: 03.24.2023
keywords: nummer, tæller
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Standardværdier for nye dokumentskabeloner

Du kan angive standardværdier for nye dokumentskabeloner, hvis det er nødvendigt. Det betyder, at værdien i feltet **Vores ref.** på dialogboksen Dokument øges med 1, hver gang netop denne skabelon bruges. Hvis du ikke markerer **Opret nye tællere automatisk for nye dokumentskabeloner**, bruges den samme tæller til alle dokumentskabeloner, så værdien i feltet **Vores ref.** øges med 1, hver gang en skabelon bruges.

> [!NOTE]
> Hvorvidt feltet **Vores ref.** på dialogboksen Dokument fungerer som et tællerfelt, afhænger af, om {snum}skabelonvariablen er angivet for den pågældende skabelon. Dette defineres på skærmbilledet Lister: Klik på **Dokumentskabelon**, dobbeltklik derefter på dokumentskabelonen under **Forekomster**, og rediger feltet **Vores ref. (standard)** i dialogboksen **Rediger forekomst**.

## Angivelse af, at nye dokumentskabeloner skal have deres egen tæller

1. [!include[Go to Options](../includes/open-options.md)]

2. Vælg fanen **Nummertildeling**.

3. Nederst på fanen skal du vælge **Opret nye tællere automatisk for nye dokumentskabeloner**.

4. Klik på **Standardværdier**.

5. Marker **Entydig**, hvis du ønsker, at værdierne i feltet **Vores ref.** skal være unikke. Det er nyttigt, når SuperOffice CRM-brugere selv allokerer værdier.

6. Markér **Tillad tomt** for at tillade tomme tællerfelter. Det er nyttigt, når tællerværdierne skal være unikke. Hvis **Tillad tomt**er markeret, betyder det, at kravet om unikke værdier ikke gælder for tomme felter.

7. Marker **Skrivebeskyttet**, hvis du ikke ønsker, at SuperOffice CRM-brugere selv skal kunne indtaste værdier i feltet **Vores ref.**.

8. Marker **Tildel**, hvis du vil bruge den automatiske tællerfunktion, så systemet indsætter værdier i feltet **Vores ref.** for dig.

    [Se resultaterne af forskellige kombinationer af disse værdier][1].

9. Angiv den værdi, tælleren skal starte med, i feltet **Næste nummer**.

10. Klik på **Gem**.

<!-- Referenced links -->
[1]: index.md

<!-- Referenced images -->
