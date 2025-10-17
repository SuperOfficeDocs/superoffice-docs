---
uid: help-sv-service-settings-system-settings
title: Systeminställningar för SuperOffice Service
description: Globala inställningar för Systeminställningar för SuperOffice Service
keywords: systeminställningar
author: digitaldiina
date: 10.17.2025
version: 11.5
content_type: reference
category: Settings and maintenance
topic: preferences
license: serviceessentials
functional_right: Service administration, General Administrator
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: sv
redirect_from: /sv/admin/preferences/learn/global-preferences/settings
---

# Globala inställningar för Systeminställningar för SuperOffice Service

Gå till <i class="ph ph-gear" aria-hidden="true"></i> **Inställningar** i navigatorn och välj fliken **Globala inställningar**. Sektionen **Systeminställningar för SuperOffice Service** innehåller följande alternativ:

* **Standardtypsnitt i redigeraren**: Välj vilket typsnitt, vilken teckenstorlek och vilken formatering som ska användas som standard för meddelanderegistrering.

* **Standardteckenstorlek**: Storlek på standardtypsnittet i ärenderedigeraren.

* **Standardteckengrovlek**: Vikt (tjocklek) på standardtypsnittet i ärenderedigeraren.

* **Skicka e-post om aktiva ärenden**: Anger om e-post om aktiva ärenden ska skickas till användarna. Om du väljer **Ärendehandläggare kan välja** kan användarna aktivera eller inaktivera e-postavisering från <i class="ph ph-user-circle" aria-hidden="true"></i> **Personliga inställningar** > **Inställningar** > **Avisering via e-post och SMS**.

* **Ny status vid övertagande av ärende**: Välj vilken status som ska användas när ett ärende övertas av en användare.

* **Antal dagar före avisering**: Anger hur många dagar som ska gå innan e-postavisering om gamla ärenden skickas ut till användarna. Du kan även ange vid vilken tid på dagen som aviseringen ska skickas.

* **Tid på dagen**: Tidpunkt på dagen för att skicka meddelanden.

* **Systemansvarig**: E-postadress till den person som ansvarar för driften av SuperOffice Service. Detta måste vara en e-postadress som inte har importerats i/bearbetats av SuperOffice Service.

* **Standardavsändare**: Systemet standardavsändare för e-post. Denna adress åsidosätts normalt av adresser som läggs till i e-postlådor. Detta måste vara en e-postadress som har importerats i SuperOffice Service. Till exempel `<support@company.com>`.

* **E-posttagg**: E-posttaggen som tillsammans med ärendenumret bildar en unik nyckel på ämnesraden i de e-postmeddelanden som skickas ut från SuperOffice Service. Du får inte ändra detta värde om du inte är helt säker på vad du gör! Om det här värdet ändras kommer inte mottagna e-postmeddelanden att kopplas rätt till befintliga ärenden.

* **Format för klockslag i systemet**: Välj om du vill använda 24-timmarsklocka eller 12-timmarsklocka (am/pm) i systemet. Användarspecifika klockslag (till exempel visning av ärenden) styrs av varje enskild användares inställningar och påverkas inte av detta värde.

* **Standardstil för utgående e-post**: Här kan du definiera en standardstil för e-post i HTML-format. Till exempel: &lt;p style='font-family:Verdana'&gt; &lt;/p&gt;

* **Minimivärde för FAQ-sökresultat (i procent)**: I svarsmallar som skickas till kunder kan [FAQ-poster läggas till automatiskt][1] för att hjälpa kunden att lösa ärendet själv. I detta fält kan du definiera i hur hög grad kundens ärende måste överensstämma med en FAQ-post för att FAQ-posten ska inkluderas i svaret till kunden. Om du definierar ett för lågt värde här kommer kunden sannolikt att få många FAQ-poster som inte är relevanta för ärendet. Om kundens ärende stämmer med ett nyckelord i en FAQ-post inkluderas alltid FAQ-posten.

* **Tidsram för kryssmarkering i minuter**: Här kan du ange ett antal minuter. Om två eller flera e-postmeddelanden kommer in från samma kontakt under denna tid skickas ärendena till samma ärendehandläggare om det är möjligt.

* **Anonymisera anvendare vid svar**: Om aktiverad kommer agentens namn att maskeras i utgående kommunikation.

* **Gräns för användarinaktivitet (timmar)**: Efter det angivna antalet timmar utan användaraktivitet anses användaren vara inaktiv (standard 2 timmar). Det här alternativet används till exempel vid delegering av ärenden.

* **Extern åtkomstnivå som standard**: Om du markerar det här alternativet blir extern åtkomstnivå standard för nya ärenden och meddelanden. Alternativet är intern åtkomstnivå som standard.

* **Skicka inte e-post till nya kontakter**: Om du markerar det här alternativet skickas inga e-postmeddelanden till nyregistrerade kontakter.

* **Skapa automatiskt kontakt för nytt inkommande ärende**: Om du klickar i den här rutan skapar SuperOffice automatiskt en ny person om e-postadressen i ett inkommande ärende inte känns igen. Det här alternativet kan inaktiveras för GDPR-efterlevnad.

* **Tillåt ändring av meddelanden**: Om du markerar det här alternativet kommer användaren att kunna redigera meddelanden.

* **Spåra alla länkar**: Klicka i den här rutan för att spåra alla länkar i utskick.

* **Intern URL**: Huvudadress för åtkomst till SuperOffice Service-systemet. (endast LOKALT)

* **Extern URL**: Huvudadress för extern åtkomst till SuperOffice Service-systemet. (endast LOKALT)

* **Cgi-Bin-mapp**: Sökväg till den mapp där SuperOffice Service Cgi-Bin-applikationsfiler ligger. Sökvägen måste ha ett inledande mappavgränsare (snedstreck) men inget avslutande tecken. Exempel: */bin* eller */Scripts*. (endast LOKALT)

* **Använd användargodkännande från webbservern**: Om du markerar det här alternativet accepterar SuperOffice Service användarautentisering från webbservern (Microsoft IIS). (endast LOKALT)

* **Använd kundgodkännande från webbservern**: Om du markerar det här alternativet accepterar SuperOffice Service användarautentisering från kundcentrets webbserver (Microsoft IIS). (endast LOKALT)

* **Tillgänglig på Internet**: Markera det här alternativet om SuperOffice Service är tillgängligt på Internet. Detta styr delar av den funktionalitet som finns tillgänglig i SuperOffice Service eftersom en del funktioner kräver att lösningen är online. (endast LOKALT)

<!-- Referenced links -->
[1]: ../../knowledge-base/learn/reply-templates/create.md#faq
