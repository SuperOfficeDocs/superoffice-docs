---
uid: help-da-customer-center-config
title: Kundecenterkonfiguration
description: Få mere at vide om, hvordan du konfigurerer dit kundecenter, i denne vejledning.
keywords: Tjeneste, Kundecenter, CEP
author: SuperOffice RnD
date: 03.16.2023
topic: howto
language: da
---

# Konfigurer kundecenter <i class="ph ph-question" aria-label="Question mark"></i>

[!include[Requirement](../../learn/includes/req-cep.md)]

Du kan redigere stylingen og layoutet af dit kundecenter og få en forhåndsvisning af ændringerne.

![Konfigurer chatwidgetten i dit kundecenter, så kunderne kan chatte med dig, mens de besøger dit website -screenshot][img2]

Hvis dit kundecenter er flersproget, kan du angive indstillinger (f.eks. velkomsttekst, åbningstider og telefonnumre) individuelt for hvert sprog.

> [!NOTE]
> Hvis du vil redigere HTML-koden for de forskellige sider, [skal du opdatere kildefilerne][1].

## Trin

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Vælg **Kundecenter** > **Konfigurer**. Der er 2 faner på skærmen Kundecenter **Kundecenter**: **Styling** og **Indstillinger**. Øverst på denne side finder du et link til forhåndsvisning af kundecenterets webside.

1. Under fanen **Styling** kan du redigere forskellige indstillinger for kundecentrets udseende og funktionalitet: Logo, foretrukken bredde, farver og skrifttyper. Eksemplet opdateres automatisk.

    ![Forhåndsvisning af dine kundecentersider -screenshot][img3]

1. Gå til fanen **Indstillinger**.

1. Vælg den sprogversion, du vil redigere.

1. Rediger indstillingerne. Se detaljer om hver indstilling nedenfor.

1. Klik på **Gem**.

1. Gentag trin 4-6 for at angive indstillingerne for et andet sprog.

1. Klik på **Gem**, når du er færdig.

## Muligheder

| Mulighed | Beskrivelse |
|---|---|
| URL-adresse til logo | Linket til logobilledet. |
| Navn på websted | Titlen på websiden. |
| Velkommen, overskrift | Titeltekst, der vises i overskriftsfeltet. |
| Velkommen, brødtekst | Brødtekst, der vises i overskriftsfeltet. |
| Vis åbningstider | Vælg denne indstilling for at få vist åbningstider i overskriftsfeltet. Angiv åbningstiderne i feltet nedenfor. |
| Vis telefonnummer | Vælg denne indstilling for at få vist dit telefonnummer i overskriftsfeltet. Angiv telefonnummeret i feltet nedenfor. |
| Aktivér søgning på velkomstsiden | Vælg denne indstilling for at få vist FAQ-søgefeltet i overskriftsfeltet. Angiv pladsholdertekst i feltet nedenfor. Eksempel: "Indtast tekst her for at søge i FAQ". |
| Aktivér oplysninger på velkomstsiden | Vælg denne indstilling for at få vist et tekstfelt under overskriftsfeltet. Klik på **Rediger** for at skrive tekst. |
| Vis mest almindeligt forekommende ofte stillede spørgsmål på velkomstsiden | Vælg denne indstilling for at få vist de mest populære spørgsmål og seneste spørgsmål. |
| Aktivér sidefod | Vælg denne indstilling for at få vist en sidefod nederst på siden. Klik på **Rediger** for at skrive tekst. |
| Aktivér chat | Vælg denne indstilling for at aktivere chatvinduet i nederste højre hjørne af siden. Vælg **Altid**, hvis chatvinduet skal være tilgængeligt for alle, der har adgang til kundecenteret. Ellers skal du vælge **Kunder, der er logget ind** for at kræve, at brugerne logger på for at få adgang til chatvinduet. |
| Chatkanal | Vælg den chatkanal, du vil bruge. Hvis der ikke er valgt en chatkanal, er chatvinduet ikke tilgængeligt. |
| Brug brugerdefineret "Kontakt os"-formular | Vælg denne indstilling for at bruge en brugerdefineret formular i stedet for standardformularen. Vælg en formular på listen.|

<!-- Referenced links -->
[1]: edit.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/customer-center/customer-centre-chat-with-agents.jpg
[img3]: ../../../media/loc/en/customer-center/config-cust-centre.png
