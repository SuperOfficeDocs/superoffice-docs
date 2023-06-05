---
uid: help-no-mailing-add-google-analytics
title: Slik legger du til emneknaggen Google Analytics i en utsendelse
description: I denne veiledningen lærer du hvordan du sporer de besøkende.
author: Bergfrid Dias
so.date: 02.20.2023
keywords: Markedsføring
so.topic: howto
language: no
---

# Slik legger du til emneknaggen Google Analytics i en utsendelse

Du kan spore personene som besøker websiden din som et resultat av at de leser utsendelsene dine, ved å bruke Google Analytics-funksjonen i SuperOffice Marketing. Google Analytics-sporingen må angis i [det første trinnet for hver utsendelse][1] du oppretter.

## Krav

For å kunne bruke [Google Analytics-funksjonen][2], trenger du en Google Analytics-konto som er koblet til websiden din.

[!include[Requirement](includes/req-marketing.md)]

## Trinn

1. Start med å åpne utsendelsen du ønsker å spore med Google Analytics, eller opprett en ny utsendelse. Gå til det første trinnet i veiviseren for utsendelser (Oppsett). Overskriften **Sporing** er plassert nederst til høyre. Her kan du velge boksene **Spor alle koblinger** og **Bruk Google Analytics**. Når du velger Bruk Google Analytics, vises tekstfeltene for Google Analytics.

    ![Velg Google Analytics og spor alle koblinger -screenshot][img1]

2. I **sporingsfeltene i Google Analytics** er «E-post» forhåndsdefinert som medium. Det betyr at sporede utsendelser som sendes fra SuperOffice CRM, nå finnes i Google Channel-rapporter under **E-post**, og ikke under **Andre**.

3. Hvis du vil identifisere en bestemt utsendelse som kilde, må feltene for Kilde og Kampanje også fylles ut.

    * I**Kilde-**feltet kan du legge til kilden til trafikken på websiden din. Her kan du velge å bruke de forskjellige abonnementene innen e-markedsføring, som for eksempel Månedlig nyhetsbrev, Kampanjeutsendelse osv.

    * I**Kampanje**-feltet kan du angi navnet på kampanjen du kjører. Det vil gjøre det enklere å spore og rapportere resultatene av utsendelsen du har sendt ut. Her kan du angi kampanjenavn, som for eksempel julesalgskampanje eller høstsalgskampanje, og så videre.

4. Når du har konfigurert alle detaljene du vil bruke til å spore utsendelsen i Google Analytics, kan du følge trinnene i veiviseren for utsendelser. Klikk på **Neste** for å velge mal, legg til innhold, legg til mottakere og send utsendelsen.

Alle koblingene du legger til i det tredje trinnet (Innhold), blir automatisk sporet fordi du har slått på Google Analytics-funksjonen. Så snart mottakerne klikker på koblingene til websiden din, kan du spore besøkene deres på websiden i Google Analytics.

## Slik sjekker du resultatene for utsendelsen din i Google Analytics

Du kan sjekke resultatene for utsendelsene dine ved å logge inn på Google Analytics-kontoen din. Utsendelsene dine skal være synlige i kanalrapportene fra Google under E-post.

> [!NOTE]
> Gi Google Analytics litt tid til å behandle sporingsinformasjonen din. Det kan ta mellom 1 og 24 timer før kilden til utsendelsen registreres i rapportene dine.

<!-- Referenced links -->
[1]: ../../mailing/learn/create/tutorial-email-mailing.yml
[2]: index.md#google

<!-- Referenced images -->
[img1]: media/google-analytics-tag.png
