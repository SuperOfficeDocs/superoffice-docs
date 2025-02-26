---
uid: help-da-service-settings-system-settings
title: SuperOffice Service-systemindstillinger
description: Globale præferencer for SuperOffice Service-systemindstillinger
keywords: Tjeneste, indstillinger, globale præferencer
author: SuperOffice RnD
date: 02.28.2025
topic: reference
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Globale præferencer for SuperOffice Service-systemindstillinger

Gå til <i class="ph ph-gear" aria-hidden="true"></i> **Præferencer** i navigatoren, og vælg fanen **Globale præferencer**. Afsnittet for **SuperOffice Service-systemindstillinger** indeholder følgende indstillinger:

* **Standardskrifttype i editor**: Vælg hvilken skrifttype, størrelse og formatering, der skal bruges som standard for meddelelsesregistrering.

* **Standardskrifttypestørrelse**: Størrelsen på standardskrifttypen i sagseditoren.

* **Standardskrifttypevægt**: Vægten (tykkelse) af standardskrifttypen i sagseditoren.

* **Send e-mailbesked om aktive sager**: Angiver, om der udsendes e-mails om åbne sager til brugerne. Hvis du vælger **Bruger kan vælge**, kan brugerne aktivere eller deaktivere e-mailbesked fra <i class="ph ph-user-circle" aria-hidden="true"></i> **Personlige indstillinger** > **Præferencer** > **Notifikation via e-mail og SMS**.

* **Ny status ved accept af en sag**: Vælg, hvilken status der skal bruges, når en sag accepteres af en bruger.

* **Antal dage før der skal underrettes**: Angiver, hvor mange dage der skal gå, før der sendes e-mailbesked ud om gamle sager til brugerne. Du kan også angive det tidspunkt på dagen, hvor meddelelsen skal sendes.

* **Tidspunkt på dagen**: Klokkeslæt for afsendelse af meddelelser.

* **Systemansvarlig**: E-mailadressen på den person, der er ansvarlig for driften af SuperOffice Service. Dette skal være en e-mailadresse, der ikke importeres til eller behandles af SuperOffice Service.

* **Standardafsender**: Systemets standardafsenderadresse til e-mails. Denne adresse tilsidesættes normalt af adresserne angivet i e-mailkonti. Der skal være tale om en e-mailadresse, som er importeret til SuperOffice Service. For eksempel, `<support@company.com>`.

* **E-mailkode**: Den e-mailkode, der sammen med sagsnummeret danner en unik nøgle for emnet i e-mails, der udsendes fra SuperOffice Service. Du må ikke ændre denne værdi, medmindre du ved, hvad du gør! Hvis denne værdi ændres, vil modtagne e-mails ikke blive linket korrekt til eksisterende sager.

* **Format for klokkeslæt i systemet**: Vælg, om du vil bruge et 24-timers eller 12-timers (AM/PM) ur i systemet. Brugerspecifikke ure (f.eks. visning af sager) styres af den enkelte brugers indstillinger og ikke af denne værdi.

* **Standardtypografi for udgående e-mail**: Her kan du definere et standardformat, der skal bruges til e-mails i HTML-format. For eksempel: &lt;p style='font-family:Verdana'&gt; &lt;/p&gt;

* **Minimumsscore for FAQ-søgeresultat (i procent)**: I svarskabeloner, der sendes til kunder, kan du tilføje [automatiske forslag til FAQ-poster][1], der kan hjælpe kunden med selv at løse sagen. I dette felt kan du definere, hvor meget sammenhæng der skal være mellem kundens sag og en FAQ-post, for at en FAQ-post kan føjes til svaret til kunden. Hvis du definerer en værdi, som er for lav, er det sandsynligt, at kunderne modtager mange FAQ'er, som ikke er relevante for sagen. Hvis en kundes sager har sammenhæng med et nøgleord i en FAQ, vil FAQ-posten altid blive medtaget.

* **Tidsramme for krydsregistrering i minutter**: Her kan du angive et antal minutter, og hvis to eller flere e-mail-meddelelser kommer ind fra den samme person i løbet af denne tidsperiode, vil sagerne blive fordelt til den samme bruger, hvis det er muligt.

* **Grænse for brugerinaktivitet (timer)**: Efter det angivne antal timer uden brugeraktivitet betragtes brugeren som inaktiv (standard 2 timer). Dette bruges f.eks. i fordelingen af sager.

* **Eksternt adgangsniveau som standard**: Hvis du markerer denne valgmulighed, vil eksternt adgangsniveau være standard for nye sager og meddelelser. Alternativet er, at internt adgangsniveau er standard.

* **Send ikke e-mail til nye personer**: Hvis du markerer denne valgmulighed, sendes der ikke e-mails til nyregistrerede personer.

* **Opret automatisk en person for ny indgående sag**: Hvis du markerer dette, opretter SuperOffice automatisk en ny person, hvis programmet ikke genkender en e-mailadresse i en indgående sag. Denne indstilling kan deaktiveres for overholdelse af GDPR.

* **Tillad ændring af meddelelser**: Hvis du markerer denne valgmulighed, har brugerne tilladelse til at ændre meddelelser.

* **Spor alle links**: Marker dette for at spore alle links i udsendelser.

* **Intern URL**: Basisadressen for adgang til SuperOffice Service-systemet. (Kun på stedet)

* **Ekstern URL**: Basisadressen for ekstern adgang til SuperOffice-systemet. (Kun på stedet)

* **Cgi-Bin-sti**: Stien til mappen, hvor SuperOffice Services cgi-bin-programfiler findes. Denne sti skal have et foranstillet mappeskilletegn (skråstreg), men ikke et afsluttende. For eksempel */bin* eller */Scripts*. (Kun på stedet)

* **Anvend brugergodkendelse fra webserveren**: Hvis denne valgmulighed er markeret, accepterer SuperOffice Service brugergodkendelse, der stammer fra webserveren (Microsoft IIS). (Kun på stedet)

* **Anvend kundegodkendelse fra webserveren**: Hvis denne valgmulighed er markeret, accepterer SuperOffice Service brugergodkendelse, der stammer fra Customer Centre-webserveren (Microsoft IIS). (Kun på stedet)

* **Tilgængelig på internettet**: Marker her, hvis SuperOffice Service er tilgængeligt på internettet. Dette vil styre dele af den funktionalitet, der er tilgængelige i SuperOffice Service, fordi nogle funktioner kræver, at løsningen rent faktisk er tilgængelig på internettet. (Kun på stedet)

<!-- Referenced links -->
[1]: ../../../../request/reply-templates/learn/create.md#faq
