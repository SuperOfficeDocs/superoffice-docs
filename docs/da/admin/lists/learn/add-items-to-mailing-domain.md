---
uid: help-da-add-items-to-mailing-domain
title: Tilføjelse af forekomster til Udsendelsesdomæner
description: Tilføjelse af forekomster til listen Udsendelsesdomæner
author: Hanne Gunnarsson
date: 03.14.2023
keywords: udsendelse, domæne, SPF
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Tilføjelse af forekomster til listen Udsendelsesdomæner

Når den globale indstilling **Brug kun godkendte domæner til afsendelse af e-mail** er angivet til **Ja**, kan brugerne kun sende e-mails fra domæner, der er føjet til denne liste i SuperOffice CRM. Det er derfor vigtigt at føje godkendte domæner med en gyldig [SPF-post (Sender Policy Framework)][1] til denne liste.

> [!NOTE]
> Den globale indstilling **Brug kun godkendte domæner til afsendelse af e-mail** i gruppen **Marketing** skal være angivet til **Ja** for at kunne bruge listen Udsendelsesdomæner.

## Trin

1. Klik på **Lister** i **Indstillinger og vedligeholdelse**, og vælg **Udsendelsesdomæner**.

1. Klik på **Tilføj** for at tilføje et nyt godkendt domæne.

1. Tilføj domænenavnet, og klik på **Gem**. Systemet foretager et SPF-opslag for at kontrollere, om domænet har en gyldig SPF-post. Hvis ikke, vises en advarsel, der fortæller dig, at der kræves en gyldig SPF-post til udsendelsesdomæner. Klik på **OK** og prøv et andet domæne.

1. Hvis domænet består SPF-opslaget, føjes det til listen over godkendte domæner, og brugerne kan sende udsendelser fra dette domæne.

> [!NOTE]
> Du kan konfigurere en SPF-post for dit domæne for at sikre, at din organisation kan sende udsendelser med bedre levering (KUN ONLINE). Hvis dit miljø er ONSITE, udføres der ikke et SPF-opslag. Men du kan stadig bruge listen til at give dine brugere forudindstillede domæner til **Fra-** og **Svar til**-adresser.

<!-- Referenced links -->
[1]: ../../../../en/email/mailgun/spf/index.md

<!-- Referenced images -->
