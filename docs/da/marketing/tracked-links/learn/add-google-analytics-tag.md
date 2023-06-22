---
uid: help-da-mailing-add-google-analytics
title: Sådan tilføjer du tags fra Google Analytics til en mailudsendelse
description: "I denne vejledning lærer du, hvordan du sporer dine besøgende."
author: Bergfrid Dias
so.date: 02.20.2023
keywords: Marketing
so.topic: howto
language: da
---

# Sådan tilføjer du tags fra Google Analytics til en mailudsendelse

Med Google Analytics-funktionen i SuperOffice Marketing kan du spore de personer, der besøger din hjemmeside som resultat af, at de har læst dine mailudsendelser. Sporing i Google Analytics skal indstilles i [det første trin for hver mailudsendelse[, du opretter.

## Krav

For at bruge [Google Analytics-funktionen][2], skal du have en Google Analytics-konto tilknyttet dit websted.

[!include[Requirement](includes/req-marketing.md)]

## Trin

1. Start med at åbne den udsendelse, du vil spore med Google Analytics, eller opret en ny udsendelse. Gå til første trin i mailudsendelsesguiden (Opsætning). Overskriften **Sporing** er placeret i nederste højre hjørne. Her kan du markere afkrydsningsfelterne **Spore alle links** og **Bruge Google Analytics**. Når du markerer Brug Google Analytics, vises tekstfelterne i Google Analytics.

    ![Marker afkrydsningsfeltet for Google Analytics, og spor alle links -screenshot][img1]

2. I **sporingsfelterne for Google Analytics** er "E-mail" foruddefineret som mediet. Det betyder, at sporede mailudsendelser sendt fra SuperOffice nu findes i Google Channel-rapporterne under **Email** i stedet for under **Andet**.

3. Hvis du vil identificere en bestemt udsendelse som kilde, skal felterne Kilde og Kampagne også udfyldes.

    * I feltet **Kilde** kan du tilføje den kilde, som trafikken til din hjemmeside kommer fra. Her kan du vælge at bruge de forskellige E-marketingabonnementer, som f.eks. månedligt nyhedsbrev, kampagneudsendelse osv.

    * I feltet **Kampagne** kan du indtaste navnet på den kampagne, du kører. Det vil gøre det lettere at spore og rapportere resultaterne af den mailudsendelse, du har sendt afsted. Her kan du indtaste kampagnenavne, som for eksempel julesalg eller efterårskampagne osv.

4. Når du har konfigureret alle de oplysninger, du vil bruge til at spore din mailudsendelse i Google Analytics, kan du følge trinene i mailudsendelsesguiden. Klik på **Næste** for at vælge skabelon, tilføje indhold, tilføje modtagere og afsende din mailudsendelse.

Alle de links, du tilføjer i tredje trin (Indhold), spores automatisk, eftersom du har aktiveret Google Analytics-funktionen. Så snart dine modtagere klikker på linkene til dit websted, kan du spore deres besøg på dit websted i Google Analytics.

## Sådan tjekker du resultaterne af din mailudsendelse i Google Analytics

Du kan tjekke resultaterne af dine udsendelser ved at logge ind på din Google Analytics-konto. Dine e-mails skulle gerne kunne ses i Google Channel-rapporterne under E-mail.

> [!NOTE]
> Giv Google Analytics lidt tid til at behandle dine sporingsoplysninger. Det kan tage et sted mellem 1 og 24 timer før din udsendelseskilde er registreret i rapporterne.

<!-- Referenced links -->
[2]: index.md#google

<!-- Referenced images -->
[img1]: media/google-analytics-tag.png
