---
uid: help-da-role
title: Rolle
description: Rolle
author: Kirsti Aakerholt
date: 04.19.2023
keywords: rolle, dataobjekt, brugerniveau 
topic: concept
audience: admin
audience_tooltip: Settings and maintenance
language: da
---

# Roller

[!include[Requirement](../includes/note-anon-req.md)]

Ved hjælp af rollebaseret sikkerhed i SuperOffice CRM kan du brugerdefinere roller til forskellige adgangsniveauer i firmaet. Rollerne styrer de adgangsrettigheder, de forskellige brugere har i SuperOffice CRM-modulerne.

En rolle beskriver to ting:

* Hvilke **dataobjekter** (virksomhed, kontakt, projekt, projektmedlemmer, udvælgelse, salg, interessent, opfølgning, dokument, relation, dashboards og mål) skal gøres tilgængelige for de brugere, der har denne rolle.

    Tilgængelighed er specificeret ved hjælp af rettigheder: ingen, læse, oprette, opdatere og slette.

* Hvilke **funktioner** (f.eks. administratoradgang i Indstillinger og vedligeholdelse, tillade masseopdatering, tilbudsgodkendelse, brevfletning, eksport af valg og udgivelse)  skal gøres tilgængelige for brugere med denne rolle.

## Foruddefinerede roller

Foruddefinerede roller følger med SuperOffice CRM. De **roller, der er angivet som brugerniveau 0-5**, svarer til brugerniveauer fra tidligere versioner af SuperOffice, hvor brugerniveau 0 er en administrator. Du kan frit redigere disse roller.

| Rolle | Forklaring |
|---|---|
| Brugerniveau 0 | Administrator: Har fuld adgang til alle data. Kan vedligeholde alle dele af systemet. |
| Brugerniveau 1 | Superuser: Har fuld adgang til data, men kan ikke vedligeholde systemet. |
| Brugerniveau 2 | Har fuld adgang inden for egen brugergruppe, men begrænset adgang ud over det. |
| Brugerniveau 3 | Har fuld adgang til egne data og kan læse data inden for egen brugergruppe, men begrænset adgang ud over det. |
| Brugerniveau 4 | Har fuld adgang til egne data, men begrænset adgang inden for egen brugergruppe og ud over det. |
| Brugerniveau 5 | Har læseadgang til de fleste data, men begrænset adgang til andres data. Kan oprette aktiviteter. |
| Listeadministrator | Har fuld adgang til data i SuperOffice CRM-klienten. Kan bruge Indstillinger og vedligeholdelse til at redigere lister i systemet (f.eks. af dokumentskabeloner og kategorier). |
| Brugeradministrator | Har fuld adgang til data. Kan bruge Indstillinger og vedligeholdelse til at oprette og redigere brugere i systemet. |
| Lokal bruger | Har fuld adgang til egne data, men ingen adgang til data, der tilhører brugere, der er knyttet til andre virksomheder. |
| Ekstern bruger | Konsulent eller partner med begrænset adgang til firma- og projektdata. Har kun adgang til offentliggjorte data. |
| Anonym bruger | Anonym bruger |
| Systembruger | Bruger af systemintegration. Tilsidesætter alle sikkerhedskontroller. Denne rolle er ikke synlig og kan ikke redigeres. |

### Bruger eller administratorrolle

Når du giver adgang til en ny person, skal du angive vedkommendes rolle – enten en bruger eller en administrator.

Administratorer har adgang til afsnittet Indstillinger og vedligeholdelse. Det er her, du kan oprette brugere, justere adgangsrettigheder og tilpasse CRM-løsningen til dine behov. Hvis du ønsker, at en bruger skal have denne adgang, skal du give ham eller hende brugerniveau 0.

Hvis du ikke ønsker, at brugerne skal have adgang til Indstillinger og vedligeholdelse, skal du tildele brugerniveau 1 eller højere, afhængigt af den adgang, de har brug for.

## Administrer dine roller

I afsnittet Roller kan [du bestemme, hvilken type adgang][3] dine brugere har til de forskellige dele af SuperOffice CRM. Du kan også tilpasse hvert brugerniveau ved at ændre datarettighederne og/eller de forskellige [funktionelle rettigheder][6].

![I afsnittet Roller kan du bestemme, hvilken type adgang dine brugere har til de forskellige dele af SuperOffice CRM -screenshot][img1]

Du kan f.eks. bestemme, om en person kan slette, opdatere, oprette eller læse oplysninger under fanen Datarettigheder. Under fanen Funktionelle rettigheder kan du tillade forskellige funktionelle rettigheder til de forskellige roller, f.eks. Tillad masseopdatering eller Listeadministrator, ved at flytte dem til højre kolonne for "Denne rolle kan".

| Rolle | Forklaring | Ingen | Læs | Opret | Opdater | Slet |
|---|---|:-:|:-:|:-:|:-:|:-:|
| Ingen | Ingen rettigheder og kan ikke se | X |  |  |  |  |
| Læs | Kan læse |  | X |  |  |  |
| Opret | Kan oprette |  | X | X |  |  |
| Opdater | Kan opdatere |  | X | X | X |  |
| Slet | Kan slette |  | X | X | X | X |

## Relateret indhold

* [Oprettelse af en rolle][1]
* [Redigering af en rolle][2]
* [Angivelse af datarettigheder for rolle][3]
* [Redigering af rettigheder for anonyme brugere][4]
* [Sletning af en rolle][5]
* [Funktionelle rettigheder][6]

<!-- Referenced links -->
[1]: create-role.md
[2]: editing-role.md
[3]: set-data-rights-for-role.md
[4]: edit-rights-for-anonymous-users.md
[5]: deleting-role.md
[6]: functional-rights.md

<!-- Referenced images -->
[img1]: ../../../../../media/loc/en/admin/manage-user-levels.png
